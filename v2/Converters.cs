using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;
using System.Collections.ObjectModel;

namespace Drugs2 {

    public class SuccessorConverter : IValueConverter {

        public object Convert(object value, Type targetType, object parameter, string language) {
            return (value as string).Replace('_', ' ');
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            return (value as string).Replace(' ', '_');
        }
    }
    public class SuccessorListConverter : IValueConverter {

        public object Convert(object value, Type targetType, object parameter, string language) {
            var id = value as Nullable<int>;
            if (id != null) {
                var task = Service.GetConceptAsync(id.Value);
            }
            return (value as string).Replace('_', ' ');
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            throw new NotImplementedException();
        }
    }
    public class EntityTypeConverter : IValueConverter {

        public object Convert(object value, Type targetType, object parameter, string language) {
            switch (value as string) {
                case "BN": return "Brandname";
                case "IN": return "Drug Ingredient";
                case "PIN": return "Precise Drug Ingredient";
                case "MIN": return "Drug Ingredient Combination";
                case "SBDG": return "Branded Dose Form Group";
                case "SBDF": return "Branded Dose Form";
                case "SBDC": return "Branded Dose Strength";
                case "SBD": return "Branded Drug";
                case "SCDG": return "Clinical Dose Form Group";
                case "SCDF": return "Clinical Dose Form";
                case "SCDC": return "Clinical Dose Strength";
                case "SCD": return "Clinical Drug";
                case "DF": return "Dose Form";
                case "DFG": return "Dose Form Group";
                case "ET": return "Entity Type";
                case "TMSY": return "Tall Man Synonym";
                case "SY": return "Synonym";
                default: return "Unknown";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            throw new NotImplementedException();
        }
    }

}
