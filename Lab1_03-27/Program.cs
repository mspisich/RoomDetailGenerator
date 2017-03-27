using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_03_27
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runProgram = true;
            while (runProgram)
            {
                Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");

                //Prompt user for length and width of room
                Console.WriteLine("Enter Length: ");
                float roomLength = float.Parse(Console.ReadLine());

                Console.WriteLine("Enter Width: ");
                float roomWidth = float.Parse(Console.ReadLine());

                Console.WriteLine("Enter Height: ");
                float roomHeight = float.Parse(Console.ReadLine());

                //Print area, perimeter, and volume
                Console.WriteLine("Area: " + (roomLength * roomWidth));
                Console.WriteLine("Perimeter: " + ((2 * roomLength) + (2 * roomWidth)));
                Console.WriteLine("Volume: " + (roomLength * roomWidth * roomHeight));

                //Ask if user wants to continue
                Console.WriteLine("\nContinue? (y/n): ");
                string cont = Console.ReadLine();

                //Verify input
                while (cont != "y" && cont != "Y" && cont != "n" && cont != "N")
                {
                    Console.WriteLine("Please type y/n! Continue?: ");
                    cont = Console.ReadLine();
                }

                //Skip a line and run program again
                if (cont == "y" || cont == "Y")
                {
                    Console.WriteLine("\n");
                }
                //Stop program
                if (cont == "n" || cont == "N")
                {
                    runProgram = false;
                }
            }
        }
    }
}
