# C# Practice

[![C#](https://img.shields.io/badge/C%23-512BD4?logo=dotnet&logoColor=white)](https://learn.microsoft.com/dotnet/csharp/)
[![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91?logo=visualstudio&logoColor=white)](https://visualstudio.microsoft.com)

A collection of small C# console applications written while learning the fundamentals of the language. Each folder is a separate project, and the solution file `ConsoleApp1.slnx` groups them in Visual Studio.

## Projects

| Project | Source file | Concepts practised |
|---|---|---|
| `ConsoleApp1` | `session.cs` | Classes, fields, and static members |
| `ConsoleApp2` | `operators.cs` | Arithmetic and comparison operators, type casting |
| `ConsoleApp3` | `variables.cs` | Variables, reading user input, type conversion |
| `ConsoleApp4` | `Control-flow.cs` | Conditional statements using user-entered marks |
| `ConsoleApp5` | `loops.cs` | Loops, including a prime-number example |
| `ConsoleApp6` | `Program.cs` | Inheritance and constructor chaining (`C` → `A` → `B`) |
| `6.Function(methods)` | `Program.cs` | Defining and calling methods with parameters and return values |

## Getting started

### Prerequisites

- [Visual Studio](https://visualstudio.microsoft.com) with the **.NET desktop development** workload, or the [.NET SDK](https://dotnet.microsoft.com/download)
- The projects target a mix of **.NET Framework 4.7.2** and **.NET 10**, so you may need both targets installed

### Run a project

In Visual Studio, open `ConsoleApp1.slnx`, set the project you want as the startup project, and press `F5`.

From the command line, projects that target .NET 10 can be run with:

```bash
dotnet run --project ConsoleApp3
```

The .NET Framework 4.7.2 projects need Visual Studio or MSBuild on Windows.

## Repository notes

- Build output (`bin/` and `obj/`) is excluded through `.gitignore`, so a fresh clone contains only source code and project files.

## Author

**Mohammad Hussain Sindhi**: [GitHub](https://github.com/Hussain-sindhi) · [LinkedIn](https://www.linkedin.com/in/mohammad-hussain-sindhi-007b4b255/)
