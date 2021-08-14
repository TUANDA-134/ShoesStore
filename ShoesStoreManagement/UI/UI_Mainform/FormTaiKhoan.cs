using ShoesStoreManagement.BLL;
using ShoesStoreManagement.UI.UI_Customer;
using ShoesStoreManagement.UI.UI_TaiKhoan;
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
    public partial class FormTaiKhoan : Form
    {
        public FormTaiKhoan()
        {
            InitializeComponent();
            if (BLL_Login.HienHanh() != null)
            {
                if (BLL_Login.HienHanh().ChucVu.ToLower().Equals("staff"))
                {
                    btnDangKy.Enabled = false;
                }
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            FormDangKyTaiKhoan FDKTK = new FormDangKyTaiKhoan();
            FDKTK.ShowDialog();
        }
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            FormDoiMatKhau FDMK = new FormDoiMatKhau();
            FDMK.ShowDialog();
        }
    }
}
