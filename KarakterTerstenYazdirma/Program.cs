using System;

namespace KarakterTerstenYazdirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string to shift: ");

            string input = Console.ReadLine();

            string[] strings = input.Split(" ");

            Methods instance = new Methods();

            foreach (var word in strings)
            {
                string s = instance.ShiftedString(word.ToString());
                Console.WriteLine(s);
            }
        }
    }

    class Methods
    {
        public string ShiftedString(string t)
        {
            return t.Substring(1, t.Length - 1) + t.Substring(0, 1);
        }
    }
}
