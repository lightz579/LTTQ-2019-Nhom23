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
    public partial class frmNguoiDan : Form
    {
        DataAccessObject.ConnectDataBase connectData = new DataAccessObject.ConnectDataBase();

        public frmNguoiDan()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (kiemTraTruocKhiLuu("MaNguoiDan") == true &&
                kiemTraTruocKhiLuu("TenNguoiDan") == true &&
                kiemTraTruocKhiLuu("NgaySinh") == true &&
                kiemTraTruocKhiLuu("MaNgheNghiep") == true &&
                kiemTraTruocKhiLuu("MaTonGiao") == true &&
                kiemTraTruocKhiLuu("GioiTinh") == true &&
                kiemTraTruocKhiLuu("MaDanToc") == true)
            {
                String gt = dgvNguoiDan.Rows[dgvNguoiDan.SelectedRows[0].Index].Cells["GioiTinh"].Value.ToString();
                int gioiTinh;
                if (gt.Equals("True"))
                    gioiTinh = 1;
                else
                    gioiTinh = 0;
                String maND = dgvNguoiDan.Rows[dgvNguoiDan.SelectedRows[0].Index].Cells["MaNguoiDan"].Value.ToString();
                String tenND = dgvNguoiDan.Rows[dgvNguoiDan.SelectedRows[0].Index].Cells["TenNguoiDan"].Value.ToString();
                String ngaySinh = dgvNguoiDan.Rows[dgvNguoiDan.SelectedRows[0].Index].Cells["NgaySinh"].Value.ToString();
                String maNN = dgvNguoiDan.Rows[dgvNguoiDan.SelectedRows[0].Index].Cells["MaNgheNghiep"].Value.ToString();
                String maTG = dgvNguoiDan.Rows[dgvNguoiDan.SelectedRows[0].Index].Cells["MaTonGiao"].Value.ToString();
                String maDT = dgvNguoiDan.Rows[dgvNguoiDan.SelectedRows[0].Index].Cells["MaDanToc"].Value.ToString();

                String sql = String.Format("UPDATE NGUOIDAN " +
                    "SET TenNguoiDan=N'{0}',GioiTinh={1}, NgaySinh='{2}',MaDanToc='{3}',MaTonGiao='{4}', MaNgheNghiep='{5}' " +
                    "WHERE MaNguoiDan = '{6}'", tenND, gioiTinh, ngaySinh, maDT, maTG, maNN, maND);
                connectData.runQuery(sql);
                refreshData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String maND = dgvNguoiDan.SelectedCells[0].OwningRow.Cells["MaNguoiDan"].Value.ToString();
            String sql = String.Format("DELETE FROM NGUOIDAN WHERE MaNguoiDan = '{0}'", maND);
            connectData.runQuery(sql);
            refreshData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuuDanhSach_Click(object sender, EventArgs e)
        {
            int gioiTinh = 0;
            if (rdNu.Checked == true)
                gioiTinh = 1;
            if (txtMaNguoiDan.Text != "" &&
                txtTenNguoiDan.Text != "" &&
                dtiNgaySinh.Value != null &&
                cbDanToc.Text != "" &&
                cbTonGiao.Text != "" &&
                cbNgheNghiep.Text != "")
            {
                String maND = txtMaNguoiDan.Text;
                String tenND = txtTenNguoiDan.Text;
                String maDT = cbDanToc.SelectedValue.ToString();
                String ngaySinh = dtiNgaySinh.Value.ToShortDateString();
                String maTG = cbTonGiao.SelectedValue.ToString();
                String maNN = cbNgheNghiep.SelectedValue.ToString();
                connectData.LuuNguoiDan(maND, tenND, gioiTinh, ngaySinh, maDT, maTG, maNN);
            }
        }


        private void frmNguoiDan_Load(object sender, EventArgs e)
        {
            refreshData();
            loadComboBoxDanToc();
            loadComboBoxNgheNghiep();
            loadComboBoxTonGiao();
        }

        private void refreshData()
        {
            String sql = "SELECT * FROM NGUOIDAN";
            dgvNguoiDan.DataSource = connectData.getData(sql);
        }

        private void loadComboBoxDanToc()
        {
            String sql = "SELECT * FROM DANTOC";
            cbDanToc.DisplayMember = "TenDanToc";
            cbDanToc.ValueMember = "MaDanToc";
            cbDanToc.DataSource = connectData.getData(sql);
        }

        private void loadComboBoxTonGiao()
        {
            String sql = "SELECT * FROM TONGIAO";
            cbTonGiao.DisplayMember = "TenTonGiao";
            cbTonGiao.ValueMember = "MaTonGiao";
            cbTonGiao.DataSource = connectData.getData(sql);
        }

        private void loadComboBoxNgheNghiep()
        {
            String sql = "SELECT * FROM NGHENGHIEP";
            cbNgheNghiep.DisplayMember = "TenNgheNghiep";
            cbNgheNghiep.ValueMember = "MaNgheNghiep";
            cbNgheNghiep.DataSource = connectData.getData(sql);
        }

        private Boolean kiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dgvNguoiDan.Rows)
            {

                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "")
                    {
                        MessageBox.Show("Thông tin không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private void btnDanToc_Click(object sender, EventArgs e)
        {
            frmDanToc myFrmDanToc = new frmDanToc();
            myFrmDanToc.ShowDialog();
        }

        private void btnThemTonGiao_Click(object sender, EventArgs e)
        {
            frmTonGiao myFrmTonGiao = new frmTonGiao();
            myFrmTonGiao.ShowDialog();
        }

        private void btnThemNgheNghiep_Click(object sender, EventArgs e)
        {
            frmNgheNghiep myFrmNgheNghiep = new frmNgheNghiep();
            myFrmNgheNghiep.ShowDialog();
        }
    }
}
