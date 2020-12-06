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
            this.Menu = new System.Windows.Forms.Panel();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.btnTamTru = new System.Windows.Forms.Button();
            this.btnHoKhau = new System.Windows.Forms.Button();
            this.btnNhanKhau = new System.Windows.Forms.Button();
            this.pnlSlideForm = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.Menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Menu.Controls.Add(this.btnTraCuu);
            this.Menu.Controls.Add(this.btnTamTru);
            this.Menu.Controls.Add(this.btnHoKhau);
            this.Menu.Controls.Add(this.btnNhanKhau);
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Margin = new System.Windows.Forms.Padding(0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(801, 35);
            this.Menu.TabIndex = 0;
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
            // pnlSlideForm
            // 
            this.pnlSlideForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSlideForm.Location = new System.Drawing.Point(0, 100);
            this.pnlSlideForm.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSlideForm.Name = "pnlSlideForm";
            this.pnlSlideForm.Size = new System.Drawing.Size(801, 610);
            this.pnlSlideForm.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 65);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTitle.Location = new System.Drawing.Point(354, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 711);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlSlideForm);
            this.Controls.Add(this.Menu);
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Text = "Quản Lý Nhân Khẩu";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Menu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Button btnHoKhau;
        private System.Windows.Forms.Button btnNhanKhau;
        private System.Windows.Forms.Button btnTamTru;
        private System.Windows.Forms.Panel pnlSlideForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnTraCuu;
    }
}

