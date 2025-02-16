﻿<!-- markdownlint-disable MD033 MD041 -->
<div align="center">

<img src="fire-icon.png" alt="Bunsen Burner" width="150px"/>

# Bunsen Burner

[:running: **_Getting Started_**](https://bmazzarol.github.io/Bunsen-Burner/articles/getting-started.html)
[:books: **_Documentation_**](https://bmazzarol.github.io/Bunsen-Burner)

[![Nuget](https://img.shields.io/nuget/v/BunsenBurner)](https://www.nuget.org/packages/BunsenBurner/)
[![Coverage](https://sonarcloud.io/api/project_badges/measure?project=bmazzarol_Bunsen-Burner&metric=coverage)](https://sonarcloud.io/summary/new_code?id=bmazzarol_Bunsen-Burner)
[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=bmazzarol_Bunsen-Burner&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=bmazzarol_Bunsen-Burner)
[![CD Build](https://github.com/bmazzarol/Bunsen-Burner/actions/workflows/cd-build.yml/badge.svg)](https://github.com/bmazzarol/Bunsen-Burner/actions/workflows/cd-build.yml)
[![Check Markdown](https://github.com/bmazzarol/Bunsen-Burner/actions/workflows/check-markdown.yml/badge.svg)](https://github.com/bmazzarol/Bunsen-Burner/actions/workflows/check-markdown.yml)
[![CodeQL](https://github.com/bmazzarol/Bunsen-Burner/actions/workflows/codeql.yml/badge.svg)](https://github.com/bmazzarol/Bunsen-Burner/actions/workflows/codeql.yml)

Set :fire: to your old unit tests!
A better way to write tests :test_tube: in C#.

</div>

## Features

* Test framework agnostic
* Zero dependencies
* Easy to use and extend
* More maintainable
* Integrations to your favourite test libraries
* Unit, Integration, Property any sort of test!

```c#
// Arrange act assert style

using static BunsenBurner.Aaa;

namespace SomeNamespace;

public static class Tests
{
    [Fact(DisplayName = "Example AAA test!!!")]
    public static async Task SomeTest() =>
        await Arrange(() => new SUT(...))
             .Act(async sut => await sut.SomeMethod(...))
             .Assert(result => Assert.Equal("should be this", result));
}

// Given when then style

using static BunsenBurner.Bdd;

namespace SomeNamespace;

public static class Tests
{
    [Fact(DisplayName = "Example BDD test!!!")]
    public static async Task SomeTest() =>
        await Given(() => new SUT(...))
             .When(async sut => await sut.SomeMethod(...))
             .Then(result => Assert.Equal("should be this", result));
}
```

## Getting Started

To use this library, simply include `BunsenBurner.dll` in your project or grab
it from [NuGet](https://www.nuget.org/packages/BunsenBurner/), and add this to
the top of each test `.cs` file
that needs it:

```C#
using static BunsenBurner.Aaa; // For Arrange act assert
```

or

```C#
using static BunsenBurner.Bdd; // For Given when then
```

Click through to the links bellow for further details.
<!-- markdownlint-disable MD013 -->

| Library                                                             | Description                                                                                                          | Nu-Get                                                                                                                                        |
|---------------------------------------------------------------------|----------------------------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------|
| [Core](./BunsenBurner/README.md)                                    | Core test abstraction that makes it all possible. This is all that is required to get started!                       | [![Nuget](https://img.shields.io/nuget/v/BunsenBurner)](https://www.nuget.org/packages/BunsenBurner/)                                         |
| [Logging](./BunsenBurner.Logging/README.md)                         | Core logging abstractions. Used to assert against logged messages, useful for cases like testing background services | [![Nuget](https://img.shields.io/nuget/v/BunsenBurner.Logging)](https://www.nuget.org/packages/BunsenBurner.Logging/)                         |
| [Xunit](./BunsenBurner.Xunit/README.md)                             | Integration with [xUnit.net](https://github.com/xunit/xunit) to easily consume Bunsen Burner                         | [![Nuget](https://img.shields.io/nuget/v/BunsenBurner.Xunit)](https://www.nuget.org/packages/BunsenBurner.Xunit/)                             |
| [NUnit](./BunsenBurner.NUnit/README.md)                             | Integration with [NUnit](https://github.com/nunit/nunit) to easily consume Bunsen Burner                             | [![Nuget](https://img.shields.io/nuget/v/BunsenBurner.NUnit)](https://www.nuget.org/packages/BunsenBurner.NUnit/)                             |
| [AutoFixture](./BunsenBurner.AutoFixture/README.md)                 | Integration with [AutoFixture](https://github.com/AutoFixture) to simplify arrange steps                             | [![Nuget](https://img.shields.io/nuget/v/BunsenBurner.AutoFixture)](https://www.nuget.org/packages/BunsenBurner.AutoFixture/)                 |
| [Bogus](./BunsenBurner.Bogus/README.md)                             | Integration with [Bogus](https://github.com/bchavez/Bogus) to simplify arrange steps                                 | [![Nuget](https://img.shields.io/nuget/v/BunsenBurner.Bogus)](https://www.nuget.org/packages/BunsenBurner.Bogus/)                             |
| [DependencyInjection](./BunsenBurner.DependencyInjection/README.md) | Provides tests for validating Dependency Injection containers                                                        | [![Nuget](https://img.shields.io/nuget/v/BunsenBurner.DependencyInjection)](https://www.nuget.org/packages/BunsenBurner.DependencyInjection/) |
| [Hedgehog](./BunsenBurner.Hedgehog/README.md)                       | Integration with [Hedgehog](https://github.com/hedgehogqa/fsharp-hedgehog) to write property based tests             | [![Nuget](https://img.shields.io/nuget/v/BunsenBurner.Hedgehog)](https://www.nuget.org/packages/BunsenBurner.Hedgehog/)                       |
| [BenchmarkDotNet](./BunsenBurner.BenchmarkDotNet/README.md)         | Integration with [BenchmarkDotNet](https://github.com/dotnet/BenchmarkDotNet) to write performance tests             | [![Nuget](https://img.shields.io/nuget/v/BunsenBurner.BenchmarkDotNet)](https://www.nuget.org/packages/BunsenBurner.BenchmarkDotNet/)         |
| [Verify.Xunit](./BunsenBurner.Verify.Xunit/README.md)               | Integration with [Verify.Xunit](https://github.com/VerifyTests/Verify) to simplify assert steps                      | [![Nuget](https://img.shields.io/nuget/v/BunsenBurner.Verify.Xunit)](https://www.nuget.org/packages/BunsenBurner.Verify.Xunit/)               |
| [Verify.NUnit](./BunsenBurner.Verify.NUnit/README.md)               | Integration with [Verify.NUnit](https://github.com/VerifyTests/Verify) to simplify assert steps                      | [![Nuget](https://img.shields.io/nuget/v/BunsenBurner.Verify.NUnit)](https://www.nuget.org/packages/BunsenBurner.Verify.NUnit/)               |
| [Http](./BunsenBurner.Http/README.md)                               | Extension methods for testing Http servers                                                                           | [![Nuget](https://img.shields.io/nuget/v/BunsenBurner.Http)](https://www.nuget.org/packages/BunsenBurner.Http/)                               |
| [FunctionApp](./BunsenBurner.FunctionApp/README.md)                 | Extension methods for testing Function apps                                                                          | [![Nuget](https://img.shields.io/nuget/v/BunsenBurner.FunctionApp)](https://www.nuget.org/packages/BunsenBurner.FunctionApp/)                 |
| [Background](./BunsenBurner.Background/README.md)                   | Extension methods for testing Background services                                                                    | [![Nuget](https://img.shields.io/nuget/v/BunsenBurner.Background)](https://www.nuget.org/packages/BunsenBurner.Background/)                   |

<!-- markdownlint-enable MD013 -->

## Why?

Most tests in the C# are written in an arrange, act, assert style, like so,

```c#
using Xunit;

namespace SomeNamespace;

public static class Tests
{
    [Fact]
    public static async Task SomeTest()
    {
        // Arrange
        var sut = new SUT(...);
        
        // Act
        var result = await sut.SomeMethod(...);
        
        // Assert
        Assert.Equal("should be this", result);
    }
}
```

This library aims to formalize this structure in the following ways,

* Enforces that all tests must be arranged before acting and acted upon before
  assertions can occur
* Converts tests to data, which can be composed and built up then executed
  * Works well wth theories
* Because tests are just data, functions can be used to extend them and compose
  them together
  * Works will with extension methods and other test libraries, use cases

```c#
// can use implicit usings
using Xunit;
using static BunsenBurner.Aaa;

namespace SomeNamespace;

public static class Tests
{
    [Fact(DisplayName = "Example AAA test!!!")]
    public static async Task SomeTest() =>
              // arrange starts a new test, 
              // whatever type it returns can be used when acting 
        await Arrange(() => new SUT(...))
              // act on the arranged data, async is supported in all test steps
             .Act(async sut => await sut.SomeMethod(...))
              // assert against the result of acting
             .Assert(result => Assert.Equal("should be this", result));
}
```

For more details/information have a look the test projects or create an issue.

## Attributions

[Fire icons created by juicy_fish](https://www.flaticon.com/free-icons/fire)
