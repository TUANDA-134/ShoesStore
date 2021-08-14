
namespace ShoesStoreManagement.UI.UI_Customer
{
    partial class FormAddKhachHang
    {
        public static int pnlShowWidth, pnlShowHeight;
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbxKhachHangMoi = new System.Windows.Forms.GroupBox();
            this.dtprNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.tbxSoDienThoai = new System.Windows.Forms.TextBox();
            this.rbtnNu = new System.Windows.Forms.RadioButton();
            this.rbtnNam = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblHoVaTen = new System.Windows.Forms.Label();
            this.tbxHoVaTen = new System.Windows.Forms.TextBox();
            this.lblMaKhachHang = new System.Windows.Forms.Label();
            this.tbxMaKhachHang = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExitScreen = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.gbxKhachHangMoi.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbxKhachHangMoi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 775);
            this.panel1.TabIndex = 0;
            // 
            // gbxKhachHangMoi
            // 
            this.gbxKhachHangMoi.Controls.Add(this.dtprNgaySinh);
            this.gbxKhachHangMoi.Controls.Add(this.btnCancel);
            this.gbxKhachHangMoi.Controls.Add(this.btnOk);
            this.gbxKhachHangMoi.Controls.Add(this.lblSoDienThoai);
            this.gbxKhachHangMoi.Controls.Add(this.tbxSoDienThoai);
            this.gbxKhachHangMoi.Controls.Add(this.rbtnNu);
            this.gbxKhachHangMoi.Controls.Add(this.rbtnNam);
            this.gbxKhachHangMoi.Controls.Add(this.lblGender);
            this.gbxKhachHangMoi.Controls.Add(this.lblNgaySinh);
            this.gbxKhachHangMoi.Controls.Add(this.lblHoVaTen);
            this.gbxKhachHangMoi.Controls.Add(this.tbxHoVaTen);
            this.gbxKhachHangMoi.Controls.Add(this.lblMaKhachHang);
            this.gbxKhachHangMoi.Controls.Add(this.tbxMaKhachHang);
            this.gbxKhachHangMoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxKhachHangMoi.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxKhachHangMoi.Location = new System.Drawing.Point(0, 0);
            this.gbxKhachHangMoi.Name = "gbxKhachHangMoi";
            this.gbxKhachHangMoi.Size = new System.Drawing.Size(894, 775);
            this.gbxKhachHangMoi.TabIndex = 0;
            this.gbxKhachHangMoi.TabStop = false;
            this.gbxKhachHangMoi.Text = "THÔNG TIN KHÁCH HÀNG MỚI";
            // 
            // dtprNgaySinh
            // 
            this.dtprNgaySinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtprNgaySinh.Font = new System.Drawing.Font("Times New Roman", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtprNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtprNgaySinh.Location = new System.Drawing.Point(397, 361);
            this.dtprNgaySinh.Name = "dtprNgaySinh";
            this.dtprNgaySinh.Size = new System.Drawing.Size(408, 75);
            this.dtprNgaySinh.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(513, 697);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 50);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOk.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(223, 697);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(130, 50);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Thêm";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDienThoai.Location = new System.Drawing.Point(85, 471);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(167, 31);
            this.lblSoDienThoai.TabIndex = 11;
            this.lblSoDienThoai.Text = "Số điện thoại";
            // 
            // tbxSoDienThoai
            // 
            this.tbxSoDienThoai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxSoDienThoai.BackColor = System.Drawing.Color.White;
            this.tbxSoDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxSoDienThoai.Font = new System.Drawing.Font("Times New Roman", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSoDienThoai.Location = new System.Drawing.Point(397, 471);
            this.tbxSoDienThoai.Multiline = true;
            this.tbxSoDienThoai.Name = "tbxSoDienThoai";
            this.tbxSoDienThoai.Size = new System.Drawing.Size(408, 40);
            this.tbxSoDienThoai.TabIndex = 3;
            // 
            // rbtnNu
            // 
            this.rbtnNu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnNu.AutoSize = true;
            this.rbtnNu.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNu.Location = new System.Drawing.Point(646, 581);
            this.rbtnNu.Name = "rbtnNu";
            this.rbtnNu.Size = new System.Drawing.Size(79, 35);
            this.rbtnNu.TabIndex = 5;
            this.rbtnNu.TabStop = true;
            this.rbtnNu.Text = "Nữ";
            this.rbtnNu.UseVisualStyleBackColor = true;
            // 
            // rbtnNam
            // 
            this.rbtnNam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnNam.AutoSize = true;
            this.rbtnNam.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNam.Location = new System.Drawing.Point(397, 581);
            this.rbtnNam.Name = "rbtnNam";
            this.rbtnNam.Size = new System.Drawing.Size(96, 35);
            this.rbtnNam.TabIndex = 4;
            this.rbtnNam.TabStop = true;
            this.rbtnNam.Text = "Nam";
            this.rbtnNam.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(85, 581);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(120, 31);
            this.lblGender.TabIndex = 12;
            this.lblGender.Text = "Giới tính";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(85, 361);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(130, 31);
            this.lblNgaySinh.TabIndex = 10;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblHoVaTen
            // 
            this.lblHoVaTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHoVaTen.AutoSize = true;
            this.lblHoVaTen.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoVaTen.Location = new System.Drawing.Point(85, 251);
            this.lblHoVaTen.Name = "lblHoVaTen";
            this.lblHoVaTen.Size = new System.Drawing.Size(127, 31);
            this.lblHoVaTen.TabIndex = 9;
            this.lblHoVaTen.Text = "Họ và tên";
            // 
            // tbxHoVaTen
            // 
            this.tbxHoVaTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxHoVaTen.BackColor = System.Drawing.Color.White;
            this.tbxHoVaTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxHoVaTen.Font = new System.Drawing.Font("Times New Roman", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHoVaTen.Location = new System.Drawing.Point(397, 251);
            this.tbxHoVaTen.Multiline = true;
            this.tbxHoVaTen.Name = "tbxHoVaTen";
            this.tbxHoVaTen.Size = new System.Drawing.Size(408, 40);
            this.tbxHoVaTen.TabIndex = 1;
            // 
            // lblMaKhachHang
            // 
            this.lblMaKhachHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMaKhachHang.AutoSize = true;
            this.lblMaKhachHang.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKhachHang.Location = new System.Drawing.Point(85, 141);
            this.lblMaKhachHang.Name = "lblMaKhachHang";
            this.lblMaKhachHang.Size = new System.Drawing.Size(195, 31);
            this.lblMaKhachHang.TabIndex = 8;
            this.lblMaKhachHang.Text = "Mã khách hàng";
            // 
            // tbxMaKhachHang
            // 
            this.tbxMaKhachHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxMaKhachHang.BackColor = System.Drawing.Color.White;
            this.tbxMaKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxMaKhachHang.Font = new System.Drawing.Font("Times New Roman", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMaKhachHang.Location = new System.Drawing.Point(397, 141);
            this.tbxMaKhachHang.Multiline = true;
            this.tbxMaKhachHang.Name = "tbxMaKhachHang";
            this.tbxMaKhachHang.Size = new System.Drawing.Size(408, 40);
            this.tbxMaKhachHang.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 839);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel2.Controls.Add(this.btnExitScreen);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(894, 52);
            this.panel2.TabIndex = 0;
            // 
            // btnExitScreen
            // 
            this.btnExitScreen.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExitScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitScreen.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnExitScreen.IconColor = System.Drawing.Color.CornflowerBlue;
            this.btnExitScreen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExitScreen.Location = new System.Drawing.Point(854, 0);
            this.btnExitScreen.Margin = new System.Windows.Forms.Padding(2);
            this.btnExitScreen.Name = "btnExitScreen";
            this.btnExitScreen.Size = new System.Drawing.Size(40, 52);
            this.btnExitScreen.TabIndex = 0;
            this.btnExitScreen.UseVisualStyleBackColor = true;
            this.btnExitScreen.Click += new System.EventHandler(this.btnExitScreen_Click);
            // 
            // FormAddKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(900, 839);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddKhachHang";
            this.SizeChanged += new System.EventHandler(this.FormAddKhachHang_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.gbxKhachHangMoi.ResumeLayout(false);
            this.gbxKhachHangMoi.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbxKhachHangMoi;
        private System.Windows.Forms.DateTimePicker dtprNgaySinh;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.TextBox tbxSoDienThoai;
        private System.Windows.Forms.RadioButton rbtnNu;
        private System.Windows.Forms.RadioButton rbtnNam;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblHoVaTen;
        private System.Windows.Forms.TextBox tbxHoVaTen;
        private System.Windows.Forms.Label lblMaKhachHang;
        private System.Windows.Forms.TextBox tbxMaKhachHang;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnExitScreen;
    }
}