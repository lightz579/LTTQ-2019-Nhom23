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
    public partial class frmDangKyCanHo : Form
    {
        DataAccessObject.ConnectDataBase connectData = new DataAccessObject.ConnectDataBase();
        

        public frmDangKyCanHo()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(rdTenND.Checked == true)
            {
                dgvNguoiDan.DataSource = timKiemTheoTen(txtTenNguoiDan.Text);
            }
            else if(rdMaND.Checked == true)
            {
                dgvNguoiDan.DataSource = timKiemTheoID(txtTenNguoiDan.Text);
            }
            else
            {
                MessageBox.Show("Hãy chọn kiểu tìm kiếm !");
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            xoaDangKy(txtMaND.Text);
            luuDangKy(txtMaND.Text, cbCanHo.Text);
            refreshData();
            txtTenNguoiDan.Text = "";
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            String maND = dgvNguoiDan.Rows[dgvNguoiDan.SelectedRows[0].Index].Cells["MaNguoiDan"].Value.ToString();
            xoaDangKy(maND);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangKyCanHo_Load(object sender, EventArgs e)
        {
            refreshData();
            loadComboBox();
        }

        private DataTable timKiemTheoTen(String tenND)
        {
            String sql = "SELECT ND.MaNguoiDan, TenNguoiDan, GioiTinh, NgaySinh, TenDanToc, TenTonGiao, TenNgheNghiep" +
                " FROM NGUOIDAN ND INNER JOIN DANTOC DT ON DT.MaDanToc = ND.MaDanToc" +
                " INNER JOIN TONGIAO TG ON TG.MaTonGiao = ND.MaTonGiao " +
                " INNER JOIN NGHENGHIEP NN ON NN.MaNgheNghiep = ND.MaNgheNghiep" +
                " WHERE TenNGuoiDan LIKE '%" + tenND + "%'";
            return connectData.getData(sql);
        }

        private DataTable timKiemTheoID(String maND)
        {
            String sql = "SELECT ND.MaNguoiDan, TenNguoiDan, GioiTinh, NgaySinh, TenDanToc, TenTonGiao, TenNgheNghiep" +
                " FROM NGUOIDAN ND INNER JOIN DANTOC DT ON DT.MaDanToc = ND.MaDanToc" +
                " INNER JOIN TONGIAO TG ON TG.MaTonGiao = ND.MaTonGiao " +
                " INNER JOIN NGHENGHIEP NN ON NN.MaNgheNghiep = ND.MaNgheNghiep" +
                " WHERE MaNguoiDan LIKE '%" + maND + "%'";
            return connectData.getData(sql);
        }

        private void dgvNguoiDan_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String tenND = dgvNguoiDan.Rows[dgvNguoiDan.SelectedRows[0].Index].Cells["TenNguoiDan"].Value.ToString();
            txtTenND2.Text = tenND;
            txtMaND.Text = dgvNguoiDan.Rows[dgvNguoiDan.SelectedRows[0].Index].Cells["MaNguoiDan"].Value.ToString();
        }

        public void refreshData()
        {
            String sql = "SELECT CHND.MaNguoiDan, TenNguoiDan, CHND.MaCanHo FROM CANHO_NGUOIDAN CHND " + 
                           " INNER JOIN NGUOIDAN ND ON CHND.MaNguoiDan = ND.MaNguoiDan";
            dgvNguoiDan.DataSource = connectData.getData(sql);
        }

        private void loadComboBox()
        {
            String sql = "SELECt * FROM CANHO";
            cbCanHo.DataSource = connectData.getData(sql);
            cbCanHo.DisplayMember = "MaCanHo";
            cbCanHo.ValueMember = "MaCanHo";
        }

        private void xoaDangKy(String maND)
        {
            String sql = "DELETE FROM CANHO_NGUOIDAN WHERE MaNguoiDan = '" + maND + "'";
            connectData.runQuery(sql);
        }

        private void luuDangKy(String maND, String maCH)
        {
            String sql = String.Format("INSERT INTO CANHO_NGUOIDAN VALUES ('{0}','{1}')", maND, maCH);
            connectData.runQuery(sql);
        }
    }
}
