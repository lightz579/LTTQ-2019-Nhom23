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
    public partial class frmChucVu : Form
    {
        DataAccessObject.ConnectDataBase connectionData = new DataAccessObject.ConnectDataBase();

        public frmChucVu()
        {
            InitializeComponent();
        }

       
        private void frmChucVu_Load(object sender, EventArgs e)
        {
            refreshData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(kiemTraTruocKhiLuu("MaChucVu") == true &&
                kiemTraTruocKhiLuu("TenChucVu") == true)
            {
                String tenCV = txtTenChucVu.Text;
                String maCV = txtMaChucVu.Text;
                String sql = String.Format("UPDATE CHUCVU " +
                    "SET TenChucVu=N'{0}' WHERE MaChucVu='{1}'", tenCV, maCV);
                connectionData.runQuery(sql);
                refreshData();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            String maCV = dgvChucVu.Rows[dgvChucVu.SelectedRows[0].Index].Cells["MaChucVu"].Value.ToString();
            String sql1 = String.Format("DELETE FROM NHANVIEN WHERE MaChucVu = '{0}'", maCV);
            String sql2 = String.Format("DELETE FROM CHUCVU WHERE MaChucVu = '{0}'", maCV);
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
            String sql = "SELECT * FROM CHUCVU";
            dgvChucVu.DataSource = connectionData.getData(sql);
        }

        private void btnSaveNewJob_Click(object sender, EventArgs e)
        {
            if(txtTenChucVu.Text != "" &&
                txtMaChucVu.Text !="")
            {
                String tenCV = txtTenChucVu.Text;
                String maCV = txtMaChucVu.Text;
                String sql = String.Format("INSERT INTO CHUCVU VALUES" +
                    "('{0}',N'{1}')", maCV, tenCV);
                connectionData.runQuery(sql);
                refreshData();
            }
        }

        public Boolean kiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dgvChucVu.Rows)
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
