# Animal Sounds Console Application

This C# console application demonstrates inheritance and polymorphism using a simple Animal class hierarchy.

## Project Structure

- **Animal** (Base class): Contains a virtual `MakeSound()` method that prints "Some generic sound"
- **Dog** (Derived class): Overrides `MakeSound()` to print "Bark"
- **Cat** (Derived class): Overrides `MakeSound()` to print "Meow"

## Features

1. **Inheritance**: Dog and Cat classes inherit from the Animal base class
2. **Method Overriding**: Each derived class overrides the `MakeSound()` method
3. **Polymorphism**: Demonstrates how different objects can be treated as their base type

## How to Run

1. Make sure you have .NET 6.0 or later installed
2. Open a terminal in the project directory
3. Run the following commands:

```bash
dotnet build
dotnet run
```

## Expected Output

```
Animal sound:
Some generic sound

Dog sound:
Bark

Cat sound:
Meow

--- Polymorphism Example ---
Animal 1 sound: Some generic sound
Animal 2 sound: Bark
Animal 3 sound: Meow

Press any key to exit...
```

## Learning Objectives

- Understanding inheritance in C#
- Learning method overriding with the `virtual` and `override` keywords
- Demonstrating polymorphism in practice
- Working with base and derived classes 