using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowPhoneSimple
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            gioiThieuMenuItem.Click += gioiThieuMenuItem_Click;
            thoatMenuItem.Click += thoatMenuItem_Click;
            danhMụcToolStripMenuItem.Click += DanhMụcToolStripMenuItem_Click;
        }

        private void DanhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDanhMuc frmDM = new FrmDanhMuc();
            frmDM.MdiParent = this;
            frmDM.Show();
        }

        private void thoatMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void gioiThieuMenuItem_Click(object sender, EventArgs e)
        {
            FrmGioiThieu frmGT = new FrmGioiThieu();
            frmGT.MdiParent = this;
            frmGT.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
