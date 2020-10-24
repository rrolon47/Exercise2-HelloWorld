using System;
using System.Dynamic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write "Hello, World" program to promt user and greet by name:
            //ask user a question
            Console.WriteLine("What is your name?");
            //create a variable to hold user input
            string name = Console.ReadLine();
            //print a greeting
            Console.WriteLine($"Hello {name}.");
            //run program

            //Write a program to calculate the area of a rectangle and print the answer to the console. You should prompt the user for the dimensions.
            //Add a print line to prompt the user for the length of the rectangle.
            Console.WriteLine("Let's calculate the area of a rectangle.\nWhat is the length of the rectangle?");
            //Define a variable to handle the user’s response.
            double length = double.Parse(Console.ReadLine());
            //Repeat the previous two steps to ask for and store the rectangle’s width.
            Console.WriteLine("Great. Now, what is the width of the rectangle?");
            double width = double.Parse(Console.ReadLine());
            //Use the length and width values to calculate the rectangle’s area.
            double area = length * width;
            //Print a statement using concatenation to communicate to the user what the area of their rectangle is.
            Console.WriteLine($"The area of a rectangle with the length of {length} and a width of {width} is {area}.");
            //Run the program to verify your code.

        }
    }
}
