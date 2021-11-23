using Umbraco.Core.Logging;
using Umbraco.Core.PropertyEditors;
using Umbraco.Web.PropertyEditors;

namespace Limbo.Umbraco.Boolean.Editors.Boolean {
    
    /// <summary>
    /// Represents a checkbox property and parameter editor.
    /// </summary>
    [DataEditor(
        EditorAlias,
        EditorType.PropertyValue | EditorType.MacroParameter,
        "Limbo Boolean",
        "boolean",
        ValueType = ValueTypes.Integer,
        Group = "Limbo",
        Icon = "icon-checkbox color-limbo")]
    public class BooleanEditor : DataEditor {

        /// <summary>
        /// Gets the alias of the editor.
        /// </summary>
        public const string EditorAlias = "Limbo.Boolean";

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanEditor"/> class.
        /// </summary>
        public BooleanEditor(ILogger logger) : base(logger) { }

        /// <inheritdoc />
        protected override IConfigurationEditor CreateConfigurationEditor() => new TrueFalseConfigurationEditor();

    }

}