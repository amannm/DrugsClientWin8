using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Drugs2.Common;
using Windows.UI.Xaml.Data;

namespace Drugs2 {
    [DataContract]
    public class DrugProduct : BindableBase {
        private int _id;
        [DataMember(IsRequired = true)]
        public int Id { get { return this._id; } set { this.SetProperty(ref this._id, value); } }
        private string _name;
        [DataMember(IsRequired = true)]
        public string Name {
            get { return this._name; }
            set { this.SetProperty(ref this._name, value); }
        } private ObservableCollection<string> _anada;
        [DataMember]
        public ObservableCollection<string> ANADA {
            get { return this._anada; }
            set { this.SetProperty(ref this._anada, value); }
        } private ObservableCollection<string> _anda;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> ANDA {
            get { return this._anda; }
            set { this.SetProperty(ref this._anda, value); }
        } private ObservableCollection<string> _bla;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> BLA {
            get { return this._bla; }
            set { this.SetProperty(ref this._bla, value); }
        } private ObservableCollection<string> _coating;
        [DataMember]
        public ObservableCollection<string> COATING {
            get { return this._coating; }
            set { this.SetProperty(ref this._coating, value); }
        } private ObservableCollection<string> _color;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> COLOR {
            get { return this._color; }
            set { this.SetProperty(ref this._color, value); }
        } private ObservableCollection<string> _colortext;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> COLORTEXT {
            get { return this._colortext; }
            set { this.SetProperty(ref this._colortext, value); }
        } private ObservableCollection<string> _dcsa;
        [DataMember]
        public ObservableCollection<string> DCSA {
            get { return this._dcsa; }
            set { this.SetProperty(ref this._dcsa, value); }
        } private ObservableCollection<string> _dm_spl_id;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> DM_SPL_ID {
            get { return this._dm_spl_id; }
            set { this.SetProperty(ref this._dm_spl_id, value); }
        } private ObservableCollection<string> _exempt_device;
        [DataMember]
        public ObservableCollection<string> EXEMPT_DEVICE {
            get { return this._exempt_device; }
            set { this.SetProperty(ref this._exempt_device, value); }
        } private ObservableCollection<string> _imprint_code;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> IMPRINT_CODE {
            get { return this._imprint_code; }
            set { this.SetProperty(ref this._imprint_code, value); }
        } private ObservableCollection<string> _label_type;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> LABEL_TYPE {
            get { return this._label_type; }
            set { this.SetProperty(ref this._label_type, value); }
        } private ObservableCollection<string> _labeler;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> LABELER {
            get { return this._labeler; }
            set { this.SetProperty(ref this._labeler, value); }
        } private ObservableCollection<string> _legally_marketed_unapproved_new_animal_drugs_for_minor_species;
        [DataMember]
        public ObservableCollection<string> LEGALLY_MARKETED_UNAPPROVED_NEW_ANIMAL_DRUGS_FOR_MINOR_SPECIES {
            get { return this._legally_marketed_unapproved_new_animal_drugs_for_minor_species; }
            set { this.SetProperty(ref this._legally_marketed_unapproved_new_animal_drugs_for_minor_species, value); }
        } private ObservableCollection<string> _marketing_category;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> MARKETING_CATEGORY {
            get { return this._marketing_category; }
            set { this.SetProperty(ref this._marketing_category, value); }
        } private ObservableCollection<string> _marketing_effective_time_high;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> MARKETING_EFFECTIVE_TIME_HIGH {
            get { return this._marketing_effective_time_high; }
            set { this.SetProperty(ref this._marketing_effective_time_high, value); }
        } private ObservableCollection<string> _marketing_effective_time_low;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> MARKETING_EFFECTIVE_TIME_LOW {
            get { return this._marketing_effective_time_low; }
            set { this.SetProperty(ref this._marketing_effective_time_low, value); }
        } private ObservableCollection<string> _marketing_status;
        [DataMember]
        public ObservableCollection<string> MARKETING_STATUS {
            get { return this._marketing_status; }
            set { this.SetProperty(ref this._marketing_status, value); }
        } private ObservableCollection<string> _nada;
        [DataMember]
        public ObservableCollection<string> NADA {
            get { return this._nada; }
            set { this.SetProperty(ref this._nada, value); }
        } private ObservableCollection<string> _nda;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> NDA {
            get { return this._nda; }
            set { this.SetProperty(ref this._nda, value); }
        } private ObservableCollection<string> _nda_authorized_generic;
        [DataMember]
        public ObservableCollection<string> NDA_AUTHORIZED_GENERIC {
            get { return this._nda_authorized_generic; }
            set { this.SetProperty(ref this._nda_authorized_generic, value); }
        } private ObservableCollection<string> _ndc;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> NDC {
            get { return this._ndc; }
            set { this.SetProperty(ref this._ndc, value); }
        } private ObservableCollection<string> _otc_monograph_final;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> OTC_MONOGRAPH_FINAL {
            get { return this._otc_monograph_final; }
            set { this.SetProperty(ref this._otc_monograph_final, value); }
        } private ObservableCollection<string> _otc_monograph_not_final;
        [DataMember]
        public ObservableCollection<string> OTC_MONOGRAPH_NOT_FINAL {
            get { return this._otc_monograph_not_final; }
            set { this.SetProperty(ref this._otc_monograph_not_final, value); }
        } private ObservableCollection<string> _premarket_notification;
        [DataMember]
        public ObservableCollection<string> PREMARKET_NOTIFICATION {
            get { return this._premarket_notification; }
            set { this.SetProperty(ref this._premarket_notification, value); }
        } private ObservableCollection<string> _score;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> SCORE {
            get { return this._score; }
            set { this.SetProperty(ref this._score, value); }
        } private ObservableCollection<string> _shape;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> SHAPE {
            get { return this._shape; }
            set { this.SetProperty(ref this._shape, value); }
        } private ObservableCollection<string> _shapetext;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> SHAPETEXT {
            get { return this._shapetext; }
            set { this.SetProperty(ref this._shapetext, value); }
        } private ObservableCollection<string> _size;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> SIZE {
            get { return this._size; }
            set { this.SetProperty(ref this._size, value); }
        } private ObservableCollection<string> _spl_set_id;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> SPL_SET_ID {
            get { return this._spl_set_id; }
            set { this.SetProperty(ref this._spl_set_id, value); }
        } private ObservableCollection<string> _symbol;
        [DataMember]
        public ObservableCollection<string> SYMBOL {
            get { return this._symbol; }
            set { this.SetProperty(ref this._symbol, value); }
        } private ObservableCollection<string> _unapproved_drug_other;
        [DataMember]
        public ObservableCollection<string> UNAPPROVED_DRUG_OTHER {
            get { return this._unapproved_drug_other; }
            set { this.SetProperty(ref this._unapproved_drug_other, value); }
        } private ObservableCollection<string> _unapproved_homeopathic;
        [DataMember]
        public ObservableCollection<string> UNAPPROVED_HOMEOPATHIC {
            get { return this._unapproved_homeopathic; }
            set { this.SetProperty(ref this._unapproved_homeopathic, value); }
        } private ObservableCollection<string> _unapproved_medical_gas;
        [DataMember]
        public ObservableCollection<string> UNAPPROVED_MEDICAL_GAS {
            get { return this._unapproved_medical_gas; }
            set { this.SetProperty(ref this._unapproved_medical_gas, value); }
        } private ObservableCollection<ActiveSubstance> _hasIngredient;
        [DataMember(IsRequired = true)]
        public ObservableCollection<ActiveSubstance> HasIngredient {
            get { return this._hasIngredient; }
            set { this.SetProperty(ref this._hasIngredient, value); }
        }
    }
    [DataContract]
    public class RxnormCreatedDp : BindableBase {
        private int _id;
        [DataMember(IsRequired = true)]
        public int Id { get { return this._id; } set { this.SetProperty(ref this._id, value); } }
        private string _name;
        [DataMember(IsRequired = true)]
        public string Name {
            get { return this._name; }
            set { this.SetProperty(ref this._name, value); }
        } private ObservableCollection<string> _anda;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> ANDA {
            get { return this._anda; }
            set { this.SetProperty(ref this._anda, value); }
        } private ObservableCollection<string> _bla;
        [DataMember]
        public ObservableCollection<string> BLA {
            get { return this._bla; }
            set { this.SetProperty(ref this._bla, value); }
        } private ObservableCollection<string> _coating;
        [DataMember]
        public ObservableCollection<string> COATING {
            get { return this._coating; }
            set { this.SetProperty(ref this._coating, value); }
        } private ObservableCollection<string> _color;
        [DataMember]
        public ObservableCollection<string> COLOR {
            get { return this._color; }
            set { this.SetProperty(ref this._color, value); }
        } private ObservableCollection<string> _colortext;
        [DataMember]
        public ObservableCollection<string> COLORTEXT {
            get { return this._colortext; }
            set { this.SetProperty(ref this._colortext, value); }
        } private string _dm_spl_id;
        [DataMember(IsRequired = true)]
        public string DM_SPL_ID {
            get { return this._dm_spl_id; }
            set { this.SetProperty(ref this._dm_spl_id, value); }
        } private ObservableCollection<string> _imprint_code;
        [DataMember]
        public ObservableCollection<string> IMPRINT_CODE {
            get { return this._imprint_code; }
            set { this.SetProperty(ref this._imprint_code, value); }
        } private ObservableCollection<string> _label_type;
        [DataMember]
        public ObservableCollection<string> LABEL_TYPE {
            get { return this._label_type; }
            set { this.SetProperty(ref this._label_type, value); }
        } private string _labeler;
        [DataMember]
        public string LABELER {
            get { return this._labeler; }
            set { this.SetProperty(ref this._labeler, value); }
        } private ObservableCollection<string> _marketing_category;
        [DataMember]
        public ObservableCollection<string> MARKETING_CATEGORY {
            get { return this._marketing_category; }
            set { this.SetProperty(ref this._marketing_category, value); }
        } private ObservableCollection<string> _marketing_effective_time_high;
        [DataMember]
        public ObservableCollection<string> MARKETING_EFFECTIVE_TIME_HIGH {
            get { return this._marketing_effective_time_high; }
            set { this.SetProperty(ref this._marketing_effective_time_high, value); }
        } private ObservableCollection<string> _marketing_effective_time_low;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> MARKETING_EFFECTIVE_TIME_LOW {
            get { return this._marketing_effective_time_low; }
            set { this.SetProperty(ref this._marketing_effective_time_low, value); }
        } private ObservableCollection<string> _marketing_status;
        [DataMember]
        public ObservableCollection<string> MARKETING_STATUS {
            get { return this._marketing_status; }
            set { this.SetProperty(ref this._marketing_status, value); }
        } private ObservableCollection<string> _nada;
        [DataMember]
        public ObservableCollection<string> NADA {
            get { return this._nada; }
            set { this.SetProperty(ref this._nada, value); }
        } private ObservableCollection<string> _nda;
        [DataMember]
        public ObservableCollection<string> NDA {
            get { return this._nda; }
            set { this.SetProperty(ref this._nda, value); }
        } private ObservableCollection<string> _nda_authorized_generic;
        [DataMember]
        public ObservableCollection<string> NDA_AUTHORIZED_GENERIC {
            get { return this._nda_authorized_generic; }
            set { this.SetProperty(ref this._nda_authorized_generic, value); }
        } private string _ndc;
        [DataMember(IsRequired = true)]
        public string NDC {
            get { return this._ndc; }
            set { this.SetProperty(ref this._ndc, value); }
        } private ObservableCollection<string> _otc_monograph_final;
        [DataMember]
        public ObservableCollection<string> OTC_MONOGRAPH_FINAL {
            get { return this._otc_monograph_final; }
            set { this.SetProperty(ref this._otc_monograph_final, value); }
        } private ObservableCollection<string> _otc_monograph_not_final;
        [DataMember]
        public ObservableCollection<string> OTC_MONOGRAPH_NOT_FINAL {
            get { return this._otc_monograph_not_final; }
            set { this.SetProperty(ref this._otc_monograph_not_final, value); }
        } private ObservableCollection<string> _score;
        [DataMember]
        public ObservableCollection<string> SCORE {
            get { return this._score; }
            set { this.SetProperty(ref this._score, value); }
        } private ObservableCollection<string> _shape;
        [DataMember]
        public ObservableCollection<string> SHAPE {
            get { return this._shape; }
            set { this.SetProperty(ref this._shape, value); }
        } private ObservableCollection<string> _shapetext;
        [DataMember]
        public ObservableCollection<string> SHAPETEXT {
            get { return this._shapetext; }
            set { this.SetProperty(ref this._shapetext, value); }
        } private ObservableCollection<string> _size;
        [DataMember]
        public ObservableCollection<string> SIZE {
            get { return this._size; }
            set { this.SetProperty(ref this._size, value); }
        } private string _spl_set_id;
        [DataMember(IsRequired = true)]
        public string SPL_SET_ID {
            get { return this._spl_set_id; }
            set { this.SetProperty(ref this._spl_set_id, value); }
        } private ObservableCollection<string> _symbol;
        [DataMember]
        public ObservableCollection<string> SYMBOL {
            get { return this._symbol; }
            set { this.SetProperty(ref this._symbol, value); }
        } private ObservableCollection<ActiveSubstance> _hasIngredient;
        [DataMember(IsRequired = true)]
        public ObservableCollection<ActiveSubstance> HasIngredient {
            get { return this._hasIngredient; }
            set { this.SetProperty(ref this._hasIngredient, value); }
        }
    }
    [DataContract]
    public class ActiveSubstance : BindableBase {
        private int _id;
        [DataMember(IsRequired = true)]
        public int Id { get { return this._id; } set { this.SetProperty(ref this._id, value); } }
        private string _name;
        [DataMember(IsRequired = true)]
        public string Name {
            get { return this._name; }
            set { this.SetProperty(ref this._name, value); }
        } private ObservableCollection<string> _fdasrs;
        [DataMember]
        public ObservableCollection<string> FDASRS {
            get { return this._fdasrs; }
            set { this.SetProperty(ref this._fdasrs, value); }
        } private string _spl_set_id;
        [DataMember(IsRequired = true)]
        public string SPL_SET_ID {
            get { return this._spl_set_id; }
            set { this.SetProperty(ref this._spl_set_id, value); }
        } private ObservableCollection<DrugProduct> _ingredientOfDP;
        [DataMember]
        public ObservableCollection<DrugProduct> IngredientOfDP {
            get { return this._ingredientOfDP; }
            set { this.SetProperty(ref this._ingredientOfDP, value); }
        } private ObservableCollection<RxnormCreatedDp> _ingredientOfMTH_RXN_DP;
        [DataMember(IsRequired = true)]
        public ObservableCollection<RxnormCreatedDp> IngredientOfMTH_RXN_DP {
            get { return this._ingredientOfMTH_RXN_DP; }
            set { this.SetProperty(ref this._ingredientOfMTH_RXN_DP, value); }
        }
    }

}
