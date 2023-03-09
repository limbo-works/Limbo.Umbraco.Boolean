using System.Collections.Generic;
using Umbraco.Cms.Core.Manifest;

namespace Limbo.Umbraco.Boolean {

    /// <inheritdoc />
    public class BooleanManifestFilter : IManifestFilter {

        /// <inheritdoc />
        public void Filter(List<PackageManifest> manifests) {
            manifests.Add(new PackageManifest {
                AllowPackageTelemetry = true,
                PackageName = BooleanPackage.Name,
                Version = BooleanPackage.InformationalVersion
            });
        }

    }

}