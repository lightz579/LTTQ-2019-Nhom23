using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentManager
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnQuanLyNguoiDan_Click(object sender, EventArgs e)
        {
            frmNguoiDan my_frmNguoiDan = new frmNguoiDan();
            my_frmNguoiDan.ShowDialog();
        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien my_frmNhanVien = new frmNhanVien();
            my_frmNhanVien.ShowDialog();
        }

        private void btnQuanLyDichVu_Click(object sender, EventArgs e)
        {

        }

        private void btnDangKyDichVu_Click(object sender, EventArgs e)
        {

        }

        private void btnTraCuuNguoiDan_Click(object sender, EventArgs e)
        {

        }

        private void btnTraCuuNhanVien_Click(object sender, EventArgs e)
        {

        }
    }
}
