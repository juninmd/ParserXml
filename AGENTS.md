# AGENTS.md File Guidelines

These guidelines are designed to ensure the consistent, efficient, and high-quality development of AGENTS.md. Adherence to these principles is mandatory for all development activities within this repository.

## 1. DRY (Don't Repeat Yourself)

*   All code should have a single, well-defined purpose.
*   Avoid duplicating code across multiple files.
*   When a similar logic emerges, refactor to a single, reusable component.
*   Prioritize clear and concise code over unnecessary complexity.

## 2. KISS (Keep It Simple, Stupid)

*   Strive for simplicity in design and implementation.
*   Minimize complexity.
*   Avoid overly intricate logic or convoluted code paths.
*   Prioritize readability and maintainability.

## 3. SOLID Principles

*   **Single Responsibility Principle:** Each class/component should have one, and only one, reason to change.
*   **Open/Closed Principle:** The system should be open for extension but closed for modification.
*   **Liskov Substitution Principle:**  Subclasses should be substitutable for their base classes without affecting the correctness of the program.
*   **Interface Segregation Principle:** Client code should not be forced to depend on abstractions they do not need.
*   **Dependency Inversion Principle:** Higher-level modules should not depend on lower-level modules.

## 4. YAGNI (You Aren't Gonna Need It)

*   Only implement functionality that is currently required.
*   Avoid adding features or code that is not essential at this time.
*   Focus on delivering working functionality incrementally.

## 5. Code Structure & File Management

*   Each file should have a single, focused purpose.
*   File names should be descriptive and follow a consistent naming convention (e.g., snake_case).
*   Use comments liberally to explain complex logic, non-obvious decisions, and the intent of the code.
*   Keep the core implementation logic within a clearly delineated section.
*   The total code length shall not exceed 180 lines.  Strictly adhere to this limit.

## 6. Test Coverage Requirements

*   All development must be productive.  Do not use mocks or fake implementations.
*   Unit tests shall demonstrate functionality.
*   Comprehensive test coverage is required, aiming for at least 80% to ensure code stability and reliability.
*   Tests should cover all critical functional aspects.
*   Test cases shall be clearly documented with a meaningful name and description.

## 7.  Code Formatting & Style

*   Use a consistent code formatter (e.g., Prettier, Black).
*   Follow a defined code style guide (e.g., Google Style Guide) for readability.
*   Utilize consistent indentation and line spacing.
*   Use meaningful variable and function names.

## 8.  File Limits

*   Each file shall have a maximum of 180 lines of code.

## 9.  Documentation & Comments

*   Include a comprehensive description of the purpose of the file.
*   Provide clear and concise comments to explain key logic and algorithms.
*   Use docstrings to document functions and classes.

## 10.  Error Handling & Logging

*   Implement robust error handling to gracefully handle unexpected situations.
*   Log all relevant events and errors to facilitate debugging and monitoring.

## 11.  Dependency Management (Optional - for larger projects)

*   Consider using a dependency management tool (e.g., `pip`, `npm`) to manage external dependencies.

## 12.  Security Considerations (Optional - for larger projects)

*   Implement basic security measures (e.g., input validation) to mitigate potential vulnerabilities.