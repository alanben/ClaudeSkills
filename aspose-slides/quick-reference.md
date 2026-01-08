---
name: aspose-slides-quick-reference
description: Fast lookup guide for Aspose.Slides.NET - common classes, patterns, and quick solutions
---

# Aspose.Slides Quick Reference

## Installation
```bash
dotnet add package Aspose.Slides.NET
```

## Core Object Model

### Presentation → Slides → Shapes → Content

```
Presentation
    ├── Slides[i]
    │       ├── Shapes[i]
    │       │       ├── TextFrame.Paragraphs[i].Portions[i]
    │       │       ├── Table[col, row]
    │       │       ├── Chart.ChartData
    │       │       └── PictureFormat.Picture
    │       ├── Background
    │       └── SlideShowTransition
    ├── Masters[i]
    ├── Layouts[i]
    └── DocumentProperties
```

## Most Common Classes

### Presentation (IPresentation)
**Purpose**: Main entry point for PowerPoint manipulation
```csharp
// Create new
using var pres = new Presentation();

// Load existing
using var pres = new Presentation("file.pptx");

// Save
pres.Save("output.pptx", SaveFormat.Pptx);
pres.Save("output.pdf", SaveFormat.Pdf);
```

### Slide (ISlide)
**Purpose**: Individual slide in presentation
```csharp
// Access
var slide = pres.Slides[0];
var slide = pres.Slides.AddEmptySlide(layout);

// Properties
slide.Shapes       // All shapes on slide
slide.Background   // Slide background
slide.SlideNumber  // Position in presentation
```

### Shape (IShape)
**Purpose**: Base interface for all shapes
```csharp
// Common properties
shape.X, shape.Y              // Position
shape.Width, shape.Height     // Size
shape.Name                    // Shape identifier
shape.AlternativeText         // Alt text

// Type checking
if (shape is IAutoShape autoShape) { }
if (shape is ITable table) { }
if (shape is IChart chart) { }
```

### AutoShape (IAutoShape)
**Purpose**: Text boxes, rectangles, shapes with text
```csharp
var shape = slide.Shapes.AddAutoShape(
    ShapeType.Rectangle, 
    x: 50, y: 50, 
    width: 200, height: 100);

// Text access
shape.TextFrame.Text = "Content";

// Formatting
shape.FillFormat.FillType = FillType.Solid;
shape.FillFormat.SolidFillColor.Color = Color.Blue;
shape.LineFormat.Width = 2;
```

### TextFrame (ITextFrame)
**Purpose**: Contains text content in a shape
```csharp
var tf = shape.TextFrame;

// Simple text
tf.Text = "Hello World";

// Paragraph access
foreach (var para in tf.Paragraphs) 
{
    para.Text = "New text";
}

// Portion access (formatted text runs)
foreach (var portion in tf.Paragraphs[0].Portions)
{
    portion.PortionFormat.FontHeight = 24;
    portion.PortionFormat.FontBold = NullableBool.True;
}
```

### Table (ITable)
**Purpose**: Data tables on slides
```csharp
// Create table
var table = slide.Shapes.AddTable(
    x: 50, y: 50,
    columnWidths: new[] { 100.0, 150.0, 200.0 },
    rowHeights: new[] { 50.0, 40.0, 40.0 });

// Access cells
table[col, row].TextFrame.Text = "Cell content";

// Cell formatting
table[0, 0].CellFormat.FillFormat.FillType = FillType.Solid;
table[0, 0].CellFormat.FillFormat.SolidFillColor.Color = Color.Gray;
```

### Chart (IChart)
**Purpose**: Charts and graphs
```csharp
var chart = slide.Shapes.AddChart(
    ChartType.ClusteredColumn,
    x: 50, y: 50,
    width: 500, height: 400);

// Clear defaults
chart.ChartData.Series.Clear();
chart.ChartData.Categories.Clear();

// Add categories
var wb = chart.ChartData.ChartDataWorkbook;
chart.ChartData.Categories.Add(wb.GetCell(0, 1, 0, "Q1"));

// Add series
var series = chart.ChartData.Series.Add(
    wb.GetCell(0, 0, 1, "Sales"), 
    chart.Type);
series.DataPoints.AddDataPointForBarSeries(
    wb.GetCell(0, 1, 1, 100));
```

### PictureFrame (IPictureFrame)
**Purpose**: Image shapes
```csharp
// Add image
using var img = Image.FromFile("logo.png");
var ppImage = pres.Images.AddImage(img);

var picture = slide.Shapes.AddPictureFrame(
    ShapeType.Rectangle,
    x: 100, y: 100,
    width: 200, height: 150,
    ppImage);
```

## Common Enumerations

### ShapeType
Most frequently used:
- `Rectangle` - Basic rectangle
- `RoundedRectangle` - Rectangle with rounded corners
- `Ellipse` - Circle/oval
- `Triangle` - Triangle shape

