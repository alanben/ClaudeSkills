# .NET CQRS API Development Skill

A comprehensive skill for Claude to guide the specification and creation of .NET APIs using CQRS pattern with MediatR, FluentValidation, and Carter modules.

## Contents

- **SKILL.md** - The complete skill documentation that Claude will reference
- **Template Files** - C# code templates demonstrating the patterns:
  - `AddXxxx.cs` - Command pattern for creating entities
  - `UpdateXxxx.cs` - Command pattern for updating entities
  - `GetXxxx.cs` - Query pattern for retrieving single entities
  - `GetXxxxs.cs` - Query pattern for retrieving collections
  - `XxxxAddRequest.cs` - Command request DTO
  - `XxxxUpdateRequest.cs` - Command request DTO
  - `XxxxResponse.cs` - Query response DTO

## How to Use This Skill

### Option 1: As a Claude Skill (Recommended)

1. Navigate to Claude's Skills section in your profile
2. Upload the `SKILL.md` file as a new skill
3. Name it "dotnet-cqrs-api" or similar
4. Claude will automatically reference this skill when you ask about .NET API development

### Option 2: As Context in Conversations

Simply upload the `SKILL.md` file to any conversation where you need guidance on:
- Designing .NET APIs with CQRS
- Implementing MediatR command/query handlers
- Setting up FluentValidation
- Creating Carter endpoint modules
- Structuring vertical slice architecture

## What This Skill Provides

### Architecture Guidance
- Vertical slice architecture organization
- CQRS pattern implementation
- Result pattern for error handling
- Functional and declarative code style

### Implementation Patterns
- **Commands**: Add, Update operations with validation
- **Queries**: Get single items, Get collections
- **DTOs**: Request and Response patterns
- **Validation**: FluentValidation rules and strategies
- **Error Handling**: Result<T> pattern with proper HTTP status codes

### Best Practices
- Immutable DTOs with init-only properties
- Comprehensive validation strategies
- Proper dependency injection
- Testing approaches (unit and integration)
- Authorization and OpenAPI documentation

## Example Usage

Once the skill is loaded, you can ask Claude questions like:

- "Create a Customer feature with Add, Get, and List operations"
- "Show me how to implement pagination in a query"
- "What's the proper way to handle validation errors?"
- "Help me structure a Product API with CQRS"
- "Review my command handler for best practices"

Claude will reference the patterns and guidance in SKILL.md to provide consistent, idiomatic C# code following your established patterns.

## Technology Stack

This skill assumes you're working with:
- .NET 6+ (modern C#)
- MediatR (mediator pattern)
- FluentValidation (declarative validation)
- Carter (minimal API modules)
- Mapster (object mapping)

## Customization

The SKILL.md file can be customized to match your specific:
- Namespace conventions
- Authorization policies
- Logging strategies
- Data access patterns
- Project structure preferences

Simply edit the SKILL.md file to reflect your team's conventions.

## Contributing

The templates in this skill are based on real production patterns. If you identify improvements or additional patterns, update the SKILL.md file to capture institutional knowledge.
