namespace quanlynhankhau
{
    partial class frmTT
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
            this.tlpTT = new System.Windows.Forms.TableLayoutPanel();
            this.tgvTT = new System.Windows.Forms.DataGridView();
            this.pnlTT = new System.Windows.Forms.Panel();
            this.btnXoaTT = new System.Windows.Forms.Button();
            this.btnSuaTT = new System.Windows.Forms.Button();
            this.btnThemTT = new System.Windows.Forms.Button();
            this.dtpThoiHan = new System.Windows.Forms.DateTimePicker();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtDiaChiTT = new System.Windows.Forms.TextBox();
            this.txtNoiTT = new System.Windows.Forms.TextBox();
            this.cboMaNK = new System.Windows.Forms.ComboBox();
            this.lblThoiHan = new System.Windows.Forms.Label();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblNoiTT = new System.Windows.Forms.Label();
            this.lblMaNK = new System.Windows.Forms.Label();
            this.tlpTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tgvTT)).BeginInit();
            this.pnlTT.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpTT
            // 
            this.tlpTT.ColumnCount = 1;
            this.tlpTT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTT.Controls.Add(this.tgvTT, 0, 1);
            this.tlpTT.Controls.Add(this.pnlTT, 0, 0);
            this.tlpTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTT.Location = new System.Drawing.Point(0, 0);
            this.tlpTT.Name = "tlpTT";
            this.tlpTT.RowCount = 2;
            this.tlpTT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpTT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpTT.Size = new System.Drawing.Size(919, 518);
            this.tlpTT.TabIndex = 0;
            // 
            // tgvTT
            // 
            this.tgvTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tgvTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tgvTT.Location = new System.Drawing.Point(3, 365);
            this.tgvTT.Name = "tgvTT";
            this.tgvTT.Size = new System.Drawing.Size(913, 150);
            this.tgvTT.TabIndex = 26;
            // 
            // pnlTT
            // 
            this.pnlTT.AutoScroll = true;
            this.pnlTT.Controls.Add(this.btnXoaTT);
            this.pnlTT.Controls.Add(this.btnSuaTT);
            this.pnlTT.Controls.Add(this.btnThemTT);
            this.pnlTT.Controls.Add(this.dtpThoiHan);
            this.pnlTT.Controls.Add(this.txtDienThoai);
            this.pnlTT.Controls.Add(this.txtDiaChiTT);
            this.pnlTT.Controls.Add(this.txtNoiTT);
            this.pnlTT.Controls.Add(this.cboMaNK);
            this.pnlTT.Controls.Add(this.lblThoiHan);
            this.pnlTT.Controls.Add(this.lblDienThoai);
            this.pnlTT.Controls.Add(this.lblDiaChi);
            this.pnlTT.Controls.Add(this.lblNoiTT);
            this.pnlTT.Controls.Add(this.lblMaNK);
            this.pnlTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTT.Location = new System.Drawing.Point(3, 3);
            this.pnlTT.Name = "pnlTT";
            this.pnlTT.Size = new System.Drawing.Size(913, 356);
            this.pnlTT.TabIndex = 0;
            // 
            // btnXoaTT
            // 
            this.btnXoaTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaTT.Location = new System.Drawing.Point(581, 266);
            this.btnXoaTT.Name = "btnXoaTT";
            this.btnXoaTT.Size = new System.Drawing.Size(100, 30);
            this.btnXoaTT.TabIndex = 36;
            this.btnXoaTT.Text = "Xóa";
            this.btnXoaTT.UseVisualStyleBackColor = true;
            // 
            // btnSuaTT
            // 
            this.btnSuaTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaTT.Location = new System.Drawing.Point(432, 266);
            this.btnSuaTT.Name = "btnSuaTT";
            this.btnSuaTT.Size = new System.Drawing.Size(100, 30);
            this.btnSuaTT.TabIndex = 35;
            this.btnSuaTT.Text = "Sửa";
            this.btnSuaTT.UseVisualStyleBackColor = true;
            // 
            // btnThemTT
            // 
            this.btnThemTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemTT.Location = new System.Drawing.Point(280, 266);
            this.btnThemTT.Name = "btnThemTT";
            this.btnThemTT.Size = new System.Drawing.Size(100, 30);
            this.btnThemTT.TabIndex = 34;
            this.btnThemTT.Text = "Thêm";
            this.btnThemTT.UseVisualStyleBackColor = true;
            // 
            // dtpThoiHan
            // 
            this.dtpThoiHan.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpThoiHan.CustomFormat = "dd/MM/yyyy";
            this.dtpThoiHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpThoiHan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiHan.Location = new System.Drawing.Point(282, 194);
            this.dtpThoiHan.Name = "dtpThoiHan";
            this.dtpThoiHan.Size = new System.Drawing.Size(464, 24);
            this.dtpThoiHan.TabIndex = 33;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDienThoai.Location = new System.Drawing.Point(282, 152);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(464, 24);
            this.txtDienThoai.TabIndex = 32;
            // 
            // txtDiaChiTT
            // 
            this.txtDiaChiTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiaChiTT.Location = new System.Drawing.Point(282, 114);
            this.txtDiaChiTT.Name = "txtDiaChiTT";
            this.txtDiaChiTT.Size = new System.Drawing.Size(464, 24);
            this.txtDiaChiTT.TabIndex = 31;
            // 
            // txtNoiTT
            // 
            this.txtNoiTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNoiTT.Location = new System.Drawing.Point(282, 74);
            this.txtNoiTT.Name = "txtNoiTT";
            this.txtNoiTT.Size = new System.Drawing.Size(464, 24);
            this.txtNoiTT.TabIndex = 30;
            // 
            // cboMaNK
            // 
            this.cboMaNK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboMaNK.FormattingEnabled = true;
            this.cboMaNK.Location = new System.Drawing.Point(282, 34);
            this.cboMaNK.Name = "cboMaNK";
            this.cboMaNK.Size = new System.Drawing.Size(464, 26);
            this.cboMaNK.TabIndex = 29;
            // 
            // lblThoiHan
            // 
            this.lblThoiHan.AutoSize = true;
            this.lblThoiHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThoiHan.Location = new System.Drawing.Point(148, 195);
            this.lblThoiHan.Name = "lblThoiHan";
            this.lblThoiHan.Size = new System.Drawing.Size(70, 20);
            this.lblThoiHan.TabIndex = 28;
            this.lblThoiHan.Text = "Thời hạn";
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDienThoai.Location = new System.Drawing.Point(148, 154);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(81, 20);
            this.lblDienThoai.TabIndex = 27;
            this.lblDienThoai.Text = "Điện thoại";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDiaChi.Location = new System.Drawing.Point(148, 116);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(57, 20);
            this.lblDiaChi.TabIndex = 26;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // lblNoiTT
            // 
            this.lblNoiTT.AutoSize = true;
            this.lblNoiTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNoiTT.Location = new System.Drawing.Point(148, 76);
            this.lblNoiTT.Name = "lblNoiTT";
            this.lblNoiTT.Size = new System.Drawing.Size(86, 20);
            this.lblNoiTT.TabIndex = 25;
            this.lblNoiTT.Text = "Nơi tạm trú";
            // 
            // lblMaNK
            // 
            this.lblMaNK.AutoSize = true;
            this.lblMaNK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaNK.Location = new System.Drawing.Point(148, 36);
            this.lblMaNK.Name = "lblMaNK";
            this.lblMaNK.Size = new System.Drawing.Size(110, 20);
            this.lblMaNK.TabIndex = 24;
            this.lblMaNK.Text = "Mã nhân khẩu";
            // 
            // frmTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 518);
            this.Controls.Add(this.tlpTT);
            this.Name = "frmTT";
            this.Text = "Quản lý tạm trú";
            this.tlpTT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tgvTT)).EndInit();
            this.pnlTT.ResumeLayout(false);
            this.pnlTT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpTT;
        private System.Windows.Forms.Panel pnlTT;
        private System.Windows.Forms.Button btnXoaTT;
        private System.Windows.Forms.Button btnSuaTT;
        private System.Windows.Forms.Button btnThemTT;
        private System.Windows.Forms.DateTimePicker dtpThoiHan;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtDiaChiTT;
        private System.Windows.Forms.TextBox txtNoiTT;
        private System.Windows.Forms.ComboBox cboMaNK;
        private System.Windows.Forms.Label lblThoiHan;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblNoiTT;
        private System.Windows.Forms.Label lblMaNK;
        private System.Windows.Forms.DataGridView tgvTT;
    }
}