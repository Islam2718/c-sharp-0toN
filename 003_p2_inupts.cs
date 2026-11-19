// Problem: 
// Write a program take inputs as string like name age, height and generate a message using this. 

using System;
namespace InputApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // string input ReadLine()
            Console.Write("Enter your name age height: ");
            string userInputs = Console.ReadLine();
            // string to array by space separator 
            string[] details = userInputs.Split(' ');

            string message = "Hello " + details[0] + "! You are a " + details[1] + " years old and your height is " + details[2] + " meters. In this age, a " + details[2] + " meters tall boy must should to stay in study table.";
            Console.WriteLine(message);
        }
    }
}