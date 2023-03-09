using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;

#pragma warning disable CS1591

namespace Limbo.Umbraco.Boolean {

    public class BooleanComposer : IComposer {

        public void Compose(IUmbracoBuilder builder) {

            builder.ManifestFilters().Append<BooleanManifestFilter>();

        }

    }

}