using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Collections.ObjectModel;
using DrugsLib;

namespace DrugsX {
    public sealed partial class SearchResultsPage : Page {

        private SearchResultsViewModel vm;

        public SearchResultsPage() {
            this.InitializeComponent();
            vm = new SearchResultsViewModel();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e) {
            this.DataContext = vm;
            vm.Results = e.Parameter as List<Term>;
        }

        private void results_ItemClick(object sender, ItemClickEventArgs e) {
            var frame = Window.Current.Content as Frame; 
            frame.Navigate(typeof(MainPage), e.ClickedItem as Term);
        }


    }
}
