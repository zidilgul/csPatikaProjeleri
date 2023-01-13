using System;

namespace AlanHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            while(n!=-1)
            {
                Console.WriteLine("1- Kare");
                Console.WriteLine("2- Dikdörtgen");
                Console.WriteLine("3- Üçgen");
                Console.WriteLine("4- Daire");
                Console.WriteLine("Çıkmak için -1 tuşlayın");

                Console.Write("Şekil numarası giriniz: ");
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
                        Console.WriteLine("Hatalı giriş yaptınız");
                        break;

                }
            }
        }
    }

    public class Methods
    {
        public void CalculateAreaSquare()
        {
            Console.Write("Kenar uzunluğu giriniz: ");
            int k = int.Parse(Console.ReadLine());

            int area = k * k;

            Console.WriteLine("Karenin alanı: " + area);
        }

        public void CalculateAreaRectangle()
        {
            Console.Write("1.kenar uzunluğu giriniz: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("2.kenar uzunluğu giriniz: ");
            int m = int.Parse(Console.ReadLine());

            int area = k * m;

            Console.WriteLine("Karenin alanı: " + area);
        }

        public void CalculateAreaTriangle()
        {
            Console.Write("Kenar uzunluğu giriniz: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Yükseklik giriniz: ");
            int h = int.Parse(Console.ReadLine());

            int area = (k * h) / 2;

            Console.WriteLine("Karenin alanı: " + area);
        }

        public void CalculateAreaCircle()
        {
            Console.Write("Yarıçap uzunluğu giriniz: ");
            int r = int.Parse(Console.ReadLine());
            const double pi = 3.14;
            double area = (pi * r * r);

            Console.WriteLine("Karenin alanı: " + area);
        }

    }
    
}
