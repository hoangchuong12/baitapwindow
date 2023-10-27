using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1bai04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap do dai canh a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("nhap do dai canh b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("nhap do dai canh c: ");
            int c = int.Parse(Console.ReadLine());

            if (LaCacCanhCuaTamGiac(a, b, c))
            {
                int chuVi = TinhChuVi(a, b, c);
                double dienTich = TinhDienTich(a, b, c);

                Console.WriteLine("dau la 3 canh tam giac.");
                Console.WriteLine($"chu vi cua tam giac la: {chuVi}");
                Console.WriteLine($"dien tich cua tam giac: {dienTich}");
            }
            else
            {
                Console.WriteLine("ba so khong phai la do dai cua tam giac.");
            }
            Console.ReadKey();
        }

        static bool LaCacCanhCuaTamGiac(int a, int b, int c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        static int TinhChuVi(int a, int b, int c)
        {
            return a + b + c;
        }

        static double TinhDienTich(int a, int b, int c)
        {
            double p = TinhChuVi(a, b, c) / 2.0;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
