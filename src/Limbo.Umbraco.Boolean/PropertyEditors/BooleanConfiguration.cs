using Umbraco.Cms.Core.PropertyEditors;

namespace Limbo.Umbraco.Boolean.PropertyEditors;

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