# MakerX Table and View Definition Specification

## Overview
This document provides a specification for creating MakerX XML Table and View definitions based on C# class models. It documents the patterns, conventions, and attributes observed in the RentaStore.Cortex and Molo projects.

---

## Table Definition Structure

### Basic Table Element
```xml
<Table type="core" name="TableName" description="Description" alias="ALI" view="ViewName" schema="SchemaName" search="yes|no">
    <!-- Column definitions -->
</Table>
```

#### Table Attributes
| Attribute | Required | Values | Description |
|-----------|----------|--------|-------------|
| `type` | Yes | `core` | Table type (typically "core") |
| `name` | Yes | String | Singular table name (PascalCase) |
| `description` | Yes | String | Human-readable description |
| `alias` | Yes | String | 2-4 character table alias for SQL joins |
| `view` | Yes | String | Plural view name (PascalCase) |
| `schema` | No | String | Database schema name (defaults to "dbo" schema) |
| `search` | No | `yes`/`no` | Enable full-text search |
| `pseudo` | No | `yes` | Mark as pseudo table (view-only, no physical table) |

#### Special Table Attributes
```xml
<!-- For excluding operations -->
<exclude>add,edit,update,delete,deleteall,get,index</exclude>

<!-- For table updates/migrations - only used when making updates to an existing model  -->
Update="UpdateName"
UpdateAction="add"
```

---

## Column Types and Definitions

### 1. Identity Column (Primary Key)
```xml
<Column type="identity"/>
<Column type="identity" startval="1000"/>  <!-- With custom start value -->
<Column type="identity" name="ConcessionID"/>  <!-- Custom column name - rarely used -->
```
- **Required** All Tables must have an Identity column
- Maps to C# `int ID { get; set; }`
- Auto-incrementing primary key
- Optional `startval` attribute for seed value
- Optional `name` attribute (defaults to "ID")

---

### 2. Property Columns (Foreign Key to Lookup Tables)
```xml
<Column type="property" name="Type">
    <Table type="property" description="Description" alias="ALI" search="no" schema="SchemaName"/>
</Column>

<Column type="property" name="State" filtertype="inlist">
    <Table type="property" description="Description" alias="ALI"/>
</Column>
```

**Maps to:** C# `int TypeId { get; set; }` or `int StateId { get; set; }`

**Automatically creates:**
- Lookup table (e.g., `ClientType`, `ClientState`)
- Foreign key relationship
- Standard lookup columns: `ID`, `Name`, `Note`

**Common property names:**
- `Type` - for classification/categorization
- `State` - for status/workflow state

**Attributes:**
- `filtertype="inlist"` - Enable filtering with multiple values, typically used when filtering on a text field, eh type="name" or type="label"

---

### 3. Unique Identifier (GUID/Token)
```xml
<Column type="uniqueid" name="Token" auto="yes" update="no"/>
<Column type="uniqueid" name="Token" auto="yes" update="auto"/>
```
- Maps to C# `Guid Token { get; set; }` or `string Token { get; set; }`
- `auto="yes"` - Generate automatically on insert
- `update="no"` - Never update after creation
- `update="auto"` - Update on modifications

---

### 4. Date/Time Columns
```xml
<!-- Auto-populated timestamps -->
<Column type="datetime" name="Created" filter="no" auto="yes" update="no"/>
<Column type="datetime" name="Updated" filter="no" auto="yes" update="auto"/>

<!-- User-editable dates -->
<Column type="datetime" name="StartDate" filter="yes"/>
<Column type="datetime" name="DOB"/>
```

**Maps to:** C# `DateTime PropertyName { get; set; }`

**Attributes:**
- `auto="yes"` - Auto-populate
- `update="no"` - Set on insert only (Created)
- `update="auto"` - Update on modifications (Updated)
- `filter="yes"` - Enable filtering (for date ranges)
- `filter="no"` - Disable filtering (for audit fields)

