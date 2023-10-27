using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buoi4bai2
{
    public partial class Form1 : Form
    {
        String[] listkhoa = { "CNTT", "QTKD", "Kết Toán", "Ngoại Ngữ" };
        int rowindex = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            double diemtb;
            try
            {
                if (!mtxtMaSv.Text.Length.Equals(10))
                {
                    throw new Exception("Mã sinh viên phải đúng 10 ký tự");
                }
                if (this.checkMaSv(mtxtMaSv.Text) == false)
                {
                    throw new Exception("Mã sinh viên đã tồn tại");
                }
                if (txtHoTen.Text.Length.Equals(0))
                {
                    throw new Exception("Họ Tên không được để trống");
                }
                if (!double.TryParse(txtDiemTB.Text, out diemtb))
                {
                    throw new Exception("điểm trung bình không phải số");
                }
                string masv = mtxtMaSv.Text;
                string hoten = txtHoTen.Text;
                string khoa = cbKhoa.Text;

                int row = dgvDanhSach.Rows.Add();
                dgvDanhSach.Rows[row].Cells["MaSv"].Value = masv;
                dgvDanhSach.Rows[row].Cells["HoTen"].Value = hoten;
                dgvDanhSach.Rows[row].Cells["DiemTB"].Value = diemtb;
                dgvDanhSach.Rows[row].Cells["khoa"].Value = khoa;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public bool checkMaSv(string masv)
        {
            if(dgvDanhSach.Rows.Count == 0)
            {
                return true;
            }
            for (int row = 0;row<dgvDanhSach.Rows.Count - 1; row++)
            {
                if (dgvDanhSach.Rows[row].Cells["MaSv"].Value.ToString() == masv)
                {
                    return false;
                }
            }
            return true;   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbKhoa.DataSource = listkhoa;
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;
            if (rowindex != -1 && rowindex < dgvDanhSach.Rows.Count - 1)
            {
                mtxtMaSv.Text = dgvDanhSach.Rows[rowindex].Cells["MaSv"].Value.ToString();
                txtHoTen.Text = dgvDanhSach.Rows[rowindex].Cells["HoTen"].Value.ToString();
                txtDiemTB.Text = dgvDanhSach.Rows[rowindex].Cells["DiemTB"].Value.ToString();
                string tenkhoa = dgvDanhSach.Rows[rowindex].Cells["khoa"].Value.ToString();
                int i = 0;
                while(i < listkhoa.Length && listkhoa[i] != tenkhoa)
                {
                    i++;
                }
                cbKhoa.SelectedIndex = i;   

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            double diemtb;
            try
            {
                if (rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sinh viên cần xoa");
                }
                if (mtxtMaSv.Text.Length.Equals(10))
                {
                    throw new Exception("Mã sinh vien phả đúng 10 ký tự");
                }
                if (this.checkMaSv(mtxtMaSv.Text) == false && mtxtMaSv.Text != dgvDanhSach.Rows[rowindex].Cells["MaSv"].Value.ToString())
                {
                    throw new Exception("Mã sinh viên đã tồn tại");
                }
                if (txtHoTen.Text.Length.Equals(0))
                {
                    throw new Exception("họ tên không để trống");
                }
                if (!double.TryParse(txtDiemTB.Text, out diemtb))
                {
                    throw new Exception("điểm trung bình không phải số");
                }
                string masv = mtxtMaSv.Text;
                string hoten = txtHoTen.Text;
                string khoa = cbKhoa.Text;



                dgvDanhSach.Rows[rowindex].Cells["MaSv"].Value = masv;
                dgvDanhSach.Rows[rowindex].Cells["HoTen"].Value = hoten;
                dgvDanhSach.Rows[rowindex].Cells["DiemTB"].Value = diemtb;
                dgvDanhSach.Rows[rowindex].Cells["khoa"].Value = khoa;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sinh viên cần cập nhật");
                }
                dgvDanhSach.Rows.RemoveAt(rowindex);
                rowindex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Bạn có muốn thoát không",
               "Thông báo",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
               );
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
