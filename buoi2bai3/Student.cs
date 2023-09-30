using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


namespace buoi2bai3
{
    internal class Student : Person
    {
        public double _MaSV { get; set; }
        public double _DiemTB { get; set; }

        public Student()
        {

        }
        public Student(double maSV, double diemTB, string khoa)
        {
            this._MaSV = maSV;
            this._DiemTB = diemTB;
            this._Khoa = khoa;
        }

        public void NhapsV()
        {
            Console.WriteLine("Nhap MaSV: ");
            _MaSV = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap HoTen: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("Nhap DiaChi: ");
            DiaChi = Console.ReadLine();
            Console.WriteLine("Nhap DiemTB: ");
            _DiemTB = double.Parse(Console.ReadLine());
        }

        public void XuatsV()
        {
            Console.WriteLine("MaSV:{0}\tHoTen:{1}\tDiaChi:{2}\tDiemTB:{3}\tKhoa:{4}", _MaSV, HoTen, DiaChi, _DiemTB, _Khoa);
        }
    }
}
