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
    public partial class frmNgheNghiep : Form
    {
        DataAccessObject.ConnectDataBase connectionData = new DataAccessObject.ConnectDataBase();

        public frmNgheNghiep()
        {
            InitializeComponent();
        }

        private void btnLuuNgheNghiep_Click(object sender, EventArgs e)
        {
            if (txtMaNgheNghiep.Text != "" &&
                txtTenNgheNghiep.Text != "")
            {
                String tenNN = txtTenNgheNghiep.Text;
                String maNN = txtMaNgheNghiep.Text;
                String sql = String.Format("INSERT INTO NGHENGHIEP VALUES" +
                    "('{0}',N'{1}')", maNN, tenNN);
                connectionData.runQuery(sql);
                refreshData();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (kiemTraTruocKhiLuu("MaNgheNghiep") == true &&
                kiemTraTruocKhiLuu("TenNgheNghiep") == true)
            {
                String tenNN = dgvNgheNghiep.Rows[dgvNgheNghiep.SelectedRows[0].Index].Cells["MaNgheNghiep"].Value.ToString();
                String maNN = dgvNgheNghiep.Rows[dgvNgheNghiep.SelectedRows[0].Index].Cells["TenNgheNghiep"].Value.ToString();
                String sql = String.Format("UPDATE NGHENGHIEP " +
                    "SET TenNgheNghiep=N'{0}' WHERE MaNgheNghiep='{1}'", tenNN, maNN);
                connectionData.runQuery(sql);
                refreshData();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            String maNN = dgvNgheNghiep.Rows[dgvNgheNghiep.SelectedRows[0].Index].Cells["MaNgheNghiep"].Value.ToString();
            String sql1 = String.Format("DELETE FROM NGUOIDAN WHERE MaNgheNghiep='{0}'", maNN);
            String sql2 = String.Format("DELETE FROM NGHENGHIEP WHERE MaNgheNghiep='{0}'", maNN);
            connectionData.runQuery(sql1);
            connectionData.runQuery(sql2);
            refreshData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNgheNghiep_Load(object sender, EventArgs e)
        {
            refreshData();
        }

        private void refreshData()
        {
            String sql = "SELECT * FROM NGHENGHIEP";
            dgvNgheNghiep.DataSource = connectionData.getData(sql);
        }

        public Boolean kiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dgvNgheNghiep.Rows)
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
    }
}
