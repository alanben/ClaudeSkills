# Maker CLI System Notes

## Overview
The Maker CLI is a code generation tool that transforms model definitions into .NET Core data API endpoints with full CRUD functionality, serving as the data repository layer for higher-level application endpoints.

## System Architecture

### Input
- **Model Definition**: XML file located in `MakerModel/` folder
- **Configuration**: Project-specific settings defining target project folders

### Processing Tool
- **Maker CLI**: Command-line utility that processes model definitions and generates output files

### Output
- **.NET Core Endpoints**: Auto-generated API endpoints
- **Associated Code**: Supporting classes and methods for relational data model access
- **Full CRUD Functionality**: Complete Create, Read, Update, Delete operations

## CLI Usage

### Standard Generation
```bash
MakerCLI --modelname=[Name] --publish=[true|false] --validate=[true|false|only]
```

## Command Line Arguments

| Argument | Required | Description | Default |
|----------|----------|-------------|---------|
| `modelname` | Yes | Name of the model to build | - |
| `foldername` | No | Folder name for the model | Same as modelname |
| `modelpath` | No | Path to model directory | From appsettings.json |
| `templatepath` | No | Path to template directory | From appsettings.json |
| `publish` | No | Whether to publish after build | false |
| `validate` | No | Model validation mode: `false`, `true`, `only` | false |


**Behavior:**
- No file output generated
- Performs model validation only
- Error messages written to console indicating model flaws
- Used for model verification before generation

## Workflow

1. **Model Definition** → XML file created in designated folder
2. **CLI Execution** → Maker CLI processes the model definition
3. **Code Generation** → Data API files created in output directory
4. **Deployment** (if `--publish true`) → Files copied to target project folders
5. **Integration** → Generated data repository layer serves higher-level endpoints

## Key Features

- **Automated CRUD Generation**: Full data access layer creation
- **Relational Data Model Support**: Works with relational database structures  
- **Configurable Deployment**: Flexible file placement via project configuration
- **Model Validation**: Built-in validation with detailed error reporting
- **Separation of Concerns**: Clear distinction between generation and deployment phases

## Integration Requirements

The Maker CLI utility capability needs to be integrated into the target project to enable this code generation workflow.
