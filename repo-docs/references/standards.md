# Repository Documentation Standards

## README.md Requirements

### Structure
- **Overview**: What the project does
- **Installation**: How to set up
- **Usage**: How to use it
- **Development**: How to contribute
- **License**: Link to license

### Guidelines
- Start with project name and brief description
- Include prerequisites clearly
- Provide working examples
- Keep instructions current
- Use clear, consistent formatting

---

## CHANGELOG.md Requirements

### Format
Follow [Keep a Changelog](https://keepachangelog.com/en/1.0.0/) format.

### Required Elements
- Format declaration link at top
- Versioning declaration link (usually Semantic Versioning)
- `[Unreleased]` section for upcoming changes
- Version sections: `[X.Y.Z] - YYYY-MM-DD`
- Categories: Added, Changed, Deprecated, Removed, Fixed, Security

### Version Comparison Links
```markdown
[Unreleased]: https://github.com/user/repo/compare/v1.0.0...HEAD
[1.0.0]: https://github.com/user/repo/compare/v0.9.0...v1.0.0
```

### Guidelines
- One line per change
- Use present tense or past tense consistently
- Focus on user impact, not implementation
- Group related changes together
- Most recent version first

---

## LICENSE Requirements

### Content
- Full license text
- Copyright year and holder
- License type clearly stated

### Common Licenses
- **MIT**: Permissive, simple
- **Apache 2.0**: Permissive, with patent grant
- **GPL**: Copyleft, derivatives must be open
- **Proprietary**: Custom restrictions

### Guidelines
- Place in repository root
- Name as `LICENSE` or `LICENSE.md`
- Update copyright year annually
- Match license to project needs

---

## CONTRIBUTING.md Requirements (Optional)

### Structure
- **Getting Started**: How to begin contributing
- **Reporting Issues**: Bug report process
- **Code Changes**: How to submit changes
- **Standards**: Coding and documentation standards
- **Review Process**: What to expect

### Guidelines
- Be welcoming and clear
- Define expectations explicitly
- Provide examples
- Link to code of conduct if exists
- Keep process simple

---

## Documentation Principles

1. **Clarity**: Write for first-time users
2. **Currency**: Keep documentation up to date with code
3. **Completeness**: Cover essential information
4. **Consistency**: Use uniform structure and style
5. **Accessibility**: Make documentation easy to find and understand
