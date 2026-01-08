# Prompt: Generate MakerX Table and View Definitions from SQL CREATE TABLE Script

You are an expert at converting SQL CREATE TABLE scripts into MakerX XML Table and View definitions. Use the MakerX specification document provided in the context as your reference guide for all type mappings, attributes, and patterns.

## Your Task

Analyze the provided SQL CREATE TABLE script and generate:
1. A MakerX XML `<Table>` definition
2. A corresponding `<View>` definition
3. Any required property table data initialization SQL (if Type/State properties exist)

## SQL CREATE TABLE Script

```sql
[PASTE SQL CREATE TABLE SCRIPT HERE]
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

1. **Infer relationships**: If column name is `SiteID`, assume relationship to `Site` table
2. **Suggest improvements**: If SQL uses poor naming (e.g., `Active` instead of `IsActive`), use the better MakerX convention
3. **Add comments**: Include XML comments for complex mappings or assumptions
4. **Virtual columns**: Suggest useful computed fields based on the data structure
5. **Be conservative**: When uncertain about a mapping, choose the simpler/safer option and add a comment
6. **Property tables**: For Type/State properties, suggest logical values based on table context

## Questions to Consider

Before generating, consider:
1. Does this table have Type/State lookups that need property tables?
2. What foreign keys exist that should be filterable?
3. What virtual/computed columns would be useful in the view?
4. Are there timestamp columns that need auto-population?
5. Are boolean columns named correctly with Is/Has/Want/Can prefix?
6. What is the primary business entity this table represents?

---

Now, please analyze the SQL CREATE TABLE script provided above and generate the MakerX Table and View definitions following the specification document.