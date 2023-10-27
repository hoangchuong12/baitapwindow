using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1bai02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap thang (1-12): ");
            int thang = int.Parse(Console.ReadLine());

            Console.Write("Nhap nam: ");
            int nam = int.Parse(Console.ReadLine());

            int soNgay = TinhSoNgayTrongThang(thang, nam);

            if (soNgay != -1)
            {
                Console.WriteLine($"So ngay trong thang {thang}/{nam} la: {soNgay} ngay.");
            }
            else
            {
                Console.WriteLine("Thang khong hop le.");
            }
            Console.ReadKey();
        }

        static bool CheckNamNhuan(int nam)
        {
            return (nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0);
        }

        static int TinhSoNgayTrongThang(int thang, int nam)
        {
            if (thang < 1 || thang > 12)
            {
                return -1; // Tháng không hợp lệ
            }

            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    return CheckNamNhuan(nam) ? 29 : 28;
                default:
                    return -1; // Trường hợp không xảy ra
            }
        }
    }
}
