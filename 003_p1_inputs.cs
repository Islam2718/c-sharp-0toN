// problem: 
// take input from user name, age, height, student status, and provide output with a generating messege
// and must with suggestion. like hello {details} and {customer suggestions}

using System;
namespace InputApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // string input ReadLine()
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // int input ReadLine() and Convert.ToInt32()
            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);

            // double input ReadLine() and Convert.ToDouble()
            Console.Write("Enter your height in meters: ");
            string heightInput = Console.ReadLine();
            double height = Convert.ToDouble(heightInput);

            // bool input ReadLine() and Convert.ToBoolean()
            Console.Write("Are you a student? (true/false): ");
            string isStudentInput = Console.ReadLine();
            bool isStudent = Convert.ToBoolean(isStudentInput);

            // char input ReadLine() and Convert.ToChar()
            Console.Write("Enter your gender (M/F): ");
            string genderInput = Console.ReadLine();
            char gender = Convert.ToChar(genderInput);


            string message = "Hello " + name + "! You are a " + isStudent + " students and your age is " + age + ". In this age, a " + height + " feet tall boy must should to stay in study table.";
            Console.WriteLine(message);
        }
    }
}