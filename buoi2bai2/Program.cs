using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi2bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<SinhVien> listSinhVien = NhapDSSinhVien();

            xuatDSSinhVien(listSinhVien);
            DSSVCNTT(listSinhVien);
            DSSVLONHON5(listSinhVien);
            DSSVSAPXEP(listSinhVien);



            Console.ReadKey();
        }

        private static List<SinhVien> NhapDSSinhVien()
        {
            Console.Write("nhap tong so sinh vien n");
            int N = Convert.ToInt32(Console.ReadLine());
            List<SinhVien> listSinhVien = new List<SinhVien>();
            Console.WriteLine("\n nhap danh sach sinh vien");
            for (int i = 0; i < N; i++)
            {
                Console.Write("nhap sinh vien thu {0}:", i + 1);
                SinhVien sv = new SinhVien();
                sv.NhapSV();
                listSinhVien.Add(sv);
            }
            return listSinhVien;
        }
        private static void xuatDSSinhVien(List<SinhVien> listSinhVien)
        {
            Console.WriteLine("\n xuat danh sach sinh vien");
            foreach (SinhVien sv in listSinhVien)
            {
                sv.XuatSV();
            }
        }

        private static void DSSVCNTT(List<SinhVien> listSinhVien)
        {
            List<SinhVien> listCNTT1 = listSinhVien.Where(p => p.Khoa == "CNTT").ToList();
            List<SinhVien> listCNTT2 = (from s in listSinhVien where s.Khoa == "CNTT" select s).ToList();

            if (listCNTT1.Count() == 0)
            {
                Console.WriteLine("khong co sinh vien khoa CNTT");
            }
            else
            {
                xuatDSSinhVien(listCNTT1);
            }
            if (listCNTT2.Count() == 0)
            {
                Console.WriteLine("khong co sinh vien khoa CNTT");
            }
            else
            {
                xuatDSSinhVien(listCNTT2);
            }

        }
        private static void DSSVLONHON5(List<SinhVien> listSinhVien)
        {
            List<SinhVien> listSV = listSinhVien.Where(p => p.DiemTB >= 5).ToList();
            if (listSV.Count() == 0)
            {
                Console.WriteLine("khong co sinh vien co diem >= 5");
            }
            else
            {
                xuatDSSinhVien(listSV);
            }
        }
        private static void DSSVSAPXEP(List<SinhVien> listSinhVien)
        {
            List<SinhVien> listSV = listSinhVien.OrderBy(p => p.DiemTB).ToList();
            xuatDSSinhVien(listSV);
        }
    }
}
