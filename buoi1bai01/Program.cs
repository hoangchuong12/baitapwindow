using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1bai01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Khai báo biến
            int a, b, tong, hieu, tich;
            double thuong = 0;
            //Thông báo nhập số a
            Console.Write("Nhap so a: ");
            //Nhập gia trị cho biến a: Ép kiểu
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so b: ");
            //Nhập gia trị cho biến b: Ép kiểu
            b = Int32.Parse(Console.ReadLine());
            //Tính tổng hiệu, tích, thương
            tong = a + b;
            hieu = a - b;
            tich = a * b;
            if (b != 0)
            {
                thuong = (double)a / b;
            }
                //Xuất kết quả
                Console.WriteLine("Tong = " + tong);
                Console.WriteLine("Hieu = {0}", hieu);
                Console.WriteLine("Tich = {0}, Thuong ={1}", tich, thuong);
                //Dừng màn hình để xem
                Console.ReadKey();
            }
     } 
}