---

### 5. Boolean/Flag Columns
```xml
<Column type="flag" name="IsActive"/>
<Column type="flag" name="IsActive" auto="yes" autoval="1"/>
<Column type="flag" name="IsActive" auto="yes" autoval="1" defval="0" update="no"/>
<Column type="flag" name="IsActive" auto="yes" autoval="1" defval="0" update="yes" updatediscrete="yes"/>
```

**Maps to:** C# `bool PropertyName { get; set; }`

**Naming convention:** Prefix with `Is`, `Has`, `Want`, `Can`

**Attributes:**
- `auto="yes"` - Set default automatically
- `autoval="0|1"` - Default value when auto-creating
- `defval="0|1"` - Database default constraint
- `update="no"` - Prevent updates after creation
- `update="yes"` - Allow updates
- `updatediscrete="yes"` - Allow discrete field updates

**Examples:**
```xml
<Column type="flag" name="IsClimate"/>      <!-- Climate controlled -->
<Column type="flag" name="IsRented"/>       <!-- Currently rented -->
<Column type="flag" name="IsPrimary"/>      <!-- Primary record -->
<Column type="flag" name="HasActiveLedger"/><!-- Has active ledger -->
<Column type="flag" name="WantClientSync"/> <!-- Want sync enabled -->
```

---

### 6. Text Columns

#### Name Column (Standard Name Field)
```xml
<Column type="name"/>                              <!-- Standard name -->
<Column type="name" drop="yes"/>                   <!-- Drop from certain operations -->
<Column type="name" name="Username" search="yes" unique="yes"/>  <!-- Custom name column -->
```
- Default length: ~100 characters
- Maps to C# `string Name { get; set; }`

#### Label Column (Short Text)
```xml
<Column type="label" name="Firstname"/>
<Column type="label" name="Email"/>
<Column type="text" name="Code" length="label"/>
```
- Typical length: 50-100 characters
- For short identifiers, codes, names

#### Note Column (Medium Text)
```xml
<Column type="note"/>
<Column type="note" name="Description"/>
<Column type="text" name="Address" length="note"/>
```
- Typical length: 500-1000 characters
- For descriptions, notes, addresses

#### Description Column (Large Text)
```xml
<Column type="text" name="Content" length="desc"/>
<Column type="text" name="ResponseJson" length="desc"/>
```
- Large text field: 2000+ characters or MAX
- For JSON, large content blocks

#### Text Column with Length

In most cases text fields should be specified as Name, Label, Note or Description types, however where required the field can be given a specific length, eg when modelling a table that might exist prior to the model creation.

```xml
<Column type="text" name="Phone" length="50"/>
<Column type="text" name="Code" length="100"/>
<Column type="text" name="UID" length="label"/>
```

**Length values:**
- Numeric: `length="50"`, `length="100"`
- Named: `length="label"` (~100), `length="name"` (~100)

**Text Column Attributes:**
- `search="yes"` - Enable full-text search
- `unique="yes"` - Enforce uniqueness
- `drop="yes"` - Exclude from certain operations
- `get="yes"` - Include in GET operations
- `filter="yes"` - Enable filtering
- `prefix="value"` - Add prefix in views

---

### 7. Numeric Columns

#### Integer
```xml
<Column type="integer" name="Count"/>
<Column type="integer" name="SiteID" filter="yes"/>
<Column type="integer" name="AgentID" filter="yes" filtertype="inlist"/>
```

**Maps to:** C# `int PropertyName { get; set; }`

**Attributes:**
- `filter="yes"` - Enable filtering (for foreign keys)
- `filtertype="inlist"` - Enable multi-value filtering
- `defval="0"` - Database default value
- `update="yes"` - Allow updates

#### Decimal
```xml
<Column type="decimal" name="Price"/>
<Column type="decimal" name="Latitude"/>
<Column type="decimal" name="TaxRate"/>
```

