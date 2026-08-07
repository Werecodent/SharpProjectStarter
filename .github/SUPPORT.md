# Support

If you encounter any issue using the project, please create an issue for the project. Make sure to refer to and follow the [code of conduct](CODE_OF_CONDUCT.md).

# Environment Setup

Ensure you understand the [contributing](CONTRIBUTING.md) requirements, then follow the instructions below relevant to your environment.

## Mac Environment Recommended Setup

1) Install Command Line Developer Tools via the Terminal:
    A) Check if installed: ‘xcode-select -p’
    B) If not, run: ‘code-select —install’
    C) Verify git works: ‘git —version’
2) Install [VS Code](https://code.visualstudio.com/docs/setup/mac) for development.
3) Install [Google Chrome](https://www.google.com/chrome) for debugging.
4) Clone the repository in the editor, then:
    A) Install all recommended extensions for the project.
    B) Follow all prompts for signing in/downloads.
    C) To see build options, run from terminal: "./build/run.sh --help"
    D) Verify project state by running from terminal: "./build/run.sh test"

## Linux Environment Recommended Setup

1) Install packages for:
    A) [.NET frameworks](https://dotnet.microsoft.com/download)
    B) [Mono](https://www.mono-project.com/download/stable/#download-lin)
    C) [VS Code](https://code.visualstudio.com/docs/setup/linux)
2) Install [Google Chrome](https://www.google.com/chrome) for debugging.
3) Clone the repository in the editor, then:
    A) Install all recommended extensions for the project.
    B) Run from terminal: "chmod +x ./build/run.sh"
    C) To see build options, run from terminal: "./build/run.sh --help"
    D) Verify project state by running from terminal: "./build/run.sh test"

## Windows Environment Optional Setup

VS Code is still recommended (see above setups), but VS Community may be utilized instead:

1) Install [VS Community](https://visualstudio.microsoft.com/vs/community) for development.
2) Clone the repository locally.
3) To see build options, run from cmd prompt: "./build/run.cmd --help"
4) Verify project state by running from cmd prompt: "./build/run.cmd test"

## Git & GPG Quick Setup Example

Set the following git configuration settings, replacing [xxx] with valid personal values:

1) git config --global user.name "[xxx]"
2) git config --global user.email "[xxx]@users.noreply.github.com"
3) git config --global user.signingKey [xxx]
4) git config --global tag.gpgSign true
5) git config --global commit.gpgSign true
6) git config --global push.gpgSign "if-asked"

Read more about GPG keys and why they must be set in the [contributing](CONTRIBUTING.md) requirements.
