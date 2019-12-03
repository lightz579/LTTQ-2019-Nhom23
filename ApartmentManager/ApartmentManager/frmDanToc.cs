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
    public partial class frmDanToc : Form
    {
        DataAccessObject.ConnectDataBase connectionData = new DataAccessObject.ConnectDataBase();

        public frmDanToc()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (kiemTraTruocKhiLuu("MaDanToc") == true &&
                kiemTraTruocKhiLuu("TenDanToc") == true)
            {
                String tenDT = dgvDanToc.Rows[dgvDanToc.SelectedRows[0].Index].Cells["TenDanToc"].Value.ToString();
                String maDT = dgvDanToc.Rows[dgvDanToc.SelectedRows[0].Index].Cells["MaDanToc"].Value.ToString();
                String sql = String.Format("UPDATE DANTOC " +
                    "SET TenDanToc=N'{0}' WHERE MaDanToc='{1}'", tenDT, maDT);
                connectionData.runQuery(sql);
                refreshData();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            String maDT = dgvDanToc.Rows[dgvDanToc.SelectedRows[0].Index].Cells["MaDanToc"].Value.ToString();
            String sql1 = String.Format("DELETE FROM NGUOIDAN WHERE MaDanToc = '{0}'", maDT);
            String sql2 = String.Format("DELETE FROM DANTOC WHERE MaDanToc = '{0}'", maDT);
            connectionData.runQuery(sql1);
            connectionData.runQuery(sql2);
            refreshData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuuDanToc_Click(object sender, EventArgs e)
        {
            if (txtMaDanToc.Text != "" &&
                txtTenDanToc.Text != "")
            {
                String tenDT = txtTenDanToc.Text;
                String maDT = txtMaDanToc.Text;
                String sql = String.Format("INSERT INTO DANTOC VALUES" +
                    "('{0}',N'{1}')", maDT, tenDT);
                connectionData.runQuery(sql);
                refreshData();
            }
        }

        private void frmDanToc_Load(object sender, EventArgs e)
        {
            refreshData();
        }

        private void refreshData()
        {
            String sql = "SELECT * FROM DANTOC";
            dgvDanToc.DataSource = connectionData.getData(sql);
        }

        public Boolean kiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dgvDanToc.Rows)
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
