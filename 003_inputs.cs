using System;
namespace InputApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // string input ReadLine()
            Console.Write("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");

            // int input ReadLine() and Convert.ToInt32()
            Console.Write("Enter your age:");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);
            Console.WriteLine($"You are {age} years old.");

            // double input ReadLine() and Convert.ToDouble()
            Console.Write("Enter your height in meters:");
            string heightInput = Console.ReadLine();
            double height = Convert.ToDouble(heightInput);
            Console.WriteLine($"Your height is {height} meters.");

            // bool input ReadLine() and Convert.ToBoolean()
            Console.Write("Are you a student? (true/false):");
            string isStudentInput = Console.ReadLine();
            bool isStudent = Convert.ToBoolean(isStudentInput);
            Console.WriteLine($"Student status: {isStudent}");

            // char input ReadLine() and Convert.ToChar()
            Console.Write("Enter your gender (M/F):");
            string genderInput = Console.ReadLine();
            char gender = Convert.ToChar(genderInput);
            Console.WriteLine($"Your gender is {gender}.");
        }
    }
}


// String (টেক্সট): Console.ReadLine()	"Rahim"
// Int (পূর্ণসংখ্যা): Convert.ToInt32(Console.ReadLine())	25
// Double (দশমিক): Convert.ToDouble(Console.ReadLine())	3.75
// Char (একটি অক্ষর): Convert.ToChar(Console.ReadLine())	'A'
