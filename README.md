# Limbo Boolean

[![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/limbo-works/Limbo.Umbraco.Boolean/blob/v17/codex/LICENSE.md)
[![NuGet](https://img.shields.io/nuget/vpre/Limbo.Umbraco.Boolean.svg)](https://www.nuget.org/packages/Limbo.Umbraco.Boolean/)
[![NuGet](https://img.shields.io/nuget/dt/Limbo.Umbraco.Boolean.svg)](https://www.nuget.org/packages/Limbo.Umbraco.Boolean)
[![Umbraco Marketplace](https://img.shields.io/badge/umbraco-marketplace-%233544B1)](https://marketplace.umbraco.com/package/limbo.umbraco.boolean)

This package adds a new boolean property editor to Umbraco. Using a toggle input, users will be able to set the value to either `true` or `false`.

<table>
  <tr>
    <td><strong>License:</strong></td>
    <td><a href="https://github.com/limbo-works/Limbo.Umbraco.Boolean/blob/v17/codex/LICENSE.md"><strong>MIT License</strong></a></td>
  </tr>
  <tr>
    <td><strong>Umbraco:</strong></td>
    <td>
      Umbraco 17
    </td>
  </tr>
  <tr>
    <td><strong>Target Framework:</strong></td>
    <td>
      .NET 10
    </td>
  </tr>
</table>











<br /><br />

### But why?
Umbraco already has a built-in property for a boolean type, so why add another one?

The build-in property editor has a **Initial state** option (alias is `default`) for the data type, but it doesn't apply retroactively to content that doesn't already have a saved value, although one could expect this behavior.

Ideally something like this should be added back to into the Umbraco source code (there is even [an issue for it](https://github.com/umbraco/Umbraco-CMS/issues/10160)), but for now, this package adds a new property editor that has the expected behavior for the default value / initial state.




<br /><br />

## Installation

### Umbraco 17

The Umbraco 17 version of this package is only available via [**NuGet**](https://www.nuget.org/packages/Limbo.Umbraco.Boolean). To install the package, you can use either .NET CLI:

```
dotnet add package Limbo.Umbraco.Boolean --version 17.0.0-alpha001
```

or the older NuGet Package Manager:

```
Install-Package Limbo.Umbraco.Boolean -Version 17.0.0-alpha001
```

### Other versions of Umbraco

- [**`v13/main`**](https://github.com/limbo-works/Limbo.Umbraco.Boolean/tree/v13/main) Umbraco 13
- ~~[**`v10/main`**](https://github.com/limbo-works/Limbo.Umbraco.Boolean/tree/v10/main) Umbraco 10, 11 and 12~~ <sub title="Umbraco 10, 11 and 12 have reached end-of-life"><sup>(EOL)</sup></sub>
- ~~[**`v12/main`**](https://github.com/limbo-works/Limbo.Umbraco.Boolean/tree/v2/main) Umbraco 9~~ <sub title="Umbraco 9 has reached end-of-life"><sup>(EOL)</sup></sub>
- ~~[**`v11/main`**](https://github.com/limbo-works/Limbo.Umbraco.Boolean/tree/v1/main) Umbraco 8~~ <sub title="Umbraco 8 has reached end-of-life"><sup>(EOL)</sup></sub>




<br /><br />

### Usage

The package works similar to the build-in [**Toggle**](https://our.umbraco.com/Documentation/Fundamentals/Backoffice/Property-Editors/Built-in-Property-Editors/True-False/index-v8) property editor, but with the addition that the default value / initial state works retroatively for properties that doesn't already have a value (eg. when adding a new property to an existing content type). The property editor will not change the value of properties that already have a value.
