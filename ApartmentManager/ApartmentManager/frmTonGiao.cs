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
    public partial class frmTonGiao : Form
    {

        DataAccessObject.ConnectDataBase connectionData = new DataAccessObject.ConnectDataBase();

        public frmTonGiao()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (kiemTraTruocKhiLuu("MaTonGiao") == true &&
                kiemTraTruocKhiLuu("TenTonGiao") == true)
            {
                String tenTG = dgvTonGiao.Rows[dgvTonGiao.SelectedRows[0].Index].Cells["TenTonGiao"].Value.ToString();
                String maTG = dgvTonGiao.Rows[dgvTonGiao.SelectedRows[0].Index].Cells["MaTonGiao"].Value.ToString();
                String sql = String.Format("UPDATE TONGIAO " +
                    "SET TenTonGiao=N'{0}' WHERE MaTonGiao='{1}'", tenTG, maTG);
                connectionData.runQuery(sql);
                refreshData();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            String maTG = dgvTonGiao.Rows[dgvTonGiao.SelectedRows[0].Index].Cells["MaTonGiao"].Value.ToString();
            String sql1 = String.Format("DELETE FROM NGUOIDAN WHERE MaTonGiao = '{0}'", maTG);
            String sql2 = String.Format("DELETE FROM TONGIAO WHERE MaTonGiao = '{0}'", maTG);
            connectionData.runQuery(sql1);
            connectionData.runQuery(sql2);
            refreshData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuuTonGiao_Click(object sender, EventArgs e)
        {
            if (txtMaTonGiao.Text != "" &&
                txtTenTonGiao.Text != "")
            {
                String tenTG = txtTenTonGiao.Text;
                String maTg = txtMaTonGiao.Text;
                String sql = String.Format("INSERT INTO TONGIAO VALUES" +
                    "('{0}',N'{1}')", maTg, tenTG);
                connectionData.runQuery(sql);
                refreshData();
            }
        }

        private void frmTonGiao_Load(object sender, EventArgs e)
        {
            refreshData();
        }

        private void refreshData()
        {
            String sql = "SELECT * FROM TONGIAO";
            dgvTonGiao.DataSource = connectionData.getData(sql);
        }

        public Boolean kiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dgvTonGiao.Rows)
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
