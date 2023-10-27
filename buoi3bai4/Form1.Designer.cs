namespace buoi3bai4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.Form1_Load = new System.Windows.Forms.ListView();
            this.lbsSinhVien = new System.Windows.Forms.ListBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnChonsv = new System.Windows.Forms.Button();
            this.btnThemAll = new System.Windows.Forms.Button();
            this.btnXoa1 = new System.Windows.Forms.Button();
            this.btnXoaAll = new System.Windows.Forms.Button();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Khoa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm sinh viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbsSinhVien);
            this.groupBox2.Location = new System.Drawing.Point(36, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 414);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sinh viên";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnXoaAll);
            this.groupBox3.Controls.Add(this.btnXoa1);
            this.groupBox3.Controls.Add(this.btnThemAll);
            this.groupBox3.Controls.Add(this.btnChonsv);
            this.groupBox3.Controls.Add(this.cbKhoa);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(252, 107);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(191, 414);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Form1_Load);
            this.groupBox4.Location = new System.Drawing.Point(449, 107);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(432, 414);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sinh viên được chọn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Khoa";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(71, 21);
            this.txtHoTen.Multiline = true;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(417, 33);
            this.txtHoTen.TabIndex = 1;
            // 
            // cbKhoa
            // 
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(26, 61);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(149, 24);
            this.cbKhoa.TabIndex = 1;
            // 
            // Form1_Load
            // 
            this.Form1_Load.BackColor = System.Drawing.SystemColors.Window;
            this.Form1_Load.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Form1_Load.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.Khoa});
            this.Form1_Load.GridLines = true;
            this.Form1_Load.HideSelection = false;
            this.Form1_Load.Location = new System.Drawing.Point(19, 34);
            this.Form1_Load.Name = "Form1_Load";
            this.Form1_Load.Size = new System.Drawing.Size(399, 362);
            this.Form1_Load.TabIndex = 0;
            this.Form1_Load.UseCompatibleStateImageBehavior = false;
            this.Form1_Load.View = System.Windows.Forms.View.Details;
            this.Form1_Load.SelectedIndexChanged += new System.EventHandler(this.Form1_Load_SelectedIndexChanged_1);
            // 
            // lbsSinhVien
            // 
            this.lbsSinhVien.FormattingEnabled = true;
            this.lbsSinhVien.ItemHeight = 16;
            this.lbsSinhVien.Items.AddRange(new object[] {
            "sss"});
            this.lbsSinhVien.Location = new System.Drawing.Point(13, 33);
            this.lbsSinhVien.Name = "lbsSinhVien";
            this.lbsSinhVien.Size = new System.Drawing.Size(185, 356);
            this.lbsSinhVien.TabIndex = 0;
            this.lbsSinhVien.SelectedIndexChanged += new System.EventHandler(this.Form1_Load_SelectedIndexChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(529, 21);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 33);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(691, 21);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(104, 33);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnChonsv
            // 
            this.btnChonsv.Location = new System.Drawing.Point(26, 106);
            this.btnChonsv.Name = "btnChonsv";
            this.btnChonsv.Size = new System.Drawing.Size(149, 46);
            this.btnChonsv.TabIndex = 2;
            this.btnChonsv.Text = ">";
            this.btnChonsv.UseVisualStyleBackColor = true;
            this.btnChonsv.Click += new System.EventHandler(this.btnChonsv_Click);
            // 
            // btnThemAll
            // 
            this.btnThemAll.Location = new System.Drawing.Point(25, 174);
            this.btnThemAll.Name = "btnThemAll";
            this.btnThemAll.Size = new System.Drawing.Size(150, 49);
            this.btnThemAll.TabIndex = 3;
            this.btnThemAll.Text = ">>";
            this.btnThemAll.UseVisualStyleBackColor = true;
            // 
            // btnXoa1
            // 
            this.btnXoa1.Location = new System.Drawing.Point(25, 246);
            this.btnXoa1.Name = "btnXoa1";
            this.btnXoa1.Size = new System.Drawing.Size(150, 54);
            this.btnXoa1.TabIndex = 4;
            this.btnXoa1.Text = "<";
            this.btnXoa1.UseVisualStyleBackColor = true;
            // 
            // btnXoaAll
            // 
            this.btnXoaAll.Location = new System.Drawing.Point(25, 319);
            this.btnXoaAll.Name = "btnXoaAll";
            this.btnXoaAll.Size = new System.Drawing.Size(149, 56);
            this.btnXoaAll.TabIndex = 5;
            this.btnXoaAll.Text = ">>";
            this.btnXoaAll.UseVisualStyleBackColor = true;
            // 
            // name
            // 
            this.name.Text = "Tên";
            this.name.Width = 193;
            // 
            // Khoa
            // 
            this.Khoa.Text = "Khoa";
            this.Khoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Khoa.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 533);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbsSinhVien;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnXoaAll;
        private System.Windows.Forms.Button btnXoa1;
        private System.Windows.Forms.Button btnThemAll;
        private System.Windows.Forms.Button btnChonsv;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView Form1_Load;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader Khoa;
    }
}

