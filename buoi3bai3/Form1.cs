using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buoi3bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txttensach.Text.Length.Equals(0))
                {
                    throw new Exception("Tên sách sinh viên Không để rổng");
                }
                string tensach = txttensach.Text;
                string masach = txtmasach.Text;
                string giasach = txtGia.Text;
                string  soluong= txtSoluong.Text;

                double stt = 1;
                txtdanhsach.Text += stt + "Tên sách:" + tensach + "mã sách:" + masach + "giá sách" + giasach + soluong + "\r\n";
                stt++;
            }
            catch (Exception )
            {
                MessageBox.Show("tên sách không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
