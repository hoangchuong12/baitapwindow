using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi2bai2
{
    internal class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public double DiemTB { get; set; }
        public string Khoa { get; set; }

        public SinhVien() { }
        public SinhVien(string maSV, string hoTen, double diemTB, string khoa)
        {
            this.MaSV = maSV;
            this.HoTen = hoTen;
            this.DiemTB = diemTB;
            this.Khoa = khoa;
        }



        public void NhapSV()
        {
            Console.WriteLine("Nhap MaSV: ");
            MaSV = Console.ReadLine();
            Console.WriteLine("Nhap HoTen: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("Nhap DiemTB: ");
            DiemTB = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Khoa: ");
            Khoa = Console.ReadLine();
        }


        public void XuatSV() { Console.WriteLine("MaSV:{0}\tHoTen:{1}\tDiemTB:{2}\tKhoa:{3}", MaSV, HoTen, DiemTB, Khoa); }
    }

}