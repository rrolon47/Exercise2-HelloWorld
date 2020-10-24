using System;
using System.Dynamic;
using System.Net.Http.Headers;

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

            //Write a program that asks a user for the number of miles they have driven 
            Console.WriteLine("How many miles have you driven?");
            double milesDriven = double.Parse(Console.ReadLine());
            //and the amount of gas they’ve consumed (in gallons), 
            Console.WriteLine("How many gallons of gas did that consume?");
            double gallonsConsumed = double.Parse(Console.ReadLine());
            //and print their miles-per-gallon
            Console.WriteLine($"Your car was getting {milesDriven/gallonsConsumed} miles-per-gallon.");



            //The first sentence of Alice’s Adventures in Wonderland is below.  Store this sentence in a string,
            string sentence = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            //and then prompt the user for a term to search for within this string
            Console.WriteLine("What word would you like to search for?");
            string userInput = Console.ReadLine();
            //Print whether or not the search term was found.Make the search case-insensitive,
            //Assume the user enters a word that is in the sentence. Print out its index within the string and its length. 
            string sentenceToLower = sentence.ToLower();
            string inputToLower = userInput.ToLower();

            if (!sentenceToLower.Contains(inputToLower))
            {
                Console.WriteLine("The word you wanted to search for was not found.");
            }
            else
            {
                int searchLength = userInput.Length;
                int searchIndex = sentenceToLower.IndexOf(inputToLower);
                Console.WriteLine($"The word '{userInput}' was found at the index of {searchIndex} and is {searchLength} characters long.");
                //Next, remove the word from the string and print the sentence again to confirm your code. Remember that strings are immutable, so you will 
                //need to reassign the old sentence variable or create a new one to store the updated phrase.
                string searchRemoved = sentence.Remove(searchIndex, searchLength);
                Console.WriteLine($"Searched word: {sentence.Substring(searchIndex, searchLength)} Remaining sentence: {searchRemoved}");

            }




        }
    }
}
