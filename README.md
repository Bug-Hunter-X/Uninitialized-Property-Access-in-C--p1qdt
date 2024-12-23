# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property that hasn't been explicitly initialized.  Uninitialized properties in C# will have a default value, but this may not always be the expected behavior, leading to subtle bugs.

**The Bug:**
The `ExampleClass` has a property `MyProperty` which is not assigned a value in the constructor or before being accessed.  When `MyMethod` attempts to use the value of `MyProperty`, it will get the default value (0 for `int`).

**The Solution:**
The improved code initializes `MyProperty` either in the constructor or before access to ensure a predictable value.

This example highlights the importance of explicit initialization of class members to avoid unexpected behavior. 