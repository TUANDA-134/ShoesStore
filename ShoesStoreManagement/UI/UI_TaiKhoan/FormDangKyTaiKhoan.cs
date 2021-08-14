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
    public partial class FormDangKyTaiKhoan : Form
    {
        string tenAnh = "";
        bool anh = false;
        public FormDangKyTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool CheckHoTen(string text)
        {
            for (int i = 33; i <= 64; i++)
            {
                if (text.Contains(Convert.ToChar(i)))
                    return false;
            }
            for (int i = 123; i <= 126; i++)
            {
                if (text.Contains(Convert.ToChar(i)))
                    return false;
            }
            return true;
        }
        public static bool CheckSDT(string number)
        {
            return Regex.Match(number, @"^\d{10}$").Success;
        }
        public static bool CheckCMND(string number)
        {
            return Regex.Match(number, @"^\d{9}$").Success;
        }
        public bool IsValidEmail(string strIn)
        {
            // Return true if strIn is in valid e-mail format.
            return Regex.IsMatch(strIn, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }
        public bool CheckPassword()
        {
            string input = tbxPassword.Text;
            var hasNumber = new Regex(@"[0-9]+");
            var hasMinimum8Chars = new Regex(@".{6,}");
            bool isValidated = hasNumber.IsMatch(input) && hasMinimum8Chars.IsMatch(input);
            return isValidated;
        }
        public bool CheckDay()
        {
            if(dtprNgaySinh.Value.Year - DateTime.Now.Year >-16)
            {
                FormThongBao.Show("Bạn không thể tuyển nhân viên duới 17 tuổi");
                return false;
            }
            return true;
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (tbxHoVaTen.Text == "")
            {
                FormThongBao.Show("Vui lòng nhập họ và tên!!! ");
            }
            else if (tbxCMND.Text == "")
            {
                FormThongBao.Show("Vui lòng nhập số chứng minh nhân dân!!!");
            }
            else if (!rbtnNam.Checked && !rbtnNu.Checked)
            {
                FormThongBao.Show("Vui lòng chọn giới tính!!!");
            }
            else if (tbxSDT.Text == "")
            {
                FormThongBao.Show("Vui lòng nhập số điện thoại!!!");
            }
            else if (tbxDiaChi.Text == "")
            {
                FormThongBao.Show("Vui lòng nhập địa chỉ!!!");
            }
            else if (tbxEmail.Text == "")
            {
                FormThongBao.Show("Vui lòng nhập email!!!");
            }
            else if(!IsValidEmail(tbxEmail.Text))
            {
                FormThongBao.Show("Vui lòng nhập lại email!!!");
            }
            else if (!rbtnAdmin.Checked && !rbtnStaff.Checked)
            {
                FormThongBao.Show("Vui lòng chọn chức vụ!!!");
            }
            else if (tbxUsername.Text == "")
            {
                FormThongBao.Show("Vui lòng nhập tên đăng nhập!!!");
            }
            else if (tbxPassword.Text == "")
            {
                FormThongBao.Show("Vui lòng nhập mật khẩu!!!");
            }
            else if(!CheckPassword())
            {
                FormThongBao.Show("Mật khẩu bắt buộc phải có số và ít nhất 6 kí tự!!!");
            }
            else if (tbxPasswordVerification.Text == "")
            {
                FormThongBao.Show("Vui lòng xác thực mật khẩu!!!");
            }
            else if (tbxPasswordVerification.Text != tbxPassword.Text)
            {
                FormThongBao.Show("Xác thực mật khẩu không chính xác!!!");
            }
            else if(!CheckDay())
            {

            }
            else if (!anh)
            {
                FormThongBao.Show("Vui lòng thêm ảnh");
            }
            else
            {
                if(CheckSDT(tbxSDT.Text) && CheckHoTen(tbxHoVaTen.Text) && CheckCMND(tbxCMND.Text))
                {
                    DTO_DangKyTaiKhoan DKTK = new DTO_DangKyTaiKhoan();
                    DKTK.HoVaTen = tbxHoVaTen.Text;
                    DKTK.CMND = tbxCMND.Text;
                    DKTK.NgaySinh = dtprNgaySinh.Value;
                    DKTK.Gender = rbtnNam.Checked ? true : false;
                    //----

                    DKTK.SDT = tbxSDT.Text;
                    DKTK.DiaChi = tbxDiaChi.Text;
                    DKTK.Email = tbxEmail.Text;
                    //----

                    DKTK.ChucVu = rbtnAdmin.Checked ? "Admin" : "Staff";
                    DKTK.NgayBatDauLamViec = dtprNgayBatDau.Value;
                    //----

                    DKTK.MatKhau = tbxPassword.Text;
                    DKTK.XacThucMatKhau = tbxPasswordVerification.Text;
                    DKTK.TenDangNhap = tbxUsername.Text;
                    string Out = BLL_TaiKhoan.Instance.SignUpNewAccount(DKTK, ofdg.FileName);
                    FormThongBao.Show(Out);
                    if (Out.Equals("Đăng ký thành công!"))
                    {
                        this.Close();
                    }
                }else
                {
                    FormThongBao.Show("Họ và tên hoặc số điện thoại hoặc chứng minh nhân dân không hợp lệ");
                }
            }
        }

        private void btnExitScreen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            ofdg.InitialDirectory = "E:";//Định đường dẫn khi mở cửa sổ tìm ảnh
            //ofdg.FileName = "";// Tên ảnh
            ofdg.Filter = "Images(*.jpg)|*.jpg|PNG (*.png)|*.png|All files (*.*)|*.*";
            DialogResult result = ofdg.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Lấy hình ảnh
                Image img = Image.FromFile(ofdg.FileName);
                //FormThongBao.Show(ofdg.FileName);
                // Gán ảnh
                pbxAnh.Image = img;
                tenAnh = ofdg.FileName;
                anh = true;
            }
        }
    }
}
