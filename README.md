# DocumentFactory

DocumentFactory is a .NET Framework solution that generates documents through an abstract factory. A script-driven console director creates Markdown or HTML documents from declarative commands.

## Features

- Abstract factory for Markdown and HTML document output
- Shared document and element interfaces
- Script parser for document, element, and run commands
- Example generated output under `docs/`

## Tech Stack

- C#
- .NET Framework 4.8
- Visual Studio/MSBuild solution

## Getting Started

Open `DocumentFactory.sln` in Visual Studio and build the solution. Run the `Director` project to process `Director/CreateDocumentScript.txt`.

## Project Structure

- `DocumentFactory/`: document factory library
- `Director/`: script runner console app
- `docs/`: generated sample output and demo binaries
