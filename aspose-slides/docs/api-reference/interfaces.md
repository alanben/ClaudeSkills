# Aspose.Slides Interface Reference

This document contains all major interfaces in Aspose.Slides.

## IAccessiblePVIObject`1

**Full Name**: `Aspose.Slides.IAccessiblePVIObject`1`

**Description**: Represents a type that can return corresponding effective data with the inheritance applied.

**Key Members**:

*Methods*:
- `GetEffective`: Gets effective data with the inheritance applied.

---

## IAdjustValue

**Full Name**: `Aspose.Slides.IAdjustValue`

**Description**: Represents a geometry shape's adjustment value. These values affect shape's form.

**Key Members**:

*Propertys*:
- `RawValue`: Returns or sets adjustment value "as is". Read/write
- `AngleValue`: Returns or sets value, interpreting it as angle in degrees. Read/write
- `Name`: Returns a name of this adjustment value. Read-only
- `Type`: Returns the type of the shape adjustment. Read-only

---

## IAdjustValueCollection

**Full Name**: `Aspose.Slides.IAdjustValueCollection`

**Description**: Reprasents a collection of shape's adjustments.

**Key Members**:

*Propertys*:
- `Item`: Returns adjustment by index.
- `AsICollection`: Allows to get base ICollection interface. Read-only
- `AsIEnumerable`: Returns IEnumerable interface. Read-only

---

## IAnimationTimeLine

**Full Name**: `Aspose.Slides.IAnimationTimeLine`

**Description**: Represents timeline of animation.

**Key Members**:

*Propertys*:
- `InteractiveSequences`: Returns collection of interactive sequences. This sequences may contain only effects by "click on sh
- `MainSequence`: Returns main sequence which may contain only main effects collection. Read-only
- `TextAnimationCollection`: Returns collection of text animations. Read-only

---

## IAudio

**Full Name**: `Aspose.Slides.IAudio`

**Description**: Represents an embedded audio file.

**Key Members**:

*Propertys*:
- `ContentType`: Returns a MIME type of an audio, encoded in
- `BinaryData`: Returns the copy of an audio's data. In case of large amount of data consider using of

*Methods*:
- `GetStream`: Returns Stream stream for reading. Use 'using' or close stream after using.

---

## IAudioCollection

**Full Name**: `Aspose.Slides.IAudioCollection`

**Description**: Represents a collection of embedded audio files.

**Key Members**:

*Propertys*:
- `Item`: Gets the element at the specified index. Read-only

*Methods*:
- `AddAudio`: Adds a copy of an audio file from an another presentation.
- `AddAudio`: Creates and adds a audio to a presentation from stream.
- `AddAudio`: Creates and adds a audio to a presentation from stream.
- `AddAudio`: Creates and adds a audio to a presentation from byte array.

---

## IAudioFrame

**Full Name**: `Aspose.Slides.IAudioFrame`

**Description**: Represents an audio clip on a slide.

**Key Members**:

*Propertys*:
- `AudioCdStartTrack`: Returns or sets a start track index. Read/write
- `AudioCdStartTrackTime`: Returns or sets a start track time. Read/write
- `AudioCdEndTrack`: Returns or sets a last track index Read/write
- `AudioCdEndTrackTime`: Returns or sets a last track time. Read/write
- `Volume`: Returns or sets the audio volume. Read/write
- `PlayMode`: Returns or sets the audio play mode. Read/write
- `HideAtShowing`: Determines whether an AudioFrame is hidden. Read/write
- `PlayLoopMode`: Determines whether an audio is looped. Read/write
- `PlayAcrossSlides`: Determines whether an audio is playing across the slides. Read/write
- `RewindAudio`: Determines whether an audio is automatically rewinded to start after playing. Read/write

---

## IAutoShape

**Full Name**: `Aspose.Slides.IAutoShape`

**Description**: Represents an AutoShape.

**Key Members**:

*Propertys*:
- `ShapeLock`: Returns shape's locks. Read-only
- `AutoShapeLock`: Returns AutoShape's locks. Read-only
- `TextFrame`: Returns TextFrame object for the AutoShape. Read-only
- `UseBackgroundFill`: Determines whether this autoshape should be filled with slide's background fill instead of specified
- `IsTextBox`: Specifies if the shape is a text box.
- `AsIGeometryShape`: Allows to get base IGeometryShape interface. Read-only

*Methods*:
- `AddTextFrame`: Adds a new TextFrame to a shape. If shape already has TextFrame then simply changes its text.

---

## IAutoShapeLock

**Full Name**: `Aspose.Slides.IAutoShapeLock`

**Description**: Determines which operations are disabled on the parent AutoshapeEx.

**Key Members**:

*Propertys*:
- `GroupingLocked`: Determines whether an adding this shape to a group is forbidden. Read-write
- `SelectLocked`: Determines whether a selecting this shape is forbidden. Read-write
- `RotateLocked`: Determines whether a changing rotation angle of this shape is forbidden. Read-write
- `AspectRatioLocked`: Determines whether a shape have to preserve aspect ratio on resizing. Read-write
- `PositionLocked`: Determines whether a moving this shape is forbidden. Read-write
- `SizeLocked`: Determines whether a resizing this shape is forbidden. Read-write
- `EditPointsLocked`: Determines whether a direct changing of contour of this shape is forbidden. Read-write
- `AdjustHandlesLocked`: Determines whether a changing adjust values is forbidden. Read-write
- `ArrowheadsLocked`: Determines whether a changing arrowheads is forbidden. Read-write
- `ShapeTypeLocked`: Determines whether a changing of a shape type is forbidden. Read-write

---

## IBackdrop3DScene

**Full Name**: `Aspose.Slides.IBackdrop3DScene`

**Description**: Defines a plane in which effects, such as glow and shadow, are applied in relation to the shape they are being applied to.

**Key Members**:

*Propertys*:
- `NormalVector`: Returns or sets a normal vector. To be more precise, this attribute defines a vector normal to the f
- `AnchorPoint`: Returns or sets a point in 3D space. This point is the point in space that anchors the backdrop plan
- `UpVector`: Returns or sets a vector representing up. To be more precise, this attribute defines a vector repres

---

## IBackground

**Full Name**: `Aspose.Slides.IBackground`

**Description**: Represents background of a slide.

**Key Members**:

*Propertys*:
- `Type`: Returns a type of background fill. Read/write
- `FillFormat`: Returns a FillFormat for BackgroundType.OwnBackground fill. Read-only
- `EffectFormat`: Returns a EffectFormat for BackgroundType.OwnBackground fill. Read-only
- `StyleColor`: Returns a ColorFormat for a BackgroundType.Themed fill. Read-only
- `StyleIndex`: Returns an index of BackgroundType.Themed fill in background theme collection. 0 means no fill. 1..9
- `AsISlideComponent`: Returns ISlideComponent interface. Read-only
- `AsIFillParamSource`: Returns IFillParamSource interface. Read-only

*Methods*:
- `GetEffective`: Gets effective background data with the inheritance applied.

---

## IBackgroundEffectiveData

**Full Name**: `Aspose.Slides.IBackgroundEffectiveData`

**Description**: Immutable object which contains effective background properties.

**Key Members**:

*Propertys*:
- `FillFormat`: Returns effective fill format. Read-only
- `EffectFormat`: Returns effective effect format. Read-only
- `AsIFillParamSource`: Returns IFillParamSource interface.

---

## IBaseHandoutNotesSlideHeaderFooterManag

**Full Name**: `Aspose.Slides.IBaseHandoutNotesSlideHeaderFooterManag`

**Description**: Represents manager which holds behavior of the placeholders, including header placeholder for all types handout and notes slides.

**Key Members**:

*Propertys*:
- `IsHeaderVisible`: Gets value indicating that a header placeholder is present. Read
- `AsIBaseSlideHeaderFooterManager`: Returns IBaseSlideHeaderFooterManager interface.

*Methods*:
- `SetHeaderVisibility`: Changes slide header placeholder visibility.
- `SetHeaderText`: Sets text to slide header placeholder.

---

## IBaseHeaderFooterManager

**Full Name**: `Aspose.Slides.IBaseHeaderFooterManager`

**Description**: Represents manager which holds behavior of the footer, date-time, page number placeholders for all slide types.

---

## IBasePortionFormat

**Full Name**: `Aspose.Slides.IBasePortionFormat`

**Description**: This class contains the text portion formatting properties. Unlike

**Key Members**:

*Propertys*:
- `LineFormat`: Returns the LineFormat properties for text outlining. No inheritance applied. Read-only
- `FillFormat`: Returns the text FillFormat properties. No inheritance applied. Read-only
- `EffectFormat`: Returns the text EffectFormat properties. No inheritance applied. Read-only
- `HighlightColor`: Returns the color used to highlight a text. No inheritance applied. Read-only
- `UnderlineLineFormat`: Returns the LineFormat properties used to outline underline line. No inheritance applied. Read-only
- `UnderlineFillFormat`: Returns the underline line FillFormat properties. No inheritance applied. Read-only
- `FontBold`: Determines whether the font is bold. No inheritance applied. Read/write
- `FontItalic`: Determines whether the font is itallic. No inheritance applied. Read/write
- `Kumimoji`: Determines whether the numbers should ignore text eastern language-specific vertical text layout. No
- `NormaliseHeight`: Determines whether the height of a text should be normalized. No inheritance applied. Read/write

---

## IBasePortionFormatEffectiveData

**Full Name**: `Aspose.Slides.IBasePortionFormatEffectiveData`

**Description**: Base interface for immutable objects which contain effective text portion formatting properties.

**Key Members**:

*Propertys*:
- `LineFormat`: Returns the LineFormat properties for text outlining. Read-only
- `FillFormat`: Returns the text FillFormat properties. Read-only
- `EffectFormat`: Returns the text EffectFormat properties. Read-only
- `HighlightColor`: Returns the color used to highlight a text. Read-only
- `UnderlineLineFormat`: Returns the LineFormat properties used to outline underline line. Read-only
- `UnderlineFillFormat`: Returns the underline line FillFormat properties. Read-only
- `FontBold`: Determines whether the font is bold. Read-only
- `FontItalic`: Determines whether the font is itallic. Read-only
- `Kumimoji`: Determines whether the numbers should ignore text eastern language-specific vertical text layout. Re
- `NormaliseHeight`: Determines whether the height of a text should be normalized. Read-only

---

## IBaseShapeLock

**Full Name**: `Aspose.Slides.IBaseShapeLock`

**Description**: Represents Shape lock (disabled operation).

**Key Members**:

*Propertys*:
- `NoLocks`: Return true if all lock-flags are disabled. Read-only

---

## IBaseSlide

**Full Name**: `Aspose.Slides.IBaseSlide`

**Description**: Represents common data for all slide types.

**Key Members**:

*Propertys*:
- `Shapes`: Returns the shapes of a slide. Read-only
- `Controls`: Returns the collection of ActiveX controls on a slide. Read-only
- `Name`: Returns or sets the name of a slide. Read/write
- `SlideId`: Returns the ID of a slide. Read-only
- `CustomData`: Returns the slide's custom data. Read-only
- `Timeline`: Returns animation timeline object. Read-only
- `SlideShowTransition`: Returns the TransitionEx object which contains information about how the specified slide advances du
- `Background`: Returns slide's background. Read-only
- `HyperlinkQueries`: Provides easy access to contained hyperlinks. Read-only
- `ShowMasterShapes`: Specifies if shapes on the master slide should be shown on slides or not. For master slide itself th

*Methods*:
- `FindShapeByAltText`: Finds first occurrence of a shape with the specified alternative text.
- `JoinPortionsWithSameFormatting`: Joins runs with same formatting in all paragraphs in all acceptable shapes.
- `Equals`: Determines whether the two IBaseSlide instances are equal. Returning value is calculated based on sl

---

## IBaseSlideHeaderFooterManager

**Full Name**: `Aspose.Slides.IBaseSlideHeaderFooterManager`

**Description**: Represents manager which holds behavior of the footer, date-time, page number placeholders for all slide types.

**Key Members**:

*Propertys*:
- `IsFooterVisible`: Gets value indicating that a footer placeholder is present. Read
- `IsSlideNumberVisible`: Gets value indicating that a page number placeholder is present. Read
- `IsDateTimeVisible`: Gets value indicating that a date-time placeholder is present. Read
- `AsIBaseHeaderFooterManager`: Returns IBaseHeaderFooterManager interface.

*Methods*:
- `SetFooterVisibility`: Changes slide footer placeholder visibility.
- `SetSlideNumberVisibility`: Changes slide page number placeholder visibility.
- `SetDateTimeVisibility`: Changes slide date-time placeholder visibility.
- `SetFooterText`: Sets text to slide footer placeholder.
- `SetDateTimeText`: Sets text to slide date-time placeholder.

---

## IBaseTableFormatEffectiveData

**Full Name**: `Aspose.Slides.IBaseTableFormatEffectiveData`

**Description**: Base interface for immutable objects which contain effective table formatting properties.

**Key Members**:

*Propertys*:
- `FillFormat`: Returns fill format effective value. Read-only
- `BorderLeft`: Returns left border line format effective value. Read-only
- `BorderTop`: Returns top border line format effective value. Read-only
- `BorderRight`: Returns right border line format effective value. Read-only
- `BorderBottom`: Returns bottom border line format effective value. Read-only
- `BorderDiagonalDown`: Returns down diagonal line format effective value. Read-only
- `BorderDiagonalUp`: Returns up diagonal line format effective value. Read-only

---

## IBlobManagementOptions

**Full Name**: `Aspose.Slides.IBlobManagementOptions`

**Description**: A Binary Large Object (BLOB) is a binary data stored as a single entity - i.e. BLOB can be an audio, video or presentation itself. A number of techniques are used to optimize memory consumption while working with BLOBs - which was already stored in the presentation or be added later programmatically. Using

**Key Members**:

*Propertys*:
- `PresentationLockingBehavior`: This property defines if an instance of the Presentation class can be an owner of the source - file 
- `IsTemporaryFilesAllowed`: This property defines if temporary files can be created while working with BLOBs, what greatly decre
- `TempFilesRootPath`: The root path where temporary files will be created. System temorary directory will be used by defau
- `MaxBlobsBytesInMemory`: Defines the maximum total size (in bytes) that all BLOBs may occupy in memory. By default, all BLOBs

---

## IBulkTextFormattable

**Full Name**: `Aspose.Slides.IBulkTextFormattable`

**Description**: Represents an object with possibility of bulk setting child text elements' formats.

**Key Members**:

*Methods*:
- `SetTextFormat`: Sets defined portion format properties to all element's portions.
- `SetTextFormat`: Sets defined paragraph format properties to all element's paragraphs.
- `SetTextFormat`: Sets defined text frame format properties to all element's text frames.

---

## IBulletFormat

**Full Name**: `Aspose.Slides.IBulletFormat`

**Description**: Represents paragraph bullet formatting properties.

**Key Members**:

*Propertys*:
- `Type`: Returns or sets the bullet type of a paragraph with no inheritance. Read/write
- `Char`: Returns or sets the bullet char of a paragraph with no inheritance. Read/write
- `Font`: Returns or sets the bullet font of a paragraph with no inheritance. Read/write
- `Height`: Returns or sets the bullet height of a paragraph with no inheritance. Value float.NaN determines tha
- `Color`: Returns the color format of a bullet of a paragraph with no inheritance. Read-only
- `Picture`: Returns the picture used as a bullet in a paragraph with no inheritance. Read-only
- `NumberedBulletStartWith`: Returns or sets the first number which is used for group of numbered bullets with no inheritance. Re
- `NumberedBulletStyle`: Returns or sets the style of a numbered bullet with no inheritance. Read/write
- `IsBulletHardColor`: Determines whether the bullet has own color or inherits it from the first portion in the paragraph.
- `IsBulletHardFont`: Determines whether the bullet has own font or inherits it from the first portion in the paragraph.

*Methods*:
- `ApplyDefaultParagraphIndentsShifts`: Sets default non-zero shifts for effective paragraph Indent and MarginLeft when bullets is enabled (
- `GetEffective`: Gets effective bullet formatting data with the inheritance applied.

---

## IBulletFormatEffectiveData

**Full Name**: `Aspose.Slides.IBulletFormatEffectiveData`

**Description**: Immutable object which contains effective paragraph bullet formatting properties.

**Key Members**:

*Propertys*:
- `Type`: Returns the bullet type of a paragraph. Read-only
- `Char`: Returns the bullet char of a paragraph. Read-only
- `ActualBulletValue`: Returns actual bullet value for parent paragraph. Read-only
- `Font`: Returns the bullet font of a paragraph. Read-only
- `Height`: Returns the bullet height of a paragraph. Read-only
- `NumberedBulletStartWith`: Returns the first number which is used for group of numbered bullets. Read-only
- `NumberedBulletStyle`: Returns the style of a numbered bullet. Read-only
- `IsBulletHardColor`: Determines whether the bullet has own color or inherits it from the first portion in the paragraph. 
- `IsBulletHardFont`: Determines whether the bullet has own font or inherits it from the first portion in the paragraph. R
- `Picture`: Returns the picture used as a bullet in the paragraph. Read-only

---

## ICamera

**Full Name**: `Aspose.Slides.ICamera`

**Description**: Represents Camera.

**Key Members**:

*Propertys*:
- `CameraType`: Camera type Read/write
- `FieldOfViewAngle`: Camera FOV (0-180 deg, field of View) Read/write
- `Zoom`: Camera zoom (positive value in percentage) Read/write

*Methods*:
- `SetRotation`: A rotation is defined through the use of a latitude coordinate, a longitude coordinate, and a revolu
- `GetRotation`: A rotation is defined through the use of a latitude coordinate, a longitude coordinate, and a revolu

---

## ICameraEffectiveData

**Full Name**: `Aspose.Slides.ICameraEffectiveData`

**Description**: Immutable object which contains effective camera properties.

**Key Members**:

*Propertys*:
- `CameraType`: Camera type. Read-only
- `FieldOfViewAngle`: Camera FOV (0-180 deg, field of View). Read-only
- `Zoom`: Camera zoom (positive value in percentage). Read-only

*Methods*:
- `GetRotation`: A rotation is defined through the use of a latitude coordinate, a longitude coordinate, and a revolu

---

## ICaptions

**Full Name**: `Aspose.Slides.ICaptions`

**Description**: Represents the WebVTT closed captions.

**Key Members**:

*Propertys*:
- `CaptionId`: Returns the globally unique identifier (GUID) of the closed captions. Read-only
- `Label`: Returns or sets the label of the closed captions. Read/write
- `BinaryData`: Returns the binary data of the closed captions. Read-only
- `DataAsString`: Returns the closed captions data as UTF-8 encoded string Read-only

---

## ICaptionsCollection

**Full Name**: `Aspose.Slides.ICaptionsCollection`

**Description**: Represents a collection of the closed captions.

**Key Members**:

*Propertys*:
- `Item`: Returns the closed captions at the specified index. Read-only
- `Count`: Returns the number of elements in the collection. Read-only

*Methods*:
- `Add`: Adds WebVTT closed captions to the end of the collection.
- `Add`: Adds WebVTT closed captions to the end of the collection from a stream.
- `Remove`: Removes the specified closed captions from the collection.
- `RemoveAt`: Removes the closed captions at the specified index.
- `Clear`: Removes all closed captions from the collection.

---

## ICell

**Full Name**: `Aspose.Slides.ICell`

**Description**: Represents a cell in a table.

**Key Members**:

*Propertys*:
- `OffsetX`: Returns a distance from left side of a table to left side of a cell. Read-only
- `OffsetY`: Returns a distance from top side of a table to top side of a cell. Read-only
- `FirstRowIndex`: Returns an index of first row, covered by the cell. Read-only
- `FirstColumnIndex`: Returns an index of first column, covered by the cell. Read-only
- `Width`: Returns the width of the cell. Read-only
- `Height`: Returns the height of the cell. Read-only
- `MinimalHeight`: Returns the minimum height of a cell. This is a sum of minimal heights of all rows cowered by the ce
- `MarginLeft`: Returns or sets the left margin in a TextFrame. Read/write
- `MarginRight`: Returns or sets the right margin in a TextFrame. Read/write
- `MarginTop`: Returns or sets the top margin in a TextFrame. Read/write

---

## ICellCollection

**Full Name**: `Aspose.Slides.ICellCollection`

**Description**: Represents a collection of cells.

**Key Members**:

*Propertys*:
- `Item`: Returns a cell by it's position. Read-only
- `AsISlideComponent`: Allows to get base ISlideComponent interface. Read-only

---

## ICellFormat

**Full Name**: `Aspose.Slides.ICellFormat`

**Description**: Represents format of a table cell.

**Key Members**:

*Propertys*:
- `FillFormat`: Returns a cell fill properties object. Read-only
- `BorderLeft`: Returns a left border line properties object. Read-only
- `BorderTop`: Returns a top border line properties object. Read-only
- `BorderRight`: Returns a right border line properties object. Read-only
- `BorderBottom`: Returns a bottom border line properties object. Read-only
- `BorderDiagonalDown`: Returns a top-left to bottom-right diagonal line properties object. Read-only
- `BorderDiagonalUp`: Returns a bottom-left to top-right diagonal line properties object. Read-only
- `Transparency`: Gets or sets the transparency of the fill color. Read/write

*Methods*:
- `GetEffective`: Gets effective table cell formatting properties with inheritance and table styles applied.

---

## ICellFormatEffectiveData

**Full Name**: `Aspose.Slides.ICellFormatEffectiveData`

**Description**: Immutable object which contains effective table cell formatting properties.

**Key Members**:

*Propertys*:
- `Transparency`: Gets the transparency of the fill color. Read
- `AsIBaseTableFormatEffectiveData`: Allows to get base IBaseTableFormatEffectiveData interface. Read-only

---

## IColorFormat

**Full Name**: `Aspose.Slides.IColorFormat`

**Description**: Represents a color used in a presentation.

**Key Members**:

*Propertys*:
- `ColorType`: Returns or sets the color definition method. Read/write
- `Color`: Returns resulting color (with all color transformations applied). Sets RGB colors and clears all col
- `PresetColor`: Returns or sets the color preset. Read/write
- `SystemColor`: Returns or sets the color identified by the system color table. Read/write
- `SchemeColor`: Returns or sets the color identified by a color scheme. Read/write
- `R`: Returns or sets the red component of a color. All color transformations are ignored. Read/write
- `G`: Returns or sets the green component of a color. All color transformations are ignored. Read/write
- `B`: Returns or sets the blue component of a color. All color transformations are ignored. Read/write
- `FloatR`: Returns or sets the red component of a color. All color transformations are ignored. Read/write
- `FloatG`: Returns or sets the green component of a color. All color transformations are ignored. Read/write

*Methods*:
- `ToString`: Returns a
- `CopyFrom`: Copy color format from "color".

---

## IColorOperation

**Full Name**: `Aspose.Slides.IColorOperation`

**Description**: Represents different color operations used for color transformations.

**Key Members**:

*Propertys*:
- `OperationType`: Returns or sets the type of an operation. Read-only
- `Parameter`: Returns a parameter of an operation. Read-only

---

## IColorOperationCollection

**Full Name**: `Aspose.Slides.IColorOperationCollection`

**Description**: Represents a collection of color transform operations.

**Key Members**:

*Propertys*:
- `Item`: Returns or sets the operation at the specified index. Read/write

*Methods*:
- `Add`: Adds a new operation to the end of collection.
- `Add`: Adds a new operation to the end of collection.
- `Insert`: Inserts the new operation to a collection.
- `Insert`: Inserts the new operation to a collection.
- `RemoveAt`: Removes the color operation from a collection.
- `Clear`: Removes all color operations.

---

## IColumn

**Full Name**: `Aspose.Slides.IColumn`

**Description**: Represents a column in a table.

**Key Members**:

*Propertys*:
- `Width`: Returns or sets the width of a column. Read/write
- `ColumnFormat`: Returns the ColumnFormat object that contains formatting properties for this column. Read-only
- `AsICellCollection`: Allows to get base ICellCollection interface. Read-only
- `AsIBulkTextFormattable`: Allows to get base IBulkTextFormattable interface. Read-only

---

## IColumnCollection

**Full Name**: `Aspose.Slides.IColumnCollection`

**Description**: Represents collection of columns in a table.

**Key Members**:

*Propertys*:
- `Item`: Returns the column at the specified index. Read-only

*Methods*:
- `AddClone`: Creates a copy of the specified template row and inserts it at the bottom of a table.
- `InsertClone`: Creates a copy of the specified template column and insert it at the specified position in a table.
- `RemoveAt`: Removes a column at the specified position from a table.

---

## IColumnFormat

**Full Name**: `Aspose.Slides.IColumnFormat`

**Description**: Represents format of a table column.

**Key Members**:

*Methods*:
- `GetEffective`: Gets effective table column formatting properties with inheritance and table styles applied.

---

## IColumnFormatEffectiveData

**Full Name**: `Aspose.Slides.IColumnFormatEffectiveData`

**Description**: Immutable object which contains effective table column formatting properties.

**Key Members**:

*Propertys*:
- `AsIBaseTableFormatEffectiveData`: Allows to get base IBaseTableFormatEffectiveData interface. Read-only

---

## IComment

**Full Name**: `Aspose.Slides.IComment`

**Description**: Represents a comment on a slide.

**Key Members**:

*Propertys*:
- `Text`: Returns or sets the plain text of a slide comment. Read/write
- `CreatedTime`: Returns or sets the time of a comment creation. Setting this property to
- `Slide`: Returns or sets the parent slide of a comment. Read-only
- `Author`: Returns the author of a comment. Read-only
- `Position`: Returns or sets the position of a comment on a slide. Read/write
- `ParentComment`: Gets or sets parent comment. Read/write

*Methods*:
- `Remove`: Removes comment and all its replies from the parent collection.

---

## ICommentAuthor

**Full Name**: `Aspose.Slides.ICommentAuthor`

**Description**: Represents an author of comments.

**Key Members**:

*Propertys*:
- `Name`: Returns or sets the author's name. Read/write
- `Initials`: Returns or sets the authors initials. Read/write
- `Comments`: Returns the collection of comments made by this author. Read-only

*Methods*:
- `Remove`: Removes the author from the parent collection.

---

## ICommentAuthorCollection

**Full Name**: `Aspose.Slides.ICommentAuthorCollection`

**Description**: Represents a collection of comment authors.

**Key Members**:

*Propertys*:
- `Item`: Gets the element at the specified index. Read-only

*Methods*:
- `AddAuthor`: Add new author at the end of a collection.
- `ToArray`: Creates and returns an array with all authors.
- `FindByName`: Find author in a collection by name.
- `FindByNameAndInitials`: Find author in a collection by name and initials.
- `RemoveAt`: Removes the author at the specified index of the collection.
- `Remove`: Removes the first occurrence of the specified author in a collection.
- `Clear`: Removes all authors from a collection.

---

## ICommentCollection

**Full Name**: `Aspose.Slides.ICommentCollection`

**Description**: Represents a collection of comments of one author.

**Key Members**:

*Propertys*:
- `Item`: Gets the element at the specified index. Read-only

*Methods*:
- `AddComment`: Add new comment at the end of a collection.
- `AddModernComment`: Add new modern comment at the end of a collection.
- `InsertComment`: Insert new comment to a collection at the specified index.
- `InsertModernComment`: Insert new modern comment to a collection at the specified index.
- `ToArray`: Creates and returns an array with all comments.
- `ToArray`: Creates and returns an array with all comments from the specified range.
- `RemoveAt`: Removes the element at the specified index in a collection.
- `Remove`: Removes the first occurrence of the specified comment in a collection.
- `Clear`: Removes all comments from a collection.

---

## ICommonSlideViewProperties

**Full Name**: `Aspose.Slides.ICommonSlideViewProperties`

**Description**: Represents common slide view properties.

**Key Members**:

*Propertys*:
- `Scale`: Specifies the view scaling ratio in percentages. Read/write
- `VariableScale`: Specifies that the view content should automatically scale to best fit the current window size. Read
- `DrawingGuides`: Returns the collection of the drawing guides. Read-only

---

## IConnector

**Full Name**: `Aspose.Slides.IConnector`

**Description**: Represents a connector.

**Key Members**:

*Propertys*:
- `ShapeLock`: Returns shape's locks. Read-only
- `ConnectorLock`: Returns Connector's locks. Read-only
- `StartShapeConnectedTo`: Returns or sets the shape to attach the beginning of the connector to. Read/write
- `EndShapeConnectedTo`: Returns or sets the shape to attach the end of the connector to. Read/write
- `StartShapeConnectionSiteIndex`: Returns or sets the index of connection site for start shape. Read/write
- `EndShapeConnectionSiteIndex`: Returns or sets the index of connection site for end shape. Read/write
- `AsIGeometryShape`: Allows to get base IGeometryShape interface. Read-only

*Methods*:
- `Reroute`: Reroutes connector so that it take the shortest possible path between the shapes it connect.

---

## IConnectorLock

**Full Name**: `Aspose.Slides.IConnectorLock`

**Description**: Determines which operations are disabled on the parent Connector.

**Key Members**:

*Propertys*:
- `GroupingLocked`: Determines whether an adding this shape to a group is forbidden. Read/write
- `SelectLocked`: Determines whether a selecting this shape is forbidden. Read/write
- `RotateLocked`: Determines whether a changing rotation angle of this shape is forbidden. Read/write
- `AspectRatioLocked`: Determines whether a shape have to preserve aspect ratio on resizing. Read/write
- `PositionMove`: Determines whether a moving this shape is forbidden. Read/write
- `SizeLocked`: Determines whether a resizing this shape is forbidden. Read/write
- `EditPointsLocked`: Determines whether a direct changing of contour of this shape is forbidden. Read/write
- `AdjustHandlesLocked`: Determines whether a changing adjust values is forbidden. Read/write
- `ArrowheadsLocked`: Determines whether a changing arrowheads is forbidden. Read/write
- `ShapeTypeLocked`: Determines whether a changing of a shape type is forbidden. Read/write

---

## IControl

**Full Name**: `Aspose.Slides.IControl`

**Description**: Represents an ActiveX control.

**Key Members**:

*Propertys*:
- `Name`: Returns the name of this control. Read/write
- `ClassId`: Gets class id of this control. Read-only
- `SubstitutePictureFormat`: Returns ControlEx image fill properties object. Read-only
- `Frame`: Returns or sets control's frame. Read/write
- `Properties`: Returns a collection of ActiveX properties. Read-only
- `Persistence`: Gets the method used to store properties of the ActiveX control. Read only
- `ActiveXControlBinary`: Specifies the persistence of an ActiveX control when the method used to persist is either PersistStr
- `AsISlideComponent`: Allows to get base ISlideComponent interface. Read-only

---

## IControlCollection

**Full Name**: `Aspose.Slides.IControlCollection`

**Description**: A collection of ActiveX controls.

**Key Members**:

*Propertys*:
- `Item`: Returns a control at the specified position.

*Methods*:
- `Remove`: Removes an ActiveX control from the collection.
- `RemoveAt`: Removes an ActiveX control stored at specified position from the collection.
- `Clear`: Removes all controls from the collection.
- `AddControl`: Creates and adds a new control to the collection.

---

## IControlPropertiesCollection

**Full Name**: `Aspose.Slides.IControlPropertiesCollection`

**Description**: A collection of ActiveX controls.

**Key Members**:

*Propertys*:
- `Count`: Returns a number of properties in the collection. Read-only
- `Item`: Returns or sets property.
- `NamesOfProperties`: Returns a number of properties in the collection. Read-only
- `AsIEnumerable`: Returns IEnumerable interface. Read-only

*Methods*:
- `Add`: Adds a property to the collection.
- `Remove`: Removes a property with the specified name.
- `Clear`: Removes all properties.

---

## ICustomData

**Full Name**: `Aspose.Slides.ICustomData`

**Description**: Represents container for custom data.

**Key Members**:

*Propertys*:
- `Tags`: Returns the Customer Data Tags collection. Read-only
- `CustomXmlParts`: Returns the custom xml parts collection. Read-only

---

## ICustomXmlPart

**Full Name**: `Aspose.Slides.ICustomXmlPart`

**Description**: Represents custom xml part.

**Key Members**:

*Propertys*:
- `XmlAsString`: Returns or sets xml data as UTF-8 string. Read/write
- `XmlData`: Returns or sets xml data. Read/write
- `ItemId`: Specifies a globally unique identifier (GUID) that uniquely identifies a single custom XML part with
- `NamespaceSchemas`: Returns the collection XML schemas that are associated with the custom XML part. Read-only

*Methods*:
- `Remove`: Removes the custom xml part from the presentation.

---

## ICustomXmlPartCollection

**Full Name**: `Aspose.Slides.ICustomXmlPartCollection`

**Description**: Represents collection of custom xml parts.

**Key Members**:

*Propertys*:
- `Item`: Returns the element at the specified index.

*Methods*:
- `Add`: Adds new custom xml part.
- `Add`: Adds new custom xml part.
- `Add`: Adds new custom xml part.
- `RemoveAt`: Removes custom xml part at the specified index.
- `Remove`: Removes the first occurrence of a specific object from the collection.
- `Clear`: Removes all items from the collection.

---

## IDigitalSignature

**Full Name**: `Aspose.Slides.IDigitalSignature`

**Description**: Digital signature in signed file.

**Key Members**:

*Propertys*:
- `Certificate`: Certificate object that was used to sign the document. Read-only
- `IsValid`: If this digital signature is valid and the document has not been tampered with, this value will be t
- `SignTime`: The time when the document was signed. Read-only
- `Comments`: The purpose of signature. Read/write

---

## IDigitalSignatureCollection

**Full Name**: `Aspose.Slides.IDigitalSignatureCollection`

**Description**: Represents a collection of digital signatures attached to a document.

**Key Members**:

*Propertys*:
- `Item`: Returns the signature by index.

*Methods*:
- `Add`: Adds the signature at the end of collection.
- `RemoveAt`: Removes the signature at the specified index.
- `Clear`: Removes all signatures from collection.

---

## IDocumentProperties

**Full Name**: `Aspose.Slides.IDocumentProperties`

**Description**: Represents properties of a presentation.

**Key Members**:

*Propertys*:
- `AppVersion`: Returns the app version. Read-only
- `NameOfApplication`: Returns or sets the name of the application. Read/write
- `Company`: Returns or sets the company property. Read/write
- `Manager`: Returns or sets the manager property. Read/write
- `PresentationFormat`: Returns or sets the intended format of a presentation. Read/write
- `SharedDoc`: Determines whether the presentation is shared between multiple people. Read/write
- `ApplicationTemplate`: Returns or sets the template of a application. Read/write
- `TotalEditingTime`: Total editing time of a presentation. Read/write
- `Title`: Returns or sets the title of a presentation. Read/write
- `Subject`: Returns or sets the subject of a presentation. Read/write

---

## IDrawingGuide

**Full Name**: `Aspose.Slides.IDrawingGuide`

**Description**: Represents an adjustable drawing guide.

**Key Members**:

*Propertys*:
- `Orientation`: Returns or sets orientation of the drawing guide. Read/write
- `Position`: Returns or sets position of the drawing guide in points from the top, left corner of the slide. Read

---

## IDrawingGuidesCollection

**Full Name**: `Aspose.Slides.IDrawingGuidesCollection`

**Description**: Represents a collection of the adjustable drawing guides.

**Key Members**:

*Propertys*:
- `Item`: Returns the drawing guide by index. Read-only
- `Count`: Gets the number of all elements in the collection. Read-only

*Methods*:
- `Add`: Adds the drawing guide at the end of the collection.
- `RemoveAt`: Removes the drawing guide at the specified index.
- `Clear`: Removes all elements from the collection.

---

## IEffectFormat

**Full Name**: `Aspose.Slides.IEffectFormat`

**Description**: Represents effect properties of shape.

**Key Members**:

*Propertys*:
- `IsNoEffects`: Returns true if all effects are disabled (as just created, default EffectFormat object). Read-only
- `BlurEffect`: Blur effect. Read/write
- `FillOverlayEffect`: Fill overlay effect. Read/write
- `GlowEffect`: Glow effect. Read/write
- `InnerShadowEffect`: Inner shadow. Read/write
- `OuterShadowEffect`: Outer shadow. Read/write
- `PresetShadowEffect`: Preset shadow. Read/write
- `ReflectionEffect`: Reflection. Read/write
- `SoftEdgeEffect`: Soft edge. Read/write

*Methods*:
- `SetBlurEffect`: Sets blur effect.
- `EnableFillOverlayEffect`: Enables fill overlay effect.
- `EnableGlowEffect`: Enables glow effect.
- `EnableInnerShadowEffect`: Enables inner shadow effect.
- `EnableOuterShadowEffect`: Enables outer shadow effect.
- `EnablePresetShadowEffect`: Enables preset shadows effect.
- `EnableReflectionEffect`: Enables reflection effect.
- `EnableSoftEdgeEffect`: Enables soft edge effect.
- `DisableBlurEffect`: Disables blur effect.
- `DisableFillOverlayEffect`: Disables fill overlay effect.

---

## IEffectFormatEffectiveData

**Full Name**: `Aspose.Slides.IEffectFormatEffectiveData`

**Description**: Imutable object which contains effective effect formatting properties.

**Key Members**:

*Propertys*:
- `IsNoEffects`: Returns true if all effects are disabled (as just created, default EffectFormat object). Read-only
- `BlurEffect`: Blur effect. Read-only
- `FillOverlayEffect`: Fill overlay effect. Read-only
- `GlowEffect`: Glow effect. Read-only
- `InnerShadowEffect`: Inner shadow. Read-only
- `OuterShadowEffect`: Outer shadow. Read-only
- `PresetShadowEffect`: Preset shadow. Read-only
- `ReflectionEffect`: Reflection. Read-only
- `SoftEdgeEffect`: Soft edge. Read-only
- `AsIEffectParamSource`: Allows to get base IEffectParamSource interface. Read-only

---

## IEffectParamSource

**Full Name**: `Aspose.Slides.IEffectParamSource`

**Description**: Auxiliary effect parameters interface.

---

## IField

**Full Name**: `Aspose.Slides.IField`

**Description**: Represents a field.

**Key Members**:

*Propertys*:
- `Type`: Returns or sets field's type. Read/write
- `AsISlideComponent`: Allows to get base ISlideComponent interface. Read-only

---

## IFieldType

**Full Name**: `Aspose.Slides.IFieldType`

**Description**: Represents a type of field. This value determines which text will be set to the field portion when it will be updated.

**Key Members**:

*Propertys*:
- `InternalString`: Returns the internal name of this FieldTypeEx object. Read/write

---

## IFillFormat

**Full Name**: `Aspose.Slides.IFillFormat`

**Description**: Represents a fill formatting options.

**Key Members**:

*Propertys*:
- `FillType`: Returns or sets the type of filling. Read/write
- `SolidFillColor`: Returns the fill color. Read-only
- `GradientFormat`: Returns the gradient fill format. Read-only
- `PatternFormat`: Returns the pattern fill format. Read-only
- `PictureFillFormat`: Returns the picture fill format. Read-only
- `RotateWithShape`: Determines whether the fill should be rotated with shape. Read/write
- `AsIFillParamSource`: Allows to get base IFillParamSource interface. Read-only

*Methods*:
- `GetEffective`: Gets effective fill formatting data with the inheritance applied.

---

## IFillFormatEffectiveData

**Full Name**: `Aspose.Slides.IFillFormatEffectiveData`

**Description**: Immutable object which contains effective fill formatting properties.

**Key Members**:

*Propertys*:
- `FillType`: Returns the type of filling. Read-only
- `SolidFillColor`: Returns the fill color. Read-only
- `GradientFormat`: Returns the gradient fill format. Read-only
- `PatternFormat`: Returns the pattern fill format. Read-only
- `PictureFillFormat`: Returns the picture fill format. Read-only
- `RotateWithShape`: Determines whether the fill should be rotated with shape. Read-only
- `AsIFillParamSource`: Returns IFillParamSource interface. Read-only

---

## IFillParamSource

**Full Name**: `Aspose.Slides.IFillParamSource`

**Description**: Auxiliary fill parameters interface.

---

## IFindResultCallback

**Full Name**: `Aspose.Slides.IFindResultCallback`

**Description**: Callback interface used to getting search text result.

**Key Members**:

*Methods*:
- `FoundResult`: Callback method that receives data about the found text.

---

## IFontData

**Full Name**: `Aspose.Slides.IFontData`

**Description**: Represents a font definition.

**Key Members**:

*Propertys*:
- `FontName`: Returns the font name. Read-only

*Methods*:
- `GetFontName`: Returns the font name, replacing theme referrence with an actual font used.

---

## IFontDataFactory

**Full Name**: `Aspose.Slides.IFontDataFactory`

**Description**: FontData factory interface

**Key Members**:

*Methods*:
- `CreateFontData`: Creates FontData with specified font name.

---

## IFontFallBackRule

**Full Name**: `Aspose.Slides.IFontFallBackRule`

**Description**: Represents font fallback rule

**Key Members**:

*Propertys*:
- `RangeStartIndex`: Get first index of continuous unicode range.
- `RangeEndIndex`: Get last index of continuous unicode range.
- `Count`: Gets the number of fonts actually defined for range.
- `Item`: Gets the font name at the specified index.

*Methods*:
- `AddFallBackFonts`: Adds a new font(s) to the list of FallBack fonts.
- `AddFallBackFonts`: Adds a new fonts to the list of FallBack fonts.
- `Clear`: Removes all fonts from the list.
- `Remove`: Removes the first occurrence of a specific FallBack font from the list.
- `RemoveAt`: Removes the FallBack font at the specified index of the list.
- `ToArray`: Creates and returns an array with all FallBack fonts for this rule.
- `ToArray`: Creates and returns an array with all FallBack fonts from the specified range in list.
- `IndexOf`: Returns an index of the specified rule in the collection.

---

## IFontFallBackRulesCollection

**Full Name**: `Aspose.Slides.IFontFallBackRulesCollection`

**Description**: Represents a collection of FontFallBack rules, defined by user

**Key Members**:

*Propertys*:
- `Item`: Gets the rule at the specified index. Read-only

*Methods*:
- `Add`: Add a new FallBack rule to the end of the collection.
- `Remove`: Removes the first occurrence of a specific FallBack rule from the collection.

---

## IFontSources

**Full Name**: `Aspose.Slides.IFontSources`

**Description**: Provides file and memory sources for external fonts.

**Key Members**:

*Propertys*:
- `FontFolders`: Folders containing font files. All font files located in these folders are included in the collectio
- `MemoryFonts`: A collection of fonts represented as byte arrays.

---

## IFontSubstRule

**Full Name**: `Aspose.Slides.IFontSubstRule`

**Description**: Represents font subtituition information

**Key Members**:

*Propertys*:
- `SourceFont`: Font to substitute Read-only
- `DestFont`: Font to use for substitution Read-only
- `ReplaceFontCondition`: Rule to apply for substitution Read-only

---

## IFontSubstRuleCollection

**Full Name**: `Aspose.Slides.IFontSubstRuleCollection`

**Description**: Represents collection of fonts substitution.

**Key Members**:

*Propertys*:
- `Item`: Gets the element at the specified index.

*Methods*:
- `Add`: Adds the new font substitution rule to the collection
- `Remove`: Removes the first occurrence of a specific object from the collection.

---

## IFonts

**Full Name**: `Aspose.Slides.IFonts`

**Description**: Represents fonts collection.

**Key Members**:

*Propertys*:
- `LatinFont`: Returns or sets the Latin font. Read/write
- `EastAsianFont`: Returns or sets the East Asian font. Read/write
- `ComplexScriptFont`: Returns or sets the complex script font. Read/write

---

## IFontsEffectiveData

**Full Name**: `Aspose.Slides.IFontsEffectiveData`

**Description**: Immutable object which contains effective fonts set.

**Key Members**:

*Propertys*:
- `LatinFont`: Returns the Latin font. Read-only
- `EastAsianFont`: Returns the East Asian font. Read-only
- `ComplexScriptFont`: Returns the complex script font. Read-only

---

## IFontsLoader

**Full Name**: `Aspose.Slides.IFontsLoader`

**Description**: Class for loading custom fonts defined by user. Should be used before creating any presentation objects.

---

## IFontsManager

**Full Name**: `Aspose.Slides.IFontsManager`

**Description**: Manages fonts across the presentation.

**Key Members**:

*Propertys*:
- `FontSubstRuleList`: Font substitutions to use when rendering Read/write
- `FontFallBackRulesCollection`: Represents a user's collection of FontFallBack rules for managing of collections of fonts for proper

*Methods*:
- `GetFonts`: Returns the fonts used in the presentation
- `GetSubstitutions`: Gets the information about fonts that will be replaced on the presentation's rendering.
- `GetEmbeddedFonts`: Returns the fonts embedded in the presentation
- `RemoveEmbeddedFont`: Removes the embedded font
- `AddEmbeddedFont`: Adds the embedded font.
- `AddEmbeddedFont`: Adds the embedded font
- `ReplaceFont`: Replace font in presentation
- `ReplaceFont`: Replace font in presentation using information provided in
- `ReplaceFont`: Replace font in presentation using information provided in collection of
- `GetFontBytes`: Retrieves the byte array representing the font data for a specified font style and font data.

---

## IFormatFactory

**Full Name**: `Aspose.Slides.IFormatFactory`

**Description**: Allows to create formats via COM interface.

**Key Members**:

*Methods*:
- `CreatePortionFormat`: Creates new
- `CreateParagraphFormat`: Creates new
- `CreateTextFrameFormat`: Creates new

---

## IGenericCloneable`1

