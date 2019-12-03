using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ApartmentManager
{
    public partial class frmNhanVien : Form
    {

        DataAccessObject.ConnectDataBase connectData = new DataAccessObject.ConnectDataBase();

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void btnLuuDanhSach_Click(object sender, EventArgs e)
        {

            int gioiTinh = 0;
            if (rdNu.Checked == true)
                gioiTinh = 1;
            if (txtMaNhanVien.Text != "" &&
                txtTenNhanVien.Text != "" &&
                dtiNgaySinh.Value != null &&
                txtDiaChi.Text != "" &&
                txtDienThoai.Text != "")
            {
                String maNV = txtMaNhanVien.Text;
                String tenNV = txtTenNhanVien.Text;
                String diaChi = txtDiaChi.Text;
                String ngaySinh = dtiNgaySinh.Value.ToShortDateString();
                String dienThoai = txtDienThoai.Text;
                String maChucVu = cbChucVu.SelectedValue.ToString();
                connectData.LuuNhanVien(maNV, tenNV, gioiTinh, ngaySinh, diaChi, dienThoai, maChucVu);
            }
        }

        private void btnThemChucVu_Click(object sender, EventArgs e)
        {
            frmChucVu myFrmChucVu = new frmChucVu();
            myFrmChucVu.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String maNV = dgvNhanVien.SelectedCells[0].OwningRow.Cells["MaNhanVien"].Value.ToString();
            String sql = String.Format("DELETE FROM NHANVIEN WHERE MaNhanVien = '{0}'", maNV);
            connectData.runQuery(sql);
            refreshData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (kiemTraTruocKhiLuu("MaNhanVien") == true &&
                kiemTraTruocKhiLuu("TenNhanVien") == true &&
                kiemTraTruocKhiLuu("NgaySinh") == true &&
                kiemTraTruocKhiLuu("DienThoai") == true &&
                kiemTraTruocKhiLuu("DiaChi") == true &&
                kiemTraTruocKhiLuu("GioiTinh") == true &&
                kiemTraTruocKhiLuu("MaChucVu") == true)
            {
                String gt = dgvNhanVien.Rows[dgvNhanVien.SelectedRows[0].Index].Cells["GioiTinh"].Value.ToString();
                int gioiTinh;
                if (gt.Equals("True"))
                    gioiTinh = 1;
                else
                    gioiTinh = 0;
                String maNV = dgvNhanVien.Rows[dgvNhanVien.SelectedRows[0].Index].Cells["MaNhanVien"].Value.ToString();
                String tenNV = dgvNhanVien.Rows[dgvNhanVien.SelectedRows[0].Index].Cells["TenNhanVien"].Value.ToString();
                String diaChi = dgvNhanVien.Rows[dgvNhanVien.SelectedRows[0].Index].Cells["DiaChi"].Value.ToString();
                String ngaySinh = dgvNhanVien.Rows[dgvNhanVien.SelectedRows[0].Index].Cells["NgaySinh"].Value.ToString();
                String dienThoai = dgvNhanVien.Rows[dgvNhanVien.SelectedRows[0].Index].Cells["DienThoai"].Value.ToString();
                String maChucVu = dgvNhanVien.Rows[dgvNhanVien.SelectedRows[0].Index].Cells["MaChucVu"].Value.ToString();

                String sql = String.Format("UPDATE NHANVIEN " +
                    "SET TenNhanVien=N'{0}',GioiTinh={1}, NgaySinh='{2}',DiaChi=N'{3}',DienThoai='{4}', MaChucVu='{5}' " +
                    "WHERE MaNhanVien = '{6}'", tenNV, gioiTinh, ngaySinh, diaChi, dienThoai, maChucVu, maNV);
                connectData.runQuery(sql);
                refreshData();
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            loadComboBoxChucVu();
            refreshData();

        }

        private void loadComboBoxChucVu()
        {
            String sql = "SELECT * FROM CHUCVU";
            cbChucVu.DisplayMember = "TenChucVu";
            cbChucVu.ValueMember = "MaChucVu";
            cbChucVu.DataSource = connectData.getData(sql);
        }

        private void refreshData()
        {
            String sql = "SELECT NV.MaNhanVien, TenNhanVien, GioiTinh, NgaySinh, DiaChi, DienThoai, TenChucVu" +
                " FROM NHANVIEN NV INNER JOIN CHUCVU CV ON NV.MaChucVu = CV.MaChucVu";
            dgvNhanVien.DataSource = connectData.getData(sql);
        }

        private void cbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            String maCV = cbChucVu.SelectedValue.ToString();
            String sql = String.Format("SELECT * FROM CHUCVU WHERE maCV = '{0}", maCV);

        }

        private Boolean kiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dgvNhanVien.Rows)
            {

                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "")
                    {
                        MessageBox.Show("Thông tin nhân viên " + row.Cells["TenNhanVien"].Value.ToString() + " không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        
    }
}
