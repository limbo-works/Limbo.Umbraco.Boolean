using System;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PropertyEditors;

namespace Limbo.Umbraco.Boolean.Editors.Boolean;

/// <summary>
/// Value converter for the <see cref="BooleanEditor"/> property editor.
/// </summary>
public class BooleanValueConverter : PropertyValueConverterBase {

    /// <inheritdoc />
    public override bool IsConverter(IPublishedPropertyType propertyType) {
        return propertyType.EditorAlias == BooleanEditor.EditorAlias;
    }

    /// <inheritdoc />
    public override Type GetPropertyValueType(IPublishedPropertyType propertyType) {
        return typeof(bool);
    }

    /// <inheritdoc />
    public override PropertyCacheLevel GetPropertyCacheLevel(IPublishedPropertyType propertyType) {
        return PropertyCacheLevel.Element;
    }

    /// <inheritdoc />
    public override object ConvertSourceToIntermediate(IPublishedElement owner, IPublishedPropertyType propertyType, object? source, bool preview) {

        TrueFalseConfiguration? config = propertyType.DataType.Configuration as TrueFalseConfiguration;

        bool fallback = config?.Default ?? false;

        return source switch {
            string s => bool.TryParse(s, out bool result) ? result : fallback,
            int i => i == 1,
            long l => l == 1,
            bool b => b,
            _ => fallback
        };

    }

    /// <inheritdoc />
    public override object ConvertIntermediateToXPath(IPublishedElement owner, IPublishedPropertyType propertyType, PropertyCacheLevel referenceCacheLevel, object? inter, bool preview) {
        return inter is true ? "1" : "0";
    }

}