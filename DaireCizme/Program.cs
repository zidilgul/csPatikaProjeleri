using System;

namespace DaireCizme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of circle: ");
            int r = int.Parse(Console.ReadLine());

            Methods instance = new Methods();
            instance.DrawCircle(r);

        }
    }

    class Methods
    {
        public void DrawCircle(int yaricap)
        {

            for (double y = -yaricap; y <= yaricap; y++)
            {
                for (double x = -yaricap; x <= yaricap; x += 1)
                {
                    if ((x * x) + (y * y) >= yaricap * yaricap)
                        Console.Write("  ");
                    else
                        Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