**Maps to:** C# `decimal PropertyName { get; set; }`

Used for:
- Monetary values (prices, rates)
- Measurements (width, length, area)
- Coordinates (lat/lon)
- Percentages

---

### 8. Foreign Key Columns
```xml
<!-- Simple foreign key -->
<Column type="integer" name="ClientID" filter="yes"/>
<Column type="integer" name="BranchID" filter="yes"/>

<!-- Foreign key with multiple value filtering -->
<Column type="integer" name="AgentID" filter="yes" filtertype="inlist"/>

<!-- Optional foreign key with default -->
<Column type="integer" name="SpecialID" filter="yes" defval="0"/>
```

**Convention:** 
- Name format: `{EntityName}ID`
- Always mark with `filter="yes"` for query filtering
- Use `filtertype="inlist"` for multi-select filtering

---

### 9. Virtual Columns (Computed in Views)
```xml
<Column type="virtual" name="FullName" drop="yes">
    <Statement>[PSN].Firstname + ' ' + [PSN].Surname</Statement>
</Column>

<Column type="virtual" name="SquareFeet" drop="yes">
    <Statement>[UI].[Width] * [UI].[Length]</Statement>
</Column>

<Column type="virtual" name="AccountCount">
    <Statement>(SELECT COUNT(*) FROM [Schema].[Table] WHERE ...)</Statement>
</Column>

<Column type="virtual" name="Size" function="GetUnitSize" schema="dbo">
    <Parameter>[Width]</Parameter>
    <Parameter>[Length]</Parameter>
</Column>
```

**Defined in Views only**, not in Table definitions.

**Attributes:**
- `drop="yes"` - Exclude from certain operations (common for computed fields)
- `function` - Call a SQL function
- `schema` - Schema for the function

---

### 10. Ghost Columns (Placeholder for Future Data)
```xml
<Column type="ghost" name="ContentCategory" value="new"/>
<Column type="ghost" name="PublishDate" value="new"/>
```

Used in pseudo tables/reports for fields that will be populated from external sources (e.g., Sanity CMS).

---

## Common Column Attributes

| Attribute | Values | Usage |
|-----------|--------|-------|
| `name` | String | Column name (PascalCase) |
| `length` | Number or name | Text field length |
| `filter` | `yes`/`no` | Enable query filtering |
| `filtertype` | `inlist` | Enable multi-value filtering |
| `search` | `yes`/`no` | Enable full-text search |
| `unique` | `yes`/`no` | Enforce uniqueness constraint |
| `auto` | `yes`/`no`/`null` | Auto-populate on insert |
| `autoval` | Value | Default value for auto fields |
| `defval` | Value | Database default constraint |
| `update` | `yes`/`no`/`auto` | Update behavior |
| `updatediscrete` | `yes` | Allow discrete updates |
| `get` | `yes` | Include in GET operations |
| `drop` | `yes` | Exclude from operations |
| `prefix` | String | Prefix for view columns |
| `force` | `yes` | Force inclusion even if redundant |
| `Update` | String | Migration/update name |
| `UpdateAction` | `add` | Migration action |

---

## View Definition Structure

### Basic View Element
```xml
<View name="ViewName" table="TableName" description="Description" schema="SchemaName">
    <!-- Joins -->
    <!-- Columns -->
    <!-- Crossapply -->
</View>
```

---

### Join Definitions

#### Simple Inner Join
```xml
<Join name="TableName" column="ForeignKeyColumn" alias="ALI" prefix="Prefix">
    <Column type="name"/>
    <Column type="text" name="Code" length="100"/>
</Join>
```

#### Left Outer Join
```xml
<Join name="TableName" column="ForeignKeyColumn" alias="ALI" prefix="Prefix" type="left outer">
    <Column type="name"/>
</Join>
```

