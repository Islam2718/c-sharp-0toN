// Assign a value of one data type to another type.
// Implicit Casting (automatically) - converting a smaller type to a larger type size
// char -> int -> long -> float -> double

// Explicit Casting (manually) - converting a larger type to a smaller size type
// double -> float -> long -> int -> char

using System;
namespace TypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Casting
            int myInt = 9;
            double myDouble = myInt; // Automatic casting: int to double

            Console.WriteLine(myInt);      // Outputs 9
            Console.WriteLine(myDouble);   // Outputs 9

            // Explicit Casting
            double myDouble2 = 9.78;
            int myInt2 = (int)myDouble2; // Manual casting: double to int

            Console.WriteLine(myDouble2);   // Outputs 9.78
            Console.WriteLine(myInt2);      // Outputs 9
        }
    }
}