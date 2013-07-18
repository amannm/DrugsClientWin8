using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.UI.Xaml.Data;

namespace DrugsLib {

    [DataContract]
    public class Term : BindableBase {

        private int _id;
        private string _name;
        private string _type;

        [DataMember(IsRequired = true, Name = "id")]
        public int Id {
            get { return this._id; }
            set { this.SetProperty(ref this._id, value); }
        }

        [DataMember(IsRequired = true, Name = "name")]
        public string Name {
            get { return this._name; }
            set { this.SetProperty(ref this._name, value); }
        }

        [DataMember(IsRequired = true, Name = "type")]
        public string Type {
            get { return this._type; }
            set { this.SetProperty(ref this._type, value); }
        }
    }
}
