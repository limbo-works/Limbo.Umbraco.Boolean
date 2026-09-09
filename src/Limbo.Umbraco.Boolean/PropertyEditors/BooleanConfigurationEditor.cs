using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.PropertyEditors;

namespace Limbo.Umbraco.Boolean.PropertyEditors;

/// <summary>
/// Configuration editor for <see cref="BooleanConfiguration"/>.
/// </summary>
public class BooleanConfigurationEditor : ConfigurationEditor<BooleanConfiguration> {

    /// <summary>
    /// Initializes a new instance of the <see cref="BooleanConfigurationEditor"/> class.
    /// </summary>
    public BooleanConfigurationEditor(IIOHelper ioHelper) : base(ioHelper) { }

}