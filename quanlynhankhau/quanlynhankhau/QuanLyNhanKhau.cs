using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlynhankhau
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();          
        }
        private void Main_Load(object sender, EventArgs e)
        {
            
        }
        
        private void btnHoKhau_Click(object sender, EventArgs e)
        {
            //clear form panel
            this.pnlSlideForm.Controls.Clear();
            lblTitle.Text = "Quản lý hộ khẩu";

            frmHK MDIChildHK = new frmHK();
            // Set the Parent Form of the Child form.
            MDIChildHK.MdiParent = this;

            //add form child vao panel
            pnlSlideForm.Controls.Add(MDIChildHK);
            //bo border cua form child
            MDIChildHK.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MDIChildHK.Dock = DockStyle.Fill;
            MDIChildHK.Show();
        }

        private void btnNhanKhau_Click(object sender, EventArgs e)
        {
            //clear form panel
            this.pnlSlideForm.Controls.Clear();
            lblTitle.Text = "Quản lý nhân khẩu";

            frmNK MDIChildNK = new frmNK();
            // Set the Parent Form of the Child form.
            MDIChildNK.MdiParent = this;

            //add form child vao panel
            pnlSlideForm.Controls.Add(MDIChildNK);
            //bo border cua form child
            MDIChildNK.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MDIChildNK.Dock = DockStyle.Fill;
            MDIChildNK.Show();
        }

        private void btnTamTru_Click(object sender, EventArgs e)
        {
            //clear form panel
            this.pnlSlideForm.Controls.Clear();
            lblTitle.Text = "Quản lý tạm trú";


            frmTT MDIChildTT = new frmTT();
            // Set the Parent Form of the Child form.
            MDIChildTT.MdiParent = this;

            //add form child vao panel
            pnlSlideForm.Controls.Add(MDIChildTT);
            //bo border cua form child
            MDIChildTT.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MDIChildTT.Dock = DockStyle.Fill;
            MDIChildTT.Show();
        }
     
        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            //clear form panel
            this.pnlSlideForm.Controls.Clear();
            lblTitle.Text = "Tra cứu";


            frmTraCuu MDIChildTC = new frmTraCuu();
            // Set the Parent Form of the Child form.
            MDIChildTC.MdiParent = this;

            //add form child vao panel
            pnlSlideForm.Controls.Add(MDIChildTC);
            //bo border cua form child
            MDIChildTC.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MDIChildTC.Dock = DockStyle.Fill;
            MDIChildTC.Show();
        }
    }
}
