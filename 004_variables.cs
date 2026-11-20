// Variable 
// Program: to take input and find the type of this inputs. 

using System;
using System.Text.Json;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter Your Inputs:");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int intValue))
                {
                    Console.WriteLine($"You entered an integer: {intValue}");
                }
                else if (double.TryParse(input, out double doubleValue))
                {
                    Console.WriteLine($"You entered a double: {doubleValue}");
                }
                else if (char.TryParse(input, out char charValue))
                {
                    Console.WriteLine($"You entered a char: {charValue}");
                }
                else if (bool.TryParse(input, out bool boolValue))
                {
                    Console.WriteLine($"You entered a boolean: {boolValue}");
                }
                else if (long.TryParse(input, out long longValue))
                {
                    Console.WriteLine($"You entered a long: {longValue}");
                }
                else if (float.TryParse(input, out float floatValue))
                {
                    Console.WriteLine($"You entered a float: {floatValue}");
                }
                else if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("You entered an empty string.");
                }
                else if (input.StartsWith("[") && input.EndsWith("]"))
                {
                    if (IsValidJson(input))
                    {
                        Console.WriteLine($"You entered an Array: {input}\n");
                    }
                    else
                    {
                        Console.WriteLine($"You entered an Array-like String (Invalid format): {input}\n");
                    }
                }
                else if (input.StartsWith("{") && input.EndsWith("}"))
                {
                    string formattedInput = input.Replace("'", "\"");

                    if (IsValidJson(formattedInput))
                    {
                        Console.WriteLine($"You entered an Object: {input}\n");
                    }
                    else
                    {
                        Console.WriteLine($"You entered an Object-like String (Invalid format): {input}\n");
                    }
                }
                else
                {
                    Console.WriteLine($"You entered a string: {input}");
                }
            }
        }
        static bool IsValidJson(string input)
        {
            try
            {
                JsonDocument.Parse(input);
                return true;
            }
            catch (JsonException)
            {
                return false;
            }
        }
    }
}