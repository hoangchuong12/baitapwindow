using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1bai06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap cac he so phuong trinh bac 3ax^2 + bx + c = 0:");
            ptb3();
            Console.ReadKey();

        }
        static void ptb3()
        {
            Console.Write("nhap a: ");
            double a = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("he so a khac khong den nay la phuong trinh bac 2.");
            }
            else
            {
                Console.Write("Nhap b: ");
                double b = double.Parse(Console.ReadLine());

                Console.Write("Nhap c: ");
                double c = double.Parse(Console.ReadLine());

                double delta = b * b - 4 * a * c;

                if (delta > 0)
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("phuong trinh co 2 nghiem phan biet:");
                    Console.WriteLine($"x1 = {x1}");
                    Console.WriteLine($"x2 = {x2}");
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine("phuong trinh co nghiem kep:");
                    Console.WriteLine($"x = {x}");
                }
                else
                {
                    Console.WriteLine("phuong trinh khong co nghiem thuc.");
                }
            }

        }
    }
}
