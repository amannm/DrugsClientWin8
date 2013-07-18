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


namespace Drugs2 {

    public sealed partial class AttributesPage : Page {
        private ViewModel vm { get; set; }

        public AttributesPage() {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e) {
            vm.CurrentConcept = e.Parameter as Concept;
            refreshAttributes();
        }

        private async void refreshAttributes() {
            vm.AttributeGroups.Clear();
            var attributeGroups = await Service.GetAttributesAsync(vm.CurrentConcept.Id);
            foreach (var a in attributeGroups) {
                vm.AttributeGroups.Add(new AttributeGroup(a.Key, a.Value));
            }
        }
        private void backButton_Click(object sender, RoutedEventArgs e) {
            (Window.Current.Content as Frame).Navigate(typeof(NavigationPage), vm.CurrentConcept);
        }
    }
}
