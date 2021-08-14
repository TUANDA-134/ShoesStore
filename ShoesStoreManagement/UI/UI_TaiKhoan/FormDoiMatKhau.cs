using ShoesStoreManagement.BLL;
using ShoesStoreManagement.DTO;
using ShoesStoreManagement.UI.UI_ThongBao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoesStoreManagement.UI.UI_TaiKhoan
{
    public partial class FormDoiMatKhau : Form
    {
        public FormDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if(tbxUsername.Text == "")
            {
                FormThongBao.Show("Vui lòng nhập tên đăng nhập");
            }else if(tbxCurrentPassword.Text == "")
            {
                FormThongBao.Show("Vui lòng nhập mật khẩu hiện tại");
            }else if(tbxNewPassword.Text == "")
            {
                FormThongBao.Show("Vui lòng nhập mật khẩu mới");
            }else if(tbxNewPasswordVerification.Text == "")
            {
                FormThongBao.Show("Vui lòng xác thực mật khẩu");
            }
            else if (!CheckPassword(tbxNewPassword.Text))
            {
                FormThongBao.Show("mật khẩu phải có ít nhất 1 số và 6 kí tự");
            }
            else
            {
                DTO_ChangePasswordOfAccount cPOA = new DTO_ChangePasswordOfAccount();
                cPOA.Username = tbxUsername.Text;
                cPOA.CurrentPassword = tbxCurrentPassword.Text;
                cPOA.NewPassword = tbxNewPassword.Text;
                cPOA.NewPasswordVerification = tbxNewPasswordVerification.Text;
                if (cPOA.NewPassword != cPOA.NewPasswordVerification)
                {
                    FormThongBao.Show("Xác thực mật khẩu không chính xác");
                }
                else
                {
                    string Out = BLL_TaiKhoan.Instance.ChangePassword(cPOA);
                    FormThongBao.Show(Out);
                    tbxUsername.Text = "";
                    tbxCurrentPassword.Text = "";
                    tbxNewPassword.Text = "";
                    tbxNewPasswordVerification.Text = "";
                    if (Out.Equals("Đổi mật khẩu thành công!"))
                    {
                        this.Close();
                    }
                }
            }
        }
        public bool CheckPassword(string mk)
        {
            string input = mk;
            var hasNumber = new Regex(@"[0-9]+");
            var hasMinimum8Chars = new Regex(@".{6,}");
            bool isValidated = hasNumber.IsMatch(input) && hasMinimum8Chars.IsMatch(input);
            return isValidated;
        }

        private void btnExitScreen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
