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

        private void btnNhanKhau_Click(object sender, EventArgs e)
        {
            
            //clear form panel
            this.pnlSlideForm.Controls.Clear();
            lblTitle.Text = "Quản lý nhân khẩu";

            frmNhanKhau MDIChildNK = new frmNhanKhau();
            // Set the Parent Form of the Child form.
            MDIChildNK.MdiParent = this;
            
            //add form child vao panel
            pnlSlideForm.Controls.Add(MDIChildNK);
            //bo border cua form child
            MDIChildNK.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MDIChildNK.Dock = DockStyle.Fill;
            MDIChildNK.Show();
        }
       
        private void btnHoKhau_Click(object sender, EventArgs e)
        {
            
            //clear form panel
            this.pnlSlideForm.Controls.Clear();
            lblTitle.Text = "Quản lý hộ khẩu";
                                   
            frmHoKhau MDIChildHK = new frmHoKhau();
            // Set the Parent Form of the Child form.
            MDIChildHK.MdiParent = this;
            
            //add form child vao panel
            pnlSlideForm.Controls.Add(MDIChildHK);
            //bo border cua form child
            MDIChildHK.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MDIChildHK.Dock = DockStyle.Fill;
            MDIChildHK.Show();      
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTamTru_Click(object sender, EventArgs e)
        {
            //clear form panel
            this.pnlSlideForm.Controls.Clear();
            lblTitle.Text = "Quản lý tạm trú";
            

            frmTamTru MDIChildTT = new frmTamTru();
            // Set the Parent Form of the Child form.
            MDIChildTT.MdiParent = this;

            //add form child vao panel
            pnlSlideForm.Controls.Add(MDIChildTT);
            //bo border cua form child
            MDIChildTT.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MDIChildTT.Dock = DockStyle.Fill;
            MDIChildTT.Show();
        }
    }
}
