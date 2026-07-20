# Day 1: .NET Foundations & C# Basics

## Core Concepts Covered Today

### 1. The .NET Ecosystem

- **.NET** is an open-source, cross-platform developer platform created by Microsoft for building many types of applications.
- **.NET Framework vs Modern .NET:** - _.NET Framework:_ Windows-only, legacy runtime.
  - _.NET (Core):_ Modern, fast, open-source, and runs on Windows, Linux, and macOS.

### 2. C# Console Application Structure

A standard C# file contains:

- `using System;` - References the core base class library namespace for basic tasks (like text input/output).
- `namespace` - Used to organize code and avoid naming conflicts.
- `class` - The building block containing variables and methods.
- `static void Main(string[] args)` - The crucial **entry point** method where your program starts executing.

### 3. Basic C# Data Types

| Data Type | Memory Size      | Description                       | Example                   |
| :-------- | :--------------- | :-------------------------------- | :------------------------ |
| `int`     | 4 Bytes          | Stores whole integers             | `int score = 95;`         |
| `double`  | 8 Bytes          | Fractional/floating-point numbers | `double price = 19.99;`   |
| `string`  | 2 Bytes per char | Sequence of text characters       | `string name = "Alice";`  |
| `char`    | 2 Bytes          | Single unicode character          | `char grade = 'A';`       |
| `bool`    | 1 Byte           | Truth values                      | `bool isComplete = true;` |

### 4. Basic Console Operations

- `Console.WriteLine()`: Output text to the console screen followed by a new line.
- `Console.Write()`: Output text to the screen keeping the cursor on the exact same line.
- `Console.ReadLine()`: Pauses execution and waits for user textual input from the console.
