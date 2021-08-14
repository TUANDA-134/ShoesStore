using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoesStoreManagement.BLL;
using ShoesStoreManagement.DTO;

namespace ShoesStoreManagement.UI.UI_NhanVien
{
    public partial class FormXemThongTin : Form
    {
        public FormXemThongTin()
        {
            InitializeComponent();
        }
        public void ShowInfoStaff(DTO_NhanVien s)
        {
            if(s != null) {
                tbxHoVaTen.Text = s.StaffName;
                tbxCMND.Text = s.StaffCMND;
                tbxGioiTinh.Text = ((bool)s.Gender) ? "Nam": "Nữ";
                tbxTuoi.Text = s.StaffAge.ToString();
                tbxSDT.Text = s.StaffTelephoneNumber;
                tbxEmail.Text = s.StaffEmail;
                tbxDiaChi.Text = s.StaffAddress;
                tbxNgayBatDau.Text = ((DateTime)s.StartWorkingDate).ToShortDateString();
                tbxNgayKetThuc.Text = ((DateTime)s.EndWorkingDate).ToShortDateString();
                tbxChucVu.Text = s.StaffRole;
                tbxTrangThai.Text = s.StaffState;
                string path;
                try
                {
                    path = BLL_DuongDan.Instance.StaffImagePath() + s.StaffId + ".png";
                    pbxAnhNhanVien.Image = Image.FromFile(path);
                    
                }
                catch(Exception e)
                {
                    pbxAnhNhanVien.Image = pbxAnhNhanVien.ErrorImage;
                }
                
            }

        }

        private void btnExitScreen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
