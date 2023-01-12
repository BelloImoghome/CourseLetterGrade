// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    class Core3
    {
        static void Main(string[] args)
        {
            char letter;
            string sig;

            Console.WriteLine("Enter name: ");
            var name = Console.ReadLine();
            while (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name can't be empty! Input your name once more");
                name = Console.ReadLine();
            }
            Console.WriteLine($"Hi, {name}!");

            Console.WriteLine("Enter your Score: ");
            var scoreAsString = Console.ReadLine();
            double score;
            while (!double.TryParse(scoreAsString, out score))
            {
                Console.WriteLine("This is not a number! Please enter your score in numbers");
                Console.WriteLine("Enter your Score: ");
                scoreAsString = Console.ReadLine();
            }
            Console.WriteLine($"Your entered score is: {score}");

            String passmessage = "Congratulations!! You Passed!!!";
            String failmessage = "Oops! Try Harder Next Time";

            static string Signa(double score)
            {
                int rem;
                string sign;
                rem = (int)(score % 10);
                if (rem >= 7)
                    sign = "+";
                else if (rem <= 3)
                    sign = "-";
                else
                    sign = "";
                return sign;
            }

            static string SignaA(double score)
            {
                int rem;
                string sign;
                rem = (int)(score % 10);
                if (rem <= 3)
                    sign = "-";
                else
                    sign = "";
                return sign;
            }

            if (score >= 90)
            {
                letter = 'A';
                sig = SignaA(score);
                Console.WriteLine("{0}, Your Grade is {1}{2} with a score of {3}", name, letter, sig, score);
                Console.WriteLine(passmessage);
            }
            else if (score >= 80)
            {
                letter = 'B';
                sig = Signa(score);
                Console.WriteLine("{0}, Your Grade is {1}{2} with a score of {3}", name, letter, sig, score);
                Console.WriteLine(passmessage);
            }
            else if (score >= 70)
            {
                letter = 'C';
                sig = Signa(score);
                Console.WriteLine("{0}, Your Grade is {1}{2} with a score of {3}", name, letter, sig, score);
                Console.WriteLine(passmessage);
            }
            else if (score >= 60)
            {
                letter = 'D';
                sig = Signa(score);
                Console.WriteLine("{0}, Your Grade is {1}{2} with a score of {3}", name, letter, sig, score);
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
                //goto start;
            }
        }
    }
}
