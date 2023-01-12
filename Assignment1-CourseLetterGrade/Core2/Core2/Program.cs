// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core2
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter;

            Console.WriteLine("Enter name: ");
            var name = Console.ReadLine();
            while (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name can't be empty! Input your name once more\n");
                Console.WriteLine("Enter name: ");
                name = Console.ReadLine();
            }
            Console.WriteLine($"\tHi, {name}!");

            Console.WriteLine("Enter your Score: ");
            var scoreAsString = Console.ReadLine();
            double score; 
            while (!double.TryParse(scoreAsString, out score))
            {
                Console.WriteLine("This is not a number! Please enter your score in numbers\n");
                Console.WriteLine("Enter your Score: ");
                scoreAsString = Console.ReadLine();
            }
            Console.WriteLine($"\tYour entered score is: {score}");
            String passmessage = "Congratulations!! You Passed!!!";
            String failmessage = "Oops! Try Harder Next Time";

            if (score >= 90)
            {
                letter = 'A';
                Console.WriteLine("{0}, Your Grade is {1} with a score of {2}", name, letter, score);
                Console.WriteLine(passmessage);
            }
            else if (score >= 80)
            {
                letter = 'B';
                Console.WriteLine("{0}, Your Grade is {1} with a score of {2}", name, letter, score);
                Console.WriteLine(passmessage);
            }
            else if (score >= 70)
            {
                letter = 'C';
                Console.WriteLine("{0}, Your Grade is {1} with a score of {2}", name, letter, score);
                Console.WriteLine(passmessage);
            }
            else if (score >= 60)
            {
                letter = 'D';
                Console.WriteLine("{0}, Your Grade is {1} with a score of {2}", name, letter, score);
                Console.WriteLine(passmessage);
            }
            else if (score < 60)
            {
                letter = 'F';
                Console.WriteLine("{0}, Your Grade is {1} with a score of {2}", name, letter, score);
                Console.WriteLine(failmessage);
            }
            else
            {
                Console.WriteLine("Wrong Input");
            }

            //Console.WriteLine("{0} has a score of {1} with a grade of {2}", name, score, letter);
        }
    }
}
