using ShoesStoreManagement.BLL;
using ShoesStoreManagement.DTO;
using ShoesStoreManagement.UI.UI_Customer;
using ShoesStoreManagement.UI.UI_ThongBao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoesStoreManagement.UI
{
    public partial class Login : Form
    {
        Mainform mainform = null;
        public Login(Mainform mainForm)
        {
            InitializeComponent();
            tbxUsername.BringToFront();
            tbxPassword.BringToFront();
            mainform = mainForm;
        }

        private void tbxUsername_Enter(object sender, EventArgs e)
        {
            tbxUsername.TabStop = true;
            tbxPassword.TabStop = true;
            tbxUsername.Text = "";
        }

        private void tbxPassword_Enter(object sender, EventArgs e)
        {
            tbxPassword.UseSystemPasswordChar = true;
            tbxUsername.TabStop = true;
            tbxPassword.TabStop = true;
            tbxPassword.Text = "";
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbxSize_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbxUsername.Text == "" || tbxUsername.Text == "Username")
            {
                lblUsernameNotice.Visible = true;
            }
            else if (tbxPassword.Text == "" || tbxPassword.Text == "Password")
            {
                lblPasswordNotice.Visible = true;
            }
            else
            {
                DTO_Account dto_acc = new DTO_Account();
                dto_acc.Username = tbxUsername.Text;
                dto_acc.Password = tbxPassword.Text;
                bool l1 = BLL_Login.Instance.GetAccount(dto_acc.Username, dto_acc.Password);
                if (l1)
                {
                    //IsSuccessful = true;
                    this.Visible = false;
                    mainform.Visible = true;
                    mainform.GetHienHanh(BLL_Login.HienHanh());
                }
                else
                {
                    FormThongBao.Show("Tên đăng nhập hoặc mật khẩu không đúng");
                }
            }
        }
    }
}
