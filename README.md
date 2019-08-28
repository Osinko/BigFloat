# BigFloat

## Purpose
This project was essentially just to implement an arbitrary precision floating point library using C#.

## Installation
Copy BigFloat.cs into your project

## Usage
Similiar to that of using BigInteger in C#.

```cs
BigFloat bigFloat = new BigFloat(1234);

// Operator overloaded usage:
bigFloat *= 12;
// Non-static method usage:
bigFloat.Multiply(12);
// Static method usage:
BigFloat.Multiply(bigFloat, 12);

// Implicit casts
bigfloat = 34;

// Parsing
bigFloat = BigFloat.Parse("98782");
// or
bigfloat = new BigFloat("98782");
```
    
    
## Examples
See Example.cs for an example
