# Day 2: Operators, I/O, & Type Conversion

## Core Concepts Covered Today

### 1. Comments

Used to document code or temporarily disable logic. Ignored by the compiler.

- `//` for single-line comments.
- `/* ... */` for multi-line comments.

### 2. Input and Output

- **Output:** `Console.WriteLine("Message");`
- **Input:** `string data = Console.ReadLine();` (Always reads data as a string).

### 3. Type Conversion

Translating data from one type to another. Essential when taking user input that needs to be used in mathematical calculations.

- **Convert Class:** `Convert.ToInt32("42")` turns the string "42" into the integer 42.
- **Parsing:** `double.Parse("19.99")` turns a string into a decimal number.
- **Implicit:** Safe, automatic conversions (smaller type to larger type).
- **Explicit:** Forced conversions that require a cast `(int)` and may lose precision.

### 4. Operators

- **Arithmetic:** `+` (Add), `-` (Subtract), `*` (Multiply), `/` (Divide), `%` (Modulo/Remainder).
- **Assignment:** `=` (Assign), `+=` (Add and assign).
- **Comparison:** `==` (Equal), `!=` (Not equal), `>`, `<`.
