# Aspose.Slides Skill - Implementation Guide

## Overview

This guide walks you through setting up the Aspose.Slides skill for Claude Code. You now have all the core components. This guide helps you organize and activate them.

## What You Have

✅ **SKILL.md** - Comprehensive skill file with:
- Object model understanding
- Modern C# patterns and best practices
- Common task patterns with code examples
- Troubleshooting guide
- Performance considerations

✅ **QUICK-REFERENCE.md** - Fast lookup guide with:
- Most common classes and methods
- 30-second patterns for frequent tasks
- Decision trees for choosing approaches
- Common enumerations
- Quick troubleshooting fixes

✅ **RESOURCE-ORGANIZATION-GUIDE.md** - Strategy for organizing additional resources:
- Recommended directory structure
- Resource processing approaches
- File size recommendations
- Usage patterns

✅ **process_xml_docs.py** - Python script for extracting documentation from XML:
- Interface extraction
- Core classes extraction
- Namespace organization
- Enumeration reference

## Quick Start (Minimal Setup)

If you want to start using the skill immediately with minimal setup:

### 1. Create the Skill Directory

```bash
# In Claude Code's skill directory
mkdir -p /mnt/skills/user/aspose-slides
```

### 2. Add Core Files

```bash
# Copy the main skill file
cp SKILL.md /mnt/skills/user/aspose-slides/

# Copy quick reference for fast lookups
cp QUICK-REFERENCE.md /mnt/skills/user/aspose-slides/
```

### 3. Test the Skill

Create a simple test:

```csharp
using Aspose.Slides;
using System;

using var presentation = new Presentation();
var slide = presentation.Slides[0];

var title = slide.Shapes.AddAutoShape(
    ShapeType.Rectangle,
    50, 50, 600, 100);

title.TextFrame.Text = "Hello from Aspose.Slides!";

presentation.Save("test.pptx", SaveFormat.Pptx);
Console.WriteLine("Presentation created successfully!");
```

**With just these two files, Claude Code can handle 80-90% of common Aspose.Slides tasks.**

## Full Setup (Enhanced with Documentation)

For comprehensive support, extract additional documentation:

### 1. Complete Directory Structure

```bash
mkdir -p /mnt/skills/user/aspose-slides/{docs/api-reference,examples,resources}
```

### 2. Process XML Documentation

```bash
# Run the Python script to extract documentation
python process_xml_docs.py \
    Aspose_Slides.xml \
    /mnt/skills/user/aspose-slides/docs/api-reference/

# This creates:
# - interfaces.md
# - core-classes.md
# - namespace-guide.md
# - enumerations.md
```

### 3. Extract GitHub Examples

Visit the GitHub repository and extract examples into categories:

```bash
# Create example category files
cd /mnt/skills/user/aspose-slides/examples/

# Categories to create:
touch creating-presentations.md
touch manipulating-slides.md
touch working-with-text.md
touch tables-and-charts.md
touch images-and-media.md
touch export-and-conversion.md
```

**Example Content for `creating-presentations.md`**:

```markdown
# Creating Presentations - Examples

## Create Empty Presentation

```csharp
using var presentation = new Presentation();
var slide = presentation.Slides.AddEmptySlide(
    presentation.LayoutSlides[0]);
presentation.Save("empty.pptx", SaveFormat.Pptx);
```

## Create from Template

```csharp
using var presentation = new Presentation("template.pptx");
// Modify as needed
presentation.Save("from-template.pptx", SaveFormat.Pptx);
```

[Add 3-5 more examples per category]
```

### 4. Final Directory Structure

```
/mnt/skills/user/aspose-slides/
├── SKILL.md                          # Main skill (comprehensive)
├── QUICK-REFERENCE.md                # Fast lookup
├── docs/
│   └── api-reference/
│       ├── interfaces.md             # From XML processing
│       ├── core-classes.md           # From XML processing
│       ├── namespace-guide.md        # From XML processing
│       └── enumerations.md           # From XML processing
├── examples/                         # From GitHub
│   ├── creating-presentations.md
│   ├── manipulating-slides.md
│   ├── working-with-text.md
│   ├── tables-and-charts.md
│   ├── images-and-media.md
│   └── export-and-conversion.md
└── resources/                        # Original files (reference only)
    ├── Aspose_Slides.xml
    └── Aspose_Slides.html
```

## How Claude Code Uses These Resources

### For Simple Tasks

Claude reads:
1. SKILL.md (patterns and object model)
2. QUICK-REFERENCE.md (verify syntax)

**Example Task**: "Create a presentation with a title slide"

Claude will:
- Check SKILL.md for object hierarchy
- Reference QUICK-REFERENCE.md for AddAutoShape syntax
- Generate code using modern C# patterns

### For Moderate Tasks

Claude reads:
1. SKILL.md
2. QUICK-REFERENCE.md
3. Relevant example category (e.g., `tables-and-charts.md`)

**Example Task**: "Create a presentation with a data table from JSON"

Claude will:
- Review table patterns in SKILL.md
- Check table syntax in QUICK-REFERENCE.md
- Adapt example from `tables-and-charts.md`
- Combine with JSON parsing pattern

### For Complex Tasks

Claude may read:
1. SKILL.md
2. QUICK-REFERENCE.md
3. Multiple example categories
4. API reference docs (interfaces.md, core-classes.md)
5. Namespace guide for discovering new APIs

**Example Task**: "Create an animated presentation with charts populated from a database"

Claude will:
- Review object model in SKILL.md
- Check multiple example categories
- Consult namespace-guide.md for animation APIs
- Reference interfaces.md for detailed method signatures

## Customizing the Skill

As you use the skill, you can enhance it:

### 1. Add Your Common Patterns