#### Join with Custom Condition
```xml
<Join name="TableName" column="ForeignKeyColumn" alias="ALI" type="left outer">
    [BaseTable].[ID] = ALI.[ForeignKeyColumn] AND ALI.[IsPrimary] = 1
    <Column type="label" name="Address"/>
</Join>
```

#### Join from Another Join (Nested Join)
```xml
<Join name="Branch" column="BranchID" alias="BRH" prefix="Branch">
    <Column type="name"/>
</Join>
<Join name="Sitelink" column="SitelinkID" base="Branch" alias="SLK" prefix="Sitelink">
    <Column type="text" name="CorpCode" length="50"/>
</Join>
```

#### Join Attributes
| Attribute | Required | Values | Description |
|-----------|----------|--------|-------------|
| `name` | Yes | String | Table name to join |
| `column` | Yes | String | Foreign key column in source |
| `ID` | No | String | Primary key column in target (default: ID) |
| `alias` | Yes | String | Table alias for SQL |
| `prefix` | No | String | Prefix for column names in result |
| `type` | No | `left outer`/`right outer` | Join type (default: inner) |
| `base` | No | String | Base table/join for nested joins |
| `properties` | No | `no` | Exclude property columns (Type/State) |
| `schema` | No | String | Target table schema |

---

### Column Definitions in Views

#### Include Columns from Joined Tables
```xml
<Join name="Person" column="PersonID" alias="PSN" prefix="">
    <Column type="label" name="Firstname"/>
    <Column type="label" name="Surname"/>
    <Column type="label" name="IDNumber"/>
</Join>
```

#### Property Columns with Prefix
```xml
<Join name="Agent" column="AgentID" prefix="Agent" alias="AG">
    <Column type="property" name="Type" alias="AGT" base="Agent" prefix="Agent"/>
    <Column type="property" name="State" alias="AGS" base="Agent" prefix="Agent"/>
</Join>
```

#### Column with Force Include
```xml
<Join name="Tenant" column="TenantID" alias="TEN" properties="no">
    <Column type="integer" name="ID" prefix="" force="yes"/>
    <Column type="integer" name="TenantID" prefix="Sitelink"/>
</Join>
```

---

### Virtual Columns in Views

```xml
<Columns>
    <!-- Simple concatenation -->
    <Column type="virtual" name="FullName" drop="yes">
        <Statement>[PSN].Firstname + ' ' + [PSN].Surname</Statement>
    </Column>
    
    <!-- Calculation -->
    <Column type="virtual" name="SquareFeet" drop="yes">
        <Statement>[UI].[Width] * [UI].[Length]</Statement>
    </Column>
    
    <!-- Formatted display -->
    <Column type="virtual" name="Size" drop="yes">
        <Statement>CAST([UN].[Width] AS VARCHAR(10)) + 'x' + CAST([UN].[Length] AS VARCHAR(10))</Statement>
    </Column>
    
    <!-- Subquery -->
    <Column type="virtual" name="AccountCount">
        <Statement>(SELECT COUNT(*) FROM [Schema].[Table] AS T WHERE T.[ClientID] = CLN.[ID])</Statement>
    </Column>
    
    <!-- Conditional logic -->
    <Column type="virtual" name="HasDiscount" drop="yes">
        <Statement>CASE WHEN [UI].[SpecialID] IS NOT NULL AND [UI].[SpecialID] > 0 THEN 1 ELSE 0 END</Statement>
    </Column>
    
    <!-- Coalesce/Default -->
    <Column type="virtual" name="EffectiveRate" drop="yes">
        <Statement>COALESCE([UI].[Rental], [UI].[StandardRate])</Statement>
    </Column>
    
    <!-- Function call -->
    <Column type="virtual" name="ContactMethod" function="GetLeadContactMethod" schema="dbo">
        <Parameter>[Answers]</Parameter>
    </Column>
</Columns>
```

---

### Crossapply (JSON and Complex Queries)

