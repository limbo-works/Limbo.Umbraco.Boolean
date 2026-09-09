using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.PropertyEditors;

namespace Limbo.Umbraco.Boolean.Editors.Boolean;

/// <summary>
/// Represents a checkbox property editor.
/// </summary>
[DataEditor(EditorAlias, ValueType = ValueTypes.Integer)]
public class BooleanEditor : DataEditor {

    private readonly IIOHelper _ioHelper;

    /// <summary>
    /// Gets the alias of the editor.
    /// </summary>
    public const string EditorAlias = "Limbo.Umbraco.Boolean";

    /// <summary>
    /// Initializes a new instance of the <see cref="BooleanEditor"/> class.
    /// </summary>
    public BooleanEditor(IDataValueEditorFactory dataValueEditorFactory, IIOHelper ioHelper) : base(dataValueEditorFactory) {
        _ioHelper = ioHelper;
    }

    /// <inheritdoc />
    protected override IConfigurationEditor CreateConfigurationEditor() => new BooleanConfigurationEditor(_ioHelper);

}
