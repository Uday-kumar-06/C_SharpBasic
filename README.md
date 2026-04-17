Introduction to .NET framework

.NET framework architecture:
It is a layered architecture consisting of several components such as:

Common Type System (CTS):
Every type in the .NET framework is defined in a common type system which provides a standard way of defining and using types across different programming languages (e.g., C#, VB.NET, F#). For example, an integer defined in C# and an Integer in VB.NET are represented as the same type in the CTS. This enables seamless interoperability between languages.

Common Language Specification (CLS):
A set of rules and guidelines that define how programming languages should be designed and implemented to be compatible with the .NET framework. If a language supports the CLS, libraries and components created in that language can be consumed by other CLS-compliant languages (for example, a library written in C# can be used in a VB.NET application).

Common Language Runtime (CLR) (IMPORTANT):
The CLR is the runtime execution environment for .NET applications. It provides a managed execution environment, handling memory management, security, and other aspects of application execution. The CLR also includes a just-in-time (JIT) compiler that converts intermediate language (IL) into native machine code at runtime, improving performance.

Common functionality of the CLR includes:
1. Memory management: CLR manages memory allocation and deallocation for .NET applications to help prevent memory leaks.
2. Security: CLR provides a security model that allows developers to specify permissions and access levels for applications.
3. Exception handling: CLR provides a robust exception handling mechanism for consistent error handling.
4. Interoperability: CLR enables interoperability between different programming languages and platforms.

Base Class Library (BCL):
The BCL is a collection of pre-built classes and functions included with the .NET framework. It provides a wide range of functionality for developers, including support for data access, networking, security, and more.
