
namespace ShoesStoreManagement.UI
{
    partial class Mainform
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
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnKhachHang = new FontAwesome.Sharp.IconButton();
            this.btnThongKe = new FontAwesome.Sharp.IconButton();
            this.btnSanPham = new FontAwesome.Sharp.IconButton();
            this.btnNhanVien = new FontAwesome.Sharp.IconButton();
            this.btnTaiKhoan = new FontAwesome.Sharp.IconButton();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.tlplTop = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tlplThongTinTaiKhoanTong = new System.Windows.Forms.TableLayoutPanel();
            this.tlplThongTin = new System.Windows.Forms.TableLayoutPanel();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.pbxAnh = new System.Windows.Forms.PictureBox();
            this.tlplButtonTop = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinScreen = new FontAwesome.Sharp.IconButton();
            this.btnMaxScreen = new FontAwesome.Sharp.IconButton();
            this.btnExitScreen = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.pnlShadow = new System.Windows.Forms.Panel();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.pnlShow = new System.Windows.Forms.Panel();
            this.pbxMenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.pnl1.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.pnlTitle.SuspendLayout();
            this.tlplTop.SuspendLayout();
            this.tlplThongTinTaiKhoanTong.SuspendLayout();
            this.tlplThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAnh)).BeginInit();
            this.tlplButtonTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlShadow.SuspendLayout();
            this.pnlDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnl1.Controls.Add(this.pnlMenu);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl1.Location = new System.Drawing.Point(0, 0);
            this.pnl1.Margin = new System.Windows.Forms.Padding(2);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(292, 1100);
            this.pnl1.TabIndex = 0;
            // 
            // pnlMenu
            // 
            this.pnlMenu.AutoSize = true;
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.pnlMenu.Controls.Add(this.pbxLogo);
            this.pnlMenu.Controls.Add(this.btnKhachHang);
            this.pnlMenu.Controls.Add(this.btnThongKe);
            this.pnlMenu.Controls.Add(this.btnSanPham);
            this.pnlMenu.Controls.Add(this.btnNhanVien);
            this.pnlMenu.Controls.Add(this.btnTaiKhoan);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(294, 1100);
            this.pnlMenu.TabIndex = 0;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::ShoesStoreManagement.Properties.Resources.Logo_1;
            this.pbxLogo.Location = new System.Drawing.Point(2, 0);
            this.pbxLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(290, 244);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 2;
            this.pbxLogo.TabStop = false;
            this.pbxLogo.Click += new System.EventHandler(this.pbxLogo_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnKhachHang.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnKhachHang.IconColor = System.Drawing.Color.White;
            this.btnKhachHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.Location = new System.Drawing.Point(0, 300);
            this.btnKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Padding = new System.Windows.Forms.Padding(8, 5, 0, 0);
            this.btnKhachHang.Size = new System.Drawing.Size(292, 73);
            this.btnKhachHang.TabIndex = 0;
            this.btnKhachHang.Text = "Khách Hàng";
            this.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnThongKe.IconColor = System.Drawing.Color.White;
            this.btnThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(0, 691);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(8, 5, 0, 0);
            this.btnThongKe.Size = new System.Drawing.Size(292, 73);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnSanPham
            // 
            this.btnSanPham.FlatAppearance.BorderSize = 0;
            this.btnSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanPham.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanPham.ForeColor = System.Drawing.Color.White;
            this.btnSanPham.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnSanPham.IconColor = System.Drawing.Color.White;
            this.btnSanPham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSanPham.Location = new System.Drawing.Point(0, 430);
            this.btnSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Padding = new System.Windows.Forms.Padding(8, 5, 0, 0);
            this.btnSanPham.Size = new System.Drawing.Size(292, 73);
            this.btnSanPham.TabIndex = 1;
            this.btnSanPham.Text = "Sản Phẩm";
            this.btnSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSanPham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSanPham.UseVisualStyleBackColor = true;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.btnNhanVien.IconColor = System.Drawing.Color.White;
            this.btnNhanVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(0, 559);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Padding = new System.Windows.Forms.Padding(8, 5, 0, 0);
            this.btnNhanVien.Size = new System.Drawing.Size(292, 73);
            this.btnNhanVien.TabIndex = 2;
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnTaiKhoan.IconChar = FontAwesome.Sharp.IconChar.HouseUser;
            this.btnTaiKhoan.IconColor = System.Drawing.Color.White;
            this.btnTaiKhoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.Location = new System.Drawing.Point(0, 820);
            this.btnTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Padding = new System.Windows.Forms.Padding(8, 5, 0, 0);
            this.btnTaiKhoan.Size = new System.Drawing.Size(292, 73);
            this.btnTaiKhoan.TabIndex = 4;
            this.btnTaiKhoan.Text = "Tài Khoản";
            this.btnTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.pnlTitle.Controls.Add(this.tlplTop);
            this.pnlTitle.Controls.Add(this.btnHome);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1508, 155);
            this.pnlTitle.TabIndex = 1;
            this.pnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            // 
            // tlplTop
            // 
            this.tlplTop.ColumnCount = 3;
            this.tlplTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.54902F));
            this.tlplTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.45098F));
            this.tlplTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 234F));
            this.tlplTop.Controls.Add(this.lblTitle, 1, 0);
            this.tlplTop.Controls.Add(this.tlplThongTinTaiKhoanTong, 0, 0);
            this.tlplTop.Controls.Add(this.tlplButtonTop, 2, 0);
            this.tlplTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlplTop.Location = new System.Drawing.Point(0, 0);
            this.tlplTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tlplTop.Name = "tlplTop";
            this.tlplTop.RowCount = 1;
            this.tlplTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlplTop.Size = new System.Drawing.Size(1508, 155);
            this.tlplTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(722, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(549, 155);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Home     ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlplThongTinTaiKhoanTong
            // 
            this.tlplThongTinTaiKhoanTong.ColumnCount = 2;
            this.tlplThongTinTaiKhoanTong.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlplThongTinTaiKhoanTong.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlplThongTinTaiKhoanTong.Controls.Add(this.tlplThongTin, 1, 0);
            this.tlplThongTinTaiKhoanTong.Controls.Add(this.pbxAnh, 0, 0);
            this.tlplThongTinTaiKhoanTong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlplThongTinTaiKhoanTong.Location = new System.Drawing.Point(4, 5);
            this.tlplThongTinTaiKhoanTong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tlplThongTinTaiKhoanTong.Name = "tlplThongTinTaiKhoanTong";
            this.tlplThongTinTaiKhoanTong.RowCount = 1;
            this.tlplThongTinTaiKhoanTong.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlplThongTinTaiKhoanTong.Size = new System.Drawing.Size(712, 145);
            this.tlplThongTinTaiKhoanTong.TabIndex = 2;
            // 
            // tlplThongTin
            // 
            this.tlplThongTin.ColumnCount = 1;
            this.tlplThongTin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlplThongTin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlplThongTin.Controls.Add(this.lblTen, 0, 0);
            this.tlplThongTin.Controls.Add(this.lblChucVu, 0, 1);
            this.tlplThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlplThongTin.Location = new System.Drawing.Point(154, 5);
            this.tlplThongTin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tlplThongTin.Name = "tlplThongTin";
            this.tlplThongTin.RowCount = 2;
            this.tlplThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.62963F));
            this.tlplThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.37037F));
            this.tlplThongTin.Size = new System.Drawing.Size(554, 135);
            this.tlplThongTin.TabIndex = 1;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTen.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.ForeColor = System.Drawing.Color.Aqua;
            this.lblTen.Location = new System.Drawing.Point(4, 0);
            this.lblTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(546, 67);
            this.lblTen.TabIndex = 1;
            this.lblTen.Text = " ";
            this.lblTen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChucVu.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucVu.ForeColor = System.Drawing.Color.Aqua;
            this.lblChucVu.Location = new System.Drawing.Point(4, 67);
            this.lblChucVu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(546, 68);
            this.lblChucVu.TabIndex = 0;
            this.lblChucVu.Text = " ";
            // 
            // pbxAnh
            // 
            this.pbxAnh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxAnh.Location = new System.Drawing.Point(4, 5);
            this.pbxAnh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbxAnh.Name = "pbxAnh";
            this.pbxAnh.Size = new System.Drawing.Size(142, 135);
            this.pbxAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAnh.TabIndex = 2;
            this.pbxAnh.TabStop = false;
            // 
            // tlplButtonTop
            // 
            this.tlplButtonTop.ColumnCount = 1;
            this.tlplButtonTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlplButtonTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlplButtonTop.Controls.Add(this.panel1, 0, 0);
            this.tlplButtonTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlplButtonTop.Location = new System.Drawing.Point(1277, 5);
            this.tlplButtonTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tlplButtonTop.Name = "tlplButtonTop";
            this.tlplButtonTop.RowCount = 2;
            this.tlplButtonTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.82759F));
            this.tlplButtonTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.17241F));
            this.tlplButtonTop.Size = new System.Drawing.Size(227, 145);
            this.tlplButtonTop.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMinScreen);
            this.panel1.Controls.Add(this.btnMaxScreen);
            this.panel1.Controls.Add(this.btnExitScreen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 55);
            this.panel1.TabIndex = 0;
            // 
            // btnMinScreen
            // 
            this.btnMinScreen.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinScreen.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinScreen.IconColor = System.Drawing.Color.CornflowerBlue;
            this.btnMinScreen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinScreen.Location = new System.Drawing.Point(18, 0);
            this.btnMinScreen.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinScreen.Name = "btnMinScreen";
            this.btnMinScreen.Size = new System.Drawing.Size(67, 55);
            this.btnMinScreen.TabIndex = 0;
            this.btnMinScreen.UseVisualStyleBackColor = true;
            this.btnMinScreen.Click += new System.EventHandler(this.btnMinScreen_Click);
            // 
            // btnMaxScreen
            // 
            this.btnMaxScreen.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaxScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxScreen.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaxScreen.IconColor = System.Drawing.Color.CornflowerBlue;
            this.btnMaxScreen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaxScreen.Location = new System.Drawing.Point(85, 0);
            this.btnMaxScreen.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaxScreen.Name = "btnMaxScreen";
            this.btnMaxScreen.Size = new System.Drawing.Size(67, 55);
            this.btnMaxScreen.TabIndex = 1;
            this.btnMaxScreen.UseVisualStyleBackColor = true;
            this.btnMaxScreen.Click += new System.EventHandler(this.btnMaxScreen_Click);
            // 
            // btnExitScreen
            // 
            this.btnExitScreen.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExitScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitScreen.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnExitScreen.IconColor = System.Drawing.Color.CornflowerBlue;
            this.btnExitScreen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExitScreen.Location = new System.Drawing.Point(152, 0);
            this.btnExitScreen.Margin = new System.Windows.Forms.Padding(2);
            this.btnExitScreen.Name = "btnExitScreen";
            this.btnExitScreen.Size = new System.Drawing.Size(67, 55);
            this.btnExitScreen.TabIndex = 2;
            this.btnExitScreen.UseVisualStyleBackColor = true;
            this.btnExitScreen.Click += new System.EventHandler(this.btnExitScreen_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.CornflowerBlue;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 60;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(286, 155);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // pnlShadow
            // 
            this.pnlShadow.BackColor = System.Drawing.Color.Black;
            this.pnlShadow.Controls.Add(this.pnlTitle);
            this.pnlShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlShadow.Location = new System.Drawing.Point(292, 0);
            this.pnlShadow.Margin = new System.Windows.Forms.Padding(2);
            this.pnlShadow.Name = "pnlShadow";
            this.pnlShadow.Size = new System.Drawing.Size(1508, 152);
            this.pnlShadow.TabIndex = 2;
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.BackColor = System.Drawing.Color.Ivory;
            this.pnlDesktop.Controls.Add(this.pnlShow);
            this.pnlDesktop.Controls.Add(this.pbxMenu);
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(292, 152);
            this.pnlDesktop.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(1508, 948);
            this.pnlDesktop.TabIndex = 3;
            // 
            // pnlShow
            // 
            this.pnlShow.BackColor = System.Drawing.Color.Ivory;
            this.pnlShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlShow.Location = new System.Drawing.Point(0, 0);
            this.pnlShow.Name = "pnlShow";
            this.pnlShow.Size = new System.Drawing.Size(1508, 948);
            this.pnlShow.TabIndex = 0;
            this.pnlShow.Visible = false;
            // 
            // pbxMenu
            // 
            this.pbxMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxMenu.Image = global::ShoesStoreManagement.Properties.Resources.River;
            this.pbxMenu.Location = new System.Drawing.Point(0, 0);
            this.pbxMenu.Name = "pbxMenu";
            this.pbxMenu.Size = new System.Drawing.Size(1508, 948);
            this.pbxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMenu.TabIndex = 0;
            this.pbxMenu.TabStop = false;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1800, 1100);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlShadow);
            this.Controls.Add(this.pnl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mainform";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.tlplTop.ResumeLayout(false);
            this.tlplTop.PerformLayout();
            this.tlplThongTinTaiKhoanTong.ResumeLayout(false);
            this.tlplThongTin.ResumeLayout(false);
            this.tlplThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAnh)).EndInit();
            this.tlplButtonTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlShadow.ResumeLayout(false);
            this.pnlDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Panel pnlMenu;
        private FontAwesome.Sharp.IconButton btnKhachHang;
        private FontAwesome.Sharp.IconButton btnSanPham;
        private FontAwesome.Sharp.IconButton btnThongKe;
        private FontAwesome.Sharp.IconButton btnNhanVien;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnTaiKhoan;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlShadow;
        private FontAwesome.Sharp.IconButton btnExitScreen;
        private FontAwesome.Sharp.IconButton btnMaxScreen;
        private FontAwesome.Sharp.IconButton btnMinScreen;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlDesktop;
        private System.Windows.Forms.PictureBox pbxMenu;
        private System.Windows.Forms.Panel pnlShow;
        private System.Windows.Forms.TableLayoutPanel tlplTop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tlplButtonTop;
        private System.Windows.Forms.TableLayoutPanel tlplThongTinTaiKhoanTong;
        private System.Windows.Forms.TableLayoutPanel tlplThongTin;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.PictureBox pbxAnh;
    }
}