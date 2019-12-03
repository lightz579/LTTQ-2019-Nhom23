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
    public partial class frmDangKyDichVu : Form
    {
        DataAccessObject.ConnectDataBase connectData = new DataAccessObject.ConnectDataBase();

        public frmDangKyDichVu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtMaCanHo.Text != "" ||
                txtTenNguoiDan.Text != "" ||
                cboMaDichVu.Text != "")
            {
                String maCH = txtMaCanHo.Text;
                String tenND = txtTenNguoiDan.Text;
                String tenDV = cboMaDichVu.Text;
                dgvDangKyDichVu.DataSource = timKiem(maCH, tenND, tenDV);
                if(dgvDangKyDichVu.RowCount == 0)
                {
                    MessageBox.Show("Không tìm thấy căn hộ như trên");
                }
            }
            else
            {
                MessageBox.Show("Không tìm kiếm được khi bạn để trống thông tin");
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if(cboCanHo.Text != "" && cboDichVu.Text != "")
            {
                String maCH = cboCanHo.SelectedValue.ToString();
                String maDV = cboDichVu.SelectedValue.ToString();
                if(luuDangKyDichVu(maCH, maDV))
                {
                    MessageBox.Show("Đăng ký thành công");
                }
                else
                {
                    MessageBox.Show("Đăng ký không thành công");
                }
            }
            else
            {
                MessageBox.Show("Không được để trống thông tin");
            }
        }

        private void frmDangKyDichVu_Load(object sender, EventArgs e)
        {
            loadComboBox();
        }

        private void refreshData()
        {
            String sql = "SELECT * FROM CANHO";
            dgvDangKyDichVu.DataSource = connectData.getData(sql);
        }

        private void loadComboBox()
        {
            String sql1 = "SELECT * FROM CANHO";
            cboCanHo.DataSource = connectData.getData(sql1);
            cboCanHo.DisplayMember = "MaCanHo";
            cboCanHo.ValueMember = "MaCanHo";

            String sql2 = "SELECT * FROM DICHVU";
            cboDichVu.DataSource = connectData.getData(sql2);
            cboDichVu.DisplayMember = "TenDichVu";
            cboDichVu.ValueMember = "MaDichVu";

            cboMaDichVu.DataSource = connectData.getData(sql2);
            cboMaDichVu.DisplayMember = "TenDichVu";
            cboMaDichVu.ValueMember = "MaDichVu";
            
        }

        public Boolean luuDangKyDichVu(String maCH, String maDV)
        {
            String sql = String.Format("INSERT INTO CANHO_DICHVU VALUES('{0}','{1}')", maCH, maDV);
            try
            {
                connectData.runQuery(sql);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private String truyVanChung()
        {
            return "SELECT CH.MaCanHo,ND.TenNguoiDan, CH.TangLau, CH.SoNguoi, CH.TongPhiDichVu, DV.TenDichVu " +
                   "FROM CANHO CH LEFT OUTER JOIN CANHO_NGUOIDAN CH_ND ON CH.MaCanHo = CH_ND.MaCanHo " +
                   "LEFT OUTER JOIN NGUOIDAN ND ON ND.MaNguoiDan = CH_ND.MaNguoiDan " +
                   "LEFT OUTER JOIN CANHO_DICHVU CH_DV ON CH.MaCanHo = CH_DV.MaCanHo " +
                   "LEFT OUTER JOIN DICHVU DV ON CH_DV.MaDichVu = DV.MaDichVu";
        }

        private DataTable timKiem(String maCH, String tenND, String tenDV)
        {
            String sql = "";
            sql +=  truyVanChung() + " WHERE ND.TenNguoiDan LIKE N'%" + tenND + "%' ";
            sql += " AND CH.MaCanHo LIKE '%" + maCH + "%'";
            sql += " AND DV.TenDichVu LIKE N'%" + tenDV + "%'";
            return connectData.getData(sql);
        }

        
    }
}
