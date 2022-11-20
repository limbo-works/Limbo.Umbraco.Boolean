[![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE.md) [![NuGet](https://img.shields.io/nuget/vpre/Limbo.Umbraco.Boolean.svg)](https://www.nuget.org/packages/Limbo.Umbraco.Boolean/4.0.0-alpha002) [![NuGet](https://img.shields.io/nuget/dt/Limbo.Umbraco.Boolean.svg)](https://www.nuget.org/packages/Limbo.Umbraco.Boolean) [![Our Umbraco](https://img.shields.io/badge/our-umbraco-%233544B1)](https://our.umbraco.com/packages/backoffice-extensions/limbo-boolean/)

This package adds a new boolean property editor to Umbraco. Using a toggle input, users will be able to set the value to either `true` or `false`.

### But why?
Umbraco already has a built-in property for a boolean type, so why add another one?

The build-in property editor has a **Initial state** option (alias is `default`) for the data type, but it doesn't apply retroactively to content that doesn't already have a saved value, although one could expect this behavior.

Ideally something like this should be added back to into the Umbraco source code (there is even [an issue for it](https://github.com/umbraco/Umbraco-CMS/issues/10160)), but for now, this package adds a new property editor that has the expected behavior for the default value / initial state.