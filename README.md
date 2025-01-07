# C# DivideByZeroException Bug
This repository demonstrates a common C# bug: a `DivideByZeroException`.  The `MyMethod` function in `bug.cs` contains a potential `DivideByZeroException` because it divides by `Value` without explicitly checking if `Value` is zero.

The `bugSolution.cs` file provides a solution to prevent this exception.

This example highlights the importance of robust error handling in C# applications.