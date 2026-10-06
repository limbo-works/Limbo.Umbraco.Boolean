using System.Collections.Generic;
using System.Threading.Tasks;
using Limbo.Umbraco.Boolean.PropertyEditors;
using Skybrud.Essentials.Umbraco.Constants;
using Skybrud.Essentials.Umbraco.Manifests.Extensions.PropertyEditors;
using Umbraco.Cms.Core.Manifest;
using Umbraco.Cms.Infrastructure.Manifest;

namespace Limbo.Umbraco.Boolean;

/// <summary>
/// Reads the package manifest for Limbo Boolean.
/// </summary>
public class BooleanPackageManifestReader : IPackageManifestReader {

    public const string Alias = BooleanPackage.Alias;

    public const string Name = BooleanPackage.Name;

    /// <inheritdoc />
    public async Task<IEnumerable<PackageManifest>> ReadPackageManifestsAsync() {

        List<PackageManifest> manifests = [
            new() {
                Id = BooleanPackage.Alias,
                Name = BooleanPackage.Name,
                AllowTelemetry = true,
                Version = BooleanPackage.InformationalVersion,
                Extensions = [
                    new PropertyEditorSchemaExtension {
                        Alias = BooleanPropertyEditor.EditorAlias,
                        Name = $"{Name}: Boolean Property Editor Schema",
                        Meta = new PropertyEditorSchemaMeta {
                            DefaultPropertyEditorUiAlias = BooleanPropertyEditor.EditorUiAlias,
                            Settings = new PropertyEditorSettings {
                                Properties = [
                                    new PropertyEditorSettingsProperty() {
                                        Alias = "default",
                                        Label = "Initial state",
                                        Description = "The initial state for properties without a saved value.",
                                        PropertyEditorUiAlias = UmbracoPropertyEditorUiAliases.Toggle
                                    }
                                ],
                                DefaultData = [
                                    new PropertyEditorSettingsDefaultData {
                                        Alias = "default",
                                        Value = false
                                    }
                                ]
                            }
                        }
                    },
                    new PropertyEditorUiExtension {
                        Alias = BooleanPropertyEditor.EditorUiAlias,
                        Name = $"{Name}: Boolean Property Editor UI",
                        Element = "/App_Plugins/Limbo.Umbraco.Boolean/boolean-property-editor-ui.js",
                        Meta = new PropertyEditorUiMeta {
                            Label = BooleanPropertyEditor.EditorName,
                            Icon = BooleanPropertyEditor.EditorIcon,
                            Group = BooleanPropertyEditor.EditorGroup,
                            PropertyEditorSchemaAlias = BooleanPropertyEditor.EditorAlias,
                            SupportsReadOnly = true,
                            Settings = new PropertyEditorSettings {
                                Properties = [
                                    new PropertyEditorSettingsProperty {
                                        Alias = "showLabels",
                                        Label = "Show on/off labels",
                                        PropertyEditorUiAlias = UmbracoPropertyEditorUiAliases.Toggle,
                                        Config = [
                                            new PropertyEditorConfigProperty {
                                                Alias = "ariaLabel",
                                                Value = "Toggle for whether if label should be displayed"
                                            }
                                        ]
                                    },
                                    new PropertyEditorSettingsProperty {
                                        Alias = "labelOn",
                                        Label = "Label On",
                                        Description = "Displays text when enabled.",
                                        PropertyEditorUiAlias = UmbracoPropertyEditorUiAliases.TextBox
                                    },
                                    new PropertyEditorSettingsProperty {
                                        Alias = "labelOff",
                                        Label = "Label Off",
                                        Description = "Displays text when disabled.",
                                        PropertyEditorUiAlias = UmbracoPropertyEditorUiAliases.TextBox
                                    },
                                    new PropertyEditorSettingsProperty {
                                        Alias = "ariaLabel",
                                        Label = "Screen Reader Label",
                                        PropertyEditorUiAlias = UmbracoPropertyEditorUiAliases.TextBox
                                    }
                                ]
                            }
                        }
                    }
                ]
            }
        ];

        return await Task.FromResult(manifests);

    }

}