```xml
<Crossapply name="LeadAnswers">
    OPENJSON(LD.ResponseJson) with (Answers NVARCHAR(MAX) '$.form_response.answers' AS JSON )
</Crossapply>
```

Used for:
- Parsing JSON columns
- Complex table-valued functions
- Dynamic pivoting

---

## Property Tables (Lookup Tables)

Property tables are automatically created when you use `<Column type="property">`:

### Automatic Structure
```xml
<Column type="property" name="Type">
    <Table type="property" description="Client type" alias="CLNT" search="no" schema="Cortex"/>
</Column>
```

**Creates:**
```sql
CREATE TABLE [Schema].[TableNameType] (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Note NVARCHAR(500)
)
```

### Data Population Example
```sql
SET IDENTITY_INSERT [Cortex].[ClientType] ON
INSERT INTO [Cortex].[ClientType] ([ID],[Name],[Note]) 
VALUES (1, 'business', 'Business'),
       (2, 'individual', 'Individual'),
       (3, 'unknown', 'Unknown')
SET IDENTITY_INSERT [Cortex].[ClientType] OFF
GO
```

**Common Property Names:**
- `Type` - Classification/category
- `State` - Status/workflow state
- `Status` - Alternative to State

**Common State Values:**
- `active` / `inactive`
- `pending` / `approved` / `rejected`
- `open` / `closed`
- `enabled` / `disabled`

---

## Naming Conventions

### Identifiers / Identity or foreign keys
- **ID or XxxxID**: rather than Id or XxxxId

### Tables
- **Singular**: `Client`, `Agent`, `Unit`
- **PascalCase**: `UnitItemType`, `ConcessionPlan`
- **Descriptive**: `SyncError`, `LeadReport`

### Views
- **Plural**: `Clients`, `Agents`, `Units`
- **PascalCase**: `UnitItemTypes`, `ConcessionPlans`

### Columns
- **PascalCase**: `FirstName`, `IsActive`, `CreatedDate`
- **Boolean prefix**: `Is`, `Has`, `Want`, `Can`
- **Foreign keys**: `{EntityName}ID` (e.g., `ClientID`, `BranchID`)
- **No abbreviations** in column names (except established conventions)

### Aliases
- **2-4 characters**: `CLN`, `AGN`, `PSN`, `BRH`
- **Uppercase**: All aliases in UPPERCASE
- **Descriptive**: First letters of table name where possible

### Prefixes in Views
- **Entity name**: `Agent`, `Site`, `Tenant`
- **Descriptive**: `Sitelink`, `Company`, `Primary`
- **Empty string** `prefix=""` to use unprefixed column names

---

## Schema Organization

### Common Schemas
```xml
<Schemas>
    <Schema name="Cortex"/>           <!-- Main application schema -->
    <Schema name="sitelink" drop="no"/><!-- External system schema -->
    <Schema name="auth"/>             <!-- Authentication schema -->
    <Schema name="ops"/>              <!-- Operations schema -->
</Schemas>
```

**Schema Attributes:**
- `drop="no"` - Don't drop/recreate (for external schemas)

---

## Update/Migration Management

### Table Updates
```xml
<Updates>
    <Update name="Lead_AgentID" version="0.1.2.0" date="20250123" complete="yes"/>
    <Update name="AccountCount" version="0.1.2.0" date="20250123" complete="yes"/>
    <Update name="LedgerState" version="0.1.5.0" date="20250225" complete="no"/>
</Updates>
```

### Column Updates
```xml
<Column type="integer" name="SaleID" Update="SalesReport" UpdateAction="add"/>
<Column type="flag" name="ShowReviews" Update="ShowReviewsFlag" UpdateAction="add"/>
```

**Attributes:**
- `Update` - Name of the update (matches `<Update name="...">`)
- `UpdateAction` - Action: `add` (add column)

---

## Pseudo Tables (Report/View-Only Tables)

