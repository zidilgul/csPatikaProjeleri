using System;

namespace OrtalamaHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the number of elements of the fibonacci sequence: ");
            int n = int.Parse(Console.ReadLine());
            int[] fibonacci = new int[n];
            Methods instance = new Methods();
            fibonacci = instance.CreateFibonacci(n);
            instance.WriteFibonacci(fibonacci);
            instance.CalculateAvg(fibonacci);
        }
    }

    class Methods
    {
        public int[] CreateFibonacci(int n)
        {
            int[] fibonacci = new int[n];

            for (int i = 0; i < n; i++)
            {
                if (i < 2)
                    for (int j = 0; j < n; j++)
                    {
                        fibonacci[j] = 1;
                    }
                else
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }

            return fibonacci;
        }

        public void CalculateAvg(int[] fibonaci)
        {
            double avg = 0;

            for (int i = 0; i < fibonaci.Length; i++)
            {
                avg += fibonaci[i];
            }

            avg /= fibonaci.Length;

            Console.WriteLine("Sequence average: " + avg);
        }

        public void WriteFibonacci(int[] fibonaci)
        {
            Console.WriteLine("Fibonacci sequence: ");
            for (int i = 0; i < fibonaci.Length; i++)
            {
                Console.Write(fibonaci[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
