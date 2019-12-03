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
            frmDichVu my_frmDichVu = new frmDichVu();
            my_frmDichVu.ShowDialog();
        }

        private void btnDangKyDichVu_Click(object sender, EventArgs e)
        {
            frmDangKyDichVu my_frmDangKyDichVu = new frmDangKyDichVu();
            my_frmDangKyDichVu.ShowDialog();
        }

        private void btnTraCuuNguoiDan_Click(object sender, EventArgs e)
        {

        }

        private void btnTraCuuNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void tsbQuanLyNguoiDan_Click(object sender, EventArgs e)
        {
            frmNguoiDan my_frmNguoiDan = new frmNguoiDan();
            my_frmNguoiDan.ShowDialog();
        }

        private void tsbQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien my_frmNhanVien = new frmNhanVien();
            my_frmNhanVien.ShowDialog();
        }

        private void tsbQuanLyDichVu_Click(object sender, EventArgs e)
        {
            frmDichVu my_frmDichVu = new frmDichVu();
            my_frmDichVu.ShowDialog();
        }

        private void tsbDangKyDichVu_Click(object sender, EventArgs e)
        {
            frmDangKyDichVu my_frmDangKyDichVu = new frmDangKyDichVu();
            my_frmDangKyDichVu.ShowDialog();
        }

        private void tsmNguoiDan_Click(object sender, EventArgs e)
        {
            frmNguoiDan my_frmNguoiDan = new frmNguoiDan();
            my_frmNguoiDan.ShowDialog();
        }

        private void tsmNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien my_frmNhanVien = new frmNhanVien();
            my_frmNhanVien.ShowDialog();
        }

        private void tsmDichVu_Click(object sender, EventArgs e)
        {
            frmDichVu my_frmDichVu = new frmDichVu();
            my_frmDichVu.ShowDialog();
        }

        private void tsmDangKyDichVu_Click(object sender, EventArgs e)
        {
            frmDangKyDichVu my_frmDangKyDichVu = new frmDangKyDichVu();
            my_frmDangKyDichVu.ShowDialog();
        }

        private void tsmNgheNghiep_Click(object sender, EventArgs e)
        {
            frmNgheNghiep my_frmNgheNghiep = new frmNgheNghiep();
            my_frmNgheNghiep.ShowDialog();
        }

        private void tsmDanToc_Click(object sender, EventArgs e)
        {
            frmDanToc my_frmDanToc = new frmDanToc();
            my_frmDanToc.ShowDialog();
        }

        private void tsmTonGiao_Click(object sender, EventArgs e)
        {
            frmTonGiao my_frmTonGiao = new frmTonGiao();
            my_frmTonGiao.ShowDialog();
        }

        private void tsmChucVu_Click(object sender, EventArgs e)
        {
            frmChucVu my_frmChucVu = new frmChucVu();
            my_frmChucVu.ShowDialog();
        }

        private void btnDangKyThue_Click(object sender, EventArgs e)
        {
            frmDangKyCanHo my_frmDangKyCanHo = new frmDangKyCanHo();
            my_frmDangKyCanHo.ShowDialog();
        }
    }
}
