using System;
using System.Linq;


//Each sandwich requires 2 slices of bread, 2 tablespoons of peanut butter, and 4 teaspoons of jelly
//Assume 1 sandwich per person
//Assume 1 loaf of bread contains exactly 28 slices
//Assume 1 jar of peanut butter contains exactly 32 tablespoons
//Assume 1 jar of jelly contains exactly 48 teaspoons



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
                int slices = numOfPeople * 2;
                int tbspButter = numOfPeople * 2;
                int tspJelly = numOfPeople * 4;

                Console.WriteLine("\nYou need:\n");
                Console.WriteLine($"\t{slices} slices of bread");
                Console.WriteLine($"\t{tbspButter} tablespoons of peanut butter");
                Console.WriteLine($"\t{tspJelly} teaspoons of jelly\n");
                Console.WriteLine("\tWhich is...\n");

                double loaves = (double)slices / 28;
                double jarsButter = (double)tbspButter / 32;
                double jarsJelly = (double)tspJelly / 48;

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