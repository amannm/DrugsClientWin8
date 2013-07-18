using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using DrugsLib;

namespace DrugsX {

    public class BrowserViewModel : BindableBase {

        private Term _currentTerm;
        public Term CurrentTerm {
            get { return this._currentTerm; }
            set { SetProperty(ref this._currentTerm, value); }
        }

        private List<Term> _history;
        public List<Term> History {
            get { return this._history; }
            set { SetProperty(ref this._history, value); }
        }

        private Dictionary<string, List<Term>> _relatedTermsGroups;
        public Dictionary<string, List<Term>> RelatedTerms {
            get { return this._relatedTermsGroups; }
            set { SetProperty(ref this._relatedTermsGroups, value); }
        }

        private Dictionary<string, List<string>> _attributesGroups;
        public Dictionary<string, List<string>> Attributes {
            get { return this._attributesGroups; }
            set { SetProperty(ref this._attributesGroups, value); }
        }

        public BrowserViewModel() {
            History = new List<Term>();
            RelatedTerms = new Dictionary<string, List<Term>>();
            Attributes = new Dictionary<string, List<string>>();
        }

        private async void refreshSuccessors() {
            RelatedTerms = await Service.GetSuccessorsAsync(CurrentTerm.Id);
        }

        private async void refreshAttributes() {
            Attributes = await Service.GetAttributesAsync(CurrentTerm.Id);
        }

        public void Go(Term next) {
            History.Add(CurrentTerm);
            CurrentTerm = next;
            refreshSuccessors();
            refreshAttributes();
        }

        public void GoBack() {
            if (History.Count > 0) {
                CurrentTerm = History.ElementAt(History.Count - 1);
                History.RemoveAt(History.Count - 1);
                refreshSuccessors();
                refreshAttributes();
            }
        }

        public bool CanGoBack {
           get {
            return _history.Count > 0; 
           }
        }
    }

    public class SampleViewModel : BindableBase {

        public Term CurrentTerm {
            get {
                return new Term() { Id = 1234, Name = "Sample Current Term", Type = "Sample Current Type" };
            }
        }

        public List<Term> History {
            get {
                return new List<Term>() {
                    new Term() {Id = 1234, Name = "Sample Term 1", Type = "Sample Type A" },
                    new Term() {Id = 1234, Name = "Sample Term 2", Type = "Sample Type B" },
                    new Term() {Id = 1234, Name = "Sample Term 3", Type = "Sample Type C" }
                };
            }
        }

        public Dictionary<string, List<Term>> RelatedTermsGroups {
            get {
                return new Dictionary<string, List<Term>>() {
                   {"Property 1", new List<Term>() {
                           new Term() {Id = 1234, Name = "Sample Term 1", Type = "Sample Type A" },
                           new Term() {Id = 1234, Name = "Sample Term 2", Type = "Sample Type B" },
                           new Term() {Id = 1234, Name = "Sample Term 3", Type = "Sample Type C" },
                           new Term() {Id = 1234, Name = "Sample Term 4", Type = "Sample Type A" },
                           new Term() {Id = 1234, Name = "Sample Term 5", Type = "Sample Type B" },
                           new Term() {Id = 1234, Name = "Sample Term 5 Term", Type = "Sample Type C" }
                       }
                }
            };
            }
        }

        public Dictionary<string, List<string>> AttributesGroups {
            get {
                return new Dictionary<string, List<string>>() {
                {"Attribute 1",new List<string>(){"Value 1", "Value 2", "Value 3"}},
                {"Attribute 2",new List<string>(){"Value 1", "Value 2"}}
                };
            }
        }
    }
}
