using System;

namespace module_3_Discussion
{
    class Program
    {
        class Octopus
        {
            // Fields
            public string name;
            public int age = 50;
            public static readonly int legs = 8;
            public static readonly int eyes = 2;

            // Main method
            static void Main()
            {
                // Create an instance of Octopus and set the name
                Octopus myOctopus = new Octopus();
                myOctopus.name = "Dhamyr";

                // Display information about the octopus
                Console.WriteLine($"Name: {myOctopus.name}");
                Console.WriteLine($"Age: {myOctopus.age}");
                Console.WriteLine($"Legs: {Octopus.legs}");
                Console.WriteLine($"Eyes: {Octopus.eyes}");

                // Display the color using the TopLevel class
                TopLevel.Color color = TopLevel.Color.Orange;
                Console.WriteLine($"Color: {color}");
            }
        }

        class TopLevel
        {
            public enum Color
            {
                Orange,
                Blue,
                Red
            }
        }
    }
}
