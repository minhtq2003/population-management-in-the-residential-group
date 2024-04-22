namespace WindowsFormsApp1
{
    partial class frm_NHANKHAU
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_Manhankhau = new System.Windows.Forms.TextBox();
            this.txt_Tenchuho = new System.Windows.Forms.TextBox();
            this.txt_Hoten = new System.Windows.Forms.TextBox();
            this.txt_So = new System.Windows.Forms.TextBox();
            this.txt_Quoctich = new System.Windows.Forms.TextBox();
            this.txt_Quanhe = new System.Windows.Forms.TextBox();
            this.txt_Noisinh = new System.Windows.Forms.TextBox();
            this.txt_Dantoc = new System.Windows.Forms.TextBox();
            this.txt_Diachitamtru = new System.Windows.Forms.TextBox();
            this.txt_Diachithuongtru = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cb_Gioitinh = new System.Windows.Forms.ComboBox();
            this.dt_BANG = new System.Windows.Forms.DataGridView();
            this.txt_Ghichu = new System.Windows.Forms.RichTextBox();
            this.txt_CCCD = new System.Windows.Forms.TextBox();
            this.dt_Ngaycap = new System.Windows.Forms.DateTimePicker();
            this.dt_Ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_Nhap = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dt_BANG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên chủ hộ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ghi chú";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 429);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Thông tin nhân khẩu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(396, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(314, 27);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cập nhật thông tin nhân khẩu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(363, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ngày sinh";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(363, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Nơi sinh";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(363, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Dân tộc";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(711, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "Địa chỉ thường trú";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(711, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "Địa chỉ tạm trú";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(711, 176);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 17);
            this.label14.TabIndex = 13;
            this.label14.Text = "CCCD/CMND";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(711, 230);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 17);
            this.label15.TabIndex = 14;
            this.label15.Text = "Ngày cấp";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(363, 272);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 17);
            this.label16.TabIndex = 15;
            this.label16.Text = "Quan hệ chủ hộ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(363, 227);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 17);
            this.label17.TabIndex = 16;
            this.label17.Text = "Quốc tịch";
            // 
            // txt_Manhankhau
            // 
            this.txt_Manhankhau.Location = new System.Drawing.Point(139, 67);
            this.txt_Manhankhau.Name = "txt_Manhankhau";
            this.txt_Manhankhau.Size = new System.Drawing.Size(174, 22);
            this.txt_Manhankhau.TabIndex = 17;
            // 
            // txt_Tenchuho
            // 
            this.txt_Tenchuho.Location = new System.Drawing.Point(139, 116);
            this.txt_Tenchuho.Name = "txt_Tenchuho";
            this.txt_Tenchuho.Size = new System.Drawing.Size(174, 22);
            this.txt_Tenchuho.TabIndex = 18;
            // 
            // txt_Hoten
            // 
            this.txt_Hoten.Location = new System.Drawing.Point(139, 166);
            this.txt_Hoten.Name = "txt_Hoten";
            this.txt_Hoten.Size = new System.Drawing.Size(174, 22);
            this.txt_Hoten.TabIndex = 19;
            // 
            // txt_So
            // 
            this.txt_So.Location = new System.Drawing.Point(139, 219);
            this.txt_So.Name = "txt_So";
            this.txt_So.Size = new System.Drawing.Size(174, 22);
            this.txt_So.TabIndex = 20;
            // 
            // txt_Quoctich
            // 
            this.txt_Quoctich.Location = new System.Drawing.Point(479, 227);
            this.txt_Quoctich.Name = "txt_Quoctich";
            this.txt_Quoctich.Size = new System.Drawing.Size(200, 22);
            this.txt_Quoctich.TabIndex = 22;
            // 
            // txt_Quanhe
            // 
            this.txt_Quanhe.Location = new System.Drawing.Point(479, 267);
            this.txt_Quanhe.Name = "txt_Quanhe";
            this.txt_Quanhe.Size = new System.Drawing.Size(195, 22);
            this.txt_Quanhe.TabIndex = 23;
            // 
            // txt_Noisinh
            // 
            this.txt_Noisinh.Location = new System.Drawing.Point(479, 113);
            this.txt_Noisinh.Name = "txt_Noisinh";
            this.txt_Noisinh.Size = new System.Drawing.Size(200, 22);
            this.txt_Noisinh.TabIndex = 24;
            // 
            // txt_Dantoc
            // 
            this.txt_Dantoc.Location = new System.Drawing.Point(479, 171);
            this.txt_Dantoc.Name = "txt_Dantoc";
            this.txt_Dantoc.Size = new System.Drawing.Size(200, 22);
            this.txt_Dantoc.TabIndex = 25;
            // 
            // txt_Diachitamtru
            // 
            this.txt_Diachitamtru.Location = new System.Drawing.Point(862, 114);
            this.txt_Diachitamtru.Name = "txt_Diachitamtru";
            this.txt_Diachitamtru.Size = new System.Drawing.Size(195, 22);
            this.txt_Diachitamtru.TabIndex = 26;
            // 
            // txt_Diachithuongtru
            // 
            this.txt_Diachithuongtru.Location = new System.Drawing.Point(862, 64);
            this.txt_Diachithuongtru.Name = "txt_Diachithuongtru";
            this.txt_Diachithuongtru.Size = new System.Drawing.Size(195, 22);
            this.txt_Diachithuongtru.TabIndex = 27;
            // 
            // cb_Gioitinh
            // 
            this.cb_Gioitinh.FormattingEnabled = true;
            this.cb_Gioitinh.Location = new System.Drawing.Point(139, 272);
            this.cb_Gioitinh.Name = "cb_Gioitinh";
            this.cb_Gioitinh.Size = new System.Drawing.Size(174, 24);
            this.cb_Gioitinh.TabIndex = 28;
            // 
            // dt_BANG
            // 
            this.dt_BANG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_BANG.Location = new System.Drawing.Point(32, 449);
            this.dt_BANG.Name = "dt_BANG";
            this.dt_BANG.RowHeadersWidth = 62;
            this.dt_BANG.RowTemplate.Height = 24;
            this.dt_BANG.Size = new System.Drawing.Size(1007, 150);
            this.dt_BANG.TabIndex = 29;
            this.dt_BANG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_BANG_CellContentClick);
            // 
            // txt_Ghichu
            // 
            this.txt_Ghichu.Location = new System.Drawing.Point(139, 330);
            this.txt_Ghichu.Name = "txt_Ghichu";
            this.txt_Ghichu.Size = new System.Drawing.Size(532, 96);
            this.txt_Ghichu.TabIndex = 30;
            this.txt_Ghichu.Text = "";
            // 
            // txt_CCCD
            // 
            this.txt_CCCD.Location = new System.Drawing.Point(862, 171);
            this.txt_CCCD.Name = "txt_CCCD";
            this.txt_CCCD.Size = new System.Drawing.Size(200, 22);
            this.txt_CCCD.TabIndex = 31;
            // 
            // dt_Ngaycap
            // 
            this.dt_Ngaycap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Ngaycap.Location = new System.Drawing.Point(862, 225);
            this.dt_Ngaycap.Name = "dt_Ngaycap";
            this.dt_Ngaycap.Size = new System.Drawing.Size(200, 22);
            this.dt_Ngaycap.TabIndex = 32;
            this.dt_Ngaycap.ValueChanged += new System.EventHandler(this.dt_Ngaycap_ValueChanged);
            // 
            // dt_Ngaysinh
            // 
            this.dt_Ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Ngaysinh.Location = new System.Drawing.Point(479, 65);
            this.dt_Ngaysinh.Name = "dt_Ngaysinh";
            this.dt_Ngaysinh.Size = new System.Drawing.Size(200, 22);
            this.dt_Ngaysinh.TabIndex = 33;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(714, 330);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 34;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(714, 402);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 35;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(841, 329);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 36;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_Dong
            // 
            this.btn_Dong.Location = new System.Drawing.Point(841, 402);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(75, 23);
            this.btn_Dong.TabIndex = 37;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(711, 275);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(190, 17);
            this.label18.TabIndex = 38;
            this.label18.Text = "Nhập thông tin bạn muốn tìm";
            // 
            // txt_Nhap
            // 
            this.txt_Nhap.Location = new System.Drawing.Point(907, 272);
            this.txt_Nhap.Name = "txt_Nhap";
            this.txt_Nhap.Size = new System.Drawing.Size(200, 22);
            this.txt_Nhap.TabIndex = 39;
            this.txt_Nhap.TextChanged += new System.EventHandler(this.txt_Nhap_TextChanged);
            // 
            // frm_NHANKHAU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 602);
            this.Controls.Add(this.txt_Nhap);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dt_Ngaysinh);
            this.Controls.Add(this.dt_Ngaycap);
            this.Controls.Add(this.txt_CCCD);
            this.Controls.Add(this.txt_Ghichu);
            this.Controls.Add(this.dt_BANG);
            this.Controls.Add(this.cb_Gioitinh);
            this.Controls.Add(this.txt_Diachithuongtru);
            this.Controls.Add(this.txt_Diachitamtru);
            this.Controls.Add(this.txt_Dantoc);
            this.Controls.Add(this.txt_Noisinh);
            this.Controls.Add(this.txt_Quanhe);
            this.Controls.Add(this.txt_Quoctich);
            this.Controls.Add(this.txt_So);
            this.Controls.Add(this.txt_Hoten);
            this.Controls.Add(this.txt_Tenchuho);
            this.Controls.Add(this.txt_Manhankhau);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_NHANKHAU";
            this.Text = "frm_NHANKHAU";
            this.Load += new System.EventHandler(this.frm_NHANKHAU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_BANG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_Manhankhau;
        private System.Windows.Forms.TextBox txt_Tenchuho;
        private System.Windows.Forms.TextBox txt_Hoten;
        private System.Windows.Forms.TextBox txt_So;
        private System.Windows.Forms.TextBox txt_Quoctich;
        private System.Windows.Forms.TextBox txt_Quanhe;
        private System.Windows.Forms.TextBox txt_Noisinh;
        private System.Windows.Forms.TextBox txt_Dantoc;
        private System.Windows.Forms.TextBox txt_Diachitamtru;
        private System.Windows.Forms.TextBox txt_Diachithuongtru;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cb_Gioitinh;
        private System.Windows.Forms.DataGridView dt_BANG;
        private System.Windows.Forms.RichTextBox txt_Ghichu;
        private System.Windows.Forms.TextBox txt_CCCD;
        private System.Windows.Forms.DateTimePicker dt_Ngaycap;
        private System.Windows.Forms.DateTimePicker dt_Ngaysinh;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_Nhap;
    }
}