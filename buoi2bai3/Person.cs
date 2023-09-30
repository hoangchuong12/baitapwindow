using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi2bai3
{
    internal class Person
    {
        public double CMND { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string _Khoa { get; set; }

        public Person(double cmnd, string hoTen, string diaChi)
        {
            this.CMND = cmnd;
            this.HoTen = hoTen;
            this.DiaChi = diaChi;
        }

        public Person() { }
    }
}
