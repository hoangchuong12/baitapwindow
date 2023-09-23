using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1bai03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("nhap vao so nguyen duong n: ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("vui long nhap lai so nguyen duong");
            }
            else
            {
                int sum = 0;

                for (int i = 1; i <= 2 * n - 1; i += 2)
                {
                    sum += i;
                }

                Console.WriteLine($"tong cac so le {2 * n - 1} là: {sum}");
                Console.ReadKey();
            }
        }
    }
}
