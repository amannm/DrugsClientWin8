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
using Drugs;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Drugs3 {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page {
        public Stack<Concept> ConceptHistory;
        public MainPage() {
            this.InitializeComponent();
            ConceptHistory = new Stack<Concept>();
        }
        protected async override void OnNavigatedTo(NavigationEventArgs e) {
            Concept req = e.Parameter as Concept;
            if (req == null) {
                req = await Service.GetConceptAsync("161");
            }
            this.DataContext = req;
        }

        private async void ListView_ItemClick(object sender, ItemClickEventArgs e) {
            ConceptHistory.Push(this.DataContext as Concept);
            Concept c = e.ClickedItem as Concept;
            conceptNameText.Text = c.Name;
            conceptTypeText.Text = c.Type;
            this.DataContext = await Service.GetConceptAsync(c.Id);
        }

        private void backButton_Click(object sender, RoutedEventArgs e) {
            if (ConceptHistory.Count > 0) {
                this.DataContext = ConceptHistory.Pop();
            }
        }
    }
}
