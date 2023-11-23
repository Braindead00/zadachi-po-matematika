using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("izberi zadacha");
            Console.WriteLine("1. Diskriminanta");
            Console.WriteLine("2. Lice na pravougulik");

            int k = Convert.ToInt32(Console.ReadLine());

            if (k == 1)
            {
                Console.WriteLine("ti izbra Diskriminanta");

                Console.WriteLine("vuvedi a");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("vuvedi b");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("vuvedi c");
                int c = Convert.ToInt32(Console.ReadLine());

                int D = (b * b - 4 * a * c);
                Console.WriteLine("Deiskriminantata e " + D);

                if (D <= 0) Console.WriteLine("nqma koreni");

                else Console.WriteLine("ima koreni");
            }

            else if (k == 2)
            {
                Console.WriteLine("ti izbra lice na pravougulnik");

                Console.WriteLine("vuvedi а");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("vuvedi b");
                int b = Convert.ToInt32(Console.ReadLine());

                int S = (a * b);
                Console.WriteLine("liceto na pravougulnik e " + S);
            }

            else Console.WriteLine("cheti uslovieto");
        }
    }
}
