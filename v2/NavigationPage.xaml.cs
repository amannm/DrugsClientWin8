using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Diagnostics;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
namespace Drugs2 {


    public sealed partial class NavigationPage : Page {

        private Stack<Concept> ConceptHistory;
        private ViewModel vm { get; set; }

        private static int defaultConcept = 902630;


        public NavigationPage() {
            this.InitializeComponent();
            this.ConceptHistory = new Stack<Concept>();
            this.vm = new ViewModel();
            this.DataContext = vm;
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e) {
            Concept init = e.Parameter as Concept;
            if (init == null) {
                vm.CurrentConcept = await Service.GetConceptAsync(defaultConcept);
            } else {
                vm.CurrentConcept = init;
            }
            refreshSuccessors();
        }

        private async void refreshSuccessors() {
            vm.Filters.Clear();
            var successors = await Service.GetSuccessorsAsync(vm.CurrentConcept.Id);
            foreach (var s in successors) {
                vm.Filters.Add(new Filter(s.Key, s.Value));
            }
        }

        private void ListView_ItemClick(object sender, ItemClickEventArgs e) {
            Concept c = e.ClickedItem as Concept;
            ConceptHistory.Push(vm.CurrentConcept);
            vm.CurrentConcept = c;
            refreshSuccessors();
        }


        private void backButton_Click(object sender, RoutedEventArgs e) {
            if (ConceptHistory.Count > 0) {
                vm.CurrentConcept = ConceptHistory.Pop();
                refreshSuccessors();
            }
        }
    }

}
