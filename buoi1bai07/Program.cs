using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1bai07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen duong n: ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 1)
            {
                Console.WriteLine("khong co so nguyen to tu 1 den " + n);
            }
            else
            {
                Console.WriteLine("cac so nguyen to tu 1 " + n + " la:");
                for (int i = 2; i <= n; i++)
                {
                    if (LaSoNguyenTo(i))
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            Console.ReadKey();
        }

        static bool LaSoNguyenTo(int number)
        {
            if (number <= 1)
                return false;

            if (number <= 3)
                return true;

            if (number % 2 == 0 || number % 3 == 0)
                return false;

            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
            }

            return true;
        }
    }
}
