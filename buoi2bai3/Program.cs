using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace buoi2bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Teacher> listGiaoVien = NhapDSnTeacher();
            xuatDSSgiaovien(listGiaoVien);
            DSSVCNTT(listGiaoVien);
        
            List<Student> listSinhVien = NhapDSStudent();
            DSSVCNTTMaxDiemTB(listSinhVien);
            DSSVLONHON5(listSinhVien);
            Console.ReadKey();
        }

        private static List<Teacher> NhapDSnTeacher()
        {
            Console.Write("Nhap tong so giao vien n: ");
            int N = Convert.ToInt32(Console.ReadLine());
            List<Teacher> listTeacher = new List<Teacher>();
            Console.WriteLine("\nNhap danh sach giao vien:");
            for (int i = 0; i < N; i++)
            {
                Console.Write("Nhap giao vien thu {0}:", i + 1);
                Teacher gv = new Teacher();
                gv.NhapGV();
                listTeacher.Add(gv);
            }
            return listTeacher;
        }

        private static List<Student> NhapDSStudent()
        {
            Console.Write("Nhap tong so sinh vien n: ");
            int N = Convert.ToInt32(Console.ReadLine());
            List<Student> listStudent = new List<Student>();
            Console.WriteLine("\nNhap danh sach sinh vien:");
            for (int i = 0; i < N; i++)
            {
                Console.Write("Nhap sinh vien thu {0}:", i + 1);
                Student sv = new Student(0, 0, ""); // Thêm các tham số thích hợp cho sinh viên
                sv.NhapsV();
                listStudent.Add(sv);
            }
            return listStudent;
        }

        private static void xuatDSSgiaovien(List<Teacher> listGiaoVien)
        {
            Console.WriteLine("\nXuat danh sach giao vien:");
            foreach (Teacher gv in listGiaoVien)
            {
                gv.XuatGV();
            }
        }
        private static void xuatDSSinhvien(List<Student> listSinhVien)
        {
            Console.WriteLine("\nXuat danh sach giao vien:");
            foreach (Student sv in listSinhVien)
            {
                sv.XuatsV();
            }
        }


        private static void DSSVCNTT(List<Teacher> listSinhVien)
        {
            List<Teacher> listCNTT1 = listSinhVien.Where(p => p._Khoa == "CNTT").ToList();
            List<Teacher> listCNTT2 = (from s in listSinhVien where s._Khoa == "CNTT" select s).ToList();

            if (listCNTT1.Count() == 0)
            {
                Console.WriteLine("Khong co giao vien khoa CNTT.");
            }
            else
            {
                xuatDSSgiaovien(listCNTT1);
            }
            if (listCNTT2.Count() == 0)
            {
                Console.WriteLine("Khong co giao vien khoa CNTT.");
            }
            else
            {
                xuatDSSgiaovien(listCNTT2);
            }
        }

        private static void DSSVLONHON5(List<Student> listGiaoVien)
        {
            List<Student> listsv = listGiaoVien.Where(p => p._DiemTB >= 5).ToList();
            if (listsv.Count() == 0)
            {
                Console.WriteLine("Khong co sinh vienco diem >= 5");
            }
            else
            {
                xuatDSSinhvien(listsv);
            }
        }

        private static void DSSVCNTTMaxDiemTB(List<Student> listSinhVien)
        {
            var maxAverageGrade = listSinhVien.Where(s => s._Khoa == "CNTT").Max(s => s._DiemTB);

            var topStudents = listSinhVien.Where(s => s._Khoa == "CNTT" && s._DiemTB == maxAverageGrade).ToList();

            if (topStudents.Count == 0)
            {
                Console.WriteLine("Khong co sinh vien thuoc khoa CNTT hoac khong co sinh vien co diem trung binh cao nhat.");
            }
            else
            {
                Console.WriteLine("\nDanh sach sinh vien co diem trung binh cao nhat va thuoc khoa CNTT:");
                foreach (var student in topStudents)
                {
                    student.XuatsV();
                }
            }
        }
    }
}

