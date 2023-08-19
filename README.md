# Limbo Boolean

[![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE.md) [![NuGet](https://img.shields.io/nuget/vpre/Limbo.Umbraco.Boolean.svg)](https://www.nuget.org/packages/Limbo.Umbraco.Boolean/4.0.0-alpha002) [![NuGet](https://img.shields.io/nuget/dt/Limbo.Umbraco.Boolean.svg)](https://www.nuget.org/packages/Limbo.Umbraco.Boolean) [![Our Umbraco](https://img.shields.io/badge/our-umbraco-%233544B1)](https://our.umbraco.com/packages/backoffice-extensions/limbo-boolean/) [![Umbraco Marketplace](https://img.shields.io/badge/umbraco-marketplace-%233544B1)](https://marketplace.umbraco.com/package/limbo.umbraco.boolean)

This package adds a new boolean property editor to Umbraco. Using a toggle input, users will be able to set the value to either `true` or `false`.

<br /><br />

### But why?
Umbraco already has a built-in property for a boolean type, so why add another one?

The build-in property editor has a **Initial state** option (alias is `default`) for the data type, but it doesn't apply retroactively to content that doesn't already have a saved value, although one could expect this behavior.

Ideally something like this should be added back to into the Umbraco source code (there is even [an issue for it](https://github.com/umbraco/Umbraco-CMS/issues/10160)), but for now, this package adds a new property editor that has the expected behavior for the default value / initial state.

<br /><br />

### Installation

The Umbraco 10 version of this package is only available via [**NuGet**](https://www.nuget.org/packages/Limbo.Umbraco.Boolean/3.0.4). To install the package, you can use either .NET CLI:

```
dotnet add package Limbo.Umbraco.Boolean --version 3.0.4
```

or the older NuGet Package Manager:

```
Install-Package Limbo.Umbraco.Boolean -Version 3.0.4
```

**Umbraco 9**  
For the Umbraco 9 version of this package, see the [**v2/main**](https://github.com/limbo-works/Limbo.Umbraco.Boolean/tree/v2/main) branch instead.

**Umbraco 8**  
For the Umbraco 8 version of this package, see the [**v1/main**](https://github.com/limbo-works/Limbo.Umbraco.Boolean/tree/v1/main) branch instead.

### Usage

The package works similar to the build-in [**Toggle**](https://our.umbraco.com/Documentation/Fundamentals/Backoffice/Property-Editors/Built-in-Property-Editors/True-False/index-v8) property editor, but with the addition that the default value / initial state works retroatively for properties that doesn't already have a value (eg. when adding a new property to an existing content type). The property editor will not change the value of properties that already have a value.