```xml
<Table type="core" name="LeadReport" description="Lead report" alias="LD" view="LeadReports" schema="Cortex" search="no" pseudo="yes">
    <exclude>add,edit,update,delete,deleteall</exclude>
    <Column type="identity"/>
    <Column type="integer" name="BranchID" filter="yes"/>
    <Column type="integer" name="Count"/>
</Table>
```

**Characteristics:**
- `pseudo="yes"` - No physical table created
- `<exclude>` - Exclude CRUD operations
- Used for reporting views
- Often includes aggregations

---

## Complete Table Examples

### Simple Lookup Table
```xml
<Table type="core" name="Special" description="Special offers/promotions" alias="SP" view="Specials" schema="Cortex" search="no">
    <Column type="identity"/>
    <Column type="name"/>
    <Column type="note"/>
    <Column type="flag" name="IsActive" auto="yes" autoval="1"/>
    <Column type="datetime" name="Created" filter="no" auto="yes" update="no"/>
</Table>

<View name="Specials" table="Special" description="Cortex Specials" schema="Cortex"/>
```

### Entity with Relationships
```xml
<Table type="core" name="Client" description="Client table" alias="CLN" view="Clients" schema="Cortex" search="no">
    <Column type="identity"/>
    <Column type="uniqueid" name="Token" auto="yes" update="no"/>
    <Column type="datetime" name="Created" filter="no" auto="yes" update="no"/>
    <Column type="datetime" name="Updated" filter="no" auto="yes" update="auto"/>
    <Column type="property" name="Type">
        <Table type="property" description="Client type" alias="CLNT" search="no" schema="Cortex"/>
    </Column>
    <Column type="property" name="State">
        <Table type="property" description="Client status" alias="CLNS" search="no" schema="Cortex"/>
    </Column>
    <Column type="integer" name="PersonID" filter="yes"/>
</Table>

<View name="Clients" table="Client" description="Cortex Clients" schema="Cortex">
    <Join name="Person" column="PersonID" alias="PSN" prefix="">
        <Column type="label" name="Firstname"/>
        <Column type="label" name="Surname"/>
        <Column type="label" name="IDNumber"/>
    </Join>
    <Columns>
        <Column type="virtual" name="ClientName" drop="yes">
            <Statement>[PSN].Firstname + ' ' + [PSN].Surname</Statement>
        </Column>
    </Columns>
</View>
```

### Junction/Mapping Table
```xml
<Table type="core" name="ConcessionUnitType" description="Concession plan unit type mappings" alias="CUT" view="ConcessionUnitTypes" schema="Cortex" search="no">
    <Column type="identity"/>
    <Column type="integer" name="ConcessionID" filter="yes"/>
    <Column type="integer" name="UnitTypeID" filter="yes"/>
    <Column type="decimal" name="Width"/>
    <Column type="decimal" name="Length"/>
</Table>

<View name="ConcessionUnitTypes" table="ConcessionUnitType" description="Concession Unit Type Mappings" schema="Cortex">
    <Join name="ConcessionPlan" column="ConcessionID" alias="CP" prefix="Concession" properties="no">
        <Column type="text" name="PlanName" length="100"/>
    </Join>
    <Join name="UnitType" column="UnitTypeID" alias="UT" prefix="UnitType" properties="no">
        <Column type="decimal" name="Area"/>
    </Join>
    <Columns>
        <Column type="virtual" name="SquareFeet" drop="yes">
            <Statement>[CUT].[Width] * [CUT].[Length]</Statement>
        </Column>
    </Columns>
</View>
```

