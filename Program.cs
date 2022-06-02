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

            Console.WriteLine("How many people are we making PB & J sandwiches for?");
            int numOfPeople = int.Parse(Console.ReadLine());

            Console.WriteLine("You need:\n");
            Console.WriteLine($"{numOfPeople * 2} slices of bread");
            Console.WriteLine($"{numOfPeople * 2} tablespoons of peanut butter");
            Console.WriteLine($"{numOfPeople * 4} teaspoons of jelly\n");
            Console.WriteLine("Which is...");
            Console.WriteLine($"{numOfPeople * 2} loaves of bread");
            Console.WriteLine($"{numOfPeople * 2} jars of peanut butter");
            Console.WriteLine($"{numOfPeople * 4} jars of jelly\n");


        }
    }
}