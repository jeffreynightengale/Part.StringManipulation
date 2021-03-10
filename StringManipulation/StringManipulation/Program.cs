using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.");
            string s1 = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";

            Console.WriteLine($"What word would you like to search for?");
            string answer = Console.ReadLine();

            Console.WriteLine($"What word would you like to change {answer} to?");
            string change = Console.ReadLine();

            bool b = s1.Contains(answer);
            if (b)
            {
                Console.WriteLine(s1.Replace(answer, change));
            }
            else
            {
                Console.WriteLine($"Sorry, I could not find your word {answer}.");

                for (int i = answer.Length-1; i >= 0; i--)
                {
                    Console.Write($"{answer[i]}");
                }
            }

        }
    }
}
