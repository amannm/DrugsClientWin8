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
    public class ViewModel : Common.BindableBase {

        private Concept _cc;
        private ObservableCollection<Filter> _filters;
        private ObservableCollection<AttributeGroup> _attributeGroups;

        public ViewModel() {
            _filters = new ObservableCollection<Filter>();
            _attributeGroups = new ObservableCollection<AttributeGroup>();
            _cc = new Concept();
        }

        public Concept CurrentConcept {
            get { return _cc; }
            set { if (this.SetProperty(ref _cc, value)) this.OnPropertyChanged("CurrentConcept"); }
        }
        public ObservableCollection<Filter> Filters {
            get { return _filters; }
            set { if (this.SetProperty(ref _filters, value)) this.OnPropertyChanged("Filters"); }
        }
        public ObservableCollection<AttributeGroup> AttributeGroups {
            get { return _attributeGroups; }
            set { if (this.SetProperty(ref _attributeGroups, value)) this.OnPropertyChanged("AttributeGroups"); }
        }
    }
    public class SampleViewModel : Common.BindableBase {

        private Concept _cc;
        private ObservableCollection<Filter> _filters;
        private ObservableCollection<AttributeGroup> _attributeGroups;

        public SampleViewModel() {
            _filters = new ObservableCollection<Filter>();
            _cc = new Concept();
            _cc.Name = "Ultradrug XTREME";
            _cc.Id = 123456;
            _cc.Type = "BN";
            _filters.Add(new Filter("tradename of", new ObservableCollection<Concept>() {
                    new Concept() {Name = "Advil", Type = "BN", Id = 12229},
                    new Concept() {Name = "Tylenol", Type = "BN", Id = 6666},
                    new Concept() {Name = "Vyvanse", Type = "BN", Id = 122509},
                    new Concept() {Name = "Poop", Type = "IN", Id = 121409},
                }));
            _filters.Add(new Filter("ingredient of", new ObservableCollection<Concept>() {
                    new Concept() {Name = "Advil", Type = "BN", Id = 12229},
                    new Concept() {Name = "Tylenol", Type = "BN", Id = 6666},
                    new Concept() {Name = "Vyvanse", Type = "BN", Id = 122509},
                    new Concept() {Name = "Poop", Type = "IN", Id = 121409},
                }));

            _filters.Add(new Filter("fartman of", new ObservableCollection<Concept>() {
                    new Concept() {Name = "Advil", Type = "BN", Id = 12229},
                    new Concept() {Name = "Tylenol", Type = "BN", Id = 6666},
                    new Concept() {Name = "Vyvanse", Type = "BN", Id = 122509},
                    new Concept() {Name = "Poop", Type = "IN", Id = 121409},
                    new Concept() {Name = "Vyvanse", Type = "BN", Id = 122509},
                    new Concept() {Name = "Poop", Type = "IN", Id = 121409},
                    new Concept() {Name = "Tylenol", Type = "BN", Id = 6666},
                    new Concept() {Name = "Vyvanse", Type = "BN", Id = 122509},
                    new Concept() {Name = "Tylenol", Type = "BN", Id = 6666},
                    new Concept() {Name = "Vyvanse", Type = "BN", Id = 122509},
                    new Concept() {Name = "Poop", Type = "IN", Id = 121409},
                    new Concept() {Name = "Tylenol", Type = "BN", Id = 6666},
                    new Concept() {Name = "Vyvanse", Type = "BN", Id = 122509},
                    new Concept() {Name = "Tylenol", Type = "BN", Id = 6666},
                }));

            _filters.Add(new Filter("asdf of", new ObservableCollection<Concept>() {
                    new Concept() {Name = "Advil", Type = "BN", Id = 12229},
                    new Concept() {Name = "Tylenol", Type = "BN", Id = 6666},
                    new Concept() {Name = "Vyvanse", Type = "BN", Id = 122509},
                    new Concept() {Name = "Poop", Type = "IN", Id = 121409},
                    new Concept() {Name = "Tylenol", Type = "BN", Id = 6666},
                    new Concept() {Name = "Vyvanse", Type = "BN", Id = 122509},
                    new Concept() {Name = "Tylenol", Type = "BN", Id = 6666},
                    new Concept() {Name = "Vyvanse", Type = "BN", Id = 122509},
                }));

            _attributeGroups = new ObservableCollection<AttributeGroup>();
            _attributeGroups.Add(new AttributeGroup("something lol", new ObservableCollection<string>() { "1234", "152234", "asdfasdf" }));
            _attributeGroups.Add(new AttributeGroup("whazzayt", new ObservableCollection<string>() { "fasdkljfals;kdfj;", "dfsfsfsf", "f0" }));

        }
        public ObservableCollection<AttributeGroup> AttributeGroups {
            get { return _attributeGroups; }
            set { if (this.SetProperty(ref _attributeGroups, value)) this.OnPropertyChanged("AttributeGroups"); }
        }
        public Concept CurrentConcept {
            get { return _cc; }
            set { if (this.SetProperty(ref _cc, value)) this.OnPropertyChanged("CurrentConcept"); }
        }
        public ObservableCollection<Filter> Filters {
            get { return _filters; }
            set { if (this.SetProperty(ref _filters, value)) this.OnPropertyChanged("Filters"); }
        }

    }
    public sealed class Filter : Common.BindableBase {

        private ObservableCollection<Concept> _concepts;
        private String _name;

        public Filter(String name, ObservableCollection<Concept> concepts, bool active = false) {
            this.Name = name.Replace('_', ' ');
            this.Concepts = concepts;
        }

        public override String ToString() {
            return Description;
        }

        public String Name {
            get { return _name; }
            set { if (this.SetProperty(ref _name, value)) this.OnPropertyChanged("Description"); }
        }
        public ObservableCollection<Concept> Concepts {
            get { return _concepts; }
            set { if (this.SetProperty(ref _concepts, value)) this.OnPropertyChanged("Description"); }
        }

        public String Description {
            get { return String.Format("{0} ({1})", _name, _concepts.Count); }
        }
    }
    public sealed class AttributeGroup : Common.BindableBase {

        private ObservableCollection<string> _attributes;
        private String _name;

        public AttributeGroup(String name, ObservableCollection<string> attributes, bool active = false) {
            this.Name = name.Replace('_', ' ');
            this.Attributes = attributes;
        }

        public override String ToString() {
            return Description;
        }

        public String Name {
            get { return _name; }
            set { if (this.SetProperty(ref _name, value)) this.OnPropertyChanged("Description"); }
        }
        public ObservableCollection<string> Attributes {
            get { return _attributes; }
            set { if (this.SetProperty(ref _attributes, value)) this.OnPropertyChanged("Description"); }
        }

        public String Description {
            get { return String.Format("{0} ({1})", _name, _attributes.Count); }
        }
    }



}
