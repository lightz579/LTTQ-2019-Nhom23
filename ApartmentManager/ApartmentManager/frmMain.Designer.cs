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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmQuanTri = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLoaiNguoiDung = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNguoiDung = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNguoiDan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDichVu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDangKyDichVu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNgheNghiep = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDanToc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTonGiao = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChucVu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTraCuu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTraCuuNguoiDan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTraCuuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.tsbQuanLyNguoiDan = new System.Windows.Forms.ToolStripButton();
            this.tsbQuanLyNhanVien = new System.Windows.Forms.ToolStripButton();
            this.tsbQuanLyDichVu = new System.Windows.Forms.ToolStripButton();
            this.tsbDangKyDichVu = new System.Windows.Forms.ToolStripButton();
            this.tsbTraCuuNguoiDan = new System.Windows.Forms.ToolStripButton();
            this.tsbTraCuuNhanVien = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTraCuuNhanVien = new System.Windows.Forms.Button();
            this.btnTraCuuNguoiDan = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDangKyDichVu = new System.Windows.Forms.Button();
            this.btnQuanLyDichVu = new System.Windows.Forms.Button();
            this.btnQuanLyNhanVien = new System.Windows.Forms.Button();
            this.btnQuanLyNguoiDan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
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
            // tsmLoaiNguoiDung
            // 
            this.tsmLoaiNguoiDung.Image = global::ApartmentManager.Properties.Resources.nguoidung;
            this.tsmLoaiNguoiDung.Name = "tsmLoaiNguoiDung";
            this.tsmLoaiNguoiDung.Size = new System.Drawing.Size(164, 22);
            this.tsmLoaiNguoiDung.Text = "Loại Người Dùng";
            // 
            // tsmNguoiDung
            // 
            this.tsmNguoiDung.Image = global::ApartmentManager.Properties.Resources.nguoidung;
            this.tsmNguoiDung.Name = "tsmNguoiDung";
            this.tsmNguoiDung.Size = new System.Drawing.Size(164, 22);
            this.tsmNguoiDung.Text = "Người Dùng";
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
            // tsmTraCuu
            // 
            this.tsmTraCuu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTraCuuNguoiDan,
            this.tsmTraCuuNhanVien});
            this.tsmTraCuu.Name = "tsmTraCuu";
            this.tsmTraCuu.Size = new System.Drawing.Size(59, 20);
            this.tsmTraCuu.Text = "Tra Cứu";
            // 
            // tsmTraCuuNguoiDan
            // 
            this.tsmTraCuuNguoiDan.Image = global::ApartmentManager.Properties.Resources.TCGV;
            this.tsmTraCuuNguoiDan.Name = "tsmTraCuuNguoiDan";
            this.tsmTraCuuNguoiDan.Size = new System.Drawing.Size(174, 22);
            this.tsmTraCuuNguoiDan.Text = "Tra Cứu Người Dân";
            // 
            // tsmTraCuuNhanVien
            // 
            this.tsmTraCuuNhanVien.Image = global::ApartmentManager.Properties.Resources.TCHS;
            this.tsmTraCuuNhanVien.Name = "tsmTraCuuNhanVien";
            this.tsmTraCuuNhanVien.Size = new System.Drawing.Size(174, 22);
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
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbQuanLyNguoiDan,
            this.tsbQuanLyNhanVien,
            this.tsbQuanLyDichVu,
            this.tsbDangKyDichVu,
            this.tsbTraCuuNguoiDan,
            this.tsbTraCuuNhanVien});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 24);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(800, 55);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // tsbQuanLyNguoiDan
            // 
            this.tsbQuanLyNguoiDan.AutoSize = false;
            this.tsbQuanLyNguoiDan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbQuanLyNguoiDan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbQuanLyNguoiDan.Image = ((System.Drawing.Image)(resources.GetObject("tsbQuanLyNguoiDan.Image")));
            this.tsbQuanLyNguoiDan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbQuanLyNguoiDan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQuanLyNguoiDan.Name = "tsbQuanLyNguoiDan";
            this.tsbQuanLyNguoiDan.Size = new System.Drawing.Size(52, 52);
            this.tsbQuanLyNguoiDan.Text = "toolStripButton1";
            // 
            // tsbQuanLyNhanVien
            // 
            this.tsbQuanLyNhanVien.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbQuanLyNhanVien.Image = global::ApartmentManager.Properties.Resources.NhanVien1;
            this.tsbQuanLyNhanVien.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbQuanLyNhanVien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQuanLyNhanVien.Name = "tsbQuanLyNhanVien";
            this.tsbQuanLyNhanVien.Size = new System.Drawing.Size(52, 52);
            this.tsbQuanLyNhanVien.Text = "toolStripButton2";
            // 
            // tsbQuanLyDichVu
            // 
            this.tsbQuanLyDichVu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbQuanLyDichVu.Image = global::ApartmentManager.Properties.Resources.DichVu1;
            this.tsbQuanLyDichVu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbQuanLyDichVu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQuanLyDichVu.Name = "tsbQuanLyDichVu";
            this.tsbQuanLyDichVu.Size = new System.Drawing.Size(52, 52);
            this.tsbQuanLyDichVu.Text = "toolStripButton3";
            // 
            // tsbDangKyDichVu
            // 
            this.tsbDangKyDichVu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDangKyDichVu.Image = global::ApartmentManager.Properties.Resources.DangKyDichVu;
            this.tsbDangKyDichVu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbDangKyDichVu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDangKyDichVu.Name = "tsbDangKyDichVu";
            this.tsbDangKyDichVu.Size = new System.Drawing.Size(52, 52);
            this.tsbDangKyDichVu.Text = "toolStripButton4";
            // 
            // tsbTraCuuNguoiDan
            // 
            this.tsbTraCuuNguoiDan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTraCuuNguoiDan.Image = global::ApartmentManager.Properties.Resources.TraCuuNguoiDan1;
            this.tsbTraCuuNguoiDan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbTraCuuNguoiDan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTraCuuNguoiDan.Name = "tsbTraCuuNguoiDan";
            this.tsbTraCuuNguoiDan.Size = new System.Drawing.Size(52, 52);
            this.tsbTraCuuNguoiDan.Text = "toolStripButton5";
            // 
            // tsbTraCuuNhanVien
            // 
            this.tsbTraCuuNhanVien.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTraCuuNhanVien.Image = global::ApartmentManager.Properties.Resources.TraCuuNhanVien;
            this.tsbTraCuuNhanVien.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbTraCuuNhanVien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTraCuuNhanVien.Name = "tsbTraCuuNhanVien";
            this.tsbTraCuuNhanVien.Size = new System.Drawing.Size(52, 52);
            this.tsbTraCuuNhanVien.Text = "toolStripButton6";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 509);
            this.panel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.btnTraCuuNhanVien);
            this.panel4.Controls.Add(this.btnTraCuuNguoiDan);
            this.panel4.Location = new System.Drawing.Point(13, 364);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(173, 126);
            this.panel4.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "TRA CỨU";
            // 
            // btnTraCuuNhanVien
            // 
            this.btnTraCuuNhanVien.Location = new System.Drawing.Point(19, 84);
            this.btnTraCuuNhanVien.Name = "btnTraCuuNhanVien";
            this.btnTraCuuNhanVien.Size = new System.Drawing.Size(132, 38);
            this.btnTraCuuNhanVien.TabIndex = 0;
            this.btnTraCuuNhanVien.Text = "Nhân Viên";
            this.btnTraCuuNhanVien.UseVisualStyleBackColor = true;
            this.btnTraCuuNhanVien.Click += new System.EventHandler(this.btnTraCuuNhanVien_Click);
            // 
            // btnTraCuuNguoiDan
            // 
            this.btnTraCuuNguoiDan.Location = new System.Drawing.Point(19, 43);
            this.btnTraCuuNguoiDan.Name = "btnTraCuuNguoiDan";
            this.btnTraCuuNguoiDan.Size = new System.Drawing.Size(132, 38);
            this.btnTraCuuNguoiDan.TabIndex = 0;
            this.btnTraCuuNguoiDan.Text = "Người Dân";
            this.btnTraCuuNguoiDan.UseVisualStyleBackColor = true;
            this.btnTraCuuNguoiDan.Click += new System.EventHandler(this.btnTraCuuNguoiDan_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnDangKyDichVu);
            this.panel3.Controls.Add(this.btnQuanLyDichVu);
            this.panel3.Controls.Add(this.btnQuanLyNhanVien);
            this.panel3.Controls.Add(this.btnQuanLyNguoiDan);
            this.panel3.Location = new System.Drawing.Point(13, 131);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(173, 207);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "QUẢN LÝ";
            // 
            // btnDangKyDichVu
            // 
            this.btnDangKyDichVu.Location = new System.Drawing.Point(19, 164);
            this.btnDangKyDichVu.Name = "btnDangKyDichVu";
            this.btnDangKyDichVu.Size = new System.Drawing.Size(132, 35);
            this.btnDangKyDichVu.TabIndex = 0;
            this.btnDangKyDichVu.Text = "Đăng Ký Dịch Vụ";
            this.btnDangKyDichVu.UseVisualStyleBackColor = true;
            this.btnDangKyDichVu.Click += new System.EventHandler(this.btnDangKyDichVu_Click);
            // 
            // btnQuanLyDichVu
            // 
            this.btnQuanLyDichVu.Location = new System.Drawing.Point(19, 125);
            this.btnQuanLyDichVu.Name = "btnQuanLyDichVu";
            this.btnQuanLyDichVu.Size = new System.Drawing.Size(132, 35);
            this.btnQuanLyDichVu.TabIndex = 0;
            this.btnQuanLyDichVu.Text = "Quản Lý Dịch Vụ";
            this.btnQuanLyDichVu.UseVisualStyleBackColor = true;
            this.btnQuanLyDichVu.Click += new System.EventHandler(this.btnQuanLyDichVu_Click);
            // 
            // btnQuanLyNhanVien
            // 
            this.btnQuanLyNhanVien.Location = new System.Drawing.Point(19, 86);
            this.btnQuanLyNhanVien.Name = "btnQuanLyNhanVien";
            this.btnQuanLyNhanVien.Size = new System.Drawing.Size(132, 35);
            this.btnQuanLyNhanVien.TabIndex = 0;
            this.btnQuanLyNhanVien.Text = "Quản Lý Nhân Viên";
            this.btnQuanLyNhanVien.UseVisualStyleBackColor = true;
            this.btnQuanLyNhanVien.Click += new System.EventHandler(this.btnQuanLyNhanVien_Click);
            // 
            // btnQuanLyNguoiDan
            // 
            this.btnQuanLyNguoiDan.Location = new System.Drawing.Point(19, 46);
            this.btnQuanLyNguoiDan.Name = "btnQuanLyNguoiDan";
            this.btnQuanLyNguoiDan.Size = new System.Drawing.Size(132, 35);
            this.btnQuanLyNguoiDan.TabIndex = 0;
            this.btnQuanLyNguoiDan.Text = "Quản Lý Người Dân";
            this.btnQuanLyNguoiDan.UseVisualStyleBackColor = true;
            this.btnQuanLyNguoiDan.Click += new System.EventHandler(this.btnQuanLyNguoiDan_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(13, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 101);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 603);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "QUẢN LÝ CHUNG CU";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton tsbQuanLyNguoiDan;
        private System.Windows.Forms.ToolStripButton tsbQuanLyNhanVien;
        private System.Windows.Forms.ToolStripButton tsbQuanLyDichVu;
        private System.Windows.Forms.ToolStripButton tsbDangKyDichVu;
        private System.Windows.Forms.ToolStripButton tsbTraCuuNguoiDan;
        private System.Windows.Forms.ToolStripButton tsbTraCuuNhanVien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnTraCuuNhanVien;
        private System.Windows.Forms.Button btnTraCuuNguoiDan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDangKyDichVu;
        private System.Windows.Forms.Button btnQuanLyDichVu;
        private System.Windows.Forms.Button btnQuanLyNhanVien;
        private System.Windows.Forms.Button btnQuanLyNguoiDan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}