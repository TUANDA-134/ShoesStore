using FontAwesome.Sharp;
using ShoesStoreManagement.BLL;
using ShoesStoreManagement.DTO;
using ShoesStoreManagement.UI.UI_Customer;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace ShoesStoreManagement.UI
{
    public partial class Mainform : Form
    {
        int panelMenuHeight;
        int panelMenuWidth;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public Mainform()
        {
            InitializeComponent();
            panelMenuHeight = pnlMenu.Height;
            panelMenuWidth = pnlMenu.Width;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, btnKhachHang.Size.Height);
            pnlMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            OpenChildForm(new Time());
            SetMenuButton(panelMenuHeight,panelMenuWidth);
        }

        
        public void SetTitle(string s)
        {
            lblTitle.Text = s;
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        //get hien hanh
        internal void GetHienHanh(DTO_HienHanh hienHanh)
        {
            if (BLL_Login.HienHanh() != null)
            {
                lblChucVu.Text = "(" + BLL_Login.HienHanh().ChucVu.ToUpper() +")";

                lblTen.Text = BLL_Login.HienHanh().Ten.ToUpper();
                if (lblChucVu.Text.ToLower().Equals("staff"))
                {
                    this.pbxAnh.Image = global::ShoesStoreManagement.Properties.Resources.manager_128;
                    btnThongKe.Enabled = true;
                }
                else
                {
                    
                    this.pbxAnh.Image = global::ShoesStoreManagement.Properties.Resources.moderator_128;
                }
            }
        }
        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new FormBaoCao());
        }
        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                btnHome.IconChar = currentBtn.IconChar;
                btnHome.Text = currentBtn.Text;
                //Title
                lblTitle.Text = currentBtn.Text;
                //panelTitle.BackColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        public void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlDesktop.Controls.Add(childForm);
            this.pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            //btnHome.IconChar = IconChar.Home;
            //btnHome.Text = "Home";
            //btnHome.IconColor = Color.CornflowerBlue;
            //btnHome.ForeColor = Color.CornflowerBlue;
            OpenChildForm(new Time());
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);

        }
        private void FormMainMenu_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new FormKhachHang());
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            FormSanPham FSP = new FormSanPham();
            OpenChildForm(FSP);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {

            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormTaiKhoan());
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new FormNhanVien());
        }

        

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExitScreen_Click(object sender, EventArgs e)
        {
            BLL_Login.Instance.SetTrangThai();
            Application.Exit();
        }

        private void btnMaxScreen_Click(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                SetPositionOfLabelTitle();
                SetMenuButton(Screen.PrimaryScreen.Bounds.Height,panelMenuWidth); 
            }
            else
            {
                WindowState = FormWindowState.Normal;
                SetPositionOfLabelTitle();
                SetMenuButton(panelMenuHeight,panelMenuWidth);
            }
        }

        private void btnMinScreen_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }



        private void pbxLogo_Click(object sender, EventArgs e)
        {
            Reset();
            this.Visible=false;
            Login login = new Login(this);
            login.ShowDialog();
            BLL_Login.Instance.SetTrangThai();
        }
        private void SetPositionOfLabelTitle()
        {
            lblTitle.Left = (pnlTitle.Width - lblTitle.Width)/2;
        }
        private void SetMenuButton(int pnlMenuHeight,int pnlMenuWidth)
        {
            int doRong = (pnlMenuHeight - pbxLogo.Size.Height)/5;
            int nutBatdau = pbxLogo.Height;
            // btn khach hang
            btnKhachHang.Location = new Point(0, nutBatdau);
            btnKhachHang.Width = pnlMenuWidth;
            btnKhachHang.Height = doRong;
            // btn san pham
            btnSanPham.Location = new Point(0, nutBatdau + btnKhachHang.Height);
            btnSanPham.Width = pnlMenuWidth;
            btnSanPham.Height = btnKhachHang.Height;
            // btn nhan vien
            btnNhanVien.Location = new Point(0, nutBatdau + btnKhachHang.Height * 2);
            btnNhanVien.Width = pnlMenuWidth;
            btnNhanVien.Height = doRong;
            // btn thong ke
            btnThongKe.Location = new Point(0, nutBatdau + btnKhachHang.Height * 3);
            btnThongKe.Width = pnlMenuWidth;
            btnThongKe.Height = doRong;
            // btn dang ky tai khoan
            btnTaiKhoan.Location = new Point(0, nutBatdau + btnKhachHang.Height * 4);
            btnTaiKhoan.Width = pnlMenuWidth;
            btnTaiKhoan.Height = doRong;
            leftBorderBtn.Size = new Size(7, btnKhachHang.Size.Height);

        }
    }
}
