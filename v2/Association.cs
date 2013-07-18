using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.UI.Xaml.Data;
using Drugs2.Common;

namespace Drugs2 {

    [DataContract]
    public class Association : BindableBase {

        private int _id;
        private string _name;
        private string _type;

        [DataMember(IsRequired = true)]
        public int Id {
            get { return this._id; }
            set { this.SetProperty(ref this._id, value); }
        }
 
        [DataMember(IsRequired = true)]
        public string Name {
            get { return this._name; }
            set { this.SetProperty(ref this._name, value); }
        }

        [DataMember(IsRequired = true)]
        public string Type {
            get { return this._type; }
            set { this.SetProperty(ref this._type, value); }
        }
    }
}
