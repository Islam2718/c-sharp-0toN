using System;
using System.Linq; // use for Concat array. 

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars;
            cars = new string[] {"BMW", "Volvo", "Ford"};
            // cars = new string[] {"Honda", "Toyota"}; // replate previous array with new array
            cars = cars.Concat(new string[] {"Honda"}).ToArray(); //Linq 

            Console.WriteLine("Cars Array Length : "+ cars.Length);

            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}