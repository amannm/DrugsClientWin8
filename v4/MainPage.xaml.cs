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
using System.Collections.ObjectModel;
using DrugsLib;
namespace DrugsX {

    public sealed partial class MainPage : Page {
        private BrowserViewModel vm;

        public MainPage() {
            this.InitializeComponent();
            vm = new BrowserViewModel();
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e) {
            this.DataContext = vm;
            var args = e.Parameter as Term;
            if (args != null) {
                vm.Go(args);
            } else {
                vm.Go(await Service.GetTermAsync(902630));
            }
        }

        private void relatedTermsView_ItemClick(object sender, ItemClickEventArgs e) {
            vm.Go(e.ClickedItem as Term);
        }


        private void backButton_Click(object sender, RoutedEventArgs e) {
            vm.GoBack();
        }
    }

}
