using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.PropertyEditors;
using Umbraco.Cms.Core.Services;

namespace Limbo.Umbraco.Boolean.Editors.Boolean;

/// <summary>
/// Represents a checkbox property and parameter editor.
/// </summary>
[DataEditor(
    EditorAlias,
    EditorType.PropertyValue | EditorType.MacroParameter,
    "Limbo Boolean (legacy)",
    "boolean",
    ValueType = ValueTypes.Integer,
    Group = "Limbo",
    Icon = "icon-checkbox color-limbo",
    IsDeprecated = true)]
public class LegacyBooleanEditor : DataEditor {

    private readonly IIOHelper _ioHelper;
    private readonly IEditorConfigurationParser _editorConfigurationParser;

    /// <summary>
    /// Gets the alias of the editor.
    /// </summary>
    public const string EditorAlias = "Limbo.Boolean";

    /// <summary>
    /// Initializes a new instance of the <see cref="LegacyBooleanEditor"/> class.
    /// </summary>
    public LegacyBooleanEditor(IDataValueEditorFactory dataValueEditorFactory, IIOHelper ioHelper, IEditorConfigurationParser editorConfigurationParser) : base(dataValueEditorFactory) {
        _ioHelper = ioHelper;
        _editorConfigurationParser = editorConfigurationParser;
    }

    /// <inheritdoc />
    protected override IConfigurationEditor CreateConfigurationEditor() => new TrueFalseConfigurationEditor(_ioHelper, _editorConfigurationParser);

}