**Full Name**: `Aspose.Slides.IGenericCloneable`1`

**Description**: Represents generic version of ICloneable

**Key Members**:

*Propertys*:
- `AsICloneable`: Returns ICloneable interface.

*Methods*:
- `CloneT`: Creates a new object that is a copy of the current instance.

---

## IGenericCollection`1

**Full Name**: `Aspose.Slides.IGenericCollection`1`

**Description**: Auxiliary generic collection interface.

**Key Members**:

*Propertys*:
- `AsICollection`: Returns ICollection interface.
- `AsIEnumerable`: Returns IEnumerable interface. Read-only

---

## IGeometryPath

**Full Name**: `Aspose.Slides.IGeometryPath`

**Description**: Represents geometry path of GeometryShape

**Key Members**:

*Propertys*:
- `PathData`: Returns geometry path of GeometryShape as an array of path segments.
- `FillMode`: Sets fill mode
- `Stroke`: Sets stroke appearance

*Methods*:
- `RemoveAt`: Removes segment at the specified index of the geometry path.
- `LineTo`: Adds line to the end of the path
- `LineTo`: Adds line to the end of the path
- `LineTo`: Adds line to the specified place of the path
- `LineTo`: Adds line to the specified place of the path
- `CubicBezierTo`: Adds cubic Bezier curve at the end the path
- `CubicBezierTo`: Adds cubic Bezier curve at the end the path
- `CubicBezierTo`: Adds cubic Bezier curve to the specified place of the path
- `CubicBezierTo`: Adds cubic Bezier curve to the specified place of the path
- `QuadraticBezierTo`: Adds quadratic Bezier curve at the end the path

---

## IGeometryShape

**Full Name**: `Aspose.Slides.IGeometryShape`

**Description**: Represents the parent class for all geometric shapes.

**Key Members**:

*Propertys*:
- `ShapeStyle`: Returns shape's style object. Read-only
- `ShapeType`: Returns or sets the geometry preset type. Note: on value changing all adjustment values will reset t
- `Adjustments`: Returns a collection of shape's adjustment values. Read-only
- `AsIShape`: Allows to get base IShape interface. Read-only

*Methods*:
- `GetGeometryPaths`: Returns the copy of path of the geometry shape. Coordinates are relative to the left top corner of t
- `SetGeometryPath`: Updates shape geometry from
- `SetGeometryPaths`: Updates shape geometry from array of
- `CreateShapeElements`: Creates and returns array of shape's elements.

---

## IGlobalLayoutSlideCollection

**Full Name**: `Aspose.Slides.IGlobalLayoutSlideCollection`

**Description**: Represents a collection of all layout slides in presentation. Extends ILayoutSlideCollection interface with methods for adding/cloning layout slides in context of uniting of the individual collections of master's layout slides.

**Key Members**:

*Propertys*:
- `AsILayoutSlideCollection`: Returns ILayoutSlideCollection interface. Read-only

*Methods*:
- `AddClone`: Adds a copy of a specified layout slide to the presentation.
- `AddClone`: Adds a copy of a specified layout slide to the presentation.
- `Add`: Adds a new layout slide to the presentation.

---

## IGradientFormat

**Full Name**: `Aspose.Slides.IGradientFormat`

**Description**: Represent a gradient format.

**Key Members**:

*Propertys*:
- `TileFlip`: Returns or sets the flipping mode for a gradient. Read/write
- `GradientDirection`: Returns or sets the style of a gradient. Read/write
- `LinearGradientAngle`: Returns or sets the angle of a gradient. Read/write
- `LinearGradientScaled`: Determines whether a gradient is scaled. Read/write
- `GradientShape`: Returns or sets the shape of a gradient. Read/write
- `GradientStops`: Returns the collection of gradient stops. Read-only
- `AsIFillParamSource`: Allows to get base IFillParamSource interface. Read-only

---

## IGradientFormatEffectiveData

**Full Name**: `Aspose.Slides.IGradientFormatEffectiveData`

**Description**: Imutable object which contains effective gradient filling properties.

**Key Members**:

*Propertys*:
- `TileFlip`: Returns the flipping mode for a gradient. Read-only
- `GradientDirection`: Returns the style of a gradient. Read-only
- `LinearGradientAngle`: Returns the angle of a gradient. Read-only
- `LinearGradientScaled`: Determines whether a gradient is scaled. Read-only
- `GradientShape`: Returns the shape of a gradient. Read-only
- `GradientStops`: Returns the collection of gradient stops. Read-only
- `AsIFillParamSource`: Allows to get base IFillParamSource interface. Read-only

---

## IGradientStop

**Full Name**: `Aspose.Slides.IGradientStop`

**Description**: Represents a gradient format.

**Key Members**:

*Propertys*:
- `Position`: Returns or sets the position (0..1) of a gradient stop. Read/write
- `Color`: Returns the color of a gradient stop. Read-only

---

## IGradientStopCollection

**Full Name**: `Aspose.Slides.IGradientStopCollection`

**Description**: Represnts a collection of gradient stops.

**Key Members**:

*Propertys*:
- `Item`: Returns the gradient stop by index.

*Methods*:
- `Add`: Creates the new gradient stop and adds it to the end of collection.
- `Add`: Creates the new gradient stop and adds it to the end of collection.
- `Add`: Creates the new gradient stop and adds it to the end of collection.
- `Insert`: Creates the new gradient stop and inserts it at the specified index to the collection.
- `Insert`: Creates the new gradient stop and inserts it at the specified index to the collection.
- `Insert`: Creates the new gradient stop and inserts it at the specified index to the collection.
- `RemoveAt`: Removes a gradient stop at the specified index.
- `Clear`: Removes all gradient stops from a collection.

---

## IGradientStopCollectionEffectiveData

**Full Name**: `Aspose.Slides.IGradientStopCollectionEffectiveData`

**Description**: Represents a collection of GradientStopDataEx objects.

**Key Members**:

*Propertys*:
- `Item`: Returns the gradient stop by index.

---

## IGradientStopEffectiveData

**Full Name**: `Aspose.Slides.IGradientStopEffectiveData`

**Description**: immutable object which represents a gradient stop.

**Key Members**:

*Propertys*:
- `Position`: Returns the position (0..1) of a gradient stop. Read-only
- `Color`: Returns the color of a gradient stop. Read-only

---

## IGraphicalObject

**Full Name**: `Aspose.Slides.IGraphicalObject`

**Description**: Represents abstract graphical object.

**Key Members**:

*Propertys*:
- `ShapeLock`: Returns shape's locks. Read-only
- `GraphicalObjectLock`: Returns shape's locks. Read-only
- `AsIShape`: Allows to get base IShape interface. Read-only

---

## IGraphicalObjectLock

**Full Name**: `Aspose.Slides.IGraphicalObjectLock`

**Description**: Determines which operations are disabled on the parent GraphicalObjectEx.

**Key Members**:

*Propertys*:
- `GroupingLocked`: Determines whether adding this shape to a group is forbidden. Read/write
- `DrilldownLocked`: Determines whether selecting subshapes of this object is forbidden. Read/write
- `SelectLocked`: Determines whether selecting this shape is forbidden. Read/write
- `AspectRatioLocked`: Determines whether shape have to preserve aspect ratio on resizing. Read/write
- `PositionLocked`: Determines whether moving this shape is forbidden. Read/write
- `SizeLocked`: Determines whether resizing this shape is forbidden. Read/write
- `AsIBaseShapeLock`: Allows to get base IBaseShapeLock interface. Read-only

---

## IGroupShape

**Full Name**: `Aspose.Slides.IGroupShape`

**Description**: Represents a group of shapes on a slide.

**Key Members**:

*Propertys*:
- `ShapeLock`: Returns shape's locks. Read-only
- `GroupShapeLock`: Returns shape's locks. Read-only
- `Shapes`: Returns the collection of shapes inside the group. Read-only
- `AsIShape`: Allows to get base IShape interface. Read-only

---

## IGroupShapeLock

**Full Name**: `Aspose.Slides.IGroupShapeLock`

**Description**: Determines which operations are disabled on the parent GroupShape.

**Key Members**:

*Propertys*:
- `GroupingLocked`: Determines whether adding this shape to a group is forbidden. Read/write
- `UngroupingLocked`: Determines whether splitting this groupshape is forbidden. Read/write
- `SelectLocked`: Determines whether selecting this shape is forbidden. Read/write
- `RotationLocked`: Determines whether changing rotation angle of this shape is forbidden. Read/write
- `AspectRatioLocked`: Determines whether shape have to preserve aspect ratio on resizing. Read/write
- `PositionLocked`: Determines whether moving this shape is forbidden. Read/write
- `SizeLocked`: Determines whether resizing this shape is forbidden. Read/write
- `AsIBaseShapeLock`: Allows to get base IBaseShapeLock interface. Read-only

---

## IHeadingPair

**Full Name**: `Aspose.Slides.IHeadingPair`

**Description**: Represents a 'Heading pair' property of the document. It indicates the group name of document parts and the number of parts in group.

**Key Members**:

*Propertys*:
- `Name`: Returns the group name of document parts. Read-only
- `Count`: Returns the number of parts in group. Read-only

---

## IHyperlink

**Full Name**: `Aspose.Slides.IHyperlink`

**Description**: Represents a hyperlink.

**Key Members**:

*Propertys*:
- `ActionType`: Returns type of HyperLinkEx's action. Read-only
- `ExternalUrl`: Specifies the external URL If this property become not null then property TargetSlide become null. R
- `ExternalUrlOriginal`: Represents a hyperlink that is set for this portion without regard to the actual content of the port
- `TargetSlide`: If the HyperlinkEx targets specific slide returns this slide. If the property become not null then p
- `TargetFrame`: Returns the frame within the parent HTML frameset for the target of the parent hyperlink when one ex
- `Tooltip`: Returns the string which may be surfaced in a user interface as associated with the parent hyperlink
- `History`: Determines whether the target of the parent hyperlink shall be added to a list of viewed hyperlinks 
- `HighlightClick`: Determines whether the hyperlink should be highlighted on click. Read/write
- `StopSoundOnClick`: Determines whether the sound should be stopped on hyperlink click. Read/write
- `Sound`: Represents the playing sound of the hyperlink. Read/write

*Methods*:
- `Equals`: Determines whether the two Hyperlink instances are equal.

---

## IHyperlinkContainer

**Full Name**: `Aspose.Slides.IHyperlinkContainer`

**Description**: Represents hyperlink object.

**Key Members**:

*Propertys*:
- `HyperlinkClick`: Returns or sets the hyperlink defined for mouse click. Read/write
- `HyperlinkMouseOver`: Returns or sets the hyperlink defined for mouse over. Read/write
- `HyperlinkManager`: Hyperlinks manager Read-only

---

## IHyperlinkManager

**Full Name**: `Aspose.Slides.IHyperlinkManager`

**Description**: Provide hyperlinks management (adding, removing).

**Key Members**:

*Methods*:
- `SetExternalHyperlinkClick`: Set external hyperlink on click.
- `SetInternalHyperlinkClick`: Sets internal hyperlink on click.
- `RemoveHyperlinkClick`: Removes hyperlink on click.
- `SetExternalHyperlinkMouseOver`: Sets external hyperlink mouse over.
- `SetInternalHyperlinkMouseOver`: Sets internal hyperlink mouse over.
- `RemoveHyperlinkMouseOver`: Removes hyperlink mouse over.
- `SetMacroHyperlinkClick`: Set Macro hyperlink on a click.

---

## IHyperlinkQueries

**Full Name**: `Aspose.Slides.IHyperlinkQueries`

**Description**: Provide easy access to contained hyperlinks.

**Key Members**:

*Methods*:
- `GetHyperlinkClicks`: Get all IHyperlinkContainer subobjects that contain not null HyperlinkClick. With given IHyperlinkCo
- `GetHyperlinkMouseOvers`: Get all IHyperlinkContainer subobjects that contain not null HyperlinkMouseOver. With given IHyperli
- `GetAnyHyperlinks`: Get all IHyperlinkContainer subobjects that contain not null HyperlinkMouseOver. With given IHyperli
- `RemoveAllHyperlinks`: Removes all contained HyperlinkClick and HyperlinkMouseOver hyperlinks (in all IHyperlinkContainer s

---

## IImage

**Full Name**: `Aspose.Slides.IImage`

**Description**: Represents a raster or vector image.

**Key Members**:

*Propertys*:
- `Size`: Gets the size of the image.
- `Width`: Gets the width of the image in pixels.
- `Height`: Gets the height of the image in pixels.

*Methods*:
- `Save`: Saves the image to a file.
- `Save`: Saves the image to a file in the specified format.
- `Save`: Saves the image to a stream in the specified format.
- `Save`: Saves the image to a file in the specified format and quality.
- `Save`: Saves the image to a stream in the specified format and quality.

---

## IImageCollection

**Full Name**: `Aspose.Slides.IImageCollection`

**Description**: Represents collection of PPImage.

**Key Members**:

*Propertys*:
- `Item`: Returns image by its index.

*Methods*:
- `AddImage`: Add an image to a presentation.
- `AddImage`: Add an image to a presentation.
- `AddImage`: Adds image from a memory stream.
- `AddImage`: Add an image to a presentation from stream.
- `AddImage`: Creates and adds an image to a presentation from stream.
- `AddImage`: Adds an image to a presentation from specified buffer.
- `AddImage`: Adds a copy of an image from an another presentation.
- `AddImage`: Add an image to a presentation from SVG object.

---

## IImageWrapper

**Full Name**: `Aspose.Slides.IImageWrapper`

**Description**: System.Drawing.Image wrapper for COM interface.

**Key Members**:

*Propertys*:
- `Image`: Gets the Syste.Drawing.Image Read-only
- `ImageSource`: Gets the image Read-only
- `Size`: Gets the width and height, in pixels, of the Image Read-only
- `AsIDisposable`: Returns IDisposable interface. Read-only

*Methods*:
- `Save`: Saves Image to the specified file
- `Save`: Saves the Image to the specified stream in the specified format.
- `Save`: Saves the Image to the specified file in the specified format.

---

## IImageWrapperFactory

**Full Name**: `Aspose.Slides.IImageWrapperFactory`

**Description**: This interface allows to initialize IBitmapWrapper.

**Key Members**:

*Methods*:
- `CreateImageWrapper`: Initializes a new instance of the ImageWrapper class from the specified existing image.
- `CreateImageWrapper`: Initializes a new instance of the ImageWrapper class from the specified existing image.
- `CreateImageWrapper`: Initializes a new instance of the ImageWrapper class from the specified data stream.
- `CreateImageWrapper`: Initializes a new instance of the ImageWrapper class from the specified file.

---

## IInterruptionToken

**Full Name**: `Aspose.Slides.IInterruptionToken`

**Description**: This class represents the token to use for signaling long running tasks whether the interruption was requested.

**Key Members**:

*Propertys*:
- `IsInterruptionRequested`: Returns

*Methods*:
- `ThrowIfInterruptionRequested`: Throws an

---

## IInterruptionTokenSource

**Full Name**: `Aspose.Slides.IInterruptionTokenSource`

**Description**: Represents the source of

**Key Members**:

*Propertys*:
- `Token`: Returns new token binded to this
- `IsInterruptionRequested`: Returns true if interruption requested, false otherwise.

*Methods*:
- `Interrupt`: Intialize request for interruption.

---

## ILayoutPlaceholderManager

**Full Name**: `Aspose.Slides.ILayoutPlaceholderManager`

**Description**: Represents manager that allows you to add placeholders to the layout slide.

**Key Members**:

*Methods*:
- `AddContentPlaceholder`: Adds a new placeholder shape to the layout slide to hold content, such as a picture, table, media or
- `AddVerticalContentPlaceholder`: Adds a new placeholder shape to the layout slide to hold content, such as a picture, table, media or
- `AddTextPlaceholder`: Adds a new placeholder shape to the layout slide to hold text content.
- `AddVerticalTextPlaceholder`: Adds a new placeholder shape to the layout slide to hold text content in a vertical direction.
- `AddPicturePlaceholder`: Adds a new placeholder shape to the layout slide to hold a picture.
- `AddChartPlaceholder`: Adds a new placeholder shape to the layout slide to hold a chart.
- `AddTablePlaceholder`: Adds a new placeholder shape to the layout slide to hold a table.
- `AddSmartArtPlaceholder`: Adds a new placeholder shape to the layout slide to hold a SmartArt diagram.
- `AddMediaPlaceholder`: Adds a new placeholder shape to the layout slide to hold a media object.
- `AddOnlineImagePlaceholder`: Adds a new placeholder shape to the layout slide to hold an online image.

---

## ILayoutSlide

**Full Name**: `Aspose.Slides.ILayoutSlide`

**Description**: Represents a layout slide.

**Key Members**:

*Propertys*:
- `HeaderFooterManager`: Returns HeaderFooter manager of the layout slide. Read-only
- `PlaceholderManager`: Returns the placeholder manager of the layout slide. Read-only
- `MasterSlide`: Returns or sets the master slide for a layout. Read/write
- `LayoutType`: Returns layout type of this layout slide. Read-only
- `HasDependingSlides`: Returns true if there exists at least one slide that depends on this layout slide. Read-only
- `AsIBaseSlide`: Allows to get base IBaseSlide interface. Read-only
- `AsIOverrideThemeable`: Returns IOverrideThemeable interface. Read-only

*Methods*:
- `GetDependingSlides`: Returns an array with all slides, which depend on this layout slide.
- `Remove`: Removes layout from presentation.

---

## ILayoutSlideCollection

**Full Name**: `Aspose.Slides.ILayoutSlideCollection`

**Description**: Represents a base class for collection of a layout slides.

**Key Members**:

*Propertys*:
- `Item`: Returns the layout slide by index. Read-only

*Methods*:
- `GetByType`: Returns the first layout slide of specified type.
- `Remove`: Removes a layout from the collection.
- `RemoveUnused`: Removes unused layout slides (layout slides whose HasDependingSlides is false).

---

## ILayoutSlideHeaderFooterManager

**Full Name**: `Aspose.Slides.ILayoutSlideHeaderFooterManager`

**Description**: Represents manager which holds behavior of the layout slide footer, date-time, page number placeholders and all child placeholders. Child placeholders mean placeholders are contained on depending slides. Depending slides use and depend on layout slide.

**Key Members**:

*Propertys*:
- `AsIBaseSlideHeaderFooterManager`: Returns IBaseSlideHeaderFooterManager interface.

*Methods*:
- `SetFooterAndChildFootersVisibility`: Changes layout slide footer placeholder and all child footer placeholders visibility. Child placehol
- `SetSlideNumberAndChildSlideNumbersVisibility`: Changes layout slide page number placeholder and all child page number placeholders visibility. Chil
- `SetDateTimeAndChildDateTimesVisibility`: Changes layout slide date-time placeholder and all child date-time placeholders visibility. Child pl
- `SetFooterAndChildFootersText`: Sets text to layout slide footer placeholder and all child footer placeholders. Child placeholders m
- `SetDateTimeAndChildDateTimesText`: Sets text to layout slide date-time placeholder and all child date-time placeholders. Child placehol

---

## ILegacyDiagram

**Full Name**: `Aspose.Slides.ILegacyDiagram`

**Description**: Represents a legacy diagram object

**Key Members**:

*Propertys*:
- `AsIGraphicalObject`: Allows to get base IGraphicalObject interface. Read-only

*Methods*:
- `ConvertToSmartArt`: Converts legacy digram to editable SmartArt object. Created SmartArt object adds to parent group sha
- `ConvertToGroupShape`: Converts legacy digram to editable group shape. Created GroupShape object adds to parent group shape

---

## ILicense

**Full Name**: `Aspose.Slides.ILicense`

**Description**: Provides methods to license the component.

**Key Members**:

*Methods*:
- `SetLicense`: Licenses the component.
- `SetLicense`: Licenses the component.
- `ResetLicense`: Reset the license
- `IsLicensed`: Check if licence is applied to component

---

## ILightRig

**Full Name**: `Aspose.Slides.ILightRig`

**Description**: Represents LightRig.

**Key Members**:

*Propertys*:
- `Direction`: Light direction. Read/write
- `LightType`: Represents a preset light right that can be applied to a shape. The light rig represents a group of 

*Methods*:
- `SetRotation`: A rotation is defined through the use of a latitude coordinate, a longitude coordinate, and a revolu
- `GetRotation`: A rotation is defined through the use of a latitude coordinate, a longitude coordinate, and a revolu

---

## ILightRigEffectiveData

**Full Name**: `Aspose.Slides.ILightRigEffectiveData`

**Description**: Immutable object which contains effective light rig properties.

**Key Members**:

*Propertys*:
- `Direction`: Light direction. Read-only
- `LightType`: Represents a preset light right that can be applied to a shape. The light rig represents a group of 

*Methods*:
- `GetRotation`: A rotation is defined through the use of a latitude coordinate, a longitude coordinate, and a revolu

---

## ILineFillFormat

**Full Name**: `Aspose.Slides.ILineFillFormat`

**Description**: Represents properties for lines filling.

**Key Members**:

*Propertys*:
- `FillType`: Returns or sets the fill type. Read/write
- `SolidFillColor`: Returns the color of a solid fill. Read-only
- `GradientFormat`: Returns the gradient fill format. Read-only
- `PatternFormat`: Returns the pattern fill format. Read-only
- `RotateWithShape`: Determines whether the fill should be rotated with a shape. Read/write
- `AsIFillParamSource`: Allows to get base IFillParamSource interface. Read-only

---

## ILineFillFormatEffectiveData

**Full Name**: `Aspose.Slides.ILineFillFormatEffectiveData`

**Description**: Immutable object which contains effective line filling properties.

**Key Members**:

*Propertys*:
- `FillType`: Returns the fill type. Read-only
- `SolidFillColor`: Returns the color of a solid fill. Read-only
- `GradientFormat`: Returns the gradient fill format. Read-only
- `PatternFormat`: Returns the pattern fill format. Read-only
- `RotateWithShape`: Determines whether the fill should be rotated with a shape. Read-only
- `AsIFillParamSource`: Returns IFillParamSource interface. Read-only

---

## ILineFormat

**Full Name**: `Aspose.Slides.ILineFormat`

**Description**: Represents format of a line.

**Key Members**:

*Propertys*:
- `IsFormatNotDefined`: Returns true if line format is not defined (as just created, default). Read-only
- `FillFormat`: Returns the fill format of a line. Read-only
- `SketchFormat`: Returns the sketch format of a line. Read-only
- `Width`: Returns or sets the width of a line. Read/write
- `DashStyle`: Returns or sets the line dash style. Read/write
- `CustomDashPattern`: Returns or sets the custom dash pattern. Read/write
- `CapStyle`: Returns or sets the line cap style. Read/write
- `Style`: Returns or sets the line style. Read/write
- `Alignment`: Returns or sets the line alignment. Read/write
- `JoinStyle`: Returns or sets the lines join style. Read/write

*Methods*:
- `Equals`: Determines whether the two LineFormat instances are equal.
- `GetEffective`: Gets effective line formatting data with the inheritance applied.

---

## ILineFormatEffectiveData

**Full Name**: `Aspose.Slides.ILineFormatEffectiveData`

**Description**: Immutable object which contains effective line formatting properties.

**Key Members**:

*Propertys*:
- `FillFormat`: Returns the fill format of a line. Read-only
- `SketchFormat`: Returns the sketch format of a line. Read-only
- `Width`: Returns the width of a line. Read-only
- `DashStyle`: Returns the line dash style. Read-only
- `CustomDashPattern`: Returns the custom dash pattern. Read-only
- `CapStyle`: Returns the line cap style. Read-only
- `Style`: Returns the line style. Read-only
- `Alignment`: Returns the line alignment. Read-only
- `JoinStyle`: Returns the lines join style. Read-only
- `MiterLimit`: Returns the miter limit of a line. Read-only

*Methods*:
- `Equals`: Determines whether the two ILineFormatEffectiveData instances are equal.

---

## ILineParamSource

**Full Name**: `Aspose.Slides.ILineParamSource`

**Description**: Auxiliary line parameters interface.

---

## ILoadOptions

**Full Name**: `Aspose.Slides.ILoadOptions`

**Description**: Allows to specify additional options (such as format or default font) when loading a presentation.

**Key Members**:

*Propertys*:
- `LoadFormat`: Returns or sets format of a presentation to load. Read/write
- `DefaultRegularFont`: Returns or sets Regular font used in case source font is not found. Read-write
- `DefaultSymbolFont`: Returns or sets Symbol font used in case source font is not found. Read-write
- `DefaultAsianFont`: Returns or sets Asian font used in case source font is not found. Read-write
- `Password`: Gets or sets the password. Read-write
- `OnlyLoadDocumentProperties`: This property makes sense, if presentation file is password protected. Value of true means that only
- `WarningCallback`: Returns or sets an object which receives warnings and decides whether loading process will continue 
- `BlobManagementOptions`: Represents the options which can be used to manage Binary Large Objects (BLOBs) handling behavior, s
- `DocumentLevelFontSources`: Specifies sources for external fonts to be used by the presentation. These fonts are available to th
- `InterruptionToken`: The token to monitor for interruption requests.

---

## IMasterHandoutSlide

**Full Name**: `Aspose.Slides.IMasterHandoutSlide`

**Description**: Represents master slide for handouts.

**Key Members**:

*Propertys*:
- `HeaderFooterManager`: Returns HeaderFooter manager of the master handout slide. Read-only
- `AsIBaseSlide`: Allows to get base IBaseSlide interface. Read-only
- `AsIMasterThemeable`: Returns IMasterThemeable interface. Read-only

---

## IMasterHandoutSlideHeaderFooterManager

**Full Name**: `Aspose.Slides.IMasterHandoutSlideHeaderFooterManager`

**Description**: Represents manager which holds behavior of the master handout slide placeholders, including header placeholder.

**Key Members**:

*Propertys*:
- `AsIBaseHandoutNotesSlideHeaderFooterManag`: Returns IBaseHandoutNotesSlideHeaderFooterManag interface.

---

## IMasterHandoutSlideManager

**Full Name**: `Aspose.Slides.IMasterHandoutSlideManager`

**Description**: Master handout slide manager.

**Key Members**:

*Propertys*:
- `MasterHandoutSlide`: Returns a master for all notes slides of this presentation if there is one, otherwise returns null. 

*Methods*:
- `SetDefaultMasterHandoutSlide`: Sets default master handout slide to related handout slide.
- `RemoveMasterHandoutSlide`: Removes master handout slide.

---

## IMasterLayoutSlideCollection

**Full Name**: `Aspose.Slides.IMasterLayoutSlideCollection`

**Description**: Represents a collections of all layout slides of defined master slide. Extends ILayoutSlideCollection interface with methods for adding/inserting/removing/cloning layout slides in context of the individual collections of master's layout slides.

**Key Members**:

*Propertys*:
- `AsILayoutSlideCollection`: Returns ILayoutSlideCollection interface. Read-only

*Methods*:
- `AddClone`: Adds a copy of a specified layout slide to the end of the collection.
- `InsertClone`: Inserts a copy of a specified layout slide to specified position of the collection.
- `Add`: Adds a new layout slide to the end of the collection.
- `Insert`: Inserts a new layout slide to specified position of the collection.
- `RemoveAt`: Removes the element at the specified index of the collection.
- `Reorder`: Moves layout slide from the collection to the specified position.

---

## IMasterNotesSlide

**Full Name**: `Aspose.Slides.IMasterNotesSlide`

**Description**: Represents master slide for notes.

**Key Members**:

*Propertys*:
- `HeaderFooterManager`: Returns HeaderFooter manager of the master notes slide. Read-only
- `NotesStyle`: Returns the style of a notes text. Read-only
- `AsIBaseSlide`: Allows to get base IBaseSlide interface. Read-only
- `AsIMasterThemeable`: Returns IMasterThemeable interface. Read-only

---

## IMasterNotesSlideHeaderFooterManager

**Full Name**: `Aspose.Slides.IMasterNotesSlideHeaderFooterManager`

**Description**: Represents manager which holds behavior of the master notes slide footer, date-time, page number placeholders and all child placeholders. Child placeholders mean placeholders are contained on depending notes slides. Depending notes slides use and depend on master notes slide.

**Key Members**:

*Propertys*:
- `AsIBaseHandoutNotesSlideHeaderFooterManag`: Returns IBaseHandoutNotesSlideHeaderFooterManag interface.

*Methods*:
- `SetHeaderAndChildHeadersVisibility`: Changes master notes slide header placeholder and all child header placeholders visibility. Child pl
- `SetHeaderAndChildHeadersText`: Sets text to master notes slide header placeholder and all child header placeholders. Child placehol
- `SetFooterAndChildFootersVisibility`: Changes master notes slide footer placeholder and all child footer placeholders visibility. Child pl
- `SetSlideNumberAndChildSlideNumbersVisibility`: Changes master notes slide page number placeholder and all child page number placeholders visibility
- `SetDateTimeAndChildDateTimesVisibility`: Changes master notes slide date-time placeholder and all child date-time placeholders visibility. Ch
- `SetFooterAndChildFootersText`: Sets text to master notes slide footer placeholder and all child footer placeholders. Child placehol
- `SetDateTimeAndChildDateTimesText`: Sets text to master notes slide date-time placeholder and all child date-time placeholders. Child pl

---

## IMasterNotesSlideManager

**Full Name**: `Aspose.Slides.IMasterNotesSlideManager`

**Description**: Master notes slide manager.

**Key Members**:

*Propertys*:
- `MasterNotesSlide`: Returns a master for all notes slides of this presentation if there is one, otherwise returns null. 

*Methods*:
- `SetDefaultMasterNotesSlide`: Sets defalut master notes slide for related notes slide.
- `RemoveMasterNotesSlide`: Removes master notes slide.

---

## IMasterSlide

**Full Name**: `Aspose.Slides.IMasterSlide`

**Description**: Represents a master slide in a presentation.

**Key Members**:

*Propertys*:
- `HeaderFooterManager`: Returns HeaderFooter manager of the master slide. Read-only
- `TitleStyle`: Returns the style of a title text. Read-only
- `BodyStyle`: Returns the style of a body text. Read-only
- `OtherStyle`: Returns the style of an other text. Read-only
- `LayoutSlides`: Returns the collection of child layout slides for this master slide. Read-only
- `Preserve`: Determines whether the corresponding master is deleted when all the slides that follow that master a
- `HasDependingSlides`: Returns true if there exists at least one slide that depends on this master slide. Read-only
- `AsIBaseSlide`: Allows to get base IBaseSlide interface. Read-only
- `AsIMasterThemeable`: Returns IMasterThemeable interface. Read-only

*Methods*:
- `ApplyExternalThemeToDependingSlides`: Creates a new master slide based on the current one, applying an external theme to it and applies th
- `GetDependingSlides`: Returns an array with all slides, which depend on this master slide.

---

## IMasterSlideCollection

**Full Name**: `Aspose.Slides.IMasterSlideCollection`

**Description**: Represents a collection of master slides.

**Key Members**:

*Propertys*:
- `Item`: Gets the element at the specified index. Read-only

*Methods*:
- `Remove`: Removes the first occurrence of a specific object from the collection.
- `RemoveAt`: Removes the element at the specified index of the collection.
- `RemoveUnused`: Removes unused master slides.
- `AddClone`: Adds a copy of a specified master slide to the end of the collection. Linked layout slides will be c
- `InsertClone`: Inserts a copy of a specified master slide to specified position of the collection. Linked layout sl

---

## IMasterSlideHeaderFooterManager

**Full Name**: `Aspose.Slides.IMasterSlideHeaderFooterManager`

**Description**: Represents manager which holds behavior of the master slide footer, date-time, page number placeholders and all child placeholders. Child placeholders mean placeholders are contained on depending layout slides and depending slides. Depending layout slides and slides use and depend on master slide.

**Key Members**:

*Propertys*:
- `AsIBaseSlideHeaderFooterManager`: Returns IBaseSlideHeaderFooterManager interface.

*Methods*:
- `SetFooterAndChildFootersVisibility`: Changes master slide footer placeholder and all child footer placeholders visibility. Child placehol
- `SetSlideNumberAndChildSlideNumbersVisibility`: Changes master slide page number placeholder and all child page number placeholders visibility. Chil
- `SetDateTimeAndChildDateTimesVisibility`: Changes master slide date-time placeholder and all child date-time placeholders visibility. Child pl
- `SetFooterAndChildFootersText`: Sets text to master slide footer placeholder and all child footer placeholders. Child placeholders m
- `SetDateTimeAndChildDateTimesText`: Sets text to master slide date-time placeholder and all child date-time placeholders. Child placehol

---

## IMetered

**Full Name**: `Aspose.Slides.IMetered`

**Description**: Provides methods to set metered key.

**Key Members**:

*Methods*:
- `SetMeteredKey`: Sets metered public and private key.

---

## IModernComment

**Full Name**: `Aspose.Slides.IModernComment`

**Description**: Represents a comment on a slide.

**Key Members**:

*Propertys*:
- `Shape`: Returns a shape associated with the comment. Read-only
- `TextSelectionStart`: Returns or sets starting position of text selection in text frame if the comment associated with Aut
- `TextSelectionLength`: Returns or sets text selection length in text frame if the comment associated with AutoShape. Read/w
- `Status`: Returns or sets the status of the comment. Read/write
- `AsIComment`: Allows to get base IComment interface. Read-only

---

## INormalViewProperties

**Full Name**: `Aspose.Slides.INormalViewProperties`

**Description**: Represents normal view properties. The normal view consists of three content regions: the slide itself, a side content region, and a bottom content region.

**Key Members**:

*Propertys*:
- `ShowOutlineIcons`: Specifies whether the application should show icons if displaying outline content in any of the cont
- `SnapVerticalSplitter`: Specifies whether the vertical splitter should snap to a minimized state when the side region is suf
- `VerticalBarState`: Specifies the state that the vertical splitter bar should be shown in. A vertical splitter bar separ
- `HorizontalBarState`: Specifies the state that the horizontal splitter bar should be shown in. A horizontal splitter bar s
- `PreferSingleView`: Specifies whether the user prefers to see a full-window single-content region over the standard norm
- `RestoredLeft`: This element specifies the sizing of the side content region of the normal view, when the region is 
- `RestoredTop`: This element specifies the sizing of the top slide region of the normal view, when the region is of 

---

## INormalViewRestoredProperties

**Full Name**: `Aspose.Slides.INormalViewRestoredProperties`

**Description**: Specifies the sizing of the slide region ((width when a child of restoredTop, height when a child of restoredLeft) of the normal view, when the region is of a variable restored size(neither minimized nor maximized).

**Key Members**:

*Propertys*:
- `DimensionSize`: Specifies the size of the slide region (width when a child of RestoredTop, height when a child of Re
- `AutoAdjust`: Specifies whether the size of the side content region should compensate for the new size when resizi

---

## INotesSize

**Full Name**: `Aspose.Slides.INotesSize`

**Description**: Represents a size of notes slide.

**Key Members**:

*Propertys*:
- `Size`: Returns or sets the size in points. Read/write

---

## INotesSlide

**Full Name**: `Aspose.Slides.INotesSlide`

**Description**: Represents a notes slide in a presentation.

**Key Members**:

*Propertys*:
- `HeaderFooterManager`: Returns HeaderFooter manager of the notes slide. Read-only
- `NotesTextFrame`: Returns a TextFrame with notes' text if there is one. Read-only
- `ParentSlide`: Returns a ParentSlide Read-only
- `AsIBaseSlide`: Allows to get base IBaseSlide interface. Read-only
- `AsIOverrideThemeable`: Returns IOverrideThemeable interface. Read-only

---

## INotesSlideHeaderFooterManager

**Full Name**: `Aspose.Slides.INotesSlideHeaderFooterManager`

**Description**: Represents manager which holds behavior of the notes slide placeholders, including header placeholder.

**Key Members**:

*Propertys*:
- `AsIBaseHandoutNotesSlideHeaderFooterManag`: Returns IBaseHandoutNotesSlideHeaderFooterManag interface.

---

## INotesSlideManager

**Full Name**: `Aspose.Slides.INotesSlideManager`

**Description**: Notes slide manager.

**Key Members**:

*Propertys*:
- `NotesSlide`: Returns the notes slide for the current slide. Returns null if slide doesn't have notes slide. Read-

*Methods*:
- `AddNotesSlide`: Returns the notes slide for the current slide, creating one if there isn't.
- `RemoveNotesSlide`: Removes notes slide of the current slide.

---

## IOleEmbeddedDataInfo

**Full Name**: `Aspose.Slides.IOleEmbeddedDataInfo`

**Description**: Represents embedded data info for OLE object.

**Key Members**:

*Propertys*:
- `EmbeddedFileData`: Returns the file data of embedded OLE object Read only
- `EmbeddedFileExtension`: Returns the file extension for the current embedded OLE object Read only

---

## IOleObjectFrame

**Full Name**: `Aspose.Slides.IOleObjectFrame`

**Description**: Represents an OLE object on a slide.

**Key Members**:

*Propertys*:
- `SubstitutePictureFormat`: Returns OleObject image fill properties object. Read-only
- `ObjectName`: Returns or sets the name of an object. Read/write
- `EmbeddedData`: Gets information about OLE embedded data. Read only
- `ObjectProgId`: Returns the ProgID of an object. Read olny
- `LinkFileName`: Returns the full path to a linked file. Short file name will be used. Read-only
- `LinkPathLong`: Returns the full path to a linked file. Long file name will be used. Read/write
- `LinkPathRelative`: Returns the relative path to a linked file if present, otherwise returns an empty string. Readonly
- `EmbeddedFileLabel`: Returns the file name of embedded OLE object
- `EmbeddedFileName`: Returns the path of embedded OLE object
- `IsObjectIcon`: Determines whether an object is visible as icon. Read/write

*Methods*:
- `SetEmbeddedData`: Sets information about OLE embedded data.

---

## IPPImage

**Full Name**: `Aspose.Slides.IPPImage`

**Description**: Represents an image in a presentation.

**Key Members**:

*Propertys*:
- `BinaryData`: Returns the copy of an image's data. Read-only
- `SystemImage`: Returns the copy of an image of the System.Drawing.Image type. Read-only
- `Image`: Returns the copy of an image. Read-only
- `SvgImage`: Returns or sets ISvgImage object
- `ContentType`: Returns a MIME type of an image, encoded in
- `Width`: Returns a width of an image. Read-only
- `Height`: Returns a height of an image. Read-only
- `X`: Returns a X-offset of an image. Read-only
- `Y`: Returns a Y-offset of an image. Read-only

*Methods*:
- `ReplaceImage`: Replaces image data.
- `ReplaceImage`: Replaces image.
- `ReplaceImage`: Replaces image.
- `ReplaceImage`: Replaces image.

---

## IParagraph

**Full Name**: `Aspose.Slides.IParagraph`

**Description**: Represents a paragraph of a text.

**Key Members**:

*Propertys*:
- `Portions`: Returns the collection of a text portions. Read-only
- `ParagraphFormat`: Returns the formatting object for this paragraph. Read-only
- `Text`: Gets or sets the the plain text of a paragraph. Read/write
- `EndParagraphPortionFormat`: Specifies the portion properties that are to be used if another portion is inserted after the last o
- `AsISlideComponent`: Allows to get base ISlideComponent interface. Read-only

*Methods*:
- `JoinPortionsWithSameFormatting`: Joins runs with same formatting.
- `GetRect`: Get coordinates of rect that bounds paragraph. The rect includes all the lines of text in paragraph,
- `GetLinesCount`: Get number of lines in a paragraph.

---

## IParagraphCollection

**Full Name**: `Aspose.Slides.IParagraphCollection`

**Description**: Represents a collection of a paragraphs.

**Key Members**:

*Propertys*:
- `Item`: Gets the element at the specified index.
- `Count`: Gets the number of elements actually contained in the collection. Read-only
- `AsISlideComponent`: Allows to get base ISlideComponent interface. Read-only
- `AsIEnumerable`: Returns IEnumerable interface. Read-only

*Methods*:
- `Add`: Adds a Paragraph to the end of collection.
- `Add`: Adds a content of ParagraphCollection to the end of collection.
- `Insert`: Inserts a Paragraph into the collection at the specified index.
- `Insert`: Inserts a content of ParagraphCollection into the collection at the specified index.
- `Clear`: Removes all elements from the collection.
- `RemoveAt`: Removes the element at the specified index of the collection.
- `Remove`: Removes the first occurrence of a specific paragraph.
- `AddFromHtml`: Adds text from specified html string to the collection.
- `AddFromHtml`: Adds text from specified html string to the collection.
- `ExportToHtml`: Converts specifying paragraphs to the HTML and returns it as String object.

---

## IParagraphFactory

**Full Name**: `Aspose.Slides.IParagraphFactory`

**Description**: Allows to create paragraphs

**Key Members**:

*Methods*:
- `CreateParagraph`: Creates a new empty paragraph.
- `CreateParagraph`: Creates a new paragraph with specified paragraph data using.

---

## IParagraphFormat

**Full Name**: `Aspose.Slides.IParagraphFormat`

**Description**: This class contains the paragraph formatting properties. Unlike

**Key Members**:

*Propertys*:
- `Bullet`: Returns bullet format of the paragraph. Read-only
- `Depth`: Returns or sets depth of the paragraph. Value 0 means undefined value. Read/write
- `Alignment`: Returns or sets the text alignment in a paragraph with no inheritance. Read/write
- `SpaceWithin`: Returns or sets the amount of space between base lines in a paragraph. Positive value means percenta
- `SpaceBefore`: Returns or sets the amount of space before the first line in a paragraph with no inheritance. A posi
- `SpaceAfter`: Returns or sets the amount of space after the last line in a paragraph with no inheritance. A positi
- `EastAsianLineBreak`: Determines whether the East Asian line break is used in a paragraph. No inheritance applied. Read/wr
- `RightToLeft`: Determines whether the Right to Left writing is used in a paragraph. No inheritance applied. Read/wr
- `LatinLineBreak`: Determines whether the Latin line break is used in a paragraph. No inheritance applied. Read/write
- `HangingPunctuation`: Determines whether the hanging punctuation is used in a paragraph. No inheritance applied. Read/writ

*Methods*:
- `GetEffective`: Gets effective paragraph formatting data with the inheritance applied.

---

## IParagraphFormatEffectiveData

**Full Name**: `Aspose.Slides.IParagraphFormatEffectiveData`

**Description**: Immutable object which contains effective paragraph formatting properties.

**Key Members**:

*Propertys*:
- `Bullet`: Returns a bullet format of a paragraph. Read-only
- `Depth`: Returns a depth of a paragraph. Read-only
- `Alignment`: Returns the text alignment in a paragraph. Read-only
- `SpaceWithin`: Returns the amount of space between base lines in a paragraph. Read-only
- `SpaceBefore`: Returns the amount of space before the first line in a paragraph. Read-only
- `SpaceAfter`: Returns the amount of space after the last line in a paragraph. Read-only
- `EastAsianLineBreak`: Determines whether the East Asian line break is used in a paragraph. Read-only
- `RightToLeft`: Determines whether the Right to Left writing is used in a paragraph. Read-only
- `LatinLineBreak`: Determines whether the Latin line break is used in a paragraph. Read-only
- `HangingPunctuation`: Determines whether the hanging punctuation is used in a paragraph. Read-only

---

## IPathSegment

**Full Name**: `Aspose.Slides.IPathSegment`

**Description**: Represents segment of graphics path of GeometryShape

**Key Members**:

*Propertys*:
- `SegmentData`: Path data of the segment
- `PathCommand`: Path type of the segment

---

## IPatternFormat

**Full Name**: `Aspose.Slides.IPatternFormat`

**Description**: Represents a pattern to fill a shape.

**Key Members**:

*Propertys*:
- `PatternStyle`: Returns or sets the pattern style. Read/write
- `ForeColor`: Returns the foreground pattern color. Read-only
- `BackColor`: Returns the background pattern color. Read-only

*Methods*:
- `GetTileImage`: Creates a tile image for the pattern fill with a specified colors.
- `GetTile`: Creates a tile image for the pattern fill with a specified colors.
- `GetTileImage`: Creates a tile image for the pattern fill.
- `GetTile`: Creates a tile image for the pattern fill.

---

## IPatternFormatEffectiveData

**Full Name**: `Aspose.Slides.IPatternFormatEffectiveData`

**Description**: Immutable object which contains effective pattern filling properties.

**Key Members**:

*Propertys*:
- `PatternStyle`: Returns the pattern style. Read-only
- `ForeColor`: Returns the foreground pattern color. Read-only
- `BackColor`: Returns the background pattern color. Read-only

*Methods*:
- `GetTileImage`: Creates a tile image for the pattern fill with a specified colors.
- `GetTileIImage`: Creates a tile image for the pattern fill with a specified colors.

---

## IPictureEffectiveData

**Full Name**: `Aspose.Slides.IPictureEffectiveData`

**Description**: Immutable object which contains effective picture properties.

**Key Members**:

*Propertys*:
- `Image`: Returns the embedded image. Read-only
- `LinkPathLong`: Returns linked image's URL. Read-only
- `ImageTransform`: Returns the collection of image transform effects. Read-only

---

## IPictureFillFormat

**Full Name**: `Aspose.Slides.IPictureFillFormat`

**Description**: Represents a picture fill style.

**Key Members**:

*Propertys*:
- `Dpi`: Returns or sets the dpi which is used to fill a picture. Read/write
- `PictureFillMode`: Returns or sets the picture fill mode. Read/write
- `Picture`: Returns the picture. Read-only
- `CropLeft`: Returns or sets the number of percents of real image width that are cropped off the left of the pict
- `CropTop`: Returns or sets the number of percents of real image height that are cropped off the top of the pict
- `CropRight`: Returns or sets the number of percents of real image width that are cropped off the right of the pic
- `CropBottom`: Returns or sets the number of percents of real image height that are cropped off the bottom of the p
- `StretchOffsetLeft`: Returns or sets left edge of the fill rectangle that is defined by a percentage offset from the left
- `StretchOffsetTop`: Returns or sets top edge of the fill rectangle that is defined by a percentage offset from the top e
- `StretchOffsetRight`: Returns or sets right edge of the fill rectangle that is defined by a percentage offset from the rig

*Methods*:
- `DeletePictureCroppedAreas`: Delete cropped areas of the fill Picture.
- `CompressImage`: Compresses the image by reducing its size based on the shape size and specified resolution. Optional
- `CompressImage`: Compresses the image by reducing its size based on the shape size and specified resolution. Optional

---

## IPictureFillFormatEffectiveData

**Full Name**: `Aspose.Slides.IPictureFillFormatEffectiveData`

**Description**: Immutable object which contains the properties of picture fill.

**Key Members**:

*Propertys*:
- `Dpi`: Returns the dpi which is used to fill a picture. Read-only
- `PictureFillMode`: Returns the picture fill mode. Read-only
- `Picture`: Returns the picture. Read-only
- `CropLeft`: Returns the number of percents of real image width that are cropped off the left of the picture. Rea
- `CropTop`: Returns the number of percents of real image height that are cropped off the top of the picture. Rea
- `CropRight`: Returns the number of percents of real image width that are cropped off the right of the picture. Re
- `CropBottom`: Returns the number of percents of real image height that are cropped off the bottom of the picture. 
- `AsIFillParamSource`: Allows to get base IFillParamSource interface. Read-only

---

## IPictureFrame

**Full Name**: `Aspose.Slides.IPictureFrame`

**Description**: Represents a frame with a picture inside.

**Key Members**:

*Propertys*:
- `ShapeLock`: Returns shape's locks. Read-only
- `PictureFrameLock`: Returns PictureFrame's locks. Read-only
- `PictureFormat`: Returns the PictureFillFormat object for a picture frame. Read-only
- `RelativeScaleHeight`: Returns or sets the scale of height(relative to original picture size) of the picture frame. Value 1
- `RelativeScaleWidth`: Returns or sets the scale of width (relative to original picture size) of the picture frame. Value 1
- `AsIGeometryShape`: Allows to get base IGeometryShape interface. Read-only

---

## IPictureFrameLock

**Full Name**: `Aspose.Slides.IPictureFrameLock`

**Description**: Determines which operations are disabled on the parent PictureFrameEx.

**Key Members**:

*Propertys*:
- `GroupingLocked`: Determines whether an adding this shape to a group is forbidden. Read/write
- `SelectLocked`: Determines whether a selecting this shape is forbidden. Read/write
- `RotationLocked`: Determines whether a changing rotation angle of this shape is forbidden. Read/write
- `AspectRatioLocked`: Determines whether a shape have to preserve aspect ratio on resizing. Read/write
- `PositionLocked`: Determines whether a moving this shape is forbidden. Read/write
- `SizeLocked`: Determines whether a resizing this shape is forbidden. Read/write
- `EditPointsLocked`: Determines whether a direct changing of contour of this shape is forbidden. Read/write
- `AdjustHandlesLocked`: Determines whether a changing adjust values is forbidden. Read/write
- `ArrowheadsLocked`: Determines whether a changing arrowheads is forbidden. Read/write
- `ShapeTypeLocked`: Determines whether a changing of a shape type is forbidden. Read/write

---

## IPlaceholder

**Full Name**: `Aspose.Slides.IPlaceholder`

**Description**: Represents a placeholder on a slide.

**Key Members**:

*Propertys*:
- `Orientation`: Gets the orientation of a placeholder. Read-only
- `Size`: Gets the size of a placeholder. Read-only
- `Type`: Gets the type of a placeholder. Read-only
- `Index`: Gets the index of a placeholder. Read-only

---

## IPortion

**Full Name**: `Aspose.Slides.IPortion`

**Description**: Represents a portion of text inside a text paragraph.

**Key Members**:

*Propertys*:
- `PortionFormat`: Returns formatting object which contains explicitly set formatting properties of the text portion wi
- `Text`: Gets or sets the plain text of a portion. Read/write
- `Field`: Returns a field of this portion. Read-only
- `AsISlideComponent`: Allows to get base ISlideComponent interface. Read-only

*Methods*:
- `AddField`: Converts this portion to the automaticaly updated field.
- `AddField`: Converts this portion to the automaticaly updated field.
- `RemoveField`: Converts this field portion to the simple portion.
- `GetRect`: Get coordinates of rect that bounds portion. The rect includes all the lines of text in portion, inc
- `GetCoordinates`: Get coordinates of the beginning of the portion. The X coordinate of point represents the portion be

---

## IPortionCollection

**Full Name**: `Aspose.Slides.IPortionCollection`

**Description**: Represents a collection of a portions.

**Key Members**:

*Propertys*:
- `Item`: Gets the element at the specified index.
- `Count`: Gets the number of elements actually contained in the collection. Read-only
- `AsIEnumerable`: Returns IEnumerable interface. Read-only

*Methods*:
- `Add`: Adds a Portion to the end of collection.
- `IndexOf`: Determines the index of a specific portion in collection.
- `Insert`: Inserts a Portion into the collection at the specified index.
- `Clear`: Removes all elements from the collection.
- `Contains`: Determines whether the
- `Remove`: Removes the first occurrence of a specific object from the
- `RemoveAt`: Removes the element at the specified index of the collection.

---

## IPortionFactory

**Full Name**: `Aspose.Slides.IPortionFactory`

**Description**: Allows to create test portions

**Key Members**:

*Methods*:
- `CreatePortion`: Creates an empty text portion.
- `CreatePortion`: Creates a text portion from specified string.
- `CreatePortion`: Creates a portion with the using of a specified portion data.

---

## IPortionFormat

**Full Name**: `Aspose.Slides.IPortionFormat`

**Description**: This class contains the text portion formatting properties. Unlike

**Key Members**:

*Propertys*:
- `BookmarkId`: Returns or sets bookmark identifier. Read/write
- `SmartTagClean`: Determines whether the smart tag should be cleaned. No inheritance applied. Read/write
- `AsIBasePortionFormat`: Returns IBasePortionFormat interface. Read-only
- `AsIHyperlinkContainer`: Allows to get base IHyperlinkContainer interface. Read-only

*Methods*:
- `GetEffective`: Gets effective portion formatting data with the inheritance applied.

---

## IPortionFormatEffectiveData

**Full Name**: `Aspose.Slides.IPortionFormatEffectiveData`

**Description**: Immutable object which contains effective text portion formatting properties.

**Key Members**:

*Propertys*:
- `BookmarkId`: Returns bookmark identifier. Read-only
- `HyperlinkClick`: Returns the hyperlink defined for mouse click. Read-only
- `HyperlinkMouseOver`: Returns the hyperlink defined for mouse over. Read-only
- `AsIBasePortionFormatEffectiveData`: Returns IBasePortionFormatEffectiveData interface.

---

## IPresentation

**Full Name**: `Aspose.Slides.IPresentation`

**Description**: Presentation document

**Key Members**:

*Propertys*:
- `CurrentDateTime`: Returns or sets date and time which will substitute content of datetime fields. Time of this Present
- `HeaderFooterManager`: Returns HeaderFooter manager of the presentation. Read-only
- `ProtectionManager`: Gets manager of the permissions for this presentation. Read-only
- `Slides`: Returns a list of all slides that are defined in the presentation. Read-only
- `Sections`: Returns a list of all slides sections that are defined in the presentation. Read-only
- `SlideSize`: Returns slide size object. Read-only
- `NotesSize`: Returns notes slide size object. Read-only
- `LayoutSlides`: Returns a list of all layout slides that are defined in the presentation. Read-only
- `Masters`: Returns a list of all master slides that are defined in the presentation. Read-only
- `MasterNotesSlideManager`: Returns notes master manager. Read-only

---

## IPresentationComponent

**Full Name**: `Aspose.Slides.IPresentationComponent`

**Description**: Represents a component of a presentation.

**Key Members**:

*Propertys*:
- `Presentation`: Returns the presentation. Read-only

---

## IPresentationFactory

**Full Name**: `Aspose.Slides.IPresentationFactory`

**Description**: Allows to create presentation via COM interface

**Key Members**:

*Methods*:
- `CreatePresentation`: Creates new presentation.
- `CreatePresentation`: Creates new presentation with additional load options
- `GetPresentationInfo`: Gets info about presentation in specified file.
- `GetPresentationInfo`: Gets info about presentation in specified stream.
- `ReadPresentation`: Reads an existing presentation from array
- `ReadPresentation`: Reads an existing presentation from array with additional load options
- `ReadPresentation`: Reads an existing presentation from stream
- `ReadPresentation`: Reads an existing presentation from stream with additional load options
- `ReadPresentation`: Reads an existing presentation from file
- `ReadPresentation`: Reads an existing presentation from stream with additional load options

---

## IPresentationHeaderFooterManager

**Full Name**: `Aspose.Slides.IPresentationHeaderFooterManager`

**Description**: Represents manager which holds behavior of all footer, date-time and page number placeholders of presentation.

**Key Members**:

*Propertys*:
- `AsIBaseHeaderFooterManager`: Returns IBaseHeaderFooterManager interface.

*Methods*:
- `SetAllHeadersVisibility`: Changes all header placeholders visibility, including notes master, notes slides and handout master.
- `SetAllFootersVisibility`: Changes all footer placeholders visibility, including master slides, layout slides and slides.
- `SetAllSlideNumbersVisibility`: Changes all page number placeholders visibility, including master slides, layout slides and slides.
- `SetAllDateTimesVisibility`: Changes all date-time placeholders visibility, including master slides, layout slides and slides.
- `SetAllHeadersText`: Sets text to all header placeholders, including notes master, notes slides and handout master.
- `SetAllFootersText`: Sets text to all footer placeholders, including master slides, layout slides and slides.
- `SetAllDateTimesText`: Sets text to all date-time placeholders, including master slides, layout slides and slides.
- `SetVisibilityOnAllTitleSlides`: Changes the footer, date-time and page number placeholders visibility for all title slides and for f

---

## IPresentationInfo

**Full Name**: `Aspose.Slides.IPresentationInfo`

**Description**: Information about presentation file

**Key Members**:

*Propertys*:
- `IsEncrypted`: Gets True if binded presentation is encrypted, otherwise False. Read-only
- `IsPasswordProtected`: Gets a value that indicates whether a binded presentation is protected by a password to open.
- `IsWriteProtected`: Gets a value that indicates whether a binded presentation is write protected.
- `LoadFormat`: Gets format of the binded presentation. Read-only

*Methods*:
- `CheckPassword`: Checks whether a password is correct for a presentation protected with open password.
- `CheckWriteProtection`: Checks whether a password to modify is correct for a write protected presentation.
- `ReadDocumentProperties`: Gets document properties of binded presentation.
- `UpdateDocumentProperties`: Updates properties of binded presentation.
- `WriteBindedPresentation`: Writes binded presentation to stream.
- `WriteBindedPresentation`: Writes binded presentation to file.

---

## IPresentationText

**Full Name**: `Aspose.Slides.IPresentationText`

**Description**: Represents the text extracted from the slide

**Key Members**:

*Propertys*:
- `SlidesText`: An array of

---

## IProgressCallback

**Full Name**: `Aspose.Slides.IProgressCallback`

**Description**: Represents a callback object for saving progress updates in percentage.

**Key Members**:

*Methods*:
- `Reporting`: Reports a progress update.

---

## IProtectionManager

**Full Name**: `Aspose.Slides.IProtectionManager`

**Description**: Presentation password protection management.

**Key Members**:

*Propertys*:
- `EncryptDocumentProperties`: This property makes sense, if presentation is password protected. If true then document properties i
- `IsEncrypted`: Gets a value indicating whether this instance is encrypted. Read-only
- `IsOnlyDocumentPropertiesLoaded`: This property makes sense, if presentation file is password protected and document properties of thi
- `IsWriteProtected`: Gets a value indicating whether this presentation is write protected. Read-only
- `EncryptionPassword`: Returns encryption password. Read-only
- `ReadOnlyRecommended`: Gets or sets read-only recommendation. Read/write

*Methods*:
- `Encrypt`: Encrypts Presentation with specified password.
- `RemoveEncryption`: Removes the encryption.
- `SetWriteProtection`: Set write protection for this presentation with specified password.
- `RemoveWriteProtection`: Removes write protection for this presentation.
- `CheckWriteProtection`: Determines whether a presentation is a password protected to modify.

---

## IResourceLoadingArgs

**Full Name**: `Aspose.Slides.IResourceLoadingArgs`

**Description**: Interface for external resource loading arguments.

**Key Members**:

*Propertys*:
- `OriginalUri`: Original URI of the resource as specified in imported presentation.
- `Uri`: URI of the resource which is used for downloading if

*Methods*:
- `SetData`: Sets user provided data of the resource which used if

---

## IResourceLoadingCallback

**Full Name**: `Aspose.Slides.IResourceLoadingCallback`

**Description**: Callback interface used to manage external resources loading.

**Key Members**:

*Methods*:
- `ResourceLoading`: Callback method which regulates external resources loading.

---

## IRow

**Full Name**: `Aspose.Slides.IRow`

**Description**: Represents a row in a table.

**Key Members**:

*Propertys*:
- `Height`: Returns the height of a row. Read-only
- `MinimalHeight`: Returns or sets the minimal possible height of a row. Read/write
- `RowFormat`: Returns the RowFormat object that contains formatting properties for this row. Read-only
- `AsICellCollection`: Allows to get base ICellCollection interface. Read-only
- `AsIBulkTextFormattable`: Allows to get base IBulkTextFormattable interface. Read-only

---

## IRowCollection

**Full Name**: `Aspose.Slides.IRowCollection`

**Description**: Represents table row collection.

**Key Members**:

*Propertys*:
- `Item`: Gets the element at the specified index.

*Methods*:
- `AddClone`: Creates a copy of the specified template row and inserts it at the bottom of a table.
- `InsertClone`: Creates a copy of the specified template row and insert it at the specified position in a table.
- `RemoveAt`: Removes a row at the specified position from a table.

---

## IRowFormat

**Full Name**: `Aspose.Slides.IRowFormat`

**Description**: Represents format of a table row.

**Key Members**:

*Methods*:
- `GetEffective`: Gets effective table row formatting properties with inheritance and table styles applied.

---

## IRowFormatEffectiveData

**Full Name**: `Aspose.Slides.IRowFormatEffectiveData`

**Description**: Immutable object which contains effective table row formatting properties.

**Key Members**:

*Propertys*:
- `AsIBaseTableFormatEffectiveData`: Allows to get base IBaseTableFormatEffectiveData interface. Read-only

---

## ISection

**Full Name**: `Aspose.Slides.ISection`

**Description**: Represents section of slides.

**Key Members**:

*Propertys*:
- `Name`: Name of the section.
- `SectionId`: Section Id.
- `StartedFromSlide`: Returns first slide of the section.

*Methods*:
- `GetSlidesListOfSection`: Returns list of slides in the section.

---

## ISectionCollection

**Full Name**: `Aspose.Slides.ISectionCollection`

**Description**: Represents a collection of sections.

**Key Members**:

*Propertys*:
- `Item`: Gets the element at the specified index. Read-only

*Methods*:
- `AddSection`: Add new section started form specific slide.
- `AddEmptySection`: Add empty section to specified position of the collection.
- `RemoveSectionWithSlides`: Remove section and slides contained in the section.
- `RemoveSection`: Remove section. Slides contained in the section will be merged into previous section.
- `ReorderSectionWithSlides`: Moves section and its slides from the collection to the specified position.
- `AppendEmptySection`: Add empty section to the end of the collection.
- `IndexOf`: Returns an index of the specified section in the collection.
- `Clear`: Removes all sections from the collection.

---

## ISectionSlideCollection

**Full Name**: `Aspose.Slides.ISectionSlideCollection`

**Description**: Represents a collection of a slides in the section.

**Key Members**:

*Propertys*:
- `Item`: Gets the element at the specified index. Read-only

---

## ISectionZoomFrame

**Full Name**: `Aspose.Slides.ISectionZoomFrame`

**Description**: Represents a Section Zoom object in a slide.

**Key Members**:

*Propertys*:
- `TargetSection`: Gets or sets the section object that the Section Zoom object is linked to. Read/write
- `AsIZoomObject`: Returns IZoomObject interface.

---

## IShape

**Full Name**: `Aspose.Slides.IShape`

**Description**: Represents a shape on a slide.

**Key Members**:

*Propertys*:
- `IsTextHolder`: Determines whether the shape is TextHolder. Read-only
- `Placeholder`: Returns the placeholder for a shape. Read-only
- `CustomData`: Returns the shape's custom data. Read-only
- `RawFrame`: Returns or sets the raw shape frame's properties. Read/write
- `Frame`: Returns or sets the shape frame's properties. Read/write
- `LineFormat`: Returns the LineFormat object that contains line formatting properties for a shape. Read-only
- `ThreeDFormat`: Returns the ThreeDFormat object that contains line formatting properties for a shape. Read-only
- `EffectFormat`: Returns the EffectFormat object which contains pixel effects applied to a shape. Read-only
- `FillFormat`: Returns the FillFormat object that contains fill formatting properties for a shape. Read-only
- `Hidden`: Determines whether the shape is hidden. Read/write

*Methods*:
- `AddPlaceholder`: Adds a new placeholder if there is no and sets placeholder properties to a specified one.
- `RemovePlaceholder`: Defines that this shape isn't a placeholder.
- `GetThumbnail`: Returns shape thumbnail. ShapeThumbnailBounds.Shape shape thumbnail bounds type is used by default.
- `GetImage`: Returns shape thumbnail. ShapeThumbnailBounds.Shape shape thumbnail bounds type is used by default.
- `GetThumbnail`: Returns shape thumbnail.
- `GetImage`: Returns shape thumbnail.

---

## IShapeBevel

**Full Name**: `Aspose.Slides.IShapeBevel`

**Description**: Represents properties of shape's main face relief.

**Key Members**:

*Propertys*:
- `Width`: Bevel width. Read/write
- `Height`: Bevel height. Read/write
- `BevelType`: Bevel type. Read/write

---

## IShapeBevelEffectiveData

**Full Name**: `Aspose.Slides.IShapeBevelEffectiveData`

**Description**: Immutable object which contains effective shape's face relief properties.

**Key Members**:

*Propertys*:
- `Width`: Bevel width. Read-only
- `Height`: Bevel height. Read-only
- `BevelType`: Bevel type. Read-only

---

## IShapeCollection

**Full Name**: `Aspose.Slides.IShapeCollection`

**Description**: Represents a collection of shapes.

**Key Members**:

*Propertys*:
- `Item`: Gets the element at the specified index. Read-only
- `ParentGroup`: Gets the parent group shape object for the shapes collection. Read-only

*Methods*:
- `AddChart`: Creates a new chart, initializes it with sample series data and settings, and adds it to the end of 
- `AddChart`: Creates a new chart, initializes it with sample series data and settings, and adds it to the end of 
- `AddSmartArt`: Creates a SmartArt diagram and adds it to the end of the shape collection.
- `InsertChart`: Creates a new chart, initializes it with sample series data and settings, and inserts it into the sh
- `InsertChart`: Creates a new chart, initializes it with sample series data and settings, and inserts it into the sh
- `AddOleObjectFrame`: Creates a new OLE object frame and adds it to the end of the shape collection.
- `AddOleObjectFrame`: Creates a new OLE object frame and adds it to the end of the shape collection.
- `InsertOleObjectFrame`: Creates a new OLE object frame and inserts it into the shape collection at the specified index.
- `InsertOleObjectFrame`: Creates a new OLE object frame and inserts it into the shape collection at the specified index.
- `AddZoomFrame`: Creates a new Zoom frame and adds it to the end of the shape collection.

---

## IShapeElement

**Full Name**: `Aspose.Slides.IShapeElement`

**Description**: Represents a part of shape with same outline and fill properties.

---

## IShapeFrame

**Full Name**: `Aspose.Slides.IShapeFrame`

**Description**: Represents shape frame's properties.

**Key Members**:

*Propertys*:
- `X`: Returns the X coordinate of the upper-left corner of a frame. Read-only
- `Y`: Returns the Y coordinate of the upper-left corner of a frame. Read-only
- `Width`: Returns the width of a frame. Read-only
- `Height`: Returns the height of a frame. Read-only
- `Rotation`: Returns the number of degrees a frame is rotated around the z-axis. A positive value indicates clock
- `CenterX`: Returns the X coordinate of a frame's center. Read-only
- `CenterY`: Returns the Y coordinate of a frame's center. Read-only
- `FlipH`: Determines whether a frame is flipped horizontally. Read-only
- `FlipV`: Determines whether a frame is flipped vertically. Read-only
- `Rectangle`: Returns the coordinates of a frame. Read-only

---

## IShapeStyle

**Full Name**: `Aspose.Slides.IShapeStyle`

**Description**: Represent shape's style reference.

**Key Members**:

*Propertys*:
- `LineColor`: Returns a shape's outline color. Read-only
- `LineStyleIndex`: Returns or sets line's column index in a style matrix. Read/write
- `FillColor`: Returns a shape's fill color. Read-only
- `FillStyleIndex`: Returns or sets shape's fill column index in style matrices. 0 means no fill, positive value - index
- `EffectColor`: Returns a shape's effect color. Read-only
- `EffectStyleIndex`: Returns or sets shape's effect column index in a style matrix. Read/write
- `FontColor`: Returns a shape's font color. Read-only
- `FontCollectionIndex`: Returns or sets shape's font index in a font collection. Read/write

---

## ISketchFormat

**Full Name**: `Aspose.Slides.ISketchFormat`

**Description**: Represents properties for lines sketch format.

**Key Members**:

*Propertys*:
- `SketchType`: Returns or sets the sketch type. Read/write

---

## ISketchFormatEffectiveData

**Full Name**: `Aspose.Slides.ISketchFormatEffectiveData`

**Description**: Immutable object which contains effective line sketch properties.

**Key Members**:

*Propertys*:
- `SketchType`: Returns the sketch type. Read only

---

## ISlide

**Full Name**: `Aspose.Slides.ISlide`

**Description**: Represents a slide in a presentation.

**Key Members**:

*Propertys*:
- `HeaderFooterManager`: Returns HeaderFooter manager of the slide. Read-only
- `SlideNumber`: Returns a number of slide. Index of slide in
- `Hidden`: Determines whether the specified slide is hidden during a slide show. Read/write

*Methods*:
- `GetThumbnail`: Returns a Thumbnail Bitmap object with custom scaling.
- `GetImage`: Returns an image object with custom scaling.
- `GetThumbnail`: Returns a Thumbnail Image object (20% of real size).
- `GetImage`: Returns a Thumbnail Image object (20% of real size).
- `GetThumbnail`: Returns a Thumbnail Bitmap object with specified size.
- `GetImage`: Returns an image object with specified size.
- `GetThumbnail`: Returns a Thumbnail tiff bitmap object with specified parameters.
- `GetImage`: Returns a Thumbnail tiff bitmap object with specified parameters.
- `GetThumbnail`: Returns a Thumbnail Bitmap object.
- `GetImage`: Returns a Thumbnail Bitmap object.

---

## ISlideCollection

**Full Name**: `Aspose.Slides.ISlideCollection`

**Description**: Represents a collection of a slides.

**Key Members**:

*Propertys*:
- `Item`: Gets the element at the specified index. Read-only

*Methods*:
- `AddClone`: Adds a copy of a specified slide to the end of the collection.
- `AddClone`: Adds a copy of a specified slide to the end of the specified section.
- `InsertClone`: Inserts a copy of a specified slide to specified position of the collection.
- `AddEmptySlide`: Adds a new empty slide to the end of the collection.
- `InsertEmptySlide`: Inserts a copy of a specified slide to specified position of the collection.
- `AddClone`: Adds a copy of a specified slide to the end of the collection.
- `InsertClone`: Inserts a copy of a specified slide to specified position of the collection.
- `AddClone`: Adds a copy of a specified source slide to the end of the collection. Appropriate layout will be sel
- `InsertClone`: Inserts a copy of a specified source slide to specified position of the collection. Appropriate layo
- `Remove`: Removes the first occurrence of a specific object from the collection.

---

## ISlideComponent

**Full Name**: `Aspose.Slides.ISlideComponent`

**Description**: Represents a component of a slide.

**Key Members**:

*Propertys*:
- `Slide`: Returns the base slide. Read-only
- `AsIPresentationComponent`: Allows to get base IPresentationComponent interface. Read-only

---

## ISlideHeaderFooterManager

**Full Name**: `Aspose.Slides.ISlideHeaderFooterManager`

**Description**: Represents manager which holds behavior of the slide footer, date-time, page number placeholders.

**Key Members**:

*Propertys*:
- `AsIBaseSlideHeaderFooterManager`: Returns IBaseSlideHeaderFooterManager interface.

---

## ISlideShowTransition

**Full Name**: `Aspose.Slides.ISlideShowTransition`

**Description**: Represents slide show transition.

**Key Members**:

*Propertys*:
- `Sound`: Returns or sets the embedded audio data. Read-write
- `SoundMode`: Set or returns sound mode for slide transition. Read-write
- `SoundLoop`: This attribute specifies if the sound will loop until the next sound event occurs in slideshow. Read
- `AdvanceOnClick`: Specifies whether a mouse click will advance the slide or not. If this attribute is not specified th
- `AdvanceAfter`: This attribute specifies if the slideshow will move to the next slide after a certain time. Read/wri
- `AdvanceAfterTime`: Specifies the time, in milliseconds, after which the transition should start. This setting may be us
- `Speed`: Specifies the transition speed that is to be used when transitioning from the current slide to the n
- `Value`: Slide show transition value. Read-only
- `Type`: Type of transition. Read-write
- `SoundIsBuiltIn`: Specifies whether or not this sound is a built-in sound. If this attribute is set to true then the g

---

## ISlideSize

**Full Name**: `Aspose.Slides.ISlideSize`

**Description**: Represents the size and orientation of a slide.

**Key Members**:

*Propertys*:
- `Size`: Gets the slide dimensions in points.
- `Type`: Gets the slide size type.
- `Orientation`: Gets or sets the slide orientation.

*Methods*:
- `SetSize`: Sets the slide size by type and scales existing content.
- `SetSize`: Sets the slide dimensions explicitly and scales existing content.

---

## ISlideText

**Full Name**: `Aspose.Slides.ISlideText`

**Description**: Represents the text extracted from the slide

**Key Members**:

*Propertys*:
- `Text`: The text on the slide's shapes
- `MasterText`: The text on the master page's shapes for this slide
- `LayoutText`: The text on the layout page's shapes for this slide
- `NotesText`: The text on the notes page's shapes for this slide
- `CommentsText`: The text of the slide comments

---

## ISlidesPicture

**Full Name**: `Aspose.Slides.ISlidesPicture`

**Description**: Represents a picture in a presentation.

**Key Members**:

*Propertys*:
- `Image`: Returns or sets the embedded image. Read/write
- `LinkPathLong`: Returns of sets linked image's URL. Read/write
- `ImageTransform`: Returns the collection of image transform effects. Read-only
- `AsISlideComponent`: Allows to get base ISlideComponent interface. Read-only

---

## ISpreadsheetOptions

**Full Name**: `Aspose.Slides.ISpreadsheetOptions`

**Description**: Represents options which can be used to specify additional spreadsheets behavior.

**Key Members**:

*Propertys*:
- `PreferredCulture`: Gets or sets preferred culture information for calculating some functions intended for use with lang
- `RecoverWorkbookFromChartCache`: If data source for the chart is an external workbook and it's not available, it will be recovered fr

---

## IStreamWrapper

**Full Name**: `Aspose.Slides.IStreamWrapper`

**Description**: Aspose.IO.Stream wrapper for COM interface.

**Key Members**:

*Propertys*:
- `Stream`: Gets a stream. Read-only
- `CanRead`: Gets a value indicating whether the current stream supports reading. Read-only
- `CanSeek`: Gets a value indicating whether the current stream supports seeking. Read-only
- `CanWrite`: Gets a value indicating whether the current stream supports writing. Read-only
- `Length`: Gets the length in bytes of the stream. Read-only
- `Position`: Gets the position within the current stream. Read-only
- `AsIDisposable`: Allows to get base IDisposable interface. Read-only

*Methods*:
- `Close`: Closes the current stream and releases any resources.
- `Flush`: Clears all buffers for this stream and causes any buffered data to be written to the underlying devi
- `Read`: Reads a sequence of bytes from the current stream and advances the position within the stream by the
- `ReadByte`: Reads a byte from the stream and advances the position within the stream by one byte, or returns -1 
- `Seek`: Sets the position within the current stream
- `Write`: writes a sequence of bytes to the current stream and advances the current position within this strea
- `WriteByte`: Writes a byte to the current position in the stream and advances the position within the stream by o

---

## IStreamWrapperFactory

**Full Name**: `Aspose.Slides.IStreamWrapperFactory`

**Description**: Factory of StreamWrappers. For COM interface.

**Key Members**:

*Methods*:
- `CreateMemoryStreamWrapper`: Creates MemoryStream wrapper.
- `CreateMemoryStreamWrapper`: Creates MemoryStream wrapper based on the specified byte array.
- `CreateFileStreamWrapper`: Creates FileStream with the specified path and creation mode.
- `CreateFileStreamWrapper`: Creates FileStream with the specified path, creation mode, and read/write permission.

---

## ISummaryZoomFrame

**Full Name**: `Aspose.Slides.ISummaryZoomFrame`

**Description**: Represents a Summary Zoom frame in a slide.

**Key Members**:

*Propertys*:
- `Layout`: Gets layout of Summary Zoom Sections in the frame. Default value is GridLayout.
- `SummaryZoomCollection`: Gets
- `AsIGraphicalObject`: Returns IGraphicalObject interface.

---

## ISummaryZoomSection

**Full Name**: `Aspose.Slides.ISummaryZoomSection`

**Description**: Represents a Summary Zoom Section object in a Summary Zoom frame.

**Key Members**:

*Propertys*:
- `Title`: Returns the text title of the Summary Zoom Section object.
- `Description`: Returns the text description of the Summary Zoom Section object.
- `AsISectionZoomFrame`: Returns ISectionZoomFrame interface.

---

## ISummaryZoomSectionCollection

**Full Name**: `Aspose.Slides.ISummaryZoomSectionCollection`

**Description**: Represents a collection of Summary Zoom Section objects.

**Key Members**:

*Propertys*:
- `Item`: Gets the element at the specified index. Read-only

*Methods*:
- `AddSummaryZoomSection`: Creates new Summary Zoom Section object and add it to the collection
- `GetSummarySection`: Returns Summary Zoom Section element for the given section.
- `RemoveSummaryZoomSection`: Remove Summary Zoom Section object from the collection.
- `IndexOf`: Returns an index of the specified SummaryZoomSection object.
- `Clear`: Removes all SummaryZoomSection objects from the collection.

---

## ISvgImage

**Full Name**: `Aspose.Slides.ISvgImage`

**Description**: Represents an SVG image.

**Key Members**:

*Propertys*:
- `SvgContent`: Returns SVG content. Read-only
- `SvgData`: Returns SVG data. Read-only
- `ExternalResourceResolver`: Return callback interface used to resolve external resources during SVG documents import. Read-only
- `BaseUri`: Returns base URI of the specified SVG. Used to resolve relative links. Read-only

*Methods*:
- `WriteAsEmf`: Saves the SVG image as an EMF file.

---

## ITab

**Full Name**: `Aspose.Slides.ITab`

**Description**: Represents a tabulation for a text.

**Key Members**:

*Propertys*:
- `Position`: Returns or sets position of a tab. Assigning this property can change tab's index in collection and 
- `Alignment`: Returns or sets align style of a tab. Read/write
- `AsIComparable`: Returns IComparable interface. Read-only

---

## ITabCollection

**Full Name**: `Aspose.Slides.ITabCollection`

**Description**: Represents a collection of tabs.

**Key Members**:

*Propertys*:
- `Item`: Gets the element at the specified index. Read-only

*Methods*:
- `Add`: Adds a Tab to the collection.
- `Add`: Adds a Tab to the collection.
- `Clear`: Removes all elements from the collection.
- `RemoveAt`: Removes the element at the specified index of the collection.

---

## ITabEffectiveData

**Full Name**: `Aspose.Slides.ITabEffectiveData`

**Description**: Immutable object which contains effective text's tabulation stop properties.

**Key Members**:

*Propertys*:
- `Position`: Returns position of a tab. Assigning this property can change tab's index in collection and invalida
- `Alignment`: Returns align style of a tab. Read-only
- `AsIComparable`: Returns IComparable interface. Read-only

---

## ITabFactory

**Full Name**: `Aspose.Slides.ITabFactory`

**Description**: Allow to create ITab instances

**Key Members**:

*Methods*:
- `CreateTab`: Creates a new ITab instance.

---

## ITable

**Full Name**: `Aspose.Slides.ITable`

**Description**: Represents a table on a slide.

**Key Members**:

*Propertys*:
- `Item`: Returns the cell at the specified column and row indexes. Read-only
- `Rows`: Returns the collectoin of rows. Read-only
- `Columns`: Returns the collectoin of columns. Read-only
- `TableFormat`: Returns the TableFormat object that contains formatting properties for this table. Read-only
- `StylePreset`: Get's or sets builtin table style. Read/write
- `RightToLeft`: Determines whether the table has right to left reading order. Read-write
- `FirstRow`: Determines whether the first row of a table has to be drawn with a special formatting. Read/write
- `FirstCol`: Determines whether the first column of a table has to be drawn with a special formatting. Read/write
- `LastRow`: Determines whether the last row of a table has to be drawn with a special formatting. Read/write
- `LastCol`: Determines whether the last column of a table has to be drawn with a special formatting. Read/write

*Methods*:
- `MergeCells`: Merges neighbour cells.

---

## ITableFormat

**Full Name**: `Aspose.Slides.ITableFormat`

**Description**: Represents format of a table.

**Key Members**:

*Propertys*:
- `FillFormat`: Returns a table fill properties object. Read-only
- `Transparency`: Gets or sets the transparency of the fill color. Read/write

*Methods*:
- `GetEffective`: Gets effective table formatting properties with inheritance and table styles applied.

---

## ITableFormatEffectiveData

**Full Name**: `Aspose.Slides.ITableFormatEffectiveData`

**Description**: Immutable object which contains effective table formatting properties.

**Key Members**:

*Propertys*:
- `Transparency`: Gets the transparency of the fill color. Read
- `AsIBaseTableFormatEffectiveData`: Allows to get base IBaseTableFormatEffectiveData interface. Read-only

---

## ITagCollection

**Full Name**: `Aspose.Slides.ITagCollection`

**Description**: Represents the collection of tags (user defined pairs of strings)

**Key Members**:

*Propertys*:
- `Item`: Returns or sets a key and a value pair of a tag.

*Methods*:
- `Add`: Adds a new tag to collection.
- `Remove`: Removes the tag with a specified name from the collection.
- `IndexOfName`: Returns the zero-based index of the specified key in the collection.
- `Contains`: Determines whether the collection contains a specific name.
- `RemoveAt`: Removes the tag at the specified index.
- `Clear`: Removes all tags from the collection.
- `GetValueByIndex`: Returns value of a tag at the specified index.
- `GetNameByIndex`: Returns key of a tag at the specified index.
- `GetNamesOfTags`: Returns names of tags.

---

## ITextFrame

**Full Name**: `Aspose.Slides.ITextFrame`

**Description**: Represents a TextFrame.

**Key Members**:

*Propertys*:
- `Paragraphs`: Returns the list of all paragraphs in a frame. Read-only
- `Text`: Gets or sets the plain text for a TextFrame. Read/write
- `TextFrameFormat`: Returns the formatting object for this TextFrame object. Read-only
- `HyperlinkQueries`: Provides easy access to contained hyperlinks. Read-only
- `ParentShape`: Returns the parent shape or null if the parent object does not implement the IShape interface Read-o
- `ParentCell`: Returns the parent cell or null if the parent object does not implement the ICell interface. Read-on
- `AsISlideComponent`: Allows to get base ISlideComponent interface. Read-only

*Methods*:
- `JoinPortionsWithSameFormatting`: Joins runs with same formatting in all paragraphs.
- `HighlightText`: Highlights all matches of the sample text with the specified color.
- `SplitTextByColumns`: Splits the text content of the
- `HighlightText`: Highlights all matches of the sample text with the specified color.
- `HighlightText`: Highlights all matches of the sample text with the specified color.
- `HighlightRegex`: Highlights all matches of the regular expression with the specified color.
- `HighlightRegex`: Highlights all matches of the regular expression with the specified color.
- `ReplaceText`: Replaces all occurrences of the specified text with another specified text.
- `ReplaceRegex`: Replaces all matches of the regular expression with the specified string.

---

## ITextFrameFormat

**Full Name**: `Aspose.Slides.ITextFrameFormat`

**Description**: Contains the TextFrame's formatting properties.

**Key Members**:

*Propertys*:
- `TextStyle`: Returns text's style. Read-only
- `MarginLeft`: Returns or sets the left margin (points) in a TextFrame. Read/write
- `MarginRight`: Returns or sets the right margin (points) in a TextFrame. Read/write
- `MarginTop`: Returns or sets the top margin (points) in a TextFrame. Read/write
- `MarginBottom`: Returns or sets the bottom margin (points) in a TextFrame. Read/write
- `WrapText`
- `AnchoringType`: Returns or sets vertical anchor text in a TextFrame. Read/write
- `CenterText`: If NullableBool.True then text should be centered in box horizontally. Read/write
- `TextVerticalType`: Determines text orientation. The resulted value of visual text rotation summarized from this propert
- `AutofitType`: Returns or sets text's autofit mode. Read/write

*Methods*:
- `GetEffective`: Gets effective text frame formatting data with the inheritance applied.

---

## ITextFrameFormatEffectiveData

**Full Name**: `Aspose.Slides.ITextFrameFormatEffectiveData`

**Description**: Immutable object which contains effective text frame formatting properties.

**Key Members**:

*Propertys*:
- `TextStyle`: Returns effective text's style. Read-only
- `MarginLeft`: Returns the left margin (points) in a TextFrame. Read-only
- `MarginRight`: Returns the right margin (points) in a TextFrame. Read-only
- `MarginTop`: Returns the top margin (points) in a TextFrame. Read-only
- `MarginBottom`: Returns the bottom margin (points) in a TextFrame. Read-only
- `WrapText`: Returns if text is wrapped at TextFrame's margins. Read-only
- `AnchoringType`: Returns vertical anchor text in a TextFrame. Read-only
- `CenterText`: Returns if text should be centered in box horizontally. Read-only
- `TextVerticalType`: Returns text orientation. Read-only
- `AutofitType`: Returns text autofit mode. Read-only

---

## ITextHighlightingOptions

**Full Name**: `Aspose.Slides.ITextHighlightingOptions`

**Description**: Represents options which can be used to highlight text in text frame.

**Key Members**:

*Propertys*:
- `CaseSensitive`: Set true to use case-sensitive search, false - otherwise. Read/write
- `WholeWordsOnly`: Set true to match only whole words, false - otherwise. Read/write

---

## ITextSearchOptions

**Full Name**: `Aspose.Slides.ITextSearchOptions`

**Description**: Represents options that can be used to search for text in a Presentation, Slide or TextFrame.

**Key Members**:

*Propertys*:
- `CaseSensitive`: Set true to use case-sensitive search, false - otherwise. Read/write
- `WholeWordsOnly`: Set true to match only whole words, false - otherwise. Read/write

---

## ITextStyle

**Full Name**: `Aspose.Slides.ITextStyle`

**Description**: Text style formatting properties.

**Key Members**:

*Propertys*:
- `DefaultParagraphFormat`: Default paragraph propertiies. Read-only

*Methods*:
- `GetLevel`: If level of style exist returns it, otherwise returns null.
- `GetEffective`: Gets effective text style formatting data with the inheritance applied.

---

## ITextStyleEffectiveData

**Full Name**: `Aspose.Slides.ITextStyleEffectiveData`

**Description**: Immutable object which contains effective text style properties.

**Key Members**:

*Propertys*:
- `DefaultParagraphFormat`: Returns effective default paragraph properties. Read-only

*Methods*:
- `GetLevel`: Returns level of effective style.

---

## IThreeDFormat

**Full Name**: `Aspose.Slides.IThreeDFormat`

**Description**: Represents 3-D properties.

**Key Members**:

*Propertys*:
- `ContourWidth`: Returns or sets the width of a 3D contour. Read/write
- `ExtrusionHeight`: Returns or sets the height of an extrusion effect. Read/write
- `Depth`: Returns or sets the depth of a 3D shape. Read/write
- `BevelTop`: Returns or sets the type of a top 3D bevel. Read-only
- `BevelBottom`: Returns or sets the type of a bottom 3D bevel. Read-only
- `ContourColor`: Returns or sets the color of a contour. Read-only
- `ExtrusionColor`: Returns or sets the color of an extrusion. Read-only
- `Camera`: Returns or sets the settings of a camera. Read-only
- `LightRig`: Returns or sets the type of a light. Read-only
- `Material`: Returns or sets the type of a material. Read/write

*Methods*:
- `GetEffective`: Gets effective 3-D formatting data with the inheritance applied.

---

## IThreeDFormatEffectiveData

**Full Name**: `Aspose.Slides.IThreeDFormatEffectiveData`

**Description**: Immutable object which represents effective 3-D formatting properties.

**Key Members**:

*Propertys*:
- `ContourWidth`: Returns the width of a 3D contour. Read-only
- `ExtrusionHeight`: Returns the height of an extrusion effect. Read-only
- `Depth`: Returns the depth of a 3D shape. Read-only
- `BevelTop`: Returns the type of a top 3D bevel. Read-only
- `BevelBottom`: Returns the type of a bottom 3D bevel. Read-only
- `ContourColor`: Returns the color of a contour. Read-only
- `ExtrusionColor`: Returns the color of an extrusion. Read-only
- `Camera`: Returns the settings of a camera. Read-only
- `LightRig`: Returns the type of a light. Read-only
- `Material`: Returns the type of a material. Read-only

---

## IThreeDParamSource

**Full Name**: `Aspose.Slides.IThreeDParamSource`

**Description**: 3D properties source auxiliary interface

---

## IVideo

**Full Name**: `Aspose.Slides.IVideo`

**Description**: Represents a video embedded into a presentation.

**Key Members**:

*Propertys*:
- `ContentType`: Returns a MIME type of an video, encoded in
- `BinaryData`: Returns the copy of an audio's data. In case of large amount of data consider using of

*Methods*:
- `GetStream`: Returns Stream stream for reading. Use 'using' or close stream after using.

---

## IVideoCollection

**Full Name**: `Aspose.Slides.IVideoCollection`

**Description**: Represents a collection of Video objects.

**Key Members**:

*Propertys*:
- `Item`: Gets the element at the specified index. Read-only

*Methods*:
- `AddVideo`: Adds a copy of an video file from an another presentation.
- `AddVideo`: Creates and adds a video to a presentation from stream.
- `AddVideo`: Creates and adds a video to a presentation from byte array.

---

## IVideoFrame

**Full Name**: `Aspose.Slides.IVideoFrame`

**Description**: Represents a video clip on a slide.

**Key Members**:

*Propertys*:
- `RewindVideo`: Determines whether a video is automatically rewinded to start as soon as the movie has finished play
- `PlayLoopMode`: Determines whether a video is looped. Read/write
- `HideAtShowing`: Determines whether a VideoFrame is hidden. Read/write
- `Volume`: Returns or sets the audio volume. Read/write
- `PlayMode`: Returns or sets the video play mode. Read/write
- `FullScreenMode`: Determines whether a video is shown in full screen mode. Read/write
- `LinkPathLong`: Returns or sets the name of an video file which is linked to a VideoFrame. Read/write
- `EmbeddedVideo`: Returns or sets embedded video object. Read/write
- `TrimFromStart`: Trim start [ms]
- `TrimFromEnd`: Trim end [ms]

---

## IViewProperties

**Full Name**: `Aspose.Slides.IViewProperties`

**Description**: Presentation wide view properties.

**Key Members**:

*Propertys*:
- `LastView`: Specifies the view mode that was used when the presentation document was last saved. Read/write
- `ShowComments`: Specifies whether the slide comments should be shown. Read/write
- `SlideViewProperties`: Specifies common view properties associated with the slide view mode. Read-only
- `NotesViewProperties`: Specifies common view properties associated with the notes view mode. Read-only
- `NormalViewProperties`: Represents normal view properties. The normal view consists of three content regions: the slide itse
- `GridSpacing`: Returns or sets the grid spacing that should be used for the grid underlying the presentation docume

---

## IZoomFrame

**Full Name**: `Aspose.Slides.IZoomFrame`

**Description**: Represents a Slide Zoom object in a slide.

**Key Members**:

*Propertys*:
- `TargetSlide`: Gets or sets the slide object that the Slide Zoom object links to. Read/write
- `AsIZoomObject`: Returns IZoomObject interface.

---

## IZoomObject

**Full Name**: `Aspose.Slides.IZoomObject`

**Description**: Represents a Zoom object in a slide.

**Key Members**:

*Propertys*:
- `ImageType`: Gets or sets the image type of a zoom object. Read/write
- `ReturnToParent`: Gets or sets the navigation behavior in slideshow. Read/write
- `ShowBackground`: Gets or sets value that specifies whether the Zoom will use the background of the destination slide.
- `ZoomImage`: Gets or sets image for zoom object. Read/write
- `TransitionDuration`: Gets or sets the duration of the transition between Zoom and slide. Read/write
- `AsIGraphicalObject`: Allows to get base IGraphicalObject interface. Read-only

---

## ImageCollection

**Full Name**: `Aspose.Slides.ImageCollection`

**Description**: Represents collection of PPImage.

**Key Members**:

*Propertys*:
- `Count`: Returns a number of images in the collection. Read-only
- `Item`: Gets the element at the specified index. Read-only
- `IsSynchronized`: Returns a value indicating whether access to the collection is synchronized (thread-safe). Read-only
- `SyncRoot`: Returns a synchronization root. Read-only

*Methods*:
- `AddImage`: Adds a copy of an image from an another presentation.
- `AddImage`: Add an image to a presentation.
- `AddImage`: Add an image to a presentation.
- `AddImage`: Add an image to a presentation from stream.
- `AddImage`: Add an image to a presentation from stream.
- `AddImage`: Creates and adds an image to a presentation from stream.
- `AddImage`: Adds an image to a presentation from specified buffer.
- `AddImage`: Add an image to a presentation from Svg object.
- `AddImage`: Add the scaled image to a presentation from Svg object.
- `AddImage`: Add an bitmap image to a presentation from Svg object.

---

## ImageFormat

**Full Name**: `Aspose.Slides.ImageFormat`

**Description**: Represents the file format of the image.

**Key Members**:

---

## ImageWrapper

**Full Name**: `Aspose.Slides.ImageWrapper`

**Description**: System.Drawing.Image wrapper for COM interface.

**Key Members**:

*Propertys*:
- `Image`: Gets Image. Read-only
- `ImageSource`: Gets Image. Read-only
- `Size`: Gets the width and height, in pixels, of the Image. Read-only

*Methods*:
- `Dispose`: Dispose ImageWrapper
- `Save`: Saves Image to the specified file
- `Save`: Saves the Image to the specified stream in the specified format.
- `Save`: Saves the Image to the specified file in the specified format.
- `Dispose`: Dispose ImageWrapper

---

## ImageWrapperFactory

**Full Name**: `Aspose.Slides.ImageWrapperFactory`

**Description**: This class allows to initialize IBitmapWrapper.

**Key Members**:

*Methods*:
- `CreateImageWrapper`: Initializes a new instance of the BitmapWrapper class from the specified existing image.
- `CreateImageWrapper`: Initializes a new instance of the ImageWrapper class from the specified existing image.
- `CreateImageWrapper`: Initializes a new instance of the BitmapWrapper class from the specified data stream.
- `CreateImageWrapper`: Initializes a new instance of the BitmapWrapper class from the specified file.

---

## Images

**Full Name**: `Aspose.Slides.Images`

**Description**: Methods to instantiate and work with

**Key Members**:

*Methods*:
- `FromFile`: Create an image from the file .
- `FromFile`: Create an image from the file
- `FromStream`: Create an image from the stream.
- `FromStream`: Create an image from the stream.
- `FromStream`: Create an image from the stream.

---

## InterruptionToken

**Full Name**: `Aspose.Slides.InterruptionToken`

**Description**: This class represents the token to use for signaling long running tasks whether the interruption was requested.

**Key Members**:

*Propertys*:
- `None`: Represents an empty interruption token.
- `IsInterruptionRequested`: Returns

*Methods*:
- `ThrowIfInterruptionRequested`: Throws an

---

## InterruptionTokenSource

**Full Name**: `Aspose.Slides.InterruptionTokenSource`

**Description**: Represents the source of

**Key Members**:

*Propertys*:
- `Token`: Returns new token binded to this
- `IsInterruptionRequested`: Returns true if interruption requested, false otherwise.

*Methods*:
- `#ctor`: Creates a new
- `Interrupt`: Intialize request for interruption.

---

## InvalidPasswordException

**Full Name**: `Aspose.Slides.InvalidPasswordException`

**Description**: Exception which thrown when presentation file format is unsupported.

**Key Members**:

*Methods*:
- `#ctor`: Default constructor.
- `#ctor`: Constructor allowing a message to be added to this exception.
- `#ctor`: Constructor for an exception containing a message and an embedded exception.

---

