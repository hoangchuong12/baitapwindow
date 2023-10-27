using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buoi3bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtHoTen.Text.Length.Equals(0))
                {
                    throw new Exception("Họ tên chưa nhập");
                }
                string hoten = txtHoTen.Text;
                lbsSinhVien.Items.Add( hoten);
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lbsSinhVien.Items.Add("Nguyên văn anh");
            lbsSinhVien.Items.Add("Nguyên văn anh");
            lbsSinhVien.Items.Add("Nguyên văn anh");
            lbsSinhVien.Items.Add("Nguyên văn anh");
            lbsSinhVien.Items.Add("Nguyên văn anh");
            cbKhoa.SelectedIndex = 0;
        }

        private void btnChonsv_Click(object sender, EventArgs e)
        {
          
        }
    }
}
