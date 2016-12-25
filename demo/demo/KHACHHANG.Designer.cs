namespace DSKhachHang
{
    partial class KHACHHANG
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
            this.txtfax = new System.Windows.Forms.TextBox();
            this.lbfax = new System.Windows.Forms.Label();
            this.labeL6 = new System.Windows.Forms.Label();
            this.btConnect = new System.Windows.Forms.Button();
            this.btDisconnect = new System.Windows.Forms.Button();
            this.txtdienthoai = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txttenkh = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lbdienthoai = new System.Windows.Forms.Label();
            this.lbdiachi = new System.Windows.Forms.Label();
            this.lbtenkh = new System.Windows.Forms.Label();
            this.lbmakh = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.bTXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.dtgvKhachHang = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.cbTimKiem = new System.Windows.Forms.ComboBox();
            this.tbFax = new System.Windows.Forms.TextBox();
            this.tbDienThoai = new System.Windows.Forms.TextBox();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.tbTenKH = new System.Windows.Forms.TextBox();
            this.tbMaKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(250, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtfax
            // 
            this.txtfax.Location = new System.Drawing.Point(184, 115);
            this.txtfax.Name = "txtfax";
            this.txtfax.Size = new System.Drawing.Size(367, 20);
            this.txtfax.TabIndex = 11;
            // 
            // lbfax
            // 
            this.lbfax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfax.ForeColor = System.Drawing.Color.Navy;
            this.lbfax.Location = new System.Drawing.Point(22, 112);
            this.lbfax.Name = "lbfax";
            this.lbfax.Size = new System.Drawing.Size(100, 23);
            this.lbfax.TabIndex = 10;
            this.lbfax.Text = "Fax";
            this.lbfax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labeL6
            // 
            this.labeL6.AutoSize = true;
            this.labeL6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeL6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labeL6.Location = new System.Drawing.Point(628, 20);
            this.labeL6.Name = "labeL6";
            this.labeL6.Size = new System.Drawing.Size(169, 13);
            this.labeL6.TabIndex = 9;
            this.labeL6.Text = "Trạng Thái: Đã ngắt kết nối!";
            this.labeL6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btConnect
            // 
            this.btConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btConnect.Location = new System.Drawing.Point(598, 69);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(75, 28);
            this.btConnect.TabIndex = 7;
            this.btConnect.Text = "Kết Nối";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btDisconnect
            // 
            this.btDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDisconnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btDisconnect.Location = new System.Drawing.Point(699, 69);
            this.btDisconnect.Name = "btDisconnect";
            this.btDisconnect.Size = new System.Drawing.Size(121, 28);
            this.btDisconnect.TabIndex = 8;
            this.btDisconnect.Text = "Ngắt Kết Nối";
            this.btDisconnect.UseVisualStyleBackColor = true;
            this.btDisconnect.Click += new System.EventHandler(this.btDisconnect_Click);
            // 
            // txtdienthoai
            // 
            this.txtdienthoai.Location = new System.Drawing.Point(184, 92);
            this.txtdienthoai.Name = "txtdienthoai";
            this.txtdienthoai.Size = new System.Drawing.Size(367, 20);
            this.txtdienthoai.TabIndex = 4;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(184, 69);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(367, 20);
            this.txtdiachi.TabIndex = 3;
            // 
            // txttenkh
            // 
            this.txttenkh.Location = new System.Drawing.Point(184, 43);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Size = new System.Drawing.Size(367, 20);
            this.txttenkh.TabIndex = 2;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(184, 20);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(367, 20);
            this.txtMaKH.TabIndex = 1;
            // 
            // lbdienthoai
            // 
            this.lbdienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdienthoai.ForeColor = System.Drawing.Color.Navy;
            this.lbdienthoai.Location = new System.Drawing.Point(22, 89);
            this.lbdienthoai.Name = "lbdienthoai";
            this.lbdienthoai.Size = new System.Drawing.Size(100, 23);
            this.lbdienthoai.TabIndex = 0;
            this.lbdienthoai.Text = "Điện Thoại";
            this.lbdienthoai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbdiachi
            // 
            this.lbdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdiachi.ForeColor = System.Drawing.Color.Navy;
            this.lbdiachi.Location = new System.Drawing.Point(36, 66);
            this.lbdiachi.Name = "lbdiachi";
            this.lbdiachi.Size = new System.Drawing.Size(133, 23);
            this.lbdiachi.TabIndex = 0;
            this.lbdiachi.Text = "Địa Chỉ Khách Hàng";
            this.lbdiachi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbtenkh
            // 
            this.lbtenkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtenkh.ForeColor = System.Drawing.Color.Navy;
            this.lbtenkh.Location = new System.Drawing.Point(36, 43);
            this.lbtenkh.Name = "lbtenkh";
            this.lbtenkh.Size = new System.Drawing.Size(100, 23);
            this.lbtenkh.TabIndex = 0;
            this.lbtenkh.Text = "Họ Tên Khách Hàng";
            this.lbtenkh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbtenkh.UseWaitCursor = true;
            // 
            // lbmakh
            // 
            this.lbmakh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmakh.ForeColor = System.Drawing.Color.Navy;
            this.lbmakh.Location = new System.Drawing.Point(36, 20);
            this.lbmakh.Name = "lbmakh";
            this.lbmakh.Size = new System.Drawing.Size(100, 23);
            this.lbmakh.TabIndex = 0;
            this.lbmakh.Text = "Mã Khách Hàng";
            this.lbmakh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btThem.Location = new System.Drawing.Point(599, 354);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 28);
            this.btThem.TabIndex = 3;
            this.btThem.Text = "THÊM";
            this.btThem.UseVisualStyleBackColor = true;
            // 
            // bTXoa
            // 
            this.bTXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bTXoa.Location = new System.Drawing.Point(723, 306);
            this.bTXoa.Name = "bTXoa";
            this.bTXoa.Size = new System.Drawing.Size(75, 28);
            this.bTXoa.TabIndex = 3;
            this.bTXoa.Text = "XÓA";
            this.bTXoa.UseVisualStyleBackColor = true;
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btSua.Location = new System.Drawing.Point(599, 306);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 28);
            this.btSua.TabIndex = 3;
            this.btSua.Text = "SỬA";
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btThoat.Location = new System.Drawing.Point(655, 398);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 28);
            this.btThoat.TabIndex = 3;
            this.btThoat.Text = "THOÁT";
            this.btThoat.UseVisualStyleBackColor = true;
            // 
            // dtgvKhachHang
            // 
            this.dtgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKhachHang.Location = new System.Drawing.Point(1, 243);
            this.dtgvKhachHang.Name = "dtgvKhachHang";
            this.dtgvKhachHang.Size = new System.Drawing.Size(542, 195);
            this.dtgvKhachHang.TabIndex = 4;
            this.dtgvKhachHang.SelectionChanged += new System.EventHandler(this.dgvKhachHang_SelectionChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(723, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "IN";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btTimKiem
            // 
            this.btTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btTimKiem.Location = new System.Drawing.Point(632, 219);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(98, 28);
            this.btTimKiem.TabIndex = 6;
            this.btTimKiem.Text = "TÌM KIẾM";
            this.btTimKiem.UseVisualStyleBackColor = true;
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Location = new System.Drawing.Point(574, 268);
            this.tbTimKiem.Multiline = true;
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(100, 21);
            this.tbTimKiem.TabIndex = 10;
            // 
            // cbTimKiem
            // 
            this.cbTimKiem.FormattingEnabled = true;
            this.cbTimKiem.Location = new System.Drawing.Point(695, 268);
            this.cbTimKiem.Name = "cbTimKiem";
            this.cbTimKiem.Size = new System.Drawing.Size(121, 21);
            this.cbTimKiem.TabIndex = 11;
            // 
            // tbFax
            // 
            this.tbFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFax.Location = new System.Drawing.Point(136, 181);
            this.tbFax.Name = "tbFax";
            this.tbFax.Size = new System.Drawing.Size(431, 26);
            this.tbFax.TabIndex = 17;
            // 
            // tbDienThoai
            // 
            this.tbDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDienThoai.Location = new System.Drawing.Point(136, 150);
            this.tbDienThoai.Name = "tbDienThoai";
            this.tbDienThoai.Size = new System.Drawing.Size(431, 26);
            this.tbDienThoai.TabIndex = 19;
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiaChi.Location = new System.Drawing.Point(136, 119);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(431, 26);
            this.tbDiaChi.TabIndex = 18;
            // 
            // tbTenKH
            // 
            this.tbTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenKH.Location = new System.Drawing.Point(136, 88);
            this.tbTenKH.Name = "tbTenKH";
            this.tbTenKH.Size = new System.Drawing.Size(431, 26);
            this.tbTenKH.TabIndex = 21;
            // 
            // tbMaKH
            // 
            this.tbMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaKH.Location = new System.Drawing.Point(136, 56);
            this.tbMaKH.Name = "tbMaKH";
            this.tbMaKH.Size = new System.Drawing.Size(431, 26);
            this.tbMaKH.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-3, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 27);
            this.label2.TabIndex = 14;
            this.label2.Text = "Fax:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-3, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 27);
            this.label3.TabIndex = 13;
            this.label3.Text = "ĐTDĐ:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-3, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "Địa Chỉ:";
            // 
            // lbHoTen
            // 
            this.lbHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.Location = new System.Drawing.Point(-3, 89);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(124, 27);
            this.lbHoTen.TabIndex = 16;
            this.lbHoTen.Text = "Họ và Tên KH:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-3, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 27);
            this.label5.TabIndex = 15;
            this.label5.Text = "Mã KH:";
            // 
            // KHACHHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 438);
            this.Controls.Add(this.tbFax);
            this.Controls.Add(this.tbDienThoai);
            this.Controls.Add(this.tbDiaChi);
            this.Controls.Add(this.tbTenKH);
            this.Controls.Add(this.tbMaKH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbHoTen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.cbTimKiem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.dtgvKhachHang);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.bTXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.label1);
            this.Name = "KHACHHANG";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.KHACHHANG_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdienthoai;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txttenkh;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label lbdienthoai;
        private System.Windows.Forms.Label lbdiachi;
        private System.Windows.Forms.Label lbtenkh;
        private System.Windows.Forms.Label lbmakh;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button bTXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.DataGridView dtgvKhachHang;
        private System.Windows.Forms.Label labeL6;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btDisconnect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.ComboBox cbTimKiem;
        private System.Windows.Forms.TextBox txtfax;
        private System.Windows.Forms.Label lbfax;
        private System.Windows.Forms.TextBox tbFax;
        private System.Windows.Forms.TextBox tbDienThoai;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.TextBox tbTenKH;
        private System.Windows.Forms.TextBox tbMaKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label label5;
    }
}

