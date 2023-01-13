using System;

namespace AlanHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            while (n != -1)
            {
                Console.WriteLine("1- Kare");
                Console.WriteLine("2- Dikd�rtgen");
                Console.WriteLine("3- ��gen");
                Console.WriteLine("4- Daire");
                Console.WriteLine("��kmak i�in -1 tu�lay�n");

                Console.Write("�ekil numaras� giriniz: ");
                bool isNum = int.TryParse(Console.ReadLine(), out n);
                Methods inst = new Methods();


                switch (n)
                {
                    case -1:
                        Console.WriteLine("Program sona erdi");
                        break;
                    case 1:
                        inst.CalculateAreaSquare();
                        break;
                    case 2:
                        inst.CalculateAreaRectangle();
                        break;
                    case 3:
                        inst.CalculateAreaTriangle();
                        break;
                    case 4:
                        inst.CalculateAreaCircle();
                        break;
                    default:
                        Console.WriteLine("Hatal� giri� yapt�n�z");
                        break;

                }
            }
        }
    }

    public class Methods
    {
        public void CalculateAreaSquare()
        {
            Console.Write("Kenar uzunlu�u giriniz: ");
            int k = int.Parse(Console.ReadLine());

            int area = k * k;

            Console.WriteLine("Karenin alan�: " + area);
        }

        public void CalculateAreaRectangle()
        {
            Console.Write("1.kenar uzunlu�u giriniz: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("2.kenar uzunlu�u giriniz: ");
            int m = int.Parse(Console.ReadLine());

            int area = k * m;

            Console.WriteLine("Karenin alan�: " + area);
        }

        public void CalculateAreaTriangle()
        {
            Console.Write("Kenar uzunlu�u giriniz: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Y�kseklik giriniz: ");
            int h = int.Parse(Console.ReadLine());

            int area = (k * h) / 2;

            Console.WriteLine("Karenin alan�: " + area);
        }

        public void CalculateAreaCircle()
        {
            Console.Write("Yar��ap uzunlu�u giriniz: ");
            int r = int.Parse(Console.ReadLine());
            const double pi = 3.14;
            double area = (pi * r * r);

            Console.WriteLine("Karenin alan�: " + area);
        }

    }

}