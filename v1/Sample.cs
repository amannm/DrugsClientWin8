using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using DrugsLib;

namespace Drugs.Data {
    public class SampleDataSource {
        private static readonly ObservableCollection<string> _spellingSuggestions = new ObservableCollection<string> { "Advil", "Tylenol", "Vyvanse" };
        private static readonly ObservableCollection<Concept> _results = new ObservableCollection<Concept> { 
            new Concept {Id="92636392", Name="Advil", Type="Brand Name"},
            new Concept {Id="12612211", Name="Tylenol", Type="Brand Name"},
            new Concept {Id="34123240", Name="Vyvanse", Type="Brand Name"}
        };

        public ObservableCollection<string> SpellingSuggestions {
            get { return _spellingSuggestions; }
        }
        public ObservableCollection<Concept> Results {
            get { return _results; }
        }
    }
}