Edit SKILL.md to add patterns you use frequently:

```markdown
### Your Custom Pattern Name

```csharp
// Your frequently used code pattern
public ISlide CreateDashboardSlide(IPresentation pres, DashboardData data)
{
    // Your implementation
}
```

**When to Use**: Explain when this pattern is appropriate
```

### 2. Document Learnings

When you solve a tricky problem, add it to QUICK-REFERENCE.md:

```markdown
### Your Specific Issue

**Problem**: Describe the problem

**Solution**:
```csharp
// Your solution code
```
```

### 3. Add Domain-Specific Examples

If you work in a specific domain (e.g., financial reports, educational content), create a domain-specific example file:

```bash
touch /mnt/skills/user/aspose-slides/examples/financial-reports.md
```

## Optimization Tips

### Keep Files Focused

- **SKILL.md**: Patterns and understanding (~3000-4000 lines)
- **QUICK-REFERENCE.md**: Fast lookups (~1000 lines)
- **Example files**: 200-400 lines each
- **API docs**: 500-1500 lines each

### Update Regularly

As Aspose.Slides updates:
1. Get new XML documentation
2. Re-run process_xml_docs.py
3. Update patterns in SKILL.md
4. Add new examples

### Performance Monitoring

Track how often different resources are used:
- Most accessed: SKILL.md and QUICK-REFERENCE.md
- Occasionally accessed: Example categories
- Rarely accessed: Detailed API docs

Remove or archive rarely-used resources.

## Common Usage Workflows

### Workflow 1: New Feature Exploration

When exploring a new Aspose.Slides feature:

1. **Check namespace-guide.md** - Find which namespace contains the feature
2. **Review SKILL.md** - Look for related patterns
3. **Consult examples/** - Find similar usage
4. **Reference interfaces.md** - Get detailed API info

### Workflow 2: Template-Driven Development

When working with templates:

1. **Start with SKILL.md** - Review template patterns
2. **Check QUICK-REFERENCE.md** - Verify placeholder access
3. **Reference creating-presentations.md** - Adapt template examples
4. **Use working-with-text.md** - For text manipulation

### Workflow 3: Data Visualization

When creating charts and tables:

1. **Review SKILL.md** - Understand chart/table object model
2. **Check tables-and-charts.md** - Find similar examples
3. **Reference QUICK-REFERENCE.md** - Verify method signatures
4. **Consult core-classes.md** - For advanced features

## Integration with Your Projects

### Project-Specific Templates

Create a project-specific skill extension:

```bash
mkdir /mnt/skills/user/aspose-slides/projects/
touch /mnt/skills/user/aspose-slides/projects/my-project-patterns.md
```

Document your project's specific needs:
- Template locations
- Corporate style guides
- Data source integrations
- Common slide layouts

### Reusable Components

Build a library of reusable components:

```csharp
// Store in your project
public static class SlideHelpers
{
    public static IAutoShape AddStyledTitle(
        this ISlide slide, 
        string text)
    {
        var title = slide.Shapes.AddAutoShape(
            ShapeType.Rectangle, 50, 50, 600, 100);
        title.TextFrame.Text = text;
        // Apply your corporate styling
        return title;
    }
}
```

Document these in your project-specific patterns file.

## Troubleshooting the Skill Setup

### Issue: Claude Can't Find the Skill

**Check**:
```bash
ls -la /mnt/skills/user/aspose-slides/SKILL.md
```

**Solution**: Ensure files are in correct location with correct names.

### Issue: Claude Doesn't Use Examples

**Reason**: Example files may be too large or poorly organized.

**Solution**: 
- Keep examples focused (200-400 lines)
- Use clear section headers
- Include searchable keywords

### Issue: Outdated Information

**Solution**:
- Regenerate docs from latest XML
- Update GitHub examples
- Review and update SKILL.md patterns

## Next Steps

### Immediate (Do Now)

1. ✅ Copy SKILL.md and QUICK-REFERENCE.md to skill directory
2. ✅ Test with a simple presentation creation task
3. ✅ Verify Claude Code can access the skill

### Short-Term (Within a Week)

4. Run process_xml_docs.py to generate API references
5. Extract 3-5 example categories from GitHub
6. Test with moderate complexity tasks

### Long-Term (As Needed)

7. Add custom patterns based on your usage
8. Create project-specific extensions
9. Build reusable component library
10. Update regularly with new Aspose.Slides versions

## Getting Help

### When You Encounter Issues

1. **Check QUICK-REFERENCE.md** - Troubleshooting section
2. **Review SKILL.md** - Similar patterns
3. **Consult examples/** - Related use cases
4. **Search API docs** - Detailed method info
5. **Ask Claude** - With context from skill files

### Reporting Issues

If you find gaps in the skill:
1. Note what was missing
2. Add it to appropriate file
3. Share learnings in project-specific patterns

## Maintenance Schedule

### Monthly
- Review and update custom patterns
- Add new examples from your work
- Clean up outdated information

### Quarterly
- Check for new Aspose.Slides releases
- Regenerate XML documentation
- Update GitHub examples

### Annually
- Comprehensive skill review
- Archive rarely-used resources
- Reorganize based on usage patterns

## Summary

**Minimum Viable Setup** (Start Here):
- SKILL.md
- QUICK-REFERENCE.md
- Simple test to verify

**Enhanced Setup** (Add As Needed):
- API reference docs (from XML)
- Example categories (from GitHub)
- Project-specific patterns

**Key Principles**:
1. Start simple, enhance as needed
2. Keep files focused and scannable
3. Update based on actual usage
4. Document your learnings

The skill is now ready to use! Claude Code has everything needed to work effectively with Aspose.Slides, from basic presentations to complex data-driven slide generation.
