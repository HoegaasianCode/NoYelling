using System;

namespace NoYellingPlease
{
    class Program
    {
        // https://edabit.com/challenge/ToMXLjWDLQqFua7Wh
        // SOLVED

        static void Main(string[] args)
        {
            YellDetector yellDetector = new("Skrik inte!!!!!!!!!!"); // "variant"
            Console.Write(yellDetector.ReverseLoop());
        }
    }
}
