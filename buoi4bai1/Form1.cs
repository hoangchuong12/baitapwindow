using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buoi4bai1
{
    public partial class Form1 : Form
    {
        String[] danhsachkhoa = { "CNTT", "QTKD", "Kết Toán", "Ngoại Ngữ" };
        int rowchoose = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn thoát không",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpNgaySinh.MaxDate = DateTime.Now;
            loadKhoa();

        }
        private void loadKhoa()
        {
            cbKhoa.DataSource = danhsachkhoa;
            cbKhoa.SelectedItem = 0;

        }

        private void tbnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtMaSV.Text.Length!=10 ) 
                {
                    throw new Exception("Mã sinh viên phải đúng 10 ký tự");
                }
                if (txtHoTen.Text.Length <2)
                {
                    throw new Exception("Họ Tên ý nhất 2 ký tự");
                }
                string masv = txtMaSV.Text;
                string hoten = txtHoTen.Text;
                string ngaysinh = dtpNgaySinh.Text;
                string khoa = cbKhoa.Text;

                int rowindex = dgvDanhSach.Rows.Add();
                dgvDanhSach.Rows[rowindex].Cells["MaSv"].Value = masv;
                dgvDanhSach.Rows[rowindex].Cells["HoTen"].Value = hoten;
                dgvDanhSach.Rows[rowindex].Cells["NgaySinh"].Value = ngaysinh;
                dgvDanhSach.Rows[rowindex].Cells["khoa"].Value = khoa;

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1 || e.RowIndex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("chưa chọn sinh viên");
                }
                rowchoose = e.RowIndex;
                txtMaSV.Text = dgvDanhSach.Rows[rowchoose].Cells["MaSv"].Value.ToString();
                txtHoTen.Text = dgvDanhSach.Rows[rowchoose].Cells["HoTen"].Value.ToString();
                dtpNgaySinh.Text = dgvDanhSach.Rows[rowchoose].Cells["NgaySinh"].Value.ToString();
                cbKhoa.Text = dgvDanhSach.Rows[rowchoose].Cells["khoa"].Value.ToString();
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if(rowchoose == -1 || rowchoose >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sinh viên cần cập nhật");
                }
                if (txtMaSV.Text.Length != 10)
                {
                    throw new Exception("Mã sinh vien phả đúng 10 ký tự");
                }
                if (txtHoTen.Text.Length < 2)
                {
                    throw new Exception("Họ tên sinh viên ít nhất 2 ký tự");
                }
                string masv = txtMaSV.Text;
                string hoten = txtHoTen.Text;
                string ngaysinh = dtpNgaySinh.Text;
                string khoa = cbKhoa.Text;


         
                dgvDanhSach.Rows[rowchoose].Cells["MaSv"].Value = masv;
                dgvDanhSach.Rows[rowchoose].Cells["HoTen"].Value = hoten;
                dgvDanhSach.Rows[rowchoose].Cells["NgaySinh"].Value = ngaysinh;
                dgvDanhSach.Rows[rowchoose].Cells["khoa"].Value = khoa;
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
                if (rowchoose == -1 || rowchoose >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sinh viên cần cập nhật");
                }
                dgvDanhSach.Rows.RemoveAt(rowchoose);
                rowchoose = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