### Complex Data Table
```xml
<Table type="core" name="Unit" description="Unit table" alias="UN" view="Units" schema="Cortex" search="no">
    <Column type="identity"/>
    <Column type="integer" name="SiteID" filter="yes"/>
    <Column type="integer" name="UnitTypeID" filter="yes"/>
    <Column type="integer" name="SiteUnitID"/>
    <Column type="text" name="UnitName" length="50"/>
    <Column type="decimal" name="Width"/>
    <Column type="decimal" name="Length"/>
    <Column type="flag" name="IsRented"/>
    <Column type="flag" name="IsClimate"/>
    <Column type="decimal" name="StandardRate"/>
    <Column type="datetime" name="Created" filter="no" auto="yes" update="no"/>
</Table>

<View name="Units" table="Unit" description="Cortex Units" schema="Cortex">
    <Join name="Site" column="SiteID" alias="ST" prefix="Site" properties="no">
        <Column type="name"/>
    </Join>
    <Join name="UnitType" column="UnitTypeID" alias="UT" prefix="UnitType" properties="no">
        <Column type="decimal" name="Area"/>
    </Join>
    <Columns>
        <Column type="virtual" name="Size" drop="yes">
            <Statement>CAST([UN].[Width] AS VARCHAR(10)) + 'x' + CAST([UN].[Length] AS VARCHAR(10))</Statement>
        </Column>
    </Columns>
</View>
```

---

## C# to XML Type Mapping Reference

| C# Type | XML Column Type | Length/Attributes | Example |
|---------|----------------|-------------------|---------|
| `int ID` | `type="identity"` | - | Primary key |
| `int PropertyID` | `type="integer"` | `filter="yes"` | Foreign key |
| `Guid Token` | `type="uniqueid"` | `auto="yes" update="no"` | GUID |
| `string Name` | `type="name"` | - | Standard name (~100 chars) |
| `string Code` | `type="text"` | `length="50"` or `length="label"` | Short code |
| `string Phone` | `type="text"` | `length="50"` | Phone number |
| `string Email` | `type="label"` | - | Email address |
| `string Description` | `type="note"` | - | Description (~500 chars) |
| `string LargeText` | `type="text"` | `length="desc"` | Large text/JSON |
| `bool IsActive` | `type="flag"` | `name="IsActive"` | Boolean with `Is` prefix |
| `DateTime Created` | `type="datetime"` | `auto="yes" update="no"` | Created timestamp |
| `DateTime Updated` | `type="datetime"` | `auto="yes" update="auto"` | Updated timestamp |
| `DateTime Date` | `type="datetime"` | `filter="yes"` | User date field |
| `decimal Price` | `type="decimal"` | - | Monetary/measurement value |

---

## Best Practices

### 1. **Foreign Keys**
- Always use `filter="yes"` on foreign key columns
- Use `filtertype="inlist"` for multi-select filtering
- Name format: `{EntityName}ID`

