using System;

namespace ConsoleApp1


{
    class Program
    {
        static void Main(string[] args)
        {



            Console.Write("Enter your value:"); 
            double userInput;
            while (!double.TryParse(Console.ReadLine(), out userInput))
            {
                Console.WriteLine("Invalid number, try again.");
            }
            
            double computerValue = Random.Shared.NextDouble() * 100; 
           
            
            double result = userInput * computerValue; 


            double roundedResult = Math.Round(result, MidpointRounding.AwayFromZero);
            Console.WriteLine("Result is: " + roundedResult);




        }

    }
}