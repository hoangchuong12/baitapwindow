using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace buoi2bai3
{
    internal class Teacher : Person
    {
        public double _MaGV { get; set; }
        public string _ChucVu { get; set; }
        public Teacher()
        {

        }

        public Teacher(double maGV, string khoa, string chucVu) 
        {
            this._MaGV = maGV;
            this._Khoa = khoa;
            this._ChucVu = chucVu;
        }

        public void NhapGV()
        {
            Console.WriteLine("Nhap MaGV: ");
            _MaGV = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap HoTen: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("Nhap DiaChi: ");
            DiaChi = Console.ReadLine();
            Console.WriteLine("Nhap ChucVu: ");
            _ChucVu = Console.ReadLine();
        }

        public void XuatGV()
        {
            Console.WriteLine("MaGV:{0}\tHoTen:{1}\tDiaChi:{2}\tKhoa:{3}\tChucVu:{4}", _MaGV, HoTen, DiaChi, _Khoa, _ChucVu);
        }
    }
}

