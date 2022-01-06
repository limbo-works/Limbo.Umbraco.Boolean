using System;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PropertyEditors;


namespace Limbo.Umbraco.Boolean.Editors.Boolean {
    
    public class BooleanValueConverter : PropertyValueConverterBase {

        public override bool IsConverter(IPublishedPropertyType propertyType) {
            return propertyType.EditorAlias == BooleanEditor.EditorAlias;
        }

        public override Type GetPropertyValueType(IPublishedPropertyType propertyType) {
            return typeof(bool);
        }

        public override PropertyCacheLevel GetPropertyCacheLevel(IPublishedPropertyType propertyType) {
            return PropertyCacheLevel.Element;
        }

        public override object ConvertSourceToIntermediate(IPublishedElement owner, IPublishedPropertyType propertyType, object source, bool preview) {

            TrueFalseConfiguration config = propertyType.DataType.ConfigurationAs<TrueFalseConfiguration>();

            return source switch {
                string s => bool.TryParse(s, out bool result) ? result : config.Default,
                int i => i == 1,
                long l => l == 1,
                bool b => b,
                _ => config.Default
            };

        }

        public override object ConvertIntermediateToXPath(IPublishedElement owner, IPublishedPropertyType propertyType, PropertyCacheLevel referenceCacheLevel, object inter, bool preview) {
            return (bool) inter ? "1" : "0";
        }

    }

}