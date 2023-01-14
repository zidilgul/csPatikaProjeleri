using System;

namespace IkiliToplam
{
        internal class Program
        {
                static void Main(string[] args)
                {
                        System.Console.Write("Enter numbers: ");
                        string input = Console.ReadLine();
                        string[] pairs = input.Split();

                        Methods instance = new Methods();

                        int[] sums = instance.Add(pairs);

                        instance.Print(sums);

                }
        }

        class Methods
        {
                public int[] Add(string[] pairs)
                {
                        int n = pairs.Length / 2;
                        int[] sums = new int[n];
                        for (int i = 0; i < n; i++)
                        {
                                int x = int.Parse(pairs[2 * i]);
                                int y = int.Parse(pairs[2 * i + 1]);

                                sums[i] = x + y;

                                if (x == y)
                                        sums[i] *= sums[i];
                        }

                        return sums;
                }

                public void Print(int[] sums)
                {

                        for (int i = 0; i < sums.Length; i++)
                        {
                                Console.WriteLine(sums[i]);
                        }
                }
        }
}