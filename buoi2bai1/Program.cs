using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi2bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap tong so sinh vien N=");
            int N =Convert.ToInt32(Console.ReadLine());
            SinhVien[] arrSinhVien = new SinhVien[N];
            Console.WriteLine("\n === nhap danh sach sinh vien ===");
            for(int i = 0; i < N; i++)
            {
                Console.Write("nhap sinh vien thu {0}:", i + 1);
                arrSinhVien[i] = new SinhVien();
                arrSinhVien[i].nhapSV();
            }
            Console.WriteLine("\n xuat danh sach sinh vien");
            foreach(SinhVien sv in arrSinhVien)
            {
                sv.Xuatsv();
            }
            Console.ReadKey();
        }

    }

}
