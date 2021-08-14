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

namespace ShoesStoreManagement.UI.UI_NhanVien
{
    public partial class FormThayDoiThongTin : Form
    {

        public FormThayDoiThongTin()
        {
            InitializeComponent();
        }

        private void pbxAnhNhanVien_Click(object sender, EventArgs e)
        {

        }
        internal void ShowInfoStaff(DTO_NhanVien s)
        {
            rbtnNam.Checked = true;
            rbtnAdmin.Checked = true;
            if (s != null)
            {
                tbxHoVaTen.Text = s.StaffName;
                tbxCMND.Text = s.StaffCMND;
                if (s.Gender != true) 
                    rbtnNu.Checked = true;
                dtprNgaySinh.Value = s.StaffBirthday;
                tbxSDT.Text = s.StaffTelephoneNumber;
                tbxEmail.Text = s.StaffEmail;
                tbxDiaChi.Text = s.StaffAddress;
                if (s.StaffRole != "Admin") 
                    rbtnStaff.Checked = true;
                string path;
                try
                {
                    path = BLL_DuongDan.Instance.StaffImagePath() + s.StaffId + ".png";
                    pbxAnhNhanVien.Image = Image.FromFile(path);
                }
                catch (Exception e)
                {

                }
            }
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
        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            if (CheckSDT(tbxSDT.Text))
            {
                if (tbxSDT.Text != "" && tbxDiaChi.Text != "" && tbxEmail.Text != "")
                {
                    Staff nV = new Staff();
                    nV.staffName = tbxHoVaTen.Text;
                    nV.staffCMND = tbxCMND.Text;
                    nV.staffGender = rbtnNam.Checked ? true : false;
                    nV.staffBirthday = dtprNgaySinh.Value;
                    nV.staffTelephoneNumber = tbxSDT.Text;
                    nV.staffEmail = tbxEmail.Text;
                    nV.staffAddress = tbxDiaChi.Text;
                    nV.staffRole = rbtnAdmin.Checked ? "Admin" : "Staff";
                    BLL_NhanVien.Instance.UpdateStaff(nV);
                    FormThongBao.Show("Thành công!!!");
                    this.Close();

                }
                else
                {
                    FormThongBao.Show("Vui lòng điền đủ thông tin vào ô còn thiếu");
                }
            }
            else
            {
                FormThongBao.Show("Số điện thoại không hợp lệ");
            }
           
        }

        private void btnExitScreen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}