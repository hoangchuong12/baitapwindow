using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi2bai1
{
    internal class SinhVien
    {
        // khai bao thuoc tinh
        private string MaSV { set; get; }
        private string HoTen { set; get; }
        private double DiemTB { set; get; }

        private string Khoa { set; get; }  
        public SinhVien() { }

        public SinhVien(String masv, string hoten, double diemtb, string khoa)
        {
            this.MaSV = masv;
            this.HoTen = hoten;
            this.DiemTB = diemtb;
            this.Khoa = khoa;
        }
        public SinhVien(SinhVien sv) 
        {
            this.MaSV = sv.MaSV;
            this.HoTen = sv.HoTen;
            this.DiemTB= sv.DiemTB;
            this.Khoa= sv.Khoa;
                
        }
        public void nhapSV()
        {
            Console.Write("nhap MaSV:");
            MaSV= Console.ReadLine();
            Console.Write("nhap Ho Ten:");
            HoTen = Console.ReadLine();
            Console.Write("nhap dienTB:");
            DiemTB = double.Parse(Console.ReadLine());      
            Console.Write("nhap khoa:");
            Khoa = Console.ReadLine();
        }
        public void Xuatsv()
        {
            Console.WriteLine("Masv:{0} \t HoTen:{1} \t DiemTB:{2} \t khoa:{3}", MaSV, HoTen, DiemTB, Khoa);
        }
    }

}
