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
using DrugsLib;
using System.Diagnostics;

namespace Drugs {
    public sealed partial class SearchResultsPage : Drugs.Common.LayoutAwarePage {
        public SearchResultsPage() {
            this.InitializeComponent();
        }
        protected async override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState) {
            var queryText = navigationParameter as String;
            this.DefaultViewModel["QueryText"] = '\u201c' + queryText + '\u201d';
            var results = await Service.FindConceptsAsync(queryText);

            var filterList = new List<Filter>();
            filterList.Add(new Filter("All", results.Count(), true));

            this.DefaultViewModel["Results"] = results;
            this.DefaultViewModel["Filters"] = filterList;

            if (results.Count() > 0) {
                this.DefaultViewModel["ShowFilters"] = true;
                VisualStateManager.GoToState(this, "ResultsFound", true);
            } else {
                var spellings = await Service.SuggestSpellingsAsync(queryText);
                foreach (var s in spellings) {
                    Debug.WriteLine(s);
                }

                this.DefaultViewModel["SpellingSuggestions"] = spellings;
                this.DefaultViewModel["ShowFilters"] = false;
                VisualStateManager.GoToState(this, "NoResultsFound", true);
            }
        }

        void Filter_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var selectedFilter = e.AddedItems.FirstOrDefault() as Filter;
            if (selectedFilter != null) {
                selectedFilter.Active = true;
                if ("All".Equals(selectedFilter.Name)) {
                    //var allConcepts = new List<Concept>();
                    //foreach (var entry in resultGroups) {
                    //    allConcepts.AddRange(entry.Value);
                    //}
                    //this.DefaultViewModel["Results"] = allConcepts;
                } else {
                    //this.DefaultViewModel["Results"] = resultGroups[selectedFilter.Name];
                }
                // Ensure results are found
                object results;
                ICollection resultsCollection;
                if (this.DefaultViewModel.TryGetValue("Results", out results) &&
                    (resultsCollection = results as ICollection) != null &&
                    resultsCollection.Count != 0) {
                    VisualStateManager.GoToState(this, "ResultsFound", true);
                    return;
                }
            }

            // Display informational text when there are no search results.
            VisualStateManager.GoToState(this, "NoResultsFound", true);
        }
        void Filter_Checked(object sender, RoutedEventArgs e) {
            // Mirror the change into the CollectionViewSource used by the corresponding ComboBox
            // to ensure that the change is reflected when snapped
            if (filtersViewSource.View != null) {
                var filter = (sender as FrameworkElement).DataContext;
                filtersViewSource.View.MoveCurrentTo(filter);
            }
        }
        private sealed class Filter : Drugs.Common.BindableBase {
            private String _name;
            private int _count;
            private bool _active;

            public Filter(String name, int count, bool active = false) {
                this.Name = name;
                this.Count = count;
                this.Active = active;
            }

            public override String ToString() {
                return Description;
            }

            public String Name {
                get { return _name; }
                set { if (this.SetProperty(ref _name, value)) this.OnPropertyChanged("Description"); }
            }

            public int Count {
                get { return _count; }
                set { if (this.SetProperty(ref _count, value)) this.OnPropertyChanged("Description"); }
            }

            public bool Active {
                get { return _active; }
                set { this.SetProperty(ref _active, value); }
            }

            public String Description {
                get { return String.Format("{0} ({1})", _name, _count); }
            }
        }
    }
}
