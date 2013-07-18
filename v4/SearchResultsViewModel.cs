using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using DrugsLib;
namespace DrugsX {
    public class SearchResultsViewModel : BindableBase {

        private List<Term> _results;
        public List<Term> Results {
            get { return this._results; }
            set { SetProperty(ref this._results, value); }
        }

        public async void Search(string query) {
            Results = await Service.FindTermsAsync(query);
        }
    }
}
