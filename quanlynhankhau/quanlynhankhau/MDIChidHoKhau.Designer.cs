namespace quanlynhankhau
{
    partial class frmHoKhau
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
            this.lblHoTenChuHo = new System.Windows.Forms.Label();
            this.lblMaHoKhau = new System.Windows.Forms.Label();
            this.lblKhuVuc = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.txtMaHK = new System.Windows.Forms.TextBox();
            this.txtHoTenChuHo = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.cboKhuVuc = new System.Windows.Forms.ComboBox();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.btnThemHK = new System.Windows.Forms.Button();
            this.btnSuaHK = new System.Windows.Forms.Button();
            this.btnXoaHK = new System.Windows.Forms.Button();
            this.tgvHK = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tgvHK)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHoTenChuHo
            // 
            this.lblHoTenChuHo.AutoSize = true;
            this.lblHoTenChuHo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHoTenChuHo.Location = new System.Drawing.Point(77, 101);
            this.lblHoTenChuHo.Name = "lblHoTenChuHo";
            this.lblHoTenChuHo.Size = new System.Drawing.Size(113, 20);
            this.lblHoTenChuHo.TabIndex = 1;
            this.lblHoTenChuHo.Text = "Họ tên chủ hộ ";
            // 
            // lblMaHoKhau
            // 
            this.lblMaHoKhau.AutoSize = true;
            this.lblMaHoKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaHoKhau.Location = new System.Drawing.Point(77, 61);
            this.lblMaHoKhau.Name = "lblMaHoKhau";
            this.lblMaHoKhau.Size = new System.Drawing.Size(92, 20);
            this.lblMaHoKhau.TabIndex = 2;
            this.lblMaHoKhau.Text = "Mã hộ khẩu";
            // 
            // lblKhuVuc
            // 
            this.lblKhuVuc.AutoSize = true;
            this.lblKhuVuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblKhuVuc.Location = new System.Drawing.Point(77, 141);
            this.lblKhuVuc.Name = "lblKhuVuc";
            this.lblKhuVuc.Size = new System.Drawing.Size(65, 20);
            this.lblKhuVuc.TabIndex = 3;
            this.lblKhuVuc.Text = "Khu vực";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDiaChi.Location = new System.Drawing.Point(77, 181);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(57, 20);
            this.lblDiaChi.TabIndex = 4;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgayLap.Location = new System.Drawing.Point(77, 221);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(70, 20);
            this.lblNgayLap.TabIndex = 5;
            this.lblNgayLap.Text = "Ngày lập";
            // 
            // txtMaHK
            // 
            this.txtMaHK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaHK.Location = new System.Drawing.Point(211, 59);
            this.txtMaHK.Name = "txtMaHK";
            this.txtMaHK.Size = new System.Drawing.Size(493, 24);
            this.txtMaHK.TabIndex = 6;
            // 
            // txtHoTenChuHo
            // 
            this.txtHoTenChuHo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHoTenChuHo.Location = new System.Drawing.Point(211, 99);
            this.txtHoTenChuHo.Name = "txtHoTenChuHo";
            this.txtHoTenChuHo.Size = new System.Drawing.Size(493, 24);
            this.txtHoTenChuHo.TabIndex = 7;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiaChi.Location = new System.Drawing.Point(211, 179);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(493, 24);
            this.txtDiaChi.TabIndex = 9;
            // 
            // cboKhuVuc
            // 
            this.cboKhuVuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboKhuVuc.FormattingEnabled = true;
            this.cboKhuVuc.Items.AddRange(new object[] {
            "Hà Nội",
            "Hà Nam",
            "Hải Dương",
            "Thanh Hóa",
            "Bắc Giang",
            "Bắc Ninh"});
            this.cboKhuVuc.Location = new System.Drawing.Point(211, 139);
            this.cboKhuVuc.Name = "cboKhuVuc";
            this.cboKhuVuc.Size = new System.Drawing.Size(493, 26);
            this.cboKhuVuc.TabIndex = 10;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgayLap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLap.Location = new System.Drawing.Point(211, 217);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(493, 24);
            this.dtpNgayLap.TabIndex = 11;
            // 
            // btnThemHK
            // 
            this.btnThemHK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemHK.Location = new System.Drawing.Point(208, 292);
            this.btnThemHK.Name = "btnThemHK";
            this.btnThemHK.Size = new System.Drawing.Size(100, 30);
            this.btnThemHK.TabIndex = 12;
            this.btnThemHK.Text = "Thêm";
            this.btnThemHK.UseVisualStyleBackColor = true;
            // 
            // btnSuaHK
            // 
            this.btnSuaHK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaHK.Location = new System.Drawing.Point(360, 292);
            this.btnSuaHK.Name = "btnSuaHK";
            this.btnSuaHK.Size = new System.Drawing.Size(100, 30);
            this.btnSuaHK.TabIndex = 13;
            this.btnSuaHK.Text = "Sửa";
            this.btnSuaHK.UseVisualStyleBackColor = true;
            // 
            // btnXoaHK
            // 
            this.btnXoaHK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaHK.Location = new System.Drawing.Point(509, 292);
            this.btnXoaHK.Name = "btnXoaHK";
            this.btnXoaHK.Size = new System.Drawing.Size(100, 30);
            this.btnXoaHK.TabIndex = 14;
            this.btnXoaHK.Text = "Xóa";
            this.btnXoaHK.UseVisualStyleBackColor = true;
            // 
            // tgvHK
            // 
            this.tgvHK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tgvHK.Location = new System.Drawing.Point(0, 410);
            this.tgvHK.Name = "tgvHK";
            this.tgvHK.Size = new System.Drawing.Size(798, 200);
            this.tgvHK.TabIndex = 25;
            // 
            // frmHoKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 611);
            this.Controls.Add(this.tgvHK);
            this.Controls.Add(this.btnXoaHK);
            this.Controls.Add(this.btnSuaHK);
            this.Controls.Add(this.btnThemHK);
            this.Controls.Add(this.dtpNgayLap);
            this.Controls.Add(this.cboKhuVuc);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtHoTenChuHo);
            this.Controls.Add(this.txtMaHK);
            this.Controls.Add(this.lblNgayLap);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblKhuVuc);
            this.Controls.Add(this.lblMaHoKhau);
            this.Controls.Add(this.lblHoTenChuHo);
            this.Name = "frmHoKhau";
            this.Text = "Quản lý hộ khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.tgvHK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHoTenChuHo;
        private System.Windows.Forms.Label lblMaHoKhau;
        private System.Windows.Forms.Label lblKhuVuc;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.TextBox txtMaHK;
        private System.Windows.Forms.TextBox txtHoTenChuHo;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.ComboBox cboKhuVuc;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Button btnThemHK;
        private System.Windows.Forms.Button btnSuaHK;
        private System.Windows.Forms.Button btnXoaHK;
        private System.Windows.Forms.DataGridView tgvHK;
    }
}