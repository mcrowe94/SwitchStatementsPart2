using System;

namespace SwitchStatementsPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi there! What is your favorite school subject?");
            Console.WriteLine();
            var subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math; a challenging subject!");
                    break;
                case "science":
                    Console.WriteLine("Science; you can never learn too much!");
                    break;
                case "english":
                    Console.WriteLine("English; you can always expand your vocabulary!");
                    break;
                default:
                    Console.WriteLine($"Oh wow! {subject} sounds awesome, I don't remember taking that!");
                    break;
            }

        }
    }
}
