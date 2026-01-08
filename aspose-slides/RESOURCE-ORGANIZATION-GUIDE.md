# Aspose.Slides Skill - Resource Organization Guide

## Overview

This document provides guidance on organizing and utilizing the various Aspose.Slides resources to maximize Claude Code's effectiveness when working with PowerPoint manipulation tasks.

## Resource Structure

Your Aspose.Slides skill should be organized with the following structure:

```
/mnt/skills/user/aspose-slides/
├── SKILL.md                          # Main skill file (already created)
├── docs/                             # Documentation resources
│   ├── api-reference/                # Extracted HTML documentation
│   │   ├── index.md                  # Searchable index
│   │   ├── core-classes.md           # Key classes reference
│   │   ├── common-patterns.md        # Usage patterns extracted from docs
│   │   └── namespace-guide.md        # Namespace organization
│   ├── xml-documentation/            # Processed XML docs
│   │   ├── interfaces.md             # All interface documentation
│   │   ├── classes.md                # All class documentation
│   │   └── enumerations.md           # All enum documentation
│   └── quick-reference.md            # Quick lookup guide
├── examples/                         # GitHub examples (curated)
│   ├── creating-presentations.md     # New presentation examples
│   ├── manipulating-slides.md        # Slide manipulation examples
│   ├── working-with-text.md          # Text handling examples
│   ├── tables-and-charts.md          # Table and chart examples
│   ├── images-and-media.md           # Media handling examples
│   ├── export-and-conversion.md      # Export examples
│   └── advanced-scenarios.md         # Complex use cases
└── resources/                        # Raw resources
    ├── Aspose_Slides.xml             # Original XML documentation
    └── html-docs/                    # Extracted HTML documentation
```

## Recommended Resource Processing Strategy

Given the size and complexity of Aspose.Slides documentation, here's how to organize resources for optimal Claude Code usage:

### 1. Core Skill File (SKILL.md)
✅ **Already Created** - This contains:
- Object model understanding
- Modern C# patterns
- Common task patterns
- Best practices
- Troubleshooting guide

### 2. Quick Reference Guide

Create a condensed reference that Claude can quickly scan:

**Purpose**: Fast lookup for common operations
**Content**: 
- Most frequently used classes and their purposes
- Common method signatures
- Typical usage patterns
- Decision trees for choosing between approaches

**Recommended Size**: 500-1000 lines
**Format**: Markdown with clear sections

### 3. API Documentation Index

Instead of including the full HTML documentation, create searchable indexes:

**Core Classes Index** (`docs/api-reference/core-classes.md`):
```markdown
# Aspose.Slides Core Classes Reference

## Presentation Management
- **Presentation (IPresentation)**: Main entry point for working with presentations
  - Constructor: `new Presentation()` or `new Presentation(string path)`
  - Methods: `Save()`, `GetSlideById()`, `Dispose()`
  - Properties: `Slides`, `Masters`, `Layouts`, `DocumentProperties`

## Slide Management
- **Slide (ISlide)**: Represents a single slide
  - Methods: `GetThumbnail()`, `JoinPortionsWithSameFormatting()`
  - Properties: `Shapes`, `Background`, `SlideShowTransition`, `NotesSlideManager`

[Continue with most important classes...]
```

### 4. Namespace Organization Guide

Create a guide that helps Claude understand where to find functionality:

**Example** (`docs/api-reference/namespace-guide.md`):
```markdown
# Aspose.Slides Namespace Organization

## Aspose.Slides
Core functionality for presentation manipulation
- Presentation loading and saving
- Slide management
- Basic shape operations

## Aspose.Slides.Charts
Everything related to charts
- Chart types and creation
- Data series management
- Chart formatting

## Aspose.Slides.Animation
Animation and transitions
- Effect types
- Timeline management
- Animation sequences

[Continue with all major namespaces...]
```

### 5. Curated Examples from GitHub

Rather than referencing the entire GitHub repository, extract and organize the most relevant examples:

**Processing Strategy**:
1. Browse the GitHub examples: https://github.com/aspose-slides/Aspose.Slides-for-.NET/tree/master/Examples/CSharp
2. Identify categories (10-15 categories maximum)
3. Extract 3-5 representative examples per category
4. Modernize the code to use modern C# patterns
5. Add explanatory comments

**Example** (`examples/working-with-text.md`):
```markdown
# Working with Text Examples

## Basic Text Manipulation

### Setting Text in a TextFrame
```csharp
using var presentation = new Presentation();
var slide = presentation.Slides[0];

var textShape = slide.Shapes.AddAutoShape(
    ShapeType.Rectangle, 
    50, 50, 200, 50);

textShape.TextFrame.Text = "Hello, Aspose.Slides!";

presentation.Save("output.pptx", SaveFormat.Pptx);
```

### Finding and Replacing Text
```csharp
// Modern functional approach
void ReplaceText(IPresentation presentation, string find, string replace)
{
    presentation.Slides
        .SelectMany(s => s.Shapes.OfType<IAutoShape>())
        .Where(s => s.TextFrame != null)
        .SelectMany(s => s.TextFrame.Paragraphs)
        .SelectMany(p => p.Portions)
        .Where(p => p.Text.Contains(find))
        .ToList()
        .ForEach(p => p.Text = p.Text.Replace(find, replace));
}
```

[Continue with more examples...]
```

### 6. XML Documentation Processing

The XML file is valuable but large (75k+ lines). Process it into focused reference files:

**Approach**:
1. **Parse the XML** to extract all member documentation
2. **Group by type**: Interfaces, Classes, Enumerations, etc.
3. **Create focused reference files** organized by domain

**Example** (`docs/xml-documentation/interfaces.md`):
```markdown
# Aspose.Slides Interfaces Reference

## Core Interfaces

### IPresentation
Main interface for working with presentations.

**Namespace**: Aspose.Slides

**Key Members**:
- `Slides`: Gets the collection of all slides
- `Masters`: Gets the collection of master slides
- `Save(string, SaveFormat)`: Saves presentation to file

**Usage Context**: Entry point for all presentation operations

---

### ISlide
Represents a presentation slide.

**Namespace**: Aspose.Slides

**Key Members**:
- `Shapes`: Gets the shapes collection
- `Background`: Gets or sets the background
- `GetThumbnail()`: Creates a thumbnail image

**Usage Context**: Working with individual slides

[Continue with key interfaces...]
```

## Resource Discovery Workflow for Claude

When Claude Code encounters an Aspose.Slides task, it should follow this workflow:

### 1. Check SKILL.md (Primary Resource)
- Review object model hierarchy
- Find relevant common patterns
- Check for similar examples

### 2. Consult Quick Reference
- Look up specific class or method
- Find typical usage patterns
- Verify method signatures

### 3. Check Namespace Guide
- Identify which namespace contains needed functionality
- Navigate to specific domain (charts, animation, etc.)

### 4. Review Curated Examples
- Find category matching the task
- Adapt example code to specific needs
- Combine patterns as necessary

### 5. Deep Dive into API Reference (If Needed)
- Consult detailed class documentation
- Review all available methods and properties
- Check interface contracts

## Processing the Raw Resources

Here's how to process the resources you have:

### Processing the HTML Documentation

The HTML file you provided is an index. To make it usable:

**Option 1: Create a Searchable Index**
```markdown
# Aspose.Slides Class Index

## A
- **AdjustValue**: Geometry shape's adjustment value
- **AdjustValueCollection**: Collection of shape's adjustments
- **Audio**: Embedded audio file
- **AudioCollection**: Collection of embedded audio files
- **AudioFrame**: Audio clip on a slide
- **AutoShape**: Represents an AutoShape
- **AutoShapeLock**: Disabled operations on AutoShape

## B
- **Backdrop3DScene**: Plane for effects like glow and shadow
- **Background**: Background of a slide
- **BaseHandoutNotesSlideHeaderFooterManager**: Manager for placeholders
[...]
```

**Option 2: Extract Most Important Classes**
Focus on the 20-30 most commonly used classes with detailed information.

### Processing the XML Documentation

The XML is comprehensive. Extract strategically:

```bash
# Pseudo-code for processing strategy
1. Parse XML file
2. Extract <member> nodes
3. Group by:
   - Type (T:), Method (M:), Property (P:), Field (F:)
4. Filter to most important namespaces:
   - Aspose.Slides (core)
   - Aspose.Slides.Charts
   - Aspose.Slides.Animation
   - Aspose.Slides.Export
5. Create focused reference files
```

**Python Script Example** to extract class summaries:
```python
import xml.etree.ElementTree as ET

tree = ET.parse('Aspose_Slides.xml')
root = tree.getroot()

# Extract all class summaries
classes = []
for member in root.findall('.//member[@name]'):
    name = member.get('name')
    if name.startswith('T:Aspose.Slides.') and not '.' in name[15:]:
        summary = member.find('summary')
        if summary is not None:
            classes.append({
                'name': name[15:],  # Remove 'T:Aspose.Slides.'
                'summary': summary.text.strip()
            })

# Create markdown file
with open('core-classes.md', 'w') as f:
    f.write('# Aspose.Slides Core Classes\n\n')
    for cls in sorted(classes, key=lambda x: x['name']):
        f.write(f"## {cls['name']}\n")
        f.write(f"{cls['summary']}\n\n")
```

## Recommended Immediate Actions

### 1. Create Quick Reference
Extract from SKILL.md:
- Most common 20 classes
- Most common 30 methods
- 10 most frequent patterns

**Target**: 500 lines, highly scannable

### 2. Process GitHub Examples
Visit the GitHub repo and extract:
- Creating presentations (3-5 examples)
- Working with slides (3-5 examples)
- Text manipulation (3-5 examples)
- Tables (2-3 examples)
- Charts (3-5 examples)
- Export/Conversion (3-5 examples)

Modernize code and organize into `examples/` directory.

### 3. Create Namespace Guide
From the HTML index, create:
- List of all namespaces
- Purpose of each namespace
- 3-5 most important classes per namespace
- When to use each namespace

**Target**: 300-500 lines

### 4. Extract Interface Reference
From XML documentation:
- All interfaces starting with `I`
- Key methods and properties for each
- Usage context notes

**Target**: 1000-1500 lines

## File Size Recommendations

For optimal Claude Code performance:

| Resource | Target Size | Priority |
|----------|-------------|----------|
| SKILL.md | 3000-4000 lines | ✅ Complete |
| Quick Reference | 500-1000 lines | High |
| Namespace Guide | 300-500 lines | High |
| Core Classes Index | 800-1200 lines | High |
| Interface Reference | 1000-1500 lines | Medium |
| Examples (each category) | 200-400 lines | Medium |
| Enumeration Reference | 500-800 lines | Low |
| Full Class Documentation | On-demand only | Low |

## Usage Patterns

### For Simple Tasks
Claude should only need:
- SKILL.md (patterns and object model)
- Quick Reference (verify syntax)

### For Moderate Tasks
Claude should consult:
- SKILL.md
- Quick Reference
- Relevant example category
- Namespace guide (if exploring new areas)

### For Complex Tasks
Claude may need:
- All of the above
- Interface reference
- Core classes index
- Potentially web search for specific scenarios

## Maintenance Strategy

As you use the skill:

1. **Note common tasks** → Add patterns to SKILL.md
2. **Discover new APIs** → Add to quick reference
3. **Solve complex problems** → Add to advanced examples
4. **Find missing documentation** → Extract from XML/HTML

## Summary

**Immediate Priority**:
1. ✅ SKILL.md is complete and comprehensive
2. Create Quick Reference (500-1000 lines)
3. Process 5-7 example categories from GitHub
4. Create Namespace Guide (300-500 lines)

**Optional Enhancements**:
5. Extract Interface Reference from XML
6. Create Core Classes Index from HTML
7. Process enumeration documentation

**Philosophy**: 
- Start with high-level guidance (SKILL.md)
- Provide fast lookup (Quick Reference)
- Offer concrete examples (GitHub examples)
- Enable deep dives when needed (detailed references)

This layered approach ensures Claude can work efficiently on most tasks while having access to comprehensive information for complex scenarios.
