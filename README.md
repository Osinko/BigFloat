# BigFloat

## Purpose
This project was essentially just to implement an arbitrary precision floating point library using C#.

## Installation
Copy BigFloat.cs into your project

## Usage
Similiar to that of using BigInteger in C#.

    BigFloat bigfloat = new BigFloat(1234);
    
    //operator overloaded usage:
    bigfloat *= 12;
    //non-static method usage:
    bigfloat.Multiply(12);
    //static method usage:
    BigFloat.Multiply(bigfloat, 12);
    
    //implicit casts
    bigfloat = 34;
    
    //parsing
    bigfloat = BigFloat.Parse("98782");
    //or
    bigfloat = new BigFloat("98782");
    
    
## Examples
See Example.cs for an example
