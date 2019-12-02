namespace ApartmentManager
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmQuanTri = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTraCuu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLoaiNguoiDung = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNguoiDung = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNguoiDan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDichVu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDangKyDichVu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNgheNghiep = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDanToc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTonGiao = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChucVu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTraCuuNguoiDan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTraCuuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmQuanTri,
            this.tsmQuanLy,
            this.tsmTraCuu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmQuanTri
            // 
            this.tsmQuanTri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLoaiNguoiDung,
            this.tsmNguoiDung});
            this.tsmQuanTri.Name = "tsmQuanTri";
            this.tsmQuanTri.Size = new System.Drawing.Size(62, 20);
            this.tsmQuanTri.Text = "Quản trị";
            // 
            // tsmQuanLy
            // 
            this.tsmQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNguoiDan,
            this.tsmNhanVien,
            this.tsmDichVu,
            this.tsmDangKyDichVu,
            this.tsmNgheNghiep,
            this.tsmDanToc,
            this.tsmTonGiao,
            this.tsmChucVu});
            this.tsmQuanLy.Name = "tsmQuanLy";
            this.tsmQuanLy.Size = new System.Drawing.Size(60, 20);
            this.tsmQuanLy.Text = "Quản lý";
            // 
            // tsmTraCuu
            // 
            this.tsmTraCuu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTraCuuNguoiDan,
            this.tsmTraCuuNhanVien});
            this.tsmTraCuu.Name = "tsmTraCuu";
            this.tsmTraCuu.Size = new System.Drawing.Size(59, 20);
            this.tsmTraCuu.Text = "Tra Cứu";
            // 
            // tsmLoaiNguoiDung
            // 
            this.tsmLoaiNguoiDung.Image = global::ApartmentManager.Properties.Resources.nguoidung;
            this.tsmLoaiNguoiDung.Name = "tsmLoaiNguoiDung";
            this.tsmLoaiNguoiDung.Size = new System.Drawing.Size(180, 22);
            this.tsmLoaiNguoiDung.Text = "Loại Người Dùng";
            // 
            // tsmNguoiDung
            // 
            this.tsmNguoiDung.Image = global::ApartmentManager.Properties.Resources.nguoidung;
            this.tsmNguoiDung.Name = "tsmNguoiDung";
            this.tsmNguoiDung.Size = new System.Drawing.Size(180, 22);
            this.tsmNguoiDung.Text = "Người Dùng";
            // 
            // tsmNguoiDan
            // 
            this.tsmNguoiDan.Image = global::ApartmentManager.Properties.Resources.NguoiDan1;
            this.tsmNguoiDan.Name = "tsmNguoiDan";
            this.tsmNguoiDan.Size = new System.Drawing.Size(161, 22);
            this.tsmNguoiDan.Text = "Người Dân";
            // 
            // tsmNhanVien
            // 
            this.tsmNhanVien.Image = global::ApartmentManager.Properties.Resources.NhanVien1;
            this.tsmNhanVien.Name = "tsmNhanVien";
            this.tsmNhanVien.Size = new System.Drawing.Size(161, 22);
            this.tsmNhanVien.Text = "Nhân Viên";
            // 
            // tsmDichVu
            // 
            this.tsmDichVu.Image = global::ApartmentManager.Properties.Resources.DichVu;
            this.tsmDichVu.Name = "tsmDichVu";
            this.tsmDichVu.Size = new System.Drawing.Size(161, 22);
            this.tsmDichVu.Text = "Dịch Vụ";
            // 
            // tsmDangKyDichVu
            // 
            this.tsmDangKyDichVu.Image = global::ApartmentManager.Properties.Resources.DangKyDichVu;
            this.tsmDangKyDichVu.Name = "tsmDangKyDichVu";
            this.tsmDangKyDichVu.Size = new System.Drawing.Size(161, 22);
            this.tsmDangKyDichVu.Text = "Đăng Ký Dịch Vụ";
            // 
            // tsmNgheNghiep
            // 
            this.tsmNgheNghiep.Image = global::ApartmentManager.Properties.Resources.NgheNghiep2;
            this.tsmNgheNghiep.Name = "tsmNgheNghiep";
            this.tsmNgheNghiep.Size = new System.Drawing.Size(161, 22);
            this.tsmNgheNghiep.Text = "Nghề Nghiệp";
            // 
            // tsmDanToc
            // 
            this.tsmDanToc.Image = global::ApartmentManager.Properties.Resources.dantoc1;
            this.tsmDanToc.Name = "tsmDanToc";
            this.tsmDanToc.Size = new System.Drawing.Size(161, 22);
            this.tsmDanToc.Text = "Dân Tộc";
            // 
            // tsmTonGiao
            // 
            this.tsmTonGiao.Image = global::ApartmentManager.Properties.Resources.tongiao;
            this.tsmTonGiao.Name = "tsmTonGiao";
            this.tsmTonGiao.Size = new System.Drawing.Size(161, 22);
            this.tsmTonGiao.Text = "Tôn Giáo";
            // 
            // tsmChucVu
            // 
            this.tsmChucVu.Image = global::ApartmentManager.Properties.Resources.nghenghiep1;
            this.tsmChucVu.Name = "tsmChucVu";
            this.tsmChucVu.Size = new System.Drawing.Size(161, 22);
            this.tsmChucVu.Text = "Chức vụ";
            // 
            // tsmTraCuuNguoiDan
            // 
            this.tsmTraCuuNguoiDan.Image = global::ApartmentManager.Properties.Resources.TCGV;
            this.tsmTraCuuNguoiDan.Name = "tsmTraCuuNguoiDan";
            this.tsmTraCuuNguoiDan.Size = new System.Drawing.Size(180, 22);
            this.tsmTraCuuNguoiDan.Text = "Tra Cứu Người Dân";
            // 
            // tsmTraCuuNhanVien
            // 
            this.tsmTraCuuNhanVien.Image = global::ApartmentManager.Properties.Resources.TCHS;
            this.tsmTraCuuNhanVien.Name = "tsmTraCuuNhanVien";
            this.tsmTraCuuNhanVien.Size = new System.Drawing.Size(180, 22);
            this.tsmTraCuuNhanVien.Text = "Tra Cứu Nhân Viên";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 24);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(800, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "QUẢN LÝ CHUNG CU";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmQuanTri;
        private System.Windows.Forms.ToolStripMenuItem tsmLoaiNguoiDung;
        private System.Windows.Forms.ToolStripMenuItem tsmNguoiDung;
        private System.Windows.Forms.ToolStripMenuItem tsmQuanLy;
        private System.Windows.Forms.ToolStripMenuItem tsmNguoiDan;
        private System.Windows.Forms.ToolStripMenuItem tsmNhanVien;
        private System.Windows.Forms.ToolStripMenuItem tsmDichVu;
        private System.Windows.Forms.ToolStripMenuItem tsmDangKyDichVu;
        private System.Windows.Forms.ToolStripMenuItem tsmNgheNghiep;
        private System.Windows.Forms.ToolStripMenuItem tsmDanToc;
        private System.Windows.Forms.ToolStripMenuItem tsmTonGiao;
        private System.Windows.Forms.ToolStripMenuItem tsmChucVu;
        private System.Windows.Forms.ToolStripMenuItem tsmTraCuu;
        private System.Windows.Forms.ToolStripMenuItem tsmTraCuuNguoiDan;
        private System.Windows.Forms.ToolStripMenuItem tsmTraCuuNhanVien;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
    }
}