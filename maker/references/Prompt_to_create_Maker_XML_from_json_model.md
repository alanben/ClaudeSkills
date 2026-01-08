# Prompt: Generate MakerX Table and View Definitions from JSON Object or Model

You are an expert at converting JSON objects or data models into MakerX XML Table and View definitions. Use the MakerX specification document provided in the context as your reference guide for all type mappings, attributes, and patterns.

## Your Task

Analyze the provided JSON object or data model and generate:
1. A MakerX XML `<Table>` definition
2. A corresponding `<View>` definition
3. Any required property table data initialization SQL (if Type/State properties exist)

## JSON Object or Model

```json
[PASTE JSON OBJECT OR MODEL HERE]
```

OR

```
[PASTE DATA MODEL STRUCTURE HERE]
```

## Output Format

Provide your response in this structure:

```xml
<!-- ============================================ -->
<!-- TABLE DEFINITION -->
<!-- ============================================ -->
<Table type="core" name="..." description="..." alias="..." view="..." schema="..." search="no">
    <!-- Columns here -->
</Table>

<!-- ============================================ -->
<!-- VIEW DEFINITION -->
<!-- ============================================ -->
<View name="..." table="..." description="..." schema="...">
    <!-- Joins here (if applicable) -->
    <!-- Virtual columns here (if applicable) -->
</View>
```

```sql
-- ============================================
-- PROPERTY TABLE DATA (if applicable)
-- ============================================
-- SQL INSERT statements here
```

## Guidelines

1. **Infer relationships**: If field name ends with `Id`, `ID`, or `_id`, assume foreign key relationship
2. **Infer types**: Map JSON/model types to appropriate MakerX column types
   - `string` → `type="text"`, `type="name"`, `type="label"`, or `type="note"` (based on context/length)
   - `number`/`integer` → `type="integer"` or `type="decimal"` (based on context)
   - `boolean` → `type="flag"` (ensure Is/Has/Want/Can prefix)
   - `date`/`datetime`/`timestamp` → `type="datetime"`
   - `id`/`_id`/`guid` → `type="identity"` or `type="uniqueid"`
3. **Suggest improvements**: If naming doesn't follow conventions, use proper MakerX naming
4. **Add comments**: Include XML comments for complex mappings or assumptions
5. **Virtual columns**: Suggest useful computed fields based on the data structure
6. **Be conservative**: When uncertain about a mapping, choose the simpler/safer option and add a comment
7. **Property tables**: For fields named `type`, `status`, `state`, `category`, consider property tables
8. **Text lengths**: Infer appropriate lengths based on field names and context:
   - Names, codes: `length="50"` or `length="label"`
   - Emails, URLs: `length="label"`
   - Descriptions: `length="note"`
   - Large text, JSON: `length="desc"`

## Questions to Consider

Before generating, consider:
1. Does this model have type/status/state fields that need property tables?
2. What relationships exist with other entities (foreign keys)?
3. What virtual/computed columns would be useful in the view?
4. Are there timestamp fields that need auto-population (created, updated)?
5. Are boolean fields named correctly with Is/Has/Want/Can prefix?
6. What is the primary business entity this model represents?
7. What fields should be filterable?
8. What fields should be searchable?

## Type Inference Examples

**JSON Field → MakerX Column:**
- `"id": 123` → `<Column type="identity"/>`
- `"token": "guid-string"` → `<Column type="uniqueid" name="Token" auto="yes" update="no"/>`
- `"siteId": 5` → `<Column type="integer" name="SiteID" filter="yes"/>`
- `"name": "John"` → `<Column type="name"/>` or `<Column type="text" name="Name" length="50"/>`
- `"email": "user@example.com"` → `<Column type="label" name="Email"/>`
- `"description": "..."` → `<Column type="note"/>` or `<Column type="text" name="Description" length="note"/>`
- `"isActive": true` → `<Column type="flag" name="IsActive"/>`
- `"active": true` → `<Column type="flag" name="IsActive"/>` (corrected naming)
- `"createdAt": "2024-01-01"` → `<Column type="datetime" name="Created" filter="no" auto="yes" update="no"/>`
- `"price": 99.99` → `<Column type="decimal" name="Price"/>`
- `"count": 5` → `<Column type="integer" name="Count"/>`
- `"type": "standard"` → `<Column type="property" name="Type">...</Column>`
- `"status": "active"` → `<Column type="property" name="State">...</Column>` (prefer State for status)

---

Now, please analyze the JSON object or model provided above and generate the MakerX Table and View definitions following the specification document.