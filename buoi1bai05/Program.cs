using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1bai05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap sp luong sin vien: ");
            int n = int.Parse(Console.ReadLine());
            string[] dssinhvien = NhapSV(n);
            Console.WriteLine("Danh sach sinh vien:");
            XuatSV(dssinhvien, n);
            Console.ReadKey();
        }
        static string[] NhapSV(int n)
        {
            string[] dssinhvien = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"nhap ho ten sinh vien {i + 1}: ");
                dssinhvien[i] = Console.ReadLine();
            }

            return dssinhvien;
        }

        static void XuatSV(string[] dssinhvien, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"sinh vien {i + 1}: {dssinhvien[i]}");
           
            }
        }
    }
}
