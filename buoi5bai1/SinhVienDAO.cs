using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace buoi5bai1
{
    internal class SinhVienDAO
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter apt = null;
        KetNoi kn = new KetNoi();
        public SinhVienDAO()
        {
            conn = kn.GetConnet();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public DataTable getList(int? maKhoa = null)
        {
            string sql = null;
            if (maKhoa == null)
            {
                sql = " SELECT SinhVien.MaSV, SinhVien.HoTemn,SinhVien.DiemTB,Khoa.TenKhoa";
                sql += "FROM SinhVien INNER JOIN Khoa ON Khoa .MaKhoa=SinhVien.MaKhoa";
            }
            else
            {
                sql = " SELECT SinhVien.MaSV, SinhVien.HoTemn,SinhVien.DiemTB,Khoa.TenKhoa";
                sql += "FROM SinhVien INNER JOIN Khoa ON Khoa .MaKhoa=SinhVien.MaKhoa WHERE SinhVien.MaKhoa='" + maKhoa + "'";
            }
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            return dt;
        }
        public int getCount()
        {
            string sql = "SELECT COUNT(SinhVien.MaSV) FROM SinhVien INNER JOIN Khoa ON Khoa.MaKhoa=SinhVien.MaKhoa";
            cmd = new SqlCommand(sql, conn);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }
        public DataRow getRow(string masv)
        {
            string sql = "SELECT SinhVien.MaSV, SinhVien.HoTen, SinhVien.DiemTB,Khoa.TenKhoa";
            sql += "FROM SInhVien INNER JOIN Khoa ON Khoa.MaKhoa=SinhVien.MaKhoa WHERE SinhVien.MaSV='" + masv + "'";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            DataRow row = dt.Rows[0];
            return row;

            ;
        }
        public void InsertOne(SinhVien sv)
        {
            string sql = "INSERT INTO SinhVien(MaSV,HoTen,MaKhoa,DiemTB)";
            sql += "VALUES('" + sv.MaSV + "',N '" + sv.HoTen + "','" + sv.MaKhoa + "','" + sv.DiemTB + "')";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        public void InsertTwo(SinhVien sv) 
        {
            string sql = "INSERT INTO SinhVien(MaSV,HoTen,MaKhoa,DiemtB) VALUES(@MASV,@HOTEN,@MAKHOA,@DIEMTB)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MASV", sv.MaSV);
            cmd.Parameters.AddWithValue("@HOTEN", sv.HoTen);
            cmd.Parameters.AddWithValue("@DIEMTB", sv.DiemTB);
            cmd.Parameters.AddWithValue("@MAKHOA", sv.MaKhoa);
            cmd.ExecuteNonQuery();
        }
        public void UpdateOne(SinhVien sv)
        {
            string sql = "UPDATE  SinhVien SET HoTen=n'" + sv.HoTen + "', MaKhoa'" + sv.MaKhoa + "', DiemTB='" + sv.DiemTB + "'";
            sql += "WHERE MASV='" + sv.MaSV + "'";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        public void UpdateTwo (SinhVien sv)
        {
            string sql = "UPDATE SinhVien SET HoTen=@HOTEN, MaKhoa=@MAKHOA, DiemTB=@DIEMTB";
            sql += "WHERE MaSV=@MASV";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MASV", sv.MaSV);
            cmd.Parameters.AddWithValue("@HOTEN", sv.HoTen);
            cmd.Parameters.AddWithValue("@DIEMTB", sv.DiemTB);
            cmd.Parameters.AddWithValue("@MAKHOA", sv.MaKhoa);
            cmd.ExecuteNonQuery();

        }
        public void DeleteOne (String masv)
        {
            string sql = "DELETE FROM  SinhVien WHERE MaSV='" + masv + "'";
            cmd = new SqlCommand (sql, conn);
            cmd.ExecuteNonQuery ();
        }
        public void DeleteTwo (String masv)
        {
            string sql = "DELETE FROM SinhVien WHERE MaSV=@MASV";
            cmd = new SqlCommand (sql, conn);
            cmd.Parameters.AddWithValue("@MASV", masv);
            cmd.ExecuteNonQuery () ;
        }
    }
}
