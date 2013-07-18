using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.UI.Xaml.Data;
using System.Collections.ObjectModel;
using Drugs2.Common;

namespace Drugs2 {
    [DataContract]
    public class FullySpecifiedDrugBrandNameThatCanNotBePrescribed : BindableBase {
        private int _id;
        [DataMember(IsRequired = true)]
        public int Id { get { return this._id; } set { this.SetProperty(ref this._id, value); } }
        private string _name;
        [DataMember(IsRequired = true)]
        public string Name {
            get { return this._name; }
            set { this.SetProperty(ref this._name, value); }
        } private ObservableCollection<string> _rxn_activated;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> RXN_ACTIVATED { get { return this._rxn_activated; } set { this.SetProperty(ref this._rxn_activated, value); } } private ObservableCollection<string> _rxn_bn_cardinality;
        [DataMember]
        public ObservableCollection<string> RXN_BN_CARDINALITY { get { return this._rxn_bn_cardinality; } set { this.SetProperty(ref this._rxn_bn_cardinality, value); } } private ObservableCollection<string> _rxn_obsoleted;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> RXN_OBSOLETED { get { return this._rxn_obsoleted; } set { this.SetProperty(ref this._rxn_obsoleted, value); } } private ObservableCollection<string> _umlsaui;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> UMLSAUI { get { return this._umlsaui; } set { this.SetProperty(ref this._umlsaui, value); } } private ObservableCollection<string> _umlscui;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> UMLSCUI { get { return this._umlscui; } set { this.SetProperty(ref this._umlscui, value); } } private ObservableCollection<NameFromAPreciseIngredient> _hasPreciseIngredient;
        [DataMember(IsRequired = true)]
        public ObservableCollection<NameFromAPreciseIngredient> HasPreciseIngredient {
            get { return this._hasPreciseIngredient; }
            set { this.SetProperty(ref this._hasPreciseIngredient, value); }
        } private ObservableCollection<SemanticBrandedDrug> _ingredientOfSBD;
        [DataMember(IsRequired = true)]
        public ObservableCollection<SemanticBrandedDrug> IngredientOfSBD {
            get { return this._ingredientOfSBD; }
            set { this.SetProperty(ref this._ingredientOfSBD, value); }
        } private ObservableCollection<SemanticBrandedDrugComponent> _ingredientOfSBDC;
        [DataMember(IsRequired = true)]
        public ObservableCollection<SemanticBrandedDrugComponent> IngredientOfSBDC {
            get { return this._ingredientOfSBDC; }
            set { this.SetProperty(ref this._ingredientOfSBDC, value); }
        } private ObservableCollection<SemanticBrandedDrugAndForm> _ingredientOfSBDF;
        [DataMember(IsRequired = true)]
        public ObservableCollection<SemanticBrandedDrugAndForm> IngredientOfSBDF {
            get { return this._ingredientOfSBDF; }
            set { this.SetProperty(ref this._ingredientOfSBDF, value); }
        } private ObservableCollection<SemanticBrandedDrugGroup> _ingredientOfSBDG;
        [DataMember(IsRequired = true)]
        public ObservableCollection<SemanticBrandedDrugGroup> IngredientOfSBDG {
            get { return this._ingredientOfSBDG; }
            set { this.SetProperty(ref this._ingredientOfSBDG, value); }
        } private FullySpecifiedDrugBrandNameThatCanNotBePrescribed _reformulatedTo;
        [DataMember(IsRequired = true)]
        public FullySpecifiedDrugBrandNameThatCanNotBePrescribed ReformulatedTo {
            get { return this._reformulatedTo; }
            set { this.SetProperty(ref this._reformulatedTo, value); }
        } private FullySpecifiedDrugBrandNameThatCanNotBePrescribed _reformulationOf;
        [DataMember(IsRequired = true)]
        public FullySpecifiedDrugBrandNameThatCanNotBePrescribed ReformulationOf {
            get { return this._reformulationOf; }
            set { this.SetProperty(ref this._reformulationOf, value); }
        } private ObservableCollection<NameForAnIngredient> _tradenameOf;
        [DataMember(IsRequired = true)]
        public ObservableCollection<NameForAnIngredient> TradenameOf {
            get { return this._tradenameOf; }
            set { this.SetProperty(ref this._tradenameOf, value); }
        }
    }
    [DataContract]
    public class BrandedDrugDeliveryDevice : BindableBase {
        private int _id;
        [DataMember(IsRequired = true)]
        public int Id { get { return this._id; } set { this.SetProperty(ref this._id, value); } }
        private string _name;
        [DataMember(IsRequired = true)]
        public string Name {
            get { return this._name; }
            set { this.SetProperty(ref this._name, value); }
        } private ObservableCollection<string> _ambiguity_flag;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> AMBIGUITY_FLAG { get { return this._ambiguity_flag; } set { this.SetProperty(ref this._ambiguity_flag, value); } } private ObservableCollection<string> _ndc;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> NDC { get { return this._ndc; } set { this.SetProperty(ref this._ndc, value); } } private ObservableCollection<string> _rxn_activated;
        [DataMember]
        public ObservableCollection<string> RXN_ACTIVATED { get { return this._rxn_activated; } set { this.SetProperty(ref this._rxn_activated, value); } } private ObservableCollection<string> _rxn_human_drug;
        [DataMember]
        public ObservableCollection<string> RXN_HUMAN_DRUG { get { return this._rxn_human_drug; } set { this.SetProperty(ref this._rxn_human_drug, value); } } private ObservableCollection<string> _rxn_obsoleted;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> RXN_OBSOLETED { get { return this._rxn_obsoleted; } set { this.SetProperty(ref this._rxn_obsoleted, value); } } private ObservableCollection<string> _rxn_vet_drug;
        [DataMember]
        public ObservableCollection<string> RXN_VET_DRUG { get { return this._rxn_vet_drug; } set { this.SetProperty(ref this._rxn_vet_drug, value); } } private ObservableCollection<string> _umlsaui;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> UMLSAUI { get { return this._umlsaui; } set { this.SetProperty(ref this._umlsaui, value); } } private ObservableCollection<string> _umlscui;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> UMLSCUI { get { return this._umlscui; } set { this.SetProperty(ref this._umlscui, value); } } private ObservableCollection<SemanticBrandedDrug> _containsSBD;
        [DataMember(IsRequired = true)]
        public ObservableCollection<SemanticBrandedDrug> ContainsSBD {
            get { return this._containsSBD; }
            set { this.SetProperty(ref this._containsSBD, value); }
        } private ObservableCollection<SemanticClinicalDrug> _containsSCD;
        [DataMember(IsRequired = true)]
        public ObservableCollection<SemanticClinicalDrug> ContainsSCD {
            get { return this._containsSCD; }
            set { this.SetProperty(ref this._containsSCD, value); }
        } private DoseForm _hasDoseForm;
        [DataMember]
        public DoseForm HasDoseForm {
            get { return this._hasDoseForm; }
            set { this.SetProperty(ref this._hasDoseForm, value); }
        } private GenericDrugDeliveryDevice _tradenameOf;
        [DataMember]
        public GenericDrugDeliveryDevice TradenameOf {
            get { return this._tradenameOf; }
            set { this.SetProperty(ref this._tradenameOf, value); }
        }
    }
    [DataContract]
    public class DoseForm : BindableBase {
        private int _id;
        [DataMember(IsRequired = true)]
        public int Id { get { return this._id; } set { this.SetProperty(ref this._id, value); } }
        private string _name;
        [DataMember(IsRequired = true)]
        public string Name {
            get { return this._name; }
            set { this.SetProperty(ref this._name, value); }
        } private ObservableCollection<string> _orig_code;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> ORIG_CODE { get { return this._orig_code; } set { this.SetProperty(ref this._orig_code, value); } } private ObservableCollection<string> _orig_source;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> ORIG_SOURCE { get { return this._orig_source; } set { this.SetProperty(ref this._orig_source, value); } } private ObservableCollection<string> _rxn_activated;
        [DataMember]
        public ObservableCollection<string> RXN_ACTIVATED { get { return this._rxn_activated; } set { this.SetProperty(ref this._rxn_activated, value); } } private ObservableCollection<string> _rxn_obsoleted;
        [DataMember]
        public ObservableCollection<string> RXN_OBSOLETED { get { return this._rxn_obsoleted; } set { this.SetProperty(ref this._rxn_obsoleted, value); } } private string _umlsaui;
        [DataMember(IsRequired = true)]
        public string UMLSAUI { get { return this._umlsaui; } set { this.SetProperty(ref this._umlsaui, value); } } private string _umlscui;
        [DataMember(IsRequired = true)]
        public string UMLSCUI { get { return this._umlscui; } set { this.SetProperty(ref this._umlscui, value); } } private ObservableCollection<BrandedDrugDeliveryDevice> _doseFormOfBPCK;
        [DataMember(IsRequired = true)]
        public ObservableCollection<BrandedDrugDeliveryDevice> DoseFormOfBPCK {
            get { return this._doseFormOfBPCK; }
            set { this.SetProperty(ref this._doseFormOfBPCK, value); }
        } private ObservableCollection<GenericDrugDeliveryDevice> _doseFormOfGPCK;
        [DataMember(IsRequired = true)]
        public ObservableCollection<GenericDrugDeliveryDevice> DoseFormOfGPCK {
            get { return this._doseFormOfGPCK; }
            set { this.SetProperty(ref this._doseFormOfGPCK, value); }
        } private ObservableCollection<SemanticBrandedDrug> _doseFormOfSBD;
        [DataMember(IsRequired = true)]
        public ObservableCollection<SemanticBrandedDrug> DoseFormOfSBD {
            get { return this._doseFormOfSBD; }
            set { this.SetProperty(ref this._doseFormOfSBD, value); }
        } private ObservableCollection<SemanticBrandedDrugAndForm> _doseFormOfSBDF;
        [DataMember(IsRequired = true)]
        public ObservableCollection<SemanticBrandedDrugAndForm> DoseFormOfSBDF {
            get { return this._doseFormOfSBDF; }
            set { this.SetProperty(ref this._doseFormOfSBDF, value); }
        } private ObservableCollection<SemanticClinicalDrug> _doseFormOfSCD;
        [DataMember(IsRequired = true)]
        public ObservableCollection<SemanticClinicalDrug> DoseFormOfSCD {
            get { return this._doseFormOfSCD; }
            set { this.SetProperty(ref this._doseFormOfSCD, value); }
        } private ObservableCollection<SemanticClinicalDrugAndForm> _doseFormOfSCDF;
        [DataMember(IsRequired = true)]
        public ObservableCollection<SemanticClinicalDrugAndForm> DoseFormOfSCDF {
            get { return this._doseFormOfSCDF; }
            set { this.SetProperty(ref this._doseFormOfSCDF, value); }
        } private ObservableCollection<DoseFormGroup> _isa;
        [DataMember(IsRequired = true)]
        public ObservableCollection<DoseFormGroup> Isa {
            get { return this._isa; }
            set { this.SetProperty(ref this._isa, value); }
        }
    }
    [DataContract]
    public class DoseFormGroup : BindableBase {
        private int _id;
        [DataMember(IsRequired = true)]
        public int Id { get { return this._id; } set { this.SetProperty(ref this._id, value); } }
        private string _name;
        [DataMember(IsRequired = true)]
        public string Name {
            get { return this._name; }
            set { this.SetProperty(ref this._name, value); }
        } private string _umlsaui;
        [DataMember(IsRequired = true)]
        public string UMLSAUI { get { return this._umlsaui; } set { this.SetProperty(ref this._umlsaui, value); } } private string _umlscui;
        [DataMember(IsRequired = true)]
        public string UMLSCUI { get { return this._umlscui; } set { this.SetProperty(ref this._umlscui, value); } } private ObservableCollection<SemanticBrandedDrugGroup> _doseformgroupOfSBDG;
        [DataMember(IsRequired = true)]
        public ObservableCollection<SemanticBrandedDrugGroup> DoseformgroupOfSBDG {
            get { return this._doseformgroupOfSBDG; }
            set { this.SetProperty(ref this._doseformgroupOfSBDG, value); }
        } private ObservableCollection<SemanticClinicalDrugGroup> _doseformgroupOfSCDG;
        [DataMember(IsRequired = true)]
        public ObservableCollection<SemanticClinicalDrugGroup> DoseformgroupOfSCDG {
            get { return this._doseformgroupOfSCDG; }
            set { this.SetProperty(ref this._doseformgroupOfSCDG, value); }
        } private ObservableCollection<DoseForm> _inverseIsaDF;
        [DataMember]
        public ObservableCollection<DoseForm> InverseIsaDF {
            get { return this._inverseIsaDF; }
            set { this.SetProperty(ref this._inverseIsaDF, value); }
        } private ObservableCollection<EntryTerm> _inverseIsaET;
        [DataMember(IsRequired = true)]
        public ObservableCollection<EntryTerm> InverseIsaET {
            get { return this._inverseIsaET; }
            set { this.SetProperty(ref this._inverseIsaET, value); }
        }
    }
    [DataContract]
    public class EntryTerm : BindableBase {
        private int _id;
        [DataMember(IsRequired = true)]
        public int Id { get { return this._id; } set { this.SetProperty(ref this._id, value); } }
        private string _name;
        [DataMember(IsRequired = true)]
        public string Name {
            get { return this._name; }
            set { this.SetProperty(ref this._name, value); }
        } private string _orig_code;
        [DataMember(IsRequired = true)]
        public string ORIG_CODE { get { return this._orig_code; } set { this.SetProperty(ref this._orig_code, value); } } private string _orig_source;
        [DataMember(IsRequired = true)]
        public string ORIG_SOURCE { get { return this._orig_source; } set { this.SetProperty(ref this._orig_source, value); } } private ObservableCollection<string> _rxn_obsoleted;
        [DataMember]
        public ObservableCollection<string> RXN_OBSOLETED { get { return this._rxn_obsoleted; } set { this.SetProperty(ref this._rxn_obsoleted, value); } } private string _umlsaui;
        [DataMember(IsRequired = true)]
        public string UMLSAUI { get { return this._umlsaui; } set { this.SetProperty(ref this._umlsaui, value); } } private string _umlscui;
        [DataMember(IsRequired = true)]
        public string UMLSCUI { get { return this._umlscui; } set { this.SetProperty(ref this._umlscui, value); } } private ObservableCollection<SemanticBrandedDrug> _doseFormOfSBD;
        [DataMember(IsRequired = true)]
        public ObservableCollection<SemanticBrandedDrug> DoseFormOfSBD {
            get { return this._doseFormOfSBD; }
            set { this.SetProperty(ref this._doseFormOfSBD, value); }
        } private ObservableCollection<SemanticBrandedDrugAndForm> _doseFormOfSBDF;
        [DataMember(IsRequired = true)]
        public ObservableCollection<SemanticBrandedDrugAndForm> DoseFormOfSBDF {
            get { return this._doseFormOfSBDF; }
            set { this.SetProperty(ref this._doseFormOfSBDF, value); }
        } private ObservableCollection<SemanticClinicalDrug> _doseFormOfSCD;
        [DataMember(IsRequired = true)]
        public ObservableCollection<SemanticClinicalDrug> DoseFormOfSCD {
            get { return this._doseFormOfSCD; }
            set { this.SetProperty(ref this._doseFormOfSCD, value); }
        } private ObservableCollection<SemanticClinicalDrugAndForm> _doseFormOfSCDF;
        [DataMember(IsRequired = true)]
        public ObservableCollection<SemanticClinicalDrugAndForm> DoseFormOfSCDF {
            get { return this._doseFormOfSCDF; }
            set { this.SetProperty(ref this._doseFormOfSCDF, value); }
        } private ObservableCollection<DoseFormGroup> _isa;
        [DataMember(IsRequired = true)]
        public ObservableCollection<DoseFormGroup> Isa {
            get { return this._isa; }
            set { this.SetProperty(ref this._isa, value); }
        }
    }
    [DataContract]
    public class GenericDrugDeliveryDevice : BindableBase {
        private int _id;
        [DataMember(IsRequired = true)]
        public int Id { get { return this._id; } set { this.SetProperty(ref this._id, value); } }
        private string _name;
        [DataMember(IsRequired = true)]
        public string Name {
            get { return this._name; }
            set { this.SetProperty(ref this._name, value); }
        } private ObservableCollection<string> _ambiguity_flag;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> AMBIGUITY_FLAG { get { return this._ambiguity_flag; } set { this.SetProperty(ref this._ambiguity_flag, value); } } private ObservableCollection<string> _ndc;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> NDC { get { return this._ndc; } set { this.SetProperty(ref this._ndc, value); } } private ObservableCollection<string> _rxn_activated;
        [DataMember]
        public ObservableCollection<string> RXN_ACTIVATED { get { return this._rxn_activated; } set { this.SetProperty(ref this._rxn_activated, value); } } private ObservableCollection<string> _rxn_human_drug;
        [DataMember]
        public ObservableCollection<string> RXN_HUMAN_DRUG { get { return this._rxn_human_drug; } set { this.SetProperty(ref this._rxn_human_drug, value); } } private ObservableCollection<string> _rxn_obsoleted;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> RXN_OBSOLETED { get { return this._rxn_obsoleted; } set { this.SetProperty(ref this._rxn_obsoleted, value); } } private ObservableCollection<string> _rxn_vet_drug;
        [DataMember]
        public ObservableCollection<string> RXN_VET_DRUG { get { return this._rxn_vet_drug; } set { this.SetProperty(ref this._rxn_vet_drug, value); } } private ObservableCollection<string> _umlsaui;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> UMLSAUI { get { return this._umlsaui; } set { this.SetProperty(ref this._umlsaui, value); } } private ObservableCollection<string> _umlscui;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> UMLSCUI { get { return this._umlscui; } set { this.SetProperty(ref this._umlscui, value); } } private ObservableCollection<SemanticClinicalDrug> _contains;
        [DataMember]
        public ObservableCollection<SemanticClinicalDrug> Contains {
            get { return this._contains; }
            set { this.SetProperty(ref this._contains, value); }
        } private DoseForm _hasDoseForm;
        [DataMember]
        public DoseForm HasDoseForm {
            get { return this._hasDoseForm; }
            set { this.SetProperty(ref this._hasDoseForm, value); }
        } private ObservableCollection<BrandedDrugDeliveryDevice> _hasTradename;
        [DataMember(IsRequired = true)]
        public ObservableCollection<BrandedDrugDeliveryDevice> HasTradename {
            get { return this._hasTradename; }
            set { this.SetProperty(ref this._hasTradename, value); }
        }
    }
    [DataContract]
    public class NameForAnIngredient : BindableBase {
        private int _id;
        [DataMember(IsRequired = true)]
        public int Id { get { return this._id; } set { this.SetProperty(ref this._id, value); } }
        private string _name;
        [DataMember(IsRequired = true)]
        public string Name {
            get { return this._name; }
            set { this.SetProperty(ref this._name, value); }
        } private ObservableCollection<string> _rxn_activated;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> RXN_ACTIVATED { get { return this._rxn_activated; } set { this.SetProperty(ref this._rxn_activated, value); } } private ObservableCollection<string> _rxn_obsoleted;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> RXN_OBSOLETED { get { return this._rxn_obsoleted; } set { this.SetProperty(ref this._rxn_obsoleted, value); } } private ObservableCollection<string> _umlsaui;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> UMLSAUI { get { return this._umlsaui; } set { this.SetProperty(ref this._umlsaui, value); } } private ObservableCollection<string> _umlscui;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> UMLSCUI { get { return this._umlscui; } set { this.SetProperty(ref this._umlscui, value); } } private ObservableCollection<string> _unii_code;
        [DataMember]
        public ObservableCollection<string> UNII_CODE { get { return this._unii_code; } set { this.SetProperty(ref this._unii_code, value); } } private ObservableCollection<NameFromAPreciseIngredient> _hasForm;
        [DataMember(IsRequired = true)]
        public ObservableCollection<NameFromAPreciseIngredient> HasForm {
            get { return this._hasForm; }
            set { this.SetProperty(ref this._hasForm, value); }
        } private ObservableCollection<FullySpecifiedDrugBrandNameThatCanNotBePrescribed> _hasTradename;
        [DataMember(IsRequired = true)]
        public ObservableCollection<FullySpecifiedDrugBrandNameThatCanNotBePrescribed> HasTradename {
            get { return this._hasTradename; }
            set { this.SetProperty(ref this._hasTradename, value); }
        } private ObservableCollection<SemanticDrugComponent> _ingredientOfSCDC;
        [DataMember(IsRequired = true)]
        public ObservableCollection<SemanticDrugComponent> IngredientOfSCDC {
            get { return this._ingredientOfSCDC; }
            set { this.SetProperty(ref this._ingredientOfSCDC, value); }
        } private ObservableCollection<SemanticClinicalDrugAndForm> _ingredientOfSCDF;
        [DataMember(IsRequired = true)]
        public ObservableCollection<SemanticClinicalDrugAndForm> IngredientOfSCDF {
            get { return this._ingredientOfSCDF; }
            set { this.SetProperty(ref this._ingredientOfSCDF, value); }
        } private ObservableCollection<SemanticClinicalDrugGroup> _ingredientOfSCDG;
        [DataMember(IsRequired = true)]
        public ObservableCollection<SemanticClinicalDrugGroup> IngredientOfSCDG {
            get { return this._ingredientOfSCDG; }
            set { this.SetProperty(ref this._ingredientOfSCDG, value); }
        } private ObservableCollection<NameForAMultiIngredient> _partOf;
        [DataMember(IsRequired = true)]
        public ObservableCollection<NameForAMultiIngredient> PartOf {
            get { return this._partOf; }
            set { this.SetProperty(ref this._partOf, value); }
        }
    }
    [DataContract]
    public class NameForAMultiIngredient : BindableBase {
        private int _id;
        [DataMember(IsRequired = true)]
        public int Id { get { return this._id; } set { this.SetProperty(ref this._id, value); } }
        private string _name;
        [DataMember(IsRequired = true)]
        public string Name {
            get { return this._name; }
            set { this.SetProperty(ref this._name, value); }
        } private ObservableCollection<string> _umlsaui;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> UMLSAUI { get { return this._umlsaui; } set { this.SetProperty(ref this._umlsaui, value); } } private ObservableCollection<string> _umlscui;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> UMLSCUI { get { return this._umlscui; } set { this.SetProperty(ref this._umlscui, value); } } private ObservableCollection<NameForAnIngredient> _hasPartIN;
        [DataMember(IsRequired = true)]
        public ObservableCollection<NameForAnIngredient> HasPartIN {
            get { return this._hasPartIN; }
            set { this.SetProperty(ref this._hasPartIN, value); }
        } private ObservableCollection<NameFromAPreciseIngredient> _hasPartPIN;
        [DataMember(IsRequired = true)]
        public ObservableCollection<NameFromAPreciseIngredient> HasPartPIN {
            get { return this._hasPartPIN; }
            set { this.SetProperty(ref this._hasPartPIN, value); }
        } private ObservableCollection<SemanticClinicalDrug> _ingredientsOf;
        [DataMember]
        public ObservableCollection<SemanticClinicalDrug> IngredientsOf {
            get { return this._ingredientsOf; }
            set { this.SetProperty(ref this._ingredientsOf, value); }
        }
    }
    [DataContract]
    public class NameFromAPreciseIngredient : BindableBase {
        private int _id;
        [DataMember(IsRequired = true)]
        public int Id { get { return this._id; } set { this.SetProperty(ref this._id, value); } }
        private string _name;
        [DataMember(IsRequired = true)]
        public string Name {
            get { return this._name; }
            set { this.SetProperty(ref this._name, value); }
        } private ObservableCollection<string> _rxn_activated;
        [DataMember]
        public ObservableCollection<string> RXN_ACTIVATED { get { return this._rxn_activated; } set { this.SetProperty(ref this._rxn_activated, value); } } private ObservableCollection<string> _rxn_obsoleted;
        [DataMember]
        public ObservableCollection<string> RXN_OBSOLETED { get { return this._rxn_obsoleted; } set { this.SetProperty(ref this._rxn_obsoleted, value); } } private ObservableCollection<string> _umlsaui;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> UMLSAUI { get { return this._umlsaui; } set { this.SetProperty(ref this._umlsaui, value); } } private ObservableCollection<string> _umlscui;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> UMLSCUI { get { return this._umlscui; } set { this.SetProperty(ref this._umlscui, value); } } private ObservableCollection<string> _unii_code;
        [DataMember]
        public ObservableCollection<string> UNII_CODE { get { return this._unii_code; } set { this.SetProperty(ref this._unii_code, value); } } private NameForAnIngredient _formOf;
        [DataMember]
        public NameForAnIngredient FormOf {
            get { return this._formOf; }
            set { this.SetProperty(ref this._formOf, value); }
        } private ObservableCollection<NameForAMultiIngredient> _partOf;
        [DataMember(IsRequired = true)]
        public ObservableCollection<NameForAMultiIngredient> PartOf {
            get { return this._partOf; }
            set { this.SetProperty(ref this._partOf, value); }
        } private ObservableCollection<FullySpecifiedDrugBrandNameThatCanNotBePrescribed> _preciseIngredientOfBN;
        [DataMember(IsRequired = true)]
        public ObservableCollection<FullySpecifiedDrugBrandNameThatCanNotBePrescribed> PreciseIngredientOfBN {
            get { return this._preciseIngredientOfBN; }
            set { this.SetProperty(ref this._preciseIngredientOfBN, value); }
        } private ObservableCollection<SemanticDrugComponent> _preciseIngredientOfSCDC;
        [DataMember(IsRequired = true)]
        public ObservableCollection<SemanticDrugComponent> PreciseIngredientOfSCDC {
            get { return this._preciseIngredientOfSCDC; }
            set { this.SetProperty(ref this._preciseIngredientOfSCDC, value); }
        }
    }
    [DataContract]
    public class SemanticBrandedDrug : BindableBase {
        private int _id;
        [DataMember(IsRequired = true)]
        public int Id { get { return this._id; } set { this.SetProperty(ref this._id, value); } }
        private string _name;
        [DataMember(IsRequired = true)]
        public string Name {
            get { return this._name; }
            set { this.SetProperty(ref this._name, value); }
        } private ObservableCollection<string> _ambiguity_flag;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> AMBIGUITY_FLAG { get { return this._ambiguity_flag; } set { this.SetProperty(ref this._ambiguity_flag, value); } } private ObservableCollection<string> _ndc;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> NDC { get { return this._ndc; } set { this.SetProperty(ref this._ndc, value); } } private ObservableCollection<string> _rxn_activated;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> RXN_ACTIVATED { get { return this._rxn_activated; } set { this.SetProperty(ref this._rxn_activated, value); } } private ObservableCollection<string> _rxn_available_strength;
        [DataMember]
        public ObservableCollection<string> RXN_AVAILABLE_STRENGTH { get { return this._rxn_available_strength; } set { this.SetProperty(ref this._rxn_available_strength, value); } } private ObservableCollection<string> _rxn_human_drug;
        [DataMember]
        public ObservableCollection<string> RXN_HUMAN_DRUG { get { return this._rxn_human_drug; } set { this.SetProperty(ref this._rxn_human_drug, value); } } private ObservableCollection<string> _rxn_obsoleted;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> RXN_OBSOLETED { get { return this._rxn_obsoleted; } set { this.SetProperty(ref this._rxn_obsoleted, value); } } private ObservableCollection<string> _rxn_quantity;
        [DataMember]
        public ObservableCollection<string> RXN_QUANTITY { get { return this._rxn_quantity; } set { this.SetProperty(ref this._rxn_quantity, value); } } private ObservableCollection<string> _rxn_vet_drug;
        [DataMember]
        public ObservableCollection<string> RXN_VET_DRUG { get { return this._rxn_vet_drug; } set { this.SetProperty(ref this._rxn_vet_drug, value); } } private string _rxterm_form;
        [DataMember]
        public string RXTERM_FORM { get { return this._rxterm_form; } set { this.SetProperty(ref this._rxterm_form, value); } } private ObservableCollection<string> _umlsaui;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> UMLSAUI { get { return this._umlsaui; } set { this.SetProperty(ref this._umlsaui, value); } } private ObservableCollection<string> _umlscui;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> UMLSCUI { get { return this._umlscui; } set { this.SetProperty(ref this._umlscui, value); } } private SemanticBrandedDrugComponent _consistsOfSBDC;
        [DataMember]
        public SemanticBrandedDrugComponent ConsistsOfSBDC {
            get { return this._consistsOfSBDC; }
            set { this.SetProperty(ref this._consistsOfSBDC, value); }
        } private ObservableCollection<SemanticDrugComponent> _consistsOfSCDC;
        [DataMember]
        public ObservableCollection<SemanticDrugComponent> ConsistsOfSCDC {
            get { return this._consistsOfSCDC; }
            set { this.SetProperty(ref this._consistsOfSCDC, value); }
        } private ObservableCollection<BrandedDrugDeliveryDevice> _containedIn;
        [DataMember(IsRequired = true)]
        public ObservableCollection<BrandedDrugDeliveryDevice> ContainedIn {
            get { return this._containedIn; }
            set { this.SetProperty(ref this._containedIn, value); }
        } private DoseForm _hasDoseFormDF;
        [DataMember]
        public DoseForm HasDoseFormDF {
            get { return this._hasDoseFormDF; }
            set { this.SetProperty(ref this._hasDoseFormDF, value); }
        } private EntryTerm _hasDoseFormET;
        [DataMember(IsRequired = true)]
        public EntryTerm HasDoseFormET {
            get { return this._hasDoseFormET; }
            set { this.SetProperty(ref this._hasDoseFormET, value); }
        } private FullySpecifiedDrugBrandNameThatCanNotBePrescribed _hasIngredient;
        [DataMember]
        public FullySpecifiedDrugBrandNameThatCanNotBePrescribed HasIngredient {
            get { return this._hasIngredient; }
            set { this.SetProperty(ref this._hasIngredient, value); }
        } private ObservableCollection<SemanticBrandedDrug> _hasQuantifiedForm;
        [DataMember(IsRequired = true)]
        public ObservableCollection<SemanticBrandedDrug> HasQuantifiedForm {
            get { return this._hasQuantifiedForm; }
            set { this.SetProperty(ref this._hasQuantifiedForm, value); }
        } private SemanticBrandedDrugAndForm _isaSBDF;
        [DataMember]
        public SemanticBrandedDrugAndForm IsaSBDF {
            get { return this._isaSBDF; }
            set { this.SetProperty(ref this._isaSBDF, value); }
        } private ObservableCollection<SemanticBrandedDrugGroup> _isaSBDG;
        [DataMember]
        public ObservableCollection<SemanticBrandedDrugGroup> IsaSBDG {
            get { return this._isaSBDG; }
            set { this.SetProperty(ref this._isaSBDG, value); }
        } private SemanticBrandedDrug _quantifiedFormOf;
        [DataMember(IsRequired = true)]
        public SemanticBrandedDrug QuantifiedFormOf {
            get { return this._quantifiedFormOf; }
            set { this.SetProperty(ref this._quantifiedFormOf, value); }
        } private SemanticClinicalDrug _tradenameOf;
        [DataMember]
        public SemanticClinicalDrug TradenameOf {
            get { return this._tradenameOf; }
            set { this.SetProperty(ref this._tradenameOf, value); }
        }
    }
    [DataContract]
    public class SemanticBrandedDrugComponent : BindableBase {
        private int _id;
        [DataMember(IsRequired = true)]
        public int Id { get { return this._id; } set { this.SetProperty(ref this._id, value); } }
        private string _name;
        [DataMember(IsRequired = true)]
        public string Name {
            get { return this._name; }
            set { this.SetProperty(ref this._name, value); }
        } private ObservableCollection<string> _rxn_activated;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> RXN_ACTIVATED { get { return this._rxn_activated; } set { this.SetProperty(ref this._rxn_activated, value); } } private ObservableCollection<string> _rxn_obsoleted;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> RXN_OBSOLETED { get { return this._rxn_obsoleted; } set { this.SetProperty(ref this._rxn_obsoleted, value); } } private ObservableCollection<string> _umlsaui;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> UMLSAUI { get { return this._umlsaui; } set { this.SetProperty(ref this._umlsaui, value); } } private ObservableCollection<string> _umlscui;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> UMLSCUI { get { return this._umlscui; } set { this.SetProperty(ref this._umlscui, value); } } private ObservableCollection<SemanticBrandedDrug> _constitutes;
        [DataMember]
        public ObservableCollection<SemanticBrandedDrug> Constitutes {
            get { return this._constitutes; }
            set { this.SetProperty(ref this._constitutes, value); }
        } private FullySpecifiedDrugBrandNameThatCanNotBePrescribed _hasIngredient;
        [DataMember]
        public FullySpecifiedDrugBrandNameThatCanNotBePrescribed HasIngredient {
            get { return this._hasIngredient; }
            set { this.SetProperty(ref this._hasIngredient, value); }
        } private ObservableCollection<SemanticDrugComponent> _tradenameOf;
        [DataMember]
        public ObservableCollection<SemanticDrugComponent> TradenameOf {
            get { return this._tradenameOf; }
            set { this.SetProperty(ref this._tradenameOf, value); }
        }
    }
    [DataContract]
    public class SemanticBrandedDrugAndForm : BindableBase {
        private int _id;
        [DataMember(IsRequired = true)]
        public int Id { get { return this._id; } set { this.SetProperty(ref this._id, value); } }
        private string _name;
        [DataMember(IsRequired = true)]
        public string Name {
            get { return this._name; }
            set { this.SetProperty(ref this._name, value); }
        } private ObservableCollection<string> _rxn_activated;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> RXN_ACTIVATED { get { return this._rxn_activated; } set { this.SetProperty(ref this._rxn_activated, value); } } private ObservableCollection<string> _rxn_obsoleted;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> RXN_OBSOLETED { get { return this._rxn_obsoleted; } set { this.SetProperty(ref this._rxn_obsoleted, value); } } private ObservableCollection<string> _umlsaui;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> UMLSAUI { get { return this._umlsaui; } set { this.SetProperty(ref this._umlsaui, value); } } private ObservableCollection<string> _umlscui;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> UMLSCUI { get { return this._umlscui; } set { this.SetProperty(ref this._umlscui, value); } } private DoseForm _hasDoseFormDF;
        [DataMember]
        public DoseForm HasDoseFormDF {
            get { return this._hasDoseFormDF; }
            set { this.SetProperty(ref this._hasDoseFormDF, value); }
        } private EntryTerm _hasDoseFormET;
        [DataMember(IsRequired = true)]
        public EntryTerm HasDoseFormET {
            get { return this._hasDoseFormET; }
            set { this.SetProperty(ref this._hasDoseFormET, value); }
        } private FullySpecifiedDrugBrandNameThatCanNotBePrescribed _hasIngredient;
        [DataMember]
        public FullySpecifiedDrugBrandNameThatCanNotBePrescribed HasIngredient {
            get { return this._hasIngredient; }
            set { this.SetProperty(ref this._hasIngredient, value); }
        } private ObservableCollection<SemanticBrandedDrug> _inverseIsa;
        [DataMember]
        public ObservableCollection<SemanticBrandedDrug> InverseIsa {
            get { return this._inverseIsa; }
            set { this.SetProperty(ref this._inverseIsa, value); }
        } private ObservableCollection<SemanticBrandedDrugGroup> _isa;
        [DataMember]
        public ObservableCollection<SemanticBrandedDrugGroup> Isa {
            get { return this._isa; }
            set { this.SetProperty(ref this._isa, value); }
        } private SemanticClinicalDrugAndForm _tradenameOf;
        [DataMember]
        public SemanticClinicalDrugAndForm TradenameOf {
            get { return this._tradenameOf; }
            set { this.SetProperty(ref this._tradenameOf, value); }
        }
    }
    [DataContract]
    public class SemanticBrandedDrugGroup : BindableBase {
        private int _id;
        [DataMember(IsRequired = true)]
        public int Id { get { return this._id; } set { this.SetProperty(ref this._id, value); } }
        private string _name;
        [DataMember(IsRequired = true)]
        public string Name {
            get { return this._name; }
            set { this.SetProperty(ref this._name, value); }
        } private ObservableCollection<string> _rxn_available_strength;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> RXN_AVAILABLE_STRENGTH { get { return this._rxn_available_strength; } set { this.SetProperty(ref this._rxn_available_strength, value); } } private ObservableCollection<string> _umlsaui;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> UMLSAUI { get { return this._umlsaui; } set { this.SetProperty(ref this._umlsaui, value); } } private ObservableCollection<string> _umlscui;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> UMLSCUI { get { return this._umlscui; } set { this.SetProperty(ref this._umlscui, value); } } private DoseFormGroup _hasDoseformgroup;
        [DataMember]
        public DoseFormGroup HasDoseformgroup {
            get { return this._hasDoseformgroup; }
            set { this.SetProperty(ref this._hasDoseformgroup, value); }
        } private FullySpecifiedDrugBrandNameThatCanNotBePrescribed _hasIngredient;
        [DataMember]
        public FullySpecifiedDrugBrandNameThatCanNotBePrescribed HasIngredient {
            get { return this._hasIngredient; }
            set { this.SetProperty(ref this._hasIngredient, value); }
        } private ObservableCollection<SemanticBrandedDrug> _inverseIsaSBD;
        [DataMember]
        public ObservableCollection<SemanticBrandedDrug> InverseIsaSBD {
            get { return this._inverseIsaSBD; }
            set { this.SetProperty(ref this._inverseIsaSBD, value); }
        } private ObservableCollection<SemanticBrandedDrugAndForm> _inverseIsaSBDF;
        [DataMember]
        public ObservableCollection<SemanticBrandedDrugAndForm> InverseIsaSBDF {
            get { return this._inverseIsaSBDF; }
            set { this.SetProperty(ref this._inverseIsaSBDF, value); }
        } private ObservableCollection<SemanticClinicalDrugGroup> _tradenameOf;
        [DataMember]
        public ObservableCollection<SemanticClinicalDrugGroup> TradenameOf {
            get { return this._tradenameOf; }
            set { this.SetProperty(ref this._tradenameOf, value); }
        }
    }
    [DataContract]
    public class SemanticClinicalDrug : BindableBase {
        private int _id;
        [DataMember(IsRequired = true)]
        public int Id { get { return this._id; } set { this.SetProperty(ref this._id, value); } }
        private string _name;
        [DataMember(IsRequired = true)]
        public string Name {
            get { return this._name; }
            set { this.SetProperty(ref this._name, value); }
        } private ObservableCollection<string> _ambiguity_flag;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> AMBIGUITY_FLAG { get { return this._ambiguity_flag; } set { this.SetProperty(ref this._ambiguity_flag, value); } } private ObservableCollection<string> _ndc;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> NDC { get { return this._ndc; } set { this.SetProperty(ref this._ndc, value); } } private ObservableCollection<string> _rxn_activated;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> RXN_ACTIVATED { get { return this._rxn_activated; } set { this.SetProperty(ref this._rxn_activated, value); } } private ObservableCollection<string> _rxn_available_strength;
        [DataMember]
        public ObservableCollection<string> RXN_AVAILABLE_STRENGTH { get { return this._rxn_available_strength; } set { this.SetProperty(ref this._rxn_available_strength, value); } } private ObservableCollection<string> _rxn_human_drug;
        [DataMember]
        public ObservableCollection<string> RXN_HUMAN_DRUG { get { return this._rxn_human_drug; } set { this.SetProperty(ref this._rxn_human_drug, value); } } private ObservableCollection<string> _rxn_obsoleted;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> RXN_OBSOLETED { get { return this._rxn_obsoleted; } set { this.SetProperty(ref this._rxn_obsoleted, value); } } private ObservableCollection<string> _rxn_quantity;
        [DataMember]
        public ObservableCollection<string> RXN_QUANTITY { get { return this._rxn_quantity; } set { this.SetProperty(ref this._rxn_quantity, value); } } private ObservableCollection<string> _rxn_vet_drug;
        [DataMember]
        public ObservableCollection<string> RXN_VET_DRUG { get { return this._rxn_vet_drug; } set { this.SetProperty(ref this._rxn_vet_drug, value); } } private string _rxterm_form;
        [DataMember]
        public string RXTERM_FORM { get { return this._rxterm_form; } set { this.SetProperty(ref this._rxterm_form, value); } } private ObservableCollection<string> _umlsaui;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> UMLSAUI { get { return this._umlsaui; } set { this.SetProperty(ref this._umlsaui, value); } } private ObservableCollection<string> _umlscui;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> UMLSCUI { get { return this._umlscui; } set { this.SetProperty(ref this._umlscui, value); } } private ObservableCollection<SemanticDrugComponent> _consistsOf;
        [DataMember]
        public ObservableCollection<SemanticDrugComponent> ConsistsOf {
            get { return this._consistsOf; }
            set { this.SetProperty(ref this._consistsOf, value); }
        } private ObservableCollection<BrandedDrugDeliveryDevice> _containedInBPCK;
        [DataMember(IsRequired = true)]
        public ObservableCollection<BrandedDrugDeliveryDevice> ContainedInBPCK {
            get { return this._containedInBPCK; }
            set { this.SetProperty(ref this._containedInBPCK, value); }
        } private ObservableCollection<GenericDrugDeliveryDevice> _containedInGPCK;
        [DataMember(IsRequired = true)]
        public ObservableCollection<GenericDrugDeliveryDevice> ContainedInGPCK {
            get { return this._containedInGPCK; }
            set { this.SetProperty(ref this._containedInGPCK, value); }
        } private DoseForm _hasDoseFormDF;
        [DataMember]
        public DoseForm HasDoseFormDF {
            get { return this._hasDoseFormDF; }
            set { this.SetProperty(ref this._hasDoseFormDF, value); }
        } private EntryTerm _hasDoseFormET;
        [DataMember(IsRequired = true)]
        public EntryTerm HasDoseFormET {
            get { return this._hasDoseFormET; }
            set { this.SetProperty(ref this._hasDoseFormET, value); }
        } private NameForAMultiIngredient _hasIngredients;
        [DataMember(IsRequired = true)]
        public NameForAMultiIngredient HasIngredients {
            get { return this._hasIngredients; }
            set { this.SetProperty(ref this._hasIngredients, value); }
        } private ObservableCollection<SemanticClinicalDrug> _hasQuantifiedForm;
        [DataMember(IsRequired = true)]
        public ObservableCollection<SemanticClinicalDrug> HasQuantifiedForm {
            get { return this._hasQuantifiedForm; }
            set { this.SetProperty(ref this._hasQuantifiedForm, value); }
        } private ObservableCollection<SemanticBrandedDrug> _hasTradename;
        [DataMember(IsRequired = true)]
        public ObservableCollection<SemanticBrandedDrug> HasTradename {
            get { return this._hasTradename; }
            set { this.SetProperty(ref this._hasTradename, value); }
        } private SemanticClinicalDrugAndForm _isaSCDF;
        [DataMember]
        public SemanticClinicalDrugAndForm IsaSCDF {
            get { return this._isaSCDF; }
            set { this.SetProperty(ref this._isaSCDF, value); }
        } private ObservableCollection<SemanticClinicalDrugGroup> _isaSCDG;
        [DataMember(IsRequired = true)]
        public ObservableCollection<SemanticClinicalDrugGroup> IsaSCDG {
            get { return this._isaSCDG; }
            set { this.SetProperty(ref this._isaSCDG, value); }
        } private SemanticClinicalDrug _quantifiedFormOf;
        [DataMember(IsRequired = true)]
        public SemanticClinicalDrug QuantifiedFormOf {
            get { return this._quantifiedFormOf; }
            set { this.SetProperty(ref this._quantifiedFormOf, value); }
        }
    }
    [DataContract]
    public class SemanticDrugComponent : BindableBase {
        private int _id;
        [DataMember(IsRequired = true)]
        public int Id { get { return this._id; } set { this.SetProperty(ref this._id, value); } }
        private string _name;
        [DataMember(IsRequired = true)]
        public string Name {
            get { return this._name; }
            set { this.SetProperty(ref this._name, value); }
        } private ObservableCollection<string> _rxn_activated;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> RXN_ACTIVATED { get { return this._rxn_activated; } set { this.SetProperty(ref this._rxn_activated, value); } } private ObservableCollection<string> _rxn_in_expressed_flag;
        [DataMember]
        public ObservableCollection<string> RXN_IN_EXPRESSED_FLAG { get { return this._rxn_in_expressed_flag; } set { this.SetProperty(ref this._rxn_in_expressed_flag, value); } } private ObservableCollection<string> _rxn_obsoleted;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> RXN_OBSOLETED { get { return this._rxn_obsoleted; } set { this.SetProperty(ref this._rxn_obsoleted, value); } } private string _rxn_strength;
        [DataMember]
        public string RXN_STRENGTH { get { return this._rxn_strength; } set { this.SetProperty(ref this._rxn_strength, value); } } private ObservableCollection<string> _umlsaui;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> UMLSAUI { get { return this._umlsaui; } set { this.SetProperty(ref this._umlsaui, value); } } private ObservableCollection<string> _umlscui;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> UMLSCUI { get { return this._umlscui; } set { this.SetProperty(ref this._umlscui, value); } } private ObservableCollection<SemanticBrandedDrug> _constitutesSBD;
        [DataMember(IsRequired = true)]
        public ObservableCollection<SemanticBrandedDrug> ConstitutesSBD {
            get { return this._constitutesSBD; }
            set { this.SetProperty(ref this._constitutesSBD, value); }
        } private ObservableCollection<SemanticClinicalDrug> _constitutesSCD;
        [DataMember]
        public ObservableCollection<SemanticClinicalDrug> ConstitutesSCD {
            get { return this._constitutesSCD; }
            set { this.SetProperty(ref this._constitutesSCD, value); }
        } private NameForAnIngredient _hasIngredient;
        [DataMember]
        public NameForAnIngredient HasIngredient {
            get { return this._hasIngredient; }
            set { this.SetProperty(ref this._hasIngredient, value); }
        } private NameFromAPreciseIngredient _hasPreciseIngredient;
        [DataMember(IsRequired = true)]
        public NameFromAPreciseIngredient HasPreciseIngredient {
            get { return this._hasPreciseIngredient; }
            set { this.SetProperty(ref this._hasPreciseIngredient, value); }
        } private ObservableCollection<SemanticBrandedDrugComponent> _hasTradename;
        [DataMember(IsRequired = true)]
        public ObservableCollection<SemanticBrandedDrugComponent> HasTradename {
            get { return this._hasTradename; }
            set { this.SetProperty(ref this._hasTradename, value); }
        }
    }
    [DataContract]
    public class SemanticClinicalDrugAndForm : BindableBase {
        private int _id;
        [DataMember(IsRequired = true)]
        public int Id { get { return this._id; } set { this.SetProperty(ref this._id, value); } }
        private string _name;
        [DataMember(IsRequired = true)]
        public string Name {
            get { return this._name; }
            set { this.SetProperty(ref this._name, value); }
        } private ObservableCollection<string> _rxn_activated;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> RXN_ACTIVATED { get { return this._rxn_activated; } set { this.SetProperty(ref this._rxn_activated, value); } } private ObservableCollection<string> _rxn_obsoleted;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> RXN_OBSOLETED { get { return this._rxn_obsoleted; } set { this.SetProperty(ref this._rxn_obsoleted, value); } } private ObservableCollection<string> _umlsaui;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> UMLSAUI { get { return this._umlsaui; } set { this.SetProperty(ref this._umlsaui, value); } } private ObservableCollection<string> _umlscui;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> UMLSCUI { get { return this._umlscui; } set { this.SetProperty(ref this._umlscui, value); } } private DoseForm _hasDoseFormDF;
        [DataMember]
        public DoseForm HasDoseFormDF {
            get { return this._hasDoseFormDF; }
            set { this.SetProperty(ref this._hasDoseFormDF, value); }
        } private EntryTerm _hasDoseFormET;
        [DataMember(IsRequired = true)]
        public EntryTerm HasDoseFormET {
            get { return this._hasDoseFormET; }
            set { this.SetProperty(ref this._hasDoseFormET, value); }
        } private ObservableCollection<NameForAnIngredient> _hasIngredient;
        [DataMember]
        public ObservableCollection<NameForAnIngredient> HasIngredient {
            get { return this._hasIngredient; }
            set { this.SetProperty(ref this._hasIngredient, value); }
        } private ObservableCollection<SemanticBrandedDrugAndForm> _hasTradename;
        [DataMember(IsRequired = true)]
        public ObservableCollection<SemanticBrandedDrugAndForm> HasTradename {
            get { return this._hasTradename; }
            set { this.SetProperty(ref this._hasTradename, value); }
        } private ObservableCollection<SemanticClinicalDrug> _inverseIsa;
        [DataMember]
        public ObservableCollection<SemanticClinicalDrug> InverseIsa {
            get { return this._inverseIsa; }
            set { this.SetProperty(ref this._inverseIsa, value); }
        } private ObservableCollection<SemanticClinicalDrugGroup> _isa;
        [DataMember(IsRequired = true)]
        public ObservableCollection<SemanticClinicalDrugGroup> Isa {
            get { return this._isa; }
            set { this.SetProperty(ref this._isa, value); }
        }
    }
    [DataContract]
    public class SemanticClinicalDrugGroup : BindableBase {
        private int _id;
        [DataMember(IsRequired = true)]
        public int Id { get { return this._id; } set { this.SetProperty(ref this._id, value); } }
        private string _name;
        [DataMember(IsRequired = true)]
        public string Name {
            get { return this._name; }
            set { this.SetProperty(ref this._name, value); }
        } private ObservableCollection<string> _rxn_available_strength;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> RXN_AVAILABLE_STRENGTH { get { return this._rxn_available_strength; } set { this.SetProperty(ref this._rxn_available_strength, value); } } private ObservableCollection<string> _umlsaui;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> UMLSAUI { get { return this._umlsaui; } set { this.SetProperty(ref this._umlsaui, value); } } private ObservableCollection<string> _umlscui;
        [DataMember(IsRequired = true)]
        public ObservableCollection<string> UMLSCUI { get { return this._umlscui; } set { this.SetProperty(ref this._umlscui, value); } } private DoseFormGroup _hasDoseformgroup;
        [DataMember]
        public DoseFormGroup HasDoseformgroup {
            get { return this._hasDoseformgroup; }
            set { this.SetProperty(ref this._hasDoseformgroup, value); }
        } private ObservableCollection<NameForAnIngredient> _hasIngredient;
        [DataMember]
        public ObservableCollection<NameForAnIngredient> HasIngredient {
            get { return this._hasIngredient; }
            set { this.SetProperty(ref this._hasIngredient, value); }
        } private ObservableCollection<SemanticBrandedDrugGroup> _hasTradename;
        [DataMember(IsRequired = true)]
        public ObservableCollection<SemanticBrandedDrugGroup> HasTradename {
            get { return this._hasTradename; }
            set { this.SetProperty(ref this._hasTradename, value); }
        } private ObservableCollection<SemanticClinicalDrug> _inverseIsaSCD;
        [DataMember]
        public ObservableCollection<SemanticClinicalDrug> InverseIsaSCD {
            get { return this._inverseIsaSCD; }
            set { this.SetProperty(ref this._inverseIsaSCD, value); }
        } private ObservableCollection<SemanticClinicalDrugAndForm> _inverseIsaSCDF;
        [DataMember]
        public ObservableCollection<SemanticClinicalDrugAndForm> InverseIsaSCDF {
            get { return this._inverseIsaSCDF; }
            set { this.SetProperty(ref this._inverseIsaSCDF, value); }
        }
    }



}
