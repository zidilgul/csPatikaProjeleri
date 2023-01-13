using System;

namespace UcgenCizme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the row number of triangle: ");
            int n = int.Parse(Console.ReadLine());
            Methods instance = new Methods();
            instance.Draw(n);
        }

    }
    class Methods
    {
        public void Draw(int n)
        {
            for(int i = 0; i <= n; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
