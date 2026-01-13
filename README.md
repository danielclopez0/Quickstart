# Reqnroll Quickstart

A simple .NET 8 price calculator app with Gherkin/BDD tests using Reqnroll.

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

## Quick Start

```bash
# Install dependencies
dotnet restore

# Build the solution
dotnet build

# Run the app
dotnet run --project ReqnrollQuickstart.App

# Run tests
dotnet test
```

## Project Structure

```
ReqnrollQuickstart.sln
├── ReqnrollQuickstart.App/          # The application
│   ├── PriceCalculator.cs           # Price calculation logic
│   └── Program.cs                   # Console entry point
└── ReqnrollQuickstart.Specs/        # BDD tests
    ├── Features/
    │   └── PriceCalculation.feature # Gherkin scenarios
    └── StepDefinitions/
        └── PriceCalculationStepDefinitions.cs
```

## Example Output

```
Shopping Basket:
  1x Electric guitar
  10x Guitar pick

Total: $195.0
```
