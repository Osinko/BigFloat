using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class Program
{
    public static void Main(String[] args)
    {
        //multiple ways to construct a BigFloat
        BigFloat bigfloat1 = new BigFloat(1234567);
        BigFloat bigfloat2 = new BigFloat("1234567");
        BigFloat bigfloat3 = new BigFloat(1234567.0); 
        BigFloat bigfloat4 = BigFloat.Parse("1234567.123");

        
        Console.WriteLine("(1234567 * 12)^2 - 15 = \n");


        Console.WriteLine("Arithmetic:             " + (Math.Pow(1234567 * 12,2) - 15));

        //non-static methods
        Console.WriteLine("BigFloat w/ non-static: " + bigfloat1.Multiply(12).Pow(2).Subtract(15));

        //static methods
        bigfloat2 = BigFloat.Multiply(bigfloat2, 12);
        bigfloat2 = BigFloat.Pow(bigfloat2, 2);
        bigfloat2 = BigFloat.Subtract(bigfloat2, new BigInteger(15));
        Console.WriteLine("BigFloat w/ static    : " + bigfloat2);

        //operators
        Console.WriteLine("BigFloat w/ operators : " + (((bigfloat3 * 12) ^ 2) - 15));


        Console.WriteLine();

        //additional methods
        Console.WriteLine("Round(1234567.1234)     = " + BigFloat.Round(bigfloat4));
        Console.WriteLine("Ceil(1234567.1234)      = " + BigFloat.Ceil(bigfloat4));
        Console.WriteLine("Floor(1234567.1234)     = " + BigFloat.Floor(bigfloat4));
        Console.WriteLine("Inverse(1234567.1234)   = " + BigFloat.Inverse(bigfloat4).ToString(20));
        Console.WriteLine("Sqrt(1234567.1234)      = " + BigFloat.Sqrt(bigfloat4));
        Console.WriteLine("log10(1234567.1234)     = " + BigFloat.Log10(bigfloat4));

        //large numbers
        BigFloat pi = new BigFloat("3.141592653589793238462643383279502884197169399375105820974944592307816406286208998628034825342117067982148086513282306647093844609550582231725359408128481117450284102701938521105559644622948954930381964428810975665933446128475648233786783165271201909145648566923460348610454326648213393607260249141273724587006606315588174881520920962829254091715364367892590360011330530548820466521384146951941511609433057270365759591953092186117381932611793105118548074462379962749567351885752724891227938183011949");
        Console.WriteLine("\nPi to a really long decimal place:");
        Console.WriteLine(pi.ToString(200));

        Console.WriteLine("\nTau (2*PI): ");
        Console.WriteLine((pi*2).ToString(200));


        Console.Read();
    }
}