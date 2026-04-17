# 📘 Introduction to .NET Framework

## 🧱 .NET Framework Architecture

The .NET Framework follows a **layered architecture** consisting of several core components:

```
+--------------------------------------+
|        Application (C#, VB.NET)      |
+--------------------------------------+
|   Common Language Specification      |
|               (CLS)                  |
+--------------------------------------+
|      Common Type System (CTS)        |
+--------------------------------------+
|   Common Language Runtime (CLR)      |
+--------------------------------------+
|     Base Class Library (BCL)         |
+--------------------------------------+
|            Operating System          |
+--------------------------------------+
```

---

## 🔹 Common Type System (CTS)

- Defines how types are declared, used, and managed in .NET.
- Ensures **language interoperability** across different languages like C#, VB.NET, and F#.
- Example:
  - `int` in C# and `Integer` in VB.NET are treated as the same type.

---

## 🔹 Common Language Specification (CLS)

- A set of rules that all .NET languages must follow.
- Ensures that code written in one language can be used in another.

✔ Example:
- A library written in C# can be used in a VB.NET application.

---

## 🔹 Common Language Runtime (CLR) ⭐ (IMPORTANT)

The **CLR** is the execution engine of the .NET Framework.

### Key Responsibilities:

1. **Memory Management**
   - Handles allocation and deallocation
   - Uses Garbage Collection

2. **Security**
   - Provides a secure execution environment

3. **Exception Handling**
   - Standard error handling mechanism

4. **Interoperability**
   - Enables cross-language interaction

5. **JIT Compiler**
   - Converts Intermediate Language (IL) into machine code

---

## 🔹 Base Class Library (BCL)

- A collection of reusable classes and methods

### Provides:
- File handling
- Data access
- Networking
- Security
- Collections

---

# 💡 Types in C#

## 🔸 Value Types

- Store actual data directly
- Stored in **stack memory**
- Passed **by value**

### Examples:
```csharp
int x = 10;
char c = 'A';
bool isTrue = true;

struct Point 
{ 
    public int X; 
    public int Y; 
}

enum Color 
{ 
    Red, Green, Blue 
}
```

---

## 🔸 Reference Types

- Store reference to actual data
- Stored in **heap memory**
- Passed **by reference**

### Types:

### 1. Class
- Blueprint for objects

### 2. Interface
- Defines contract (methods/properties)

### 3. Array
- Collection of same-type elements

---

# 🧵 Strings in C#

## 🔹 String

- Reference type
- **Immutable**

```csharp
string s = "Hello";
s = s + " World"; // new object created
```

---

## 🔹 StringBuilder

- Mutable string class
- More efficient for multiple operations

```csharp
using System.Text;

StringBuilder sb = new StringBuilder("Hello");
sb.Append(" World");
```

---

## 🔥 String vs StringBuilder

| Feature        | String        | StringBuilder      |
|---------------|--------------|--------------------|
| Mutability    | Immutable     | Mutable            |
| Performance   | Slower        | Faster             |
| Memory Usage  | Higher        | Lower              |

---

# 🚀 Summary

- **CTS** → Defines types  
- **CLS** → Language compatibility  
- **CLR** → Runtime execution  
- **BCL** → Libraries  
- **Value Types** → Stack, copied  
- **Reference Types** → Heap, referenced  
- **String** → Immutable  
- **StringBuilder** → Mutable  

---

⭐ Perfect for beginners coming from Java!
