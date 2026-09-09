using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.PropertyEditors;

namespace Limbo.Umbraco.Boolean.Editors.Boolean;

/// <summary>
/// Configuration for the boolean property editor.
/// </summary>
public class BooleanConfiguration {

    /// <summary>
    /// Gets or sets the initial value for properties without a saved value.
    /// </summary>
    [ConfigurationField("default")]
    public bool Default { get; set; }

}

/// <summary>
/// Configuration editor for <see cref="BooleanConfiguration"/>.
/// </summary>
public class BooleanConfigurationEditor : ConfigurationEditor<BooleanConfiguration> {

    /// <summary>
    /// Initializes a new instance of the <see cref="BooleanConfigurationEditor"/> class.
    /// </summary>
    public BooleanConfigurationEditor(IIOHelper ioHelper) : base(ioHelper) { }

}