### PlaceholderType
- `Title` - Slide title
- `Body` - Main content area
- `CenteredTitle` - Centered title
- `Subtitle` - Subtitle placeholder
- `Object` - Generic content

### FillType
- `Solid` - Solid color fill
- `Gradient` - Gradient fill
- `Pattern` - Pattern fill
- `Picture` - Picture fill
- `NoFill` - No fill

### SaveFormat
- `Pptx` - PowerPoint 2007+
- `Ppt` - PowerPoint 97-2003
- `Pdf` - PDF document
- `Html` - HTML format
- `Png` - PNG images
- `Jpeg` - JPEG images
- `Tiff` - TIFF images

### ChartType
Common types:
- `ClusteredColumn` - Vertical bars
- `Line` - Line chart
- `Pie` - Pie chart
- `Bar` - Horizontal bars
- `Area` - Area chart
- `Scatter` - Scatter plot

## 30-Second Patterns

### Create Presentation from Template
```csharp
using var pres = new Presentation("template.pptx");

foreach (var slide in pres.Slides)
{
    // Find title placeholder
    var title = slide.Shapes
        .OfType<IAutoShape>()
        .FirstOrDefault(s => s.Placeholder?.Type == PlaceholderType.Title);
    
    if (title != null)
        title.TextFrame.Text = "New Title";
}

pres.Save("output.pptx", SaveFormat.Pptx);
```

### Add Slide with Layout
```csharp
using var pres = new Presentation();

// Get layout
var layout = pres.Masters[0].LayoutSlides[1];

// Add slide
var slide = pres.Slides.AddEmptySlide(layout);

pres.Save("output.pptx", SaveFormat.Pptx);
```

### Find and Replace Text
```csharp
void ReplaceText(IPresentation pres, string find, string replace)
{
    foreach (var slide in pres.Slides)
    {
        foreach (var shape in slide.Shapes.OfType<IAutoShape>())
        {
            if (shape.TextFrame == null) continue;
            
            foreach (var para in shape.TextFrame.Paragraphs)
            {
                foreach (var portion in para.Portions)
                {
                    if (portion.Text.Contains(find))
                        portion.Text = portion.Text.Replace(find, replace);
                }
            }
        }
    }
}
```

### Add Formatted Text
```csharp
var shape = slide.Shapes.AddAutoShape(
    ShapeType.Rectangle, 50, 50, 300, 100);

var tf = shape.TextFrame;
tf.Paragraphs.Clear();

var para = new Paragraph();
var portion = new Portion("Formatted Text");

// Format portion
portion.PortionFormat.FontHeight = 28;
portion.PortionFormat.FontBold = NullableBool.True;
portion.PortionFormat.FillFormat.FillType = FillType.Solid;
portion.PortionFormat.FillFormat.SolidFillColor.Color = Color.Blue;

para.Portions.Add(portion);
tf.Paragraphs.Add(para);
```

### Create Bullet List
```csharp
var shape = slide.Shapes
    .OfType<IAutoShape>()
    .First(s => s.Placeholder?.Type == PlaceholderType.Body);

shape.TextFrame.Paragraphs.Clear();

var items = new[] { "First point", "Second point", "Third point" };
foreach (var item in items)
{
    var para = new Paragraph { Text = item };
    para.ParagraphFormat.Bullet.Type = BulletType.Symbol;
    para.ParagraphFormat.Bullet.Char = '•';
    para.ParagraphFormat.Indent = 20;
    shape.TextFrame.Paragraphs.Add(para);
}
```

### Clone Slide
```csharp
// Clone within same presentation
var clonedSlide = pres.Slides.AddClone(pres.Slides[0]);

// Clone to another presentation
using var targetPres = new Presentation();
targetPres.Slides.AddClone(pres.Slides[0]);
```

### Remove Slide
```csharp
// By index
pres.Slides.RemoveAt(0);

// By reference
pres.Slides.Remove(slide);
```

### Extract All Text
```csharp
string ExtractText(IPresentation pres)
{
    return string.Join("\n", pres.Slides
        .SelectMany(s => s.Shapes.OfType<IAutoShape>())
        .Where(s => s.TextFrame != null)
        .Select(s => s.TextFrame.Text));
}
```

### Convert to PDF
```csharp
using var pres = new Presentation("input.pptx");

var options = new PdfOptions
{
    JpegQuality = 90,
    EmbedFullFonts = true
};

pres.Save("output.pdf", SaveFormat.Pdf, options);
```

### Export Slides as Images
```csharp
using var pres = new Presentation("input.pptx");

foreach (var slide in pres.Slides)
{
    using var bitmap = slide.GetThumbnail(1.0f, 1.0f);
    bitmap.Save(
        $"slide_{slide.SlideNumber}.png",
        System.Drawing.Imaging.ImageFormat.Png);
}
```

