using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buoi3bai2
{
    public partial class Form1 : Form
    {
        double stt = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtHoTen_Click(object sender, EventArgs e)
        {
      
                
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtHoTen.Text.Length.Equals(0))
                {
                    throw new Exception("Họ tên sinh viên Không để rổng");
                }
                string hoten = txtHoTen.Text;
                string masv = txtmsv.Text;
                string ngaysinh = txtNgaySinh.Text;
                string gioitinh = (rbNam.Checked) ? "Nam" : "Nữ";
                string sothich = null;
                    if(chbdulich.Checked){
                        sothich += "Du Lịch";
                    }
                    if (chbthethao.Checked)
                    {
                        sothich += "Thể Thao";
                    }
                    if (chbmuasam.Checked)
                    {
                        sothich += "Mua Sảm";
                    }
                    if (sothich != null)
                    {
                        sothich = " Sở thích: " + sothich;
                    }
             
                txtdanhsach.Text += stt + "Họ tên:" + hoten + "Ngày sinh:" + ngaysinh + "Giới tính" + gioitinh + sothich + "\r\n";
                stt++;
                }
                catch(Exception ) 
                {
                MessageBox.Show("Họ tên không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            txtdanhsach.Text = "";
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtmsv_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNgaySinh_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
