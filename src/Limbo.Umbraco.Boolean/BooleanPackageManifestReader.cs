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
                        type = "bundle",
                        alias = "Limbo.Umbraco.Boolean.Bundle",
                        name = "Limbo Boolean",
                        js = "/App_Plugins/Limbo.Umbraco.Boolean/manifest.js"
                    }
                ]
            }
        ];

        return await Task.FromResult(manifests);

    }

}
