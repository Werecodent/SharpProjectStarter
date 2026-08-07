# Ultimate Project Starter

[![Build](https://github.com/Werecodent/UltimateProjectStarter/actions/workflows/integration.yml/badge.svg?branch=main)](https://github.com/Werecodent/UltimateProjectStarter/actions/workflows/integration.yml)
[![CodeCov Coverage](https://codecov.io/gh/Werecodent/UltimateProjectStarter/branch/main/graph/badge.svg)](https://codecov.io/gh/Werecodent/UltimateProjectStarter/branch/main)

(This project is under construction at the moment; be cautious of incomplete instructions.)

Everything you need to get a quick start for a C# project on GitHub! Useful as a template, a few find+replace actions and you're immediately ready to go, or just a useful reference. Contains:

1) All the special GitHub project files to make your project polished.
2) A variety of sample projects to fit whatever you want to do.
3) Build workflows with test coverage collection.
4) Clean project structure with all output directed to './artifacts'.
5) Even the start of a [documentation site](https://Werecodent.github.io/UltimateProjectStarter/) using GitHub pages.

## Instructions

Customize the project for your own use by following these steps:

1) Replace all instance of "Werecodent" with your organization's name (or empty).
2) Replace all instances of "UltimateProjectStarter" with your project's name.
3) Install "CodeCov" as a GitHub app to the project/organization and set it up, or remove all references.
4) Tweak existing code as needed and begin coding.

## Documentation

The documentation site is located here: https://Werecodent.github.io/UltimateProjectStarter/

The raw files can be viewed from the [docs](docs) folder or built into a local site using Jekyll.

## Contributing

If you're looking to contribute, thanks for your interest. Feel free to submit reports for any issues you can find, or request potential features you'd like to see [here](../../issues). If you wish to contribute code to the project, refer to the contributing guidelines [here](.github/CONTRIBUTING.md) which also include instructions for environment setup. Please follow the [code of conduct](.github/CODE_OF_CONDUCT.md) when contributing.

## License

This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at https://mozilla.org/MPL/2.0/.

View the [license](LICENSE) file for more details.

## Acknowledgments

* [CreateAndFake](https://github.com/CreateAndFake/CreateAndFake): For testing behavior.
* [xUnit](https://github.com/xunit/xunit) + [bUnit](https://bunit.dev): For running tests.
* [Coverlet](https://github.com/tonerdo/coverlet) + [ReportGenerator](https://danielpalme.github.io/ReportGenerator) + [CodeCov](https://codecov.io): For test coverage.
* [Bullseye](https://github.com/adamralph/bullseye) + [SimpleExec](https://github.com/adamralph/simple-exec) + [MinVer](https://github.com/adamralph/minver): For project building.
* [AsyncFixer](https://github.com/semihokur/AsyncFixer) + [MissingAwaitWarning](https://github.com/ykoksen/unused-task-warning) + [Meziantou.Analyzer](https://github.com/meziantou/Meziantou.Analyzer) + [Sonar](https://github.com/SonarSource/sonar-dotnet): For code analyzers.
* [CSharpier](https://github.com/belav/csharpier): For formatting code.
* [GitHub](https://github.com): For hosting code.
* [Microsoft](https://visualstudio.microsoft.com/vs/features/net-development): For C# and editors.

