// Arithmetic Operators: + - * / % ++ --
// Assignment Operators: = += -= *= /= %=
// Comparison Operators: == != > < >= <=
// Logical Operators: && || !
using System;
namespace OperatorsAndTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arithmetic Operators
            int a = 10;
            int b = 3;

            Console.WriteLine(a + b); // Outputs 13
            Console.WriteLine(a - b); // Outputs 7
            Console.WriteLine(a * b); // Outputs 30
            Console.WriteLine(a / b); // Outputs 3
            Console.WriteLine(a % b); // Outputs 1

            a++; // Increment operator
            Console.WriteLine(a); // Outputs 11

            b--; // Decrement operator
            Console.WriteLine(b); // Outputs 2

            // Assignment Operators
            int c = 5;
            c += 2; // c = c + 2
            Console.WriteLine(c); // Outputs 7

            c -= 3; // c = c - 3
            Console.WriteLine(c); // Outputs 4

            c *= 2; // c = c * 2
            Console.WriteLine(c); // Outputs 8

            c /= 4; // c = c / 4
            Console.WriteLine(c); // Outputs 2

            c %= 2; // c = c % 2
            Console.WriteLine(c); // Outputs 0

            // Comparison Operators
            int x = 5;
            int y = 10;

            Console.WriteLine(x == y); // Outputs False
            Console.WriteLine(x != y); // Outputs True
            Console.WriteLine(x > y);   // Outputs False
            Console.WriteLine(x < y);   // Outputs True
            Console.WriteLine(x >= y);  // Outputs False
            Console.WriteLine(x <= y);  // Outputs True

            // Logical Operators
            bool condition1 = true;
            bool condition2 = false;

            Console.WriteLine(condition1 && condition2); // Outputs False
            Console.WriteLine(condition1 || condition2); // Outputs True
            Console.WriteLine(!condition1);              // Outputs False
        }
    }
}