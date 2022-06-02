using System;
using System.Linq;

namespace ConsoleApp2 {
    internal class Program {
        static void Main(string[] args)
        {
            string exit;
            do
            {
                Console.Clear();
                Console.WriteLine("How many people are we making PB & J sandwiches for?");
                int numOfPeople = int.Parse(Console.ReadLine());

                int slices = numOfPeople * 2;  // Slices of bread per person
                int tbspButter = numOfPeople * 2; // Tablespoons of peanut butter per person
                int tspJelly = numOfPeople * 4; // Teaspoons of jelly per person

                Console.WriteLine("\nYou need:\n");
                Console.WriteLine($"\t{slices} slices of bread");
                Console.WriteLine($"\t{tbspButter} tablespoons of peanut butter");
                Console.WriteLine($"\t{tspJelly} teaspoons of jelly\n");
                Console.WriteLine("\tWhich is...\n");

                double loaves = (double)slices / 28; // How many loaves of bread to make the sandwiches
                double jarsButter = (double)tbspButter / 32; // How many jars of peanut butter to make the sandwiches
                double jarsJelly = (double)tspJelly / 48; // How many jars of jelly to make the sandwiches

                Console.WriteLine($"\t{Math.Ceiling(loaves)} loaves of bread");
                Console.WriteLine($"\t{Math.Ceiling(jarsButter)} jars of peanut butter");
                Console.WriteLine($"\t{Math.Ceiling(jarsJelly)} jars of jelly\n");

                Console.WriteLine("Would you like to restart? Enter yes or y to continue, or enter any other key to exit.");
                exit = Console.ReadLine().ToLower();

            } while(exit == "yes" || exit == "y");

            Console.WriteLine("Goodbye!");
        }
    }
}