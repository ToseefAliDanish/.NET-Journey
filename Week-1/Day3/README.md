# Day 3: Conditions & Logical Operators

## Core Concepts Covered Today

### 1. Conditional Statements

Allow code to make decisions and branch into different execution paths based on boolean (`true`/`false`) logic.

- **`if`:** Executes code only if the specified condition is `true`.
- **`else if`:** Tests a new condition if the previous `if` condition was `false`.
- **`else`:** The default block that executes if all previous conditions were `false`.

### 2. Logical Operators

Used to combine multiple conditions together into a single boolean result.

- **`&&` (Logical AND):** Returns `true` if BOTH conditions are true. (e.g., `score >= 90 && score <= 100`)
- **`||` (Logical OR):** Returns `true` if AT LEAST ONE condition is true. (e.g., `score < 0 || score > 100`)
- **`!` (Logical NOT):** Reverses the boolean state. (e.g., `!true` becomes `false`)

### 3. The `switch` Statement

An alternative to writing multiple `else if` statements when evaluating a single variable against various specific values.

- Uses `case` to define potential matches.
- Requires a `break;` keyword at the end of each case to prevent the code from bleeding into the next case.
- Uses `default:` as a catch-all, similar to an `else` statement.
