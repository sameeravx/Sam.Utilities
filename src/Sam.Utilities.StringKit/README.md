# Sam.Utilities.StringKit

A modern C# string utility library with extension methods for validation, formatting, and cleaning.

## Installation

```bash
dotnet add package Sam.Utilities.StringKit
```

## Usage

```csharp
using Sam.Utilities.StringKit.Extensions;

string name = "hello world";

bool isLettersOnly = name.IsLettersOnly();
string title = name.ToTitleCase();
string cleaned = "  hello    world  ".NormalizeSpaces();
```

## Features

### Validation

- `IsLettersOnly()`
- `IsNumericOnly()`
- `IsAlphaNumeric()`

### Formatting

- `ToTitleCase()`

### Cleaning

- `RemoveWhiteSpaces()`
- `NormalizeSpaces()`

## License

MIT