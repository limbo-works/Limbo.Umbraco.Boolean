using System.Collections.Generic;
using Umbraco.Cms.Core.Manifest;

namespace Limbo.Umbraco.Boolean;

/// <inheritdoc />
public class BooleanManifestFilter : IManifestFilter {

    /// <inheritdoc />
    public void Filter(List<PackageManifest> manifests) {

        // Initialize a new manifest filter for this package
        PackageManifest manifest = new() {
            AllowPackageTelemetry = true,
            PackageId = BooleanPackage.Alias,
            PackageName = BooleanPackage.Name,
            Version = BooleanPackage.InformationalVersion
        };

        // Append the manifest
        manifests.Add(manifest);

    }

}