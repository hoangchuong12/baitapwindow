using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buoi5bai1
{
    public partial class Form1 : Form
    {
        SinhVienDAO svDAO = new SinhVienDAO();
        KhoaDAO khDAO = new KhoaDAO();

        string insertupdate = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            txtMaSV.Enabled = false;
            btnXoa.Enabled = false;
            LoadDSSinhVien();
            LoadDSKhoa();
            TongSinhVien();
        }
        private void LoadDSSinhVien()
        {
            dgvDanhSach.DataSource = svDAO.getList();
        }
        private void LoadDSKhoa()
        {
            txtKhoa.DataSource = khDAO.getList();
            txtKhoa.DisplayMember = "TenKhoa ";
            txtKhoa.ValueMember = "MaKhoa";
        }
        private void TongSinhVien()
        {
            txtDiemTB.Text = svDAO.getCount().ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            insertupdate = "insert";
            btnLuu.Enabled=true;
            txtMaSV.Enabled=true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            insertupdate = "update";
            btnLuu.Enabled = true;
            txtMaSV.Enabled = false;
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if (rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("chưa chọn sinh viên");
                }

                txtMaSV.Text = dgvDanhSach.Rows[rowindex].Cells["MaSV"].Value.ToString();
                txtHoTen.Text = dgvDanhSach.Rows[rowindex].Cells["HoTen"].Value.ToString();
                txtKhoa.Text = dgvDanhSach.Rows[rowindex].Cells["TenKhoa"].Value.ToString();
                txtDiemTB.Text = dgvDanhSach.Rows[rowindex].Cells["DiemTB"].Value.ToString();
                btnXoa.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
 
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                double diemtb = 0;
                if(txtMaSV.Text.Length != 10)
                {
                    throw new Exception(" Mã Sinh viên Số");
                }
                if (!double.TryParse(txtDiemTB.Text,out diemtb))
                {
                    throw new Exception(" Điểm sinh viên số");
                }
                string masv = txtMaSV.Text;
                string hoten = txtHoTen.Text;
                int makhoa = int.Parse(txtKhoa.SelectedValue.ToString());
               SinhVien sv = new SinhVien(masv, hoten, makhoa, diemtb);
                switch (insertupdate)
                {
                    case "insert":
                        {
                            svDAO.InsertTwo(sv);
                            LoadDSSinhVien();
                            TongSinhVien();
                            MessageBox.Show("Thêm thành công");
                            break;
                        }
                    case "update":
                        {
                            svDAO.UpdateTwo(sv);
                            LoadDSSinhVien();
                            TongSinhVien();
                            MessageBox.Show(" cập nhật thành công");
                            break;
                        }
                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.Message, "thông báo ", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
