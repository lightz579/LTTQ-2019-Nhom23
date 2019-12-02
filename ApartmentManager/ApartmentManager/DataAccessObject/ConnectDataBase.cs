using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManager.DataAccessObject
{
    class ConnectDataBase
    {
        String conStr = @"Data Source=LIGHTZ;Initial Catalog=DepartmentManager;User ID=sa;Password=0368664604a";
        SqlConnection sqlConnection;

        public ConnectDataBase()
        {
            sqlConnection = new SqlConnection(conStr);
        }

        public DataTable getData(String sql)
        {
            SqlDataAdapter myDa = new SqlDataAdapter(sql, sqlConnection);
            DataTable myDt = new DataTable();
            myDa.Fill(myDt);
            return myDt;
        }
        
        public void runQuery(String sql)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void LuuNhanVien(String maNV, String tenNV, int gioiTinh, String ngaySinh, 
            String diaChi, String dienThoai, String maChucVu)
        {
            String sql = String.Format("INSERT INTO NHANVIEN VALUES('{0}', N'{1}', {2}, '{3}', " +
                "N'{4}', '{5}', '{6}')", maNV, tenNV, gioiTinh, ngaySinh, diaChi, dienThoai, maChucVu);
            runQuery(sql);
        }
    }
}
