using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buoi3bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                if(!double.TryParse(textBox1.Text, out a))
                {
                    throw new Exception("so a khong duoc de trong hoac phai so");
                }
                if(!double.TryParse(textBox2.Text, out b))
                {
                    throw new Exception("so b khong duoc de trong hoac phai so");

                }
                textBox3.Text = (a + b).ToString();
            }
            catch (Exception ex) {
                textBox3.Text = ex.Message;
            }

        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                if (!double.TryParse(textBox1.Text, out a))
                {
                    throw new Exception("so a khong duoc de trong hoac phai so");
                }
                if (!double.TryParse(textBox2.Text, out b))
                {
                    throw new Exception("so b khong duoc de trong hoac phai so");

                }
                textBox3.Text = (a - b).ToString();
            }
            catch (Exception ex)
            {
                textBox3.Text = ex.Message;
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                if (!double.TryParse(textBox1.Text, out a))
                {
                    throw new Exception("so a khong duoc de trong hoac phai so");
                }
                if (!double.TryParse(textBox2.Text, out b))
                {
                    throw new Exception("so b khong duoc de trong hoac phai so");

                }
                textBox3.Text = (a * b).ToString();
            }
            catch (Exception ex)
            {
                textBox3.Text = ex.Message;
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                if (!double.TryParse(textBox1.Text, out a))
                {
                    throw new Exception("so a khong duoc de trong hoac phai so");
                }
                if (!double.TryParse(textBox2.Text, out b))
                {
                    throw new Exception("so b khong duoc de trong hoac phai so");

                }
                textBox3.Text = (a / b).ToString();
            }
            catch (Exception ex)
            {
                textBox3.Text = ex.Message;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
