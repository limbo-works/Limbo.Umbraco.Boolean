using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.PropertyEditors;

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

        private readonly IIOHelper _ioHelper;

        /// <summary>
        /// Gets the alias of the editor.
        /// </summary>
        public const string EditorAlias = "Limbo.Boolean";

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanEditor"/> class.
        /// </summary>
        public BooleanEditor(IDataValueEditorFactory dataValueEditorFactory, IIOHelper ioHelper) : base(dataValueEditorFactory) {
            _ioHelper = ioHelper;
        }

        /// <inheritdoc />
        protected override IConfigurationEditor CreateConfigurationEditor() => new TrueFalseConfigurationEditor(_ioHelper);

    }

}