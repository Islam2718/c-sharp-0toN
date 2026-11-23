// convert data types explicitly by using built-in methods, such as Convert.ToBoolean, 
// Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) and Convert.ToInt64 (long)
using System;
namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Convert int to string
            int myInt = 10;
            string myString = Convert.ToString(myInt);
            Console.WriteLine(myString); // Outputs "10"

            // Convert string to int
            string myString2 = "20";
            int myInt2 = Convert.ToInt32(myString2);
            Console.WriteLine(myInt2); // Outputs 20

            // Convert double to int
            double myDouble = 9.78;
            int myInt3 = Convert.ToInt32(myDouble);
            Console.WriteLine(myInt3); // Outputs 10 (rounded)

            // Convert boolean to string
            bool myBool = true;
            string myString3 = Convert.ToString(myBool);
            Console.WriteLine(myString3); // Outputs "True"

            // Convert string to boolean
            string myString4 = "False";
            bool myBool2 = Convert.ToBoolean(myString4);
            Console.WriteLine(myBool2); // Outputs False
        }
    }
}