// c# maths : 
// max, min, abs, pow, sqrt, round, floor, ceil, log, log10, exp, 
// sin, cos, tan, asin, acos, atan, atan2

using System;
namespace MathOperations{
    class Program{
        static void Main(string[] args){
            double a = -5.5;
            double b = 2.0;

            Console.WriteLine("Max: " + Math.Max(a, b));
            Console.WriteLine("Min: " + Math.Min(a, b));
            Console.WriteLine("Abs: " + Math.Abs(a));
            Console.WriteLine("Pow: " + Math.Pow(b, 3));
            Console.WriteLine("Sqrt: " + Math.Sqrt(16));
            Console.WriteLine("Round: " + Math.Round(3.6));
            Console.WriteLine("Floor: " + Math.Floor(3.6));
            Console.WriteLine("Ceil: " + Math.Ceiling(3.2));
            Console.WriteLine("Log: " + Math.Log(10));
            Console.WriteLine("Log10: " + Math.Log10(100));
            Console.WriteLine("Exp: " + Math.Exp(1));
            Console.WriteLine("Sin: " + Math.Sin(Math.PI / 2));
            Console.WriteLine("Cos: " + Math.Cos(Math.PI));
            Console.WriteLine("Tan: " + Math.Tan(Math.PI / 4));
            Console.WriteLine("Asin: " + Math.Asin(1));
            Console.WriteLine("Acos: " + Math.Acos(0));
            Console.WriteLine("Atan: " + Math.Atan(1));
            Console.WriteLine("Atan2: " + Math.Atan2(1, 1));
        }
    }
}