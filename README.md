# Limbo Boolean

This package adds a new boolean property editor to Umbraco 8. Using a toggl input, users will be able to set the value to either `true` or `false`.

### But why?
Umbraco already has a built-in property for a boolean type, so why add another one?

The build-in property editor has a **Initial state** option (alias is `default`) for the data type, but it doesn't apply retroactively to content that doesn't already have a saved value, although one could expect this behavior.

Ideally something like this should be added back to into the Umbraco source code (there is even [an issue for it](https://github.com/umbraco/Umbraco-CMS/issues/10160)), but for now, this package adds a new property editor that has the expected behavior for the default value / initial state.

## Installation

Currently only available for Umbraco 8, the package can be installed using one of the methods below:

### Install via NuGet
This is the recommend approach, as you install the [**NuGet Package**](https://www.nuget.org/packages/Limbo.Umbraco.Boolean/1.0.1) in your Visual Studio project, and NuGet takes care of the rest.

**Umbraco 8**  
Latest release for Umbraco 8 is [**v1.0.1**](https://www.nuget.org/packages/Limbo.Umbraco.Boolean/1.0.1):

```
Install-Package Limbo.Umbraco.Boolean -Version 1.0.1
```

### Usage

The package works similar to the build-in [**Toggle**](https://our.umbraco.com/Documentation/Fundamentals/Backoffice/Property-Editors/Built-in-Property-Editors/True-False/index-v8) property editor, but with the addition that the default value / initial state works retroatively for properties that doesn't already have a value (eg. when adding a new property to an existing content type). The property editor will not change the value of properties that already have a value.
