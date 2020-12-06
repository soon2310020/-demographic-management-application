namespace quanlynhankhau
{
    partial class Main
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
            this.tplMain = new System.Windows.Forms.TableLayoutPanel();
            this.Menu = new System.Windows.Forms.Panel();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.btnTamTru = new System.Windows.Forms.Button();
            this.btnHoKhau = new System.Windows.Forms.Button();
            this.btnNhanKhau = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlSlideForm = new System.Windows.Forms.Panel();
            this.tplMain.SuspendLayout();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tplMain
            // 
            this.tplMain.ColumnCount = 1;
            this.tplMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tplMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tplMain.Controls.Add(this.Menu, 0, 0);
            this.tplMain.Controls.Add(this.lblTitle, 0, 1);
            this.tplMain.Controls.Add(this.pnlSlideForm, 0, 2);
            this.tplMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tplMain.Location = new System.Drawing.Point(0, 0);
            this.tplMain.Name = "tplMain";
            this.tplMain.RowCount = 3;
            this.tplMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tplMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tplMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tplMain.Size = new System.Drawing.Size(1040, 711);
            this.tplMain.TabIndex = 7;
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.btnTraCuu);
            this.Menu.Controls.Add(this.btnTamTru);
            this.Menu.Controls.Add(this.btnHoKhau);
            this.Menu.Controls.Add(this.btnNhanKhau);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Margin = new System.Windows.Forms.Padding(0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1040, 35);
            this.Menu.TabIndex = 1;
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuu.Location = new System.Drawing.Point(390, 0);
            this.btnTraCuu.Margin = new System.Windows.Forms.Padding(0);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(130, 35);
            this.btnTraCuu.TabIndex = 3;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // btnTamTru
            // 
            this.btnTamTru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTamTru.Location = new System.Drawing.Point(260, 0);
            this.btnTamTru.Margin = new System.Windows.Forms.Padding(0);
            this.btnTamTru.Name = "btnTamTru";
            this.btnTamTru.Size = new System.Drawing.Size(130, 35);
            this.btnTamTru.TabIndex = 2;
            this.btnTamTru.Text = "Tạm trú";
            this.btnTamTru.UseVisualStyleBackColor = true;
            this.btnTamTru.Click += new System.EventHandler(this.btnTamTru_Click);
            // 
            // btnHoKhau
            // 
            this.btnHoKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoKhau.Location = new System.Drawing.Point(0, 0);
            this.btnHoKhau.Margin = new System.Windows.Forms.Padding(0);
            this.btnHoKhau.Name = "btnHoKhau";
            this.btnHoKhau.Size = new System.Drawing.Size(130, 35);
            this.btnHoKhau.TabIndex = 1;
            this.btnHoKhau.Text = "Hộ khẩu";
            this.btnHoKhau.UseVisualStyleBackColor = true;
            this.btnHoKhau.Click += new System.EventHandler(this.btnHoKhau_Click);
            // 
            // btnNhanKhau
            // 
            this.btnNhanKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanKhau.Location = new System.Drawing.Point(130, 0);
            this.btnNhanKhau.Margin = new System.Windows.Forms.Padding(0);
            this.btnNhanKhau.Name = "btnNhanKhau";
            this.btnNhanKhau.Size = new System.Drawing.Size(130, 35);
            this.btnNhanKhau.TabIndex = 0;
            this.btnNhanKhau.Text = "Nhân khẩu";
            this.btnNhanKhau.UseVisualStyleBackColor = true;
            this.btnNhanKhau.Click += new System.EventHandler(this.btnNhanKhau_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTitle.Location = new System.Drawing.Point(520, 43);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 24);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSlideForm
            // 
            this.pnlSlideForm.AutoScroll = true;
            this.pnlSlideForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSlideForm.Location = new System.Drawing.Point(3, 78);
            this.pnlSlideForm.Name = "pnlSlideForm";
            this.pnlSlideForm.Size = new System.Drawing.Size(1034, 630);
            this.pnlSlideForm.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 711);
            this.Controls.Add(this.tplMain);
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Text = "Quản Lý Nhân Khẩu";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tplMain.ResumeLayout(false);
            this.tplMain.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tplMain;
        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Button btnTamTru;
        private System.Windows.Forms.Button btnHoKhau;
        private System.Windows.Forms.Button btnNhanKhau;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlSlideForm;
    }
}

