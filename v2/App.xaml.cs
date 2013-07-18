using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.ApplicationModel;
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
using Windows.ApplicationModel.Search;

namespace Drugs2 {
    sealed partial class App : Application {

        public App() {
            this.InitializeComponent();
            this.Suspending += OnSuspending;
        }

        protected override void OnLaunched(LaunchActivatedEventArgs args) {
            Frame rootFrame = Window.Current.Content as Frame;
            if (rootFrame == null) {
                rootFrame = new Frame();

                if (args.PreviousExecutionState == ApplicationExecutionState.Terminated) {
                    //TODO: Load state from previously suspended application
                }

                Window.Current.Content = rootFrame;
            }

            if (rootFrame.Content == null) {
                if (!rootFrame.Navigate(typeof(NavigationPage), args.Arguments)) {
                    throw new Exception("Failed to create initial page");
                }
            }
            Window.Current.Activate();
        }

        protected override void OnWindowCreated(WindowCreatedEventArgs args) {
            SearchPane searchPane = SearchPane.GetForCurrentView();
            searchPane.QuerySubmitted += searchPane_QuerySubmitted;
            searchPane.SuggestionsRequested += searchPane_SuggestionsRequested;
        }

        public async void searchPane_QuerySubmitted(SearchPane sender, SearchPaneQuerySubmittedEventArgs args) {
            var frame = Window.Current.Content as Frame; 
            var coll = await Service.FindConceptsAsync(args.QueryText);
            if (coll.Count > 0) {
                frame.Navigate(typeof(NavigationPage), coll.ElementAt(0));
            } else {
                frame.Navigate(typeof(NavigationPage), null);
            }
        }

        public async void searchPane_SuggestionsRequested(SearchPane sender, SearchPaneSuggestionsRequestedEventArgs args) {
            var deferral = args.Request.GetDeferral();
            var results = await Service.SuggestCompletionsAsync(args.QueryText);
            args.Request.SearchSuggestionCollection.AppendQuerySuggestions(results);
            deferral.Complete();
        }

        private void OnSuspending(object sender, SuspendingEventArgs e) {
            var deferral = e.SuspendingOperation.GetDeferral();
            //TODO: Save application state and stop any background activity
            deferral.Complete();
        }
        /// <summary>
        /// Invoked when the application is activated to display search results.
        /// </summary>
        /// <param name="args">Details about the activation request.</param>
        protected async override void OnSearchActivated(Windows.ApplicationModel.Activation.SearchActivatedEventArgs args) {
            // TODO: Register the Windows.ApplicationModel.Search.SearchPane.GetForCurrentView().QuerySubmitted
            // event in OnWindowCreated to speed up searches once the application is already running

            // If the Window isn't already using Frame navigation, insert our own Frame
            var previousContent = Window.Current.Content;
            var frame = previousContent as Frame;

            // If the app does not contain a top-level frame, it is possible that this 
            // is the initial launch of the app. Typically this method and OnLaunched 
            // in App.xaml.cs can call a common method.
            if (frame == null) {
                // Create a Frame to act as the navigation context and associate it with
                // a SuspensionManager key
                frame = new Frame();
                Drugs2.Common.SuspensionManager.RegisterFrame(frame, "AppFrame");

                if (args.PreviousExecutionState == ApplicationExecutionState.Terminated) {
                    // Restore the saved session state only when appropriate
                    try {
                        await Drugs2.Common.SuspensionManager.RestoreAsync();
                    } catch (Drugs2.Common.SuspensionManagerException) {
                        //Something went wrong restoring state.
                        //Assume there is no state and continue
                    }
                }
            }
            var coll = await Service.FindConceptsAsync(args.QueryText);
            if (coll.Count > 0) {
                frame.Navigate(typeof(NavigationPage), coll.ElementAt(0));
            } else {
                frame.Navigate(typeof(NavigationPage), null);
            }

            Window.Current.Content = frame;

            // Ensure the current window is active
            Window.Current.Activate();
        }

    }
}