### 2. **Timestamps**
- Created: `auto="yes" update="no"`
- Updated: `auto="yes" update="auto"`
- Both: `filter="no"` (audit fields don't need filtering)

### 3. **Boolean Flags**
- Prefix with `Is`, `Has`, `Want`, `Can`
- Use `auto="yes" autoval="1"` for default true
- Use `defval="0"` for database constraint

### 4. **Text Lengths**
Choose appropriate lengths:
- `length="label"` Short names, emails
- `length="name"` Names, typically unique
- `length="note"` Short Descriptions
- `length="desc"` - Large text, JSON
- `length="50"` - Unique or specific length required

### 5. **Property Tables**
- Use for classification (`Type`) and workflow (`State`)
- Populate with meaningful name/note values
- Consider common states: active/inactive, open/closed

### 6. **Virtual Columns**
- Use for computed fields (concatenation, calculations)
- Mark with `drop="yes"` if not needed in all operations
- Keep SQL simple for performance

### 7. **View Joins**
- Use `prefix=""` sparingly (only for main entity fields)
- Use descriptive prefixes for clarity: `Site`, `Agent`, `Tenant`
- Use `properties="no"` when you don't need Type/State columns

### 8. **Aliases**
- Keep short (2-4 characters)
- Make them somewhat memorable/meaningful
- Use UPPERCASE consistently
- Ensure not reserved SQL word eg IF

### 9. **Pseudo Tables**
- Use for reports and aggregations
- Exclude CRUD operations: `<exclude>add,edit,update,delete,deleteall</exclude>`
- Can include ghost columns for external data

### 10. **Updates/Migrations**
- Track with `Update` attribute on columns
- Document in `<Updates>` section
- Mark `complete="yes"` when deployed

---

## Common Patterns

### Audit Fields Pattern
```xml
<Column type="datetime" name="Created" filter="no" auto="yes" update="no"/>
<Column type="datetime" name="Updated" filter="no" auto="yes" update="auto"/>
```

### Token Pattern
```xml
<Column type="uniqueid" name="Token" auto="yes" update="no"/>
```

### Type/State Pattern
```xml
<Column type="property" name="Type">
    <Table type="property" description="Entity type" alias="ET" search="no" schema="SchemaName"/>
</Column>
<Column type="property" name="State">
    <Table type="property" description="Entity status" alias="ES" search="no" schema="SchemaName"/>
</Column>
```

### Foreign Key Pattern
```xml
<Column type="integer" name="ParentID" filter="yes"/>
<Column type="integer" name="RelatedID" filter="yes" filtertype="inlist"/>
```

### Boolean Flags Pattern
```xml
<Column type="flag" name="IsActive" auto="yes" autoval="1" defval="1"/>
<Column type="flag" name="IsDeleted" auto="yes" autoval="0" defval="0"/>
```

### Address Pattern
```xml
<Column type="label" name="Address1"/>
<Column type="label" name="Address2"/>
<Column type="text" name="City" length="100"/>
<Column type="text" name="Province" length="100"/>
<Column type="text" name="Country" length="100"/>
<Column type="text" name="Code" length="50"/>
```

### Contact Pattern
```xml
<Column type="text" name="Phone" length="50"/>
<Column type="text" name="Mobile" length="50"/>
<Column type="label" name="Email"/>
```

### Measurement Pattern
```xml
<Column type="decimal" name="Width"/>
<Column type="decimal" name="Length"/>
<Column type="decimal" name="Area"/>
```

### Pricing Pattern
```xml
<Column type="decimal" name="StandardRate"/>
<Column type="decimal" name="DiscountedRate"/>
<Column type="decimal" name="TaxRate"/>
<Column type="decimal" name="Total"/>
```

---

## Troubleshooting Common Issues

### Issue: Column not appearing in view
**Solution:** Check if column is marked `drop="yes"` or if join has `properties="no"` when trying to include Type/State

### Issue: Foreign key not filterable
**Solution:** Add `filter="yes"` attribute to the column

### Issue: Virtual column causing performance issues
**Solution:** Consider storing the value in the table instead, or optimize the SQL statement

### Issue: Boolean defaulting to wrong value
**Solution:** Check `autoval` and `defval` - both should be set correctly

### Issue: Timestamp not updating
**Solution:** Verify `auto="yes"` and `update="auto"` for Updated fields

### Issue: Property table not created
**Solution:** Ensure nested `<Table type="property">` element is present in the column definition

---

## Summary Checklist

When creating a new Table/View definition:

- [ ] Table has unique, descriptive `name` (singular)
- [ ] Table has short, memorable `alias` (2-4 chars, UPPERCASE)
- [ ] View `name` is plural form of table name
- [ ] Identity column defined (usually first)
- [ ] Foreign keys have `filter="yes"`
- [ ] Booleans use `Is/Has/Want/Can` prefix
- [ ] Text columns have appropriate `length`
- [ ] Audit fields (Created/Updated) configured correctly
- [ ] Property columns have nested table definitions
- [ ] View includes necessary joins
- [ ] Virtual columns use `drop="yes"` when appropriate
- [ ] Aliases in view are consistent with table definitions
- [ ] Property table data populated in SQL data file

---

*End of Specification Document*