## Shape Type Checking Pattern

```csharp
foreach (var shape in slide.Shapes)
{
    switch (shape)
    {
        case IAutoShape autoShape when autoShape.TextFrame != null:
            ProcessTextShape(autoShape);
            break;
        
        case ITable table:
            ProcessTable(table);
            break;
        
        case IChart chart:
            ProcessChart(chart);
            break;
        
        case IPictureFrame picture:
            ProcessImage(picture);
            break;
        
        case IGroupShape group:
            ProcessGroup(group);
            break;
    }
}
```

## Measurement Units

Aspose.Slides uses **points** (1/72 inch) for measurements:
- X, Y positions
- Width, Height
- Font sizes

```csharp
// Convert inches to points
float InchesToPoints(float inches) => inches * 72f;

// Convert centimeters to points
float CmToPoints(float cm) => cm * 28.3465f;

// Standard slide dimensions (16:9)
// Width: 10 inches = 720 points
// Height: 5.625 inches = 405 points
```

## Common Namespaces

```csharp
using Aspose.Slides;                  // Core
using Aspose.Slides.Charts;           // Charts
using Aspose.Slides.Export;           // Export options
using Aspose.Slides.Animation;        // Animations
using System.Drawing;                 // Colors, Images
using System.Linq;                    // Collection operations
```

## Troubleshooting Quick Fixes

### Text Overflow
```csharp
// Auto-fit text to shape
shape.TextFrame.TextFrameFormat.AutofitType = TextAutofitType.Shape;
```

### Shape Not Visible
```csharp
// Check if shape is on slide (Z-order)
shape.ZOrderPosition  // Higher = more on top

// Bring to front
slide.Shapes.Reorder(slide.Shapes.Count - 1, shape);
```

### Font Issues
```csharp
// Embed fonts
var fontData = File.ReadAllBytes("font.ttf");
pres.FontsManager.AddEmbeddedFont(fontData, EmbedFontCharacters.All);
```

### Chart Not Updating
```csharp
// Force chart data refresh
chart.ChartData.ChartDataWorkbook.Clear(0);
// Then re-populate
```

### Large File Size
```csharp
// Compress images
var options = new PdfOptions { JpegQuality = 80 };

// Remove unused masters
pres.Masters.RemoveUnused();
```

## Decision Trees

### When to Use What?

**Need to add text?**
- Single line → Use AutoShape with TextFrame.Text
- Multiple paragraphs → Use AutoShape with Paragraphs
- Formatted text → Use Portions with PortionFormat
- Template text → Use PlaceholderType

**Need to display data?**
- Tabular data → Use Table
- Trends/comparisons → Use Chart
- Single metric → Use AutoShape with large text
- Images → Use PictureFrame

**Need to export?**
- Editing later → Save as PPTX
- Sharing → Save as PDF
- Web → Save as HTML
- Thumbnail → GetThumbnail() as PNG

**Need to style?**
- Consistent design → Use Masters/Layouts
- One-off styling → Direct shape formatting
- Corporate identity → Use Themes
- Custom look → FillFormat and LineFormat

## Performance Tips

```csharp
// For large presentations
var options = new LoadOptions
{
    BlobManagementOptions = new BlobManagementOptions
    {
        IsTemporaryFilesAllowed = true
    }
};
using var pres = new Presentation("large.pptx", options);
```

## Common Method Signatures

```csharp
// AddAutoShape
IAutoShape AddAutoShape(
    ShapeType shapeType,
    float x, float y,
    float width, float height)

// AddTable  
ITable AddTable(
    float x, float y,
    double[] columnWidths,
    double[] rowHeights)

// AddChart
IChart AddChart(
    ChartType type,
    float x, float y,
    float width, float height)

// AddPictureFrame
IPictureFrame AddPictureFrame(
    ShapeType shapeType,
    float x, float y,
    float width, float height,
    IPPImage image)

// Save
void Save(string fname, SaveFormat format)
void Save(string fname, SaveFormat format, ISaveOptions options)
```

## Quick Checks

**Is it a text shape?**
```csharp
shape is IAutoShape autoShape && autoShape.TextFrame != null
```

**Is it a placeholder?**
```csharp
shape is IAutoShape autoShape && autoShape.Placeholder != null
```

**Has the shape been modified?**
```csharp
// No built-in tracking; consider custom tracking
```

**What slide is this shape on?**
```csharp
shape.ParentGroup?.ParentGroup  // Slides don't expose direct parent
// Better: Track during iteration
```

---

**Remember**: 
- Always use `using` for Presentation disposal
- Prefer LINQ for collections
- Check for null on TextFrame and Placeholder
- Points are 1/72 of an inch
- Higher Z-order = on top
