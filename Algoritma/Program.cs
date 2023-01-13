using System;

namespace Algoritma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] S = new string[2];
            Console.Write("Enter a word and the index of character you wanted to remove from it: ");
            S = (Console.ReadLine()).Split(" ");

            string s1 = S[0];
            int index = int.Parse(S[1]);

            if(s1.Length < index)
            {
                Console.WriteLine("The index you entered is not within the word length limits.");
            }
            else
            {
                s1 = s1.Remove(index,1);

                Console.WriteLine("Your string is now: " + s1);
            }
        }
    }
}
