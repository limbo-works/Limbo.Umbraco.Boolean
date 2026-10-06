using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.PropertyEditors;

namespace Limbo.Umbraco.Boolean.PropertyEditors;

/// <summary>
/// Represents a checkbox property editor.
/// </summary>
[DataEditor(EditorAlias, ValueType = EditorValueType)]
public class BooleanPropertyEditor : DataEditor {

    private readonly IIOHelper _ioHelper;

    /// <summary>
    /// Gets the alias of the property editor.
    /// </summary>
    public const string EditorAlias = "Limbo.Umbraco.Boolean";

    /// <summary>
    /// Gets the alias of the property editor UI.
    /// </summary>
    public const string EditorUiAlias = "Limbo.Umbraco.Boolean.PropertyEditorUi";

    /// <summary>
    /// Gets the name of the property editor.
    /// </summary>
    public const string EditorName = "Limbo Boolean";

    /// <summary>
    /// Gets the name of the property editor.
    /// </summary>
    public const string EditorIcon = "icon-checkbox";

    /// <summary>
    /// Gets the name of the property editor.
    /// </summary>
    public const string EditorGroup = "Limbo";

    /// <summary>
    /// Gets the value type of the property editor.
    /// </summary>
    public const string EditorValueType = ValueTypes.Integer;

    /// <summary>
    /// Initializes a new instance of the <see cref="BooleanPropertyEditor"/> class.
    /// </summary>
    public BooleanPropertyEditor(IDataValueEditorFactory dataValueEditorFactory, IIOHelper ioHelper) : base(dataValueEditorFactory) {
        _ioHelper = ioHelper;
    }

    /// <inheritdoc />
    protected override IConfigurationEditor CreateConfigurationEditor() => new BooleanConfigurationEditor(_ioHelper);

}