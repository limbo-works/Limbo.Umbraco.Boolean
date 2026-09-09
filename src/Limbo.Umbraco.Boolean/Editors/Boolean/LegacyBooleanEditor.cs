using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.PropertyEditors;

namespace Limbo.Umbraco.Boolean.Editors.Boolean;

/// <summary>
/// Represents the deprecated legacy checkbox property editor.
/// </summary>
[DataEditor(EditorAlias, ValueType = ValueTypes.Integer, IsDeprecated = true)]
public class LegacyBooleanEditor : DataEditor {

    private readonly IIOHelper _ioHelper;

    /// <summary>
    /// Gets the alias of the editor.
    /// </summary>
    public const string EditorAlias = "Limbo.Boolean";

    /// <summary>
    /// Initializes a new instance of the <see cref="LegacyBooleanEditor"/> class.
    /// </summary>
    public LegacyBooleanEditor(IDataValueEditorFactory dataValueEditorFactory, IIOHelper ioHelper) : base(dataValueEditorFactory) {
        _ioHelper = ioHelper;
    }

    /// <inheritdoc />
    protected override IConfigurationEditor CreateConfigurationEditor() => new BooleanConfigurationEditor(_ioHelper);

}
