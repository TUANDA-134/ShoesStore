
namespace ShoesStoreManagement.UI
{
    partial class FormKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXemThongTin = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cbxSapXep = new System.Windows.Forms.ComboBox();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.gbxXemThongTin = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblThongTinKhachHang = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.pnlMenu.SuspendLayout();
            this.gbxXemThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.AutoSize = true;
            this.btnCapNhat.BackColor = System.Drawing.Color.Transparent;
            this.btnCapNhat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCapNhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(608, 0);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(200, 35);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXemThongTin
            // 
            this.btnXemThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXemThongTin.AutoSize = true;
            this.btnXemThongTin.BackColor = System.Drawing.Color.Transparent;
            this.btnXemThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXemThongTin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemThongTin.ForeColor = System.Drawing.Color.White;
            this.btnXemThongTin.Location = new System.Drawing.Point(61, 116);
            this.btnXemThongTin.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnXemThongTin.Name = "btnXemThongTin";
            this.btnXemThongTin.Size = new System.Drawing.Size(73, 37);
            this.btnXemThongTin.TabIndex = 1;
            this.btnXemThongTin.Text = "Tìm";
            this.btnXemThongTin.UseVisualStyleBackColor = false;
            this.btnXemThongTin.Click += new System.EventHandler(this.btnXemThongTin_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("Times New Roman", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.Location = new System.Drawing.Point(7, 50);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(178, 46);
            this.tbxSearch.TabIndex = 0;
            this.tbxSearch.Enter += new System.EventHandler(this.tbxSearch_Enter);
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Black;
            this.lblSearch.Location = new System.Drawing.Point(199, 50);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(373, 17);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Vui lòng nhập tên hoặc số điện thoại hoặc ID để tìm kiếm!!!";
            this.lblSearch.Visible = false;
            // 
            // cbxSapXep
            // 
            this.cbxSapXep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxSapXep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSapXep.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSapXep.FormattingEnabled = true;
            this.cbxSapXep.ItemHeight = 46;
            this.cbxSapXep.Location = new System.Drawing.Point(0, 0);
            this.cbxSapXep.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cbxSapXep.Name = "cbxSapXep";
            this.cbxSapXep.Size = new System.Drawing.Size(408, 54);
            this.cbxSapXep.TabIndex = 0;
            // 
            // btnSapXep
            // 
            this.btnSapXep.AutoSize = true;
            this.btnSapXep.BackColor = System.Drawing.Color.Transparent;
            this.btnSapXep.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSapXep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSapXep.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSapXep.ForeColor = System.Drawing.Color.White;
            this.btnSapXep.Location = new System.Drawing.Point(408, 0);
            this.btnSapXep.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(200, 35);
            this.btnSapXep.TabIndex = 1;
            this.btnSapXep.Text = "Sắp xếp\r\n";
            this.btnSapXep.UseVisualStyleBackColor = false;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.pnlMenu.Controls.Add(this.gbxXemThongTin);
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMenu.Location = new System.Drawing.Point(808, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(197, 627);
            this.pnlMenu.TabIndex = 0;
            // 
            // gbxXemThongTin
            // 
            this.gbxXemThongTin.Controls.Add(this.btnXemThongTin);
            this.gbxXemThongTin.Controls.Add(this.tbxSearch);
            this.gbxXemThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxXemThongTin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxXemThongTin.ForeColor = System.Drawing.Color.White;
            this.gbxXemThongTin.Location = new System.Drawing.Point(0, 252);
            this.gbxXemThongTin.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbxXemThongTin.Name = "gbxXemThongTin";
            this.gbxXemThongTin.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbxXemThongTin.Size = new System.Drawing.Size(197, 163);
            this.gbxXemThongTin.TabIndex = 0;
            this.gbxXemThongTin.TabStop = false;
            this.gbxXemThongTin.Text = "Ô tìm kiếm";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::ShoesStoreManagement.Properties.Resources.dolphin;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.pnlTop.Controls.Add(this.cbxSapXep);
            this.pnlTop.Controls.Add(this.btnSapXep);
            this.pnlTop.Controls.Add(this.btnCapNhat);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.ForeColor = System.Drawing.Color.White;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(808, 35);
            this.pnlTop.TabIndex = 17;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.Controls.Add(this.lblThongTinKhachHang, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgv1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 77);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.585492F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.41451F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(771, 532);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblThongTinKhachHang
            // 
            this.lblThongTinKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblThongTinKhachHang.AutoSize = true;
            this.lblThongTinKhachHang.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinKhachHang.Location = new System.Drawing.Point(2, 0);
            this.lblThongTinKhachHang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThongTinKhachHang.Name = "lblThongTinKhachHang";
            this.lblThongTinKhachHang.Size = new System.Drawing.Size(767, 50);
            this.lblThongTinKhachHang.TabIndex = 0;
            this.lblThongTinKhachHang.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // dgv1
            // 
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.dgv1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv1.EnableHeadersVisualStyles = false;
            this.dgv1.Location = new System.Drawing.Point(2, 51);
            this.dgv1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv1.RowHeadersWidth = 82;
            this.dgv1.RowTemplate.Height = 33;
            this.dgv1.Size = new System.Drawing.Size(767, 480);
            this.dgv1.TabIndex = 1;
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1005, 627);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "FormKhachHang";
            this.Text = "FormKhachHang";
            this.pnlMenu.ResumeLayout(false);
            this.gbxXemThongTin.ResumeLayout(false);
            this.gbxXemThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXemThongTin;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cbxSapXep;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.GroupBox gbxXemThongTin;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblThongTinKhachHang;
        private System.Windows.Forms.DataGridView dgv1;
    }
}