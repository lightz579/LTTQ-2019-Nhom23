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
    public partial class frmDichVu : Form
    {
        DataAccessObject.ConnectDataBase connectionData = new DataAccessObject.ConnectDataBase();

        public frmDichVu()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (kiemTraTruocKhiLuu("MaDichVu") == true &&
                kiemTraTruocKhiLuu("TenDichVu") == true &&
                kiemTraTruocKhiLuu("DonGia") == true)
            {
                String tenDV = dgvDichVu.Rows[dgvDichVu.SelectedRows[0].Index].Cells["TenDichVu"].Value.ToString();
                String maDV = dgvDichVu.Rows[dgvDichVu.SelectedRows[0].Index].Cells["MaDichVu"].Value.ToString();
                String donGia = dgvDichVu.Rows[dgvDichVu.SelectedRows[0].Index].Cells["DonGia"].Value.ToString();
                String sql = String.Format("UPDATE DICHVU " +
                    "SET TenDichVu=N'{0}', DonGia={1} WHERE MaDichVu='{2}'", tenDV, donGia, maDV);
                connectionData.runQuery(sql);
                refreshData();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            String maDV = dgvDichVu.Rows[dgvDichVu.SelectedRows[0].Index].Cells["MaDichVu"].Value.ToString();
            
            String sql1 = String.Format("DELETE FROM CANHO_DICHVU WHERE MaDichVu = '{0}'", maDV);
            String sql2 = String.Format("DELETE FROM DICHVU WHERE MaDichVu = '{0}'", maDV);
            connectionData.runQuery(sql1);
            connectionData.runQuery(sql2);
            refreshData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshData()
        {
            String sql = "SELECT * FROM DICHVU";
            dgvDichVu.DataSource = connectionData.getData(sql);
        }

        private void frmDichVu_Load(object sender, EventArgs e)
        {
            refreshData();
        }

        public Boolean kiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dgvDichVu.Rows)
            {

                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "")
                    {
                        MessageBox.Show("Giá trị ô không được rỗng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private void btnLuuDichVu_Click(object sender, EventArgs e)
        {
            if (txtMaDichVu.Text != "" &&
                txtTenDichVu.Text != "" &&
                txtDonGia.Text != "")
            {
                String tenDV = txtTenDichVu.Text;
                String maDV = txtMaDichVu.Text;
                String donGia = txtDonGia.Text;
                String sql = String.Format("INSERT INTO DICHVU VALUES" +
                    "('{0}',N'{1}', {2})", maDV, tenDV, donGia);
                connectionData.runQuery(sql);
                refreshData();
            }
        }
    }
}
