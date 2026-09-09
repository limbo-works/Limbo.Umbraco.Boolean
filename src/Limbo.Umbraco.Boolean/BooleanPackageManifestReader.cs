using System.Collections.Generic;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Manifest;
using Umbraco.Cms.Infrastructure.Manifest;

namespace Limbo.Umbraco.Boolean;

/// <summary>
/// Reads the package manifest for Limbo Boolean.
/// </summary>
public class BooleanPackageManifestReader : IPackageManifestReader {

    /// <inheritdoc />
    public async Task<IEnumerable<PackageManifest>> ReadPackageManifestsAsync() {

        List<PackageManifest> manifests = [
            new() {
                Id = BooleanPackage.Alias,
                Name = BooleanPackage.Name,
                AllowTelemetry = true,
                Version = BooleanPackage.InformationalVersion,
                Extensions = [
                    new {
                        type = "propertyEditorSchema",
                        alias = "Limbo.Umbraco.Boolean",
                        name = "Limbo Boolean",
                        meta = new {
                            defaultPropertyEditorUiAlias = "Umb.PropertyEditorUi.Toggle",
                            settings = new {
                                properties = new[] {
                                    new {
                                        alias = "default",
                                        label = "Initial state",
                                        description = "The initial state for properties without a saved value.",
                                        propertyEditorUiAlias = "Umb.PropertyEditorUi.Toggle"
                                    }
                                },
                                defaultData = new[] {
                                    new {
                                        alias = "default",
                                        value = false
                                    }
                                }
                            }
                        }
                    }
                ]
            }
        ];

        return await Task.FromResult(manifests);

    }

}
