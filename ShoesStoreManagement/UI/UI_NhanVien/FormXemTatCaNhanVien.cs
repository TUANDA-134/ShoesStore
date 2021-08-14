using ShoesStoreManagement.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoesStoreManagement.UI.UI_NhanVien
{
    public partial class FormXemTatCaNhanVien : Form
    {
        public FormXemTatCaNhanVien()
        {
            InitializeComponent();
            SetDGV();
        }
        private void SetDGV()
        {
            dgv1.DataSource = BLL_NhanVien.Instance.GetAllNhanVien();
            SetColumnHeader();
        }
        private void SetColumnHeader()
        {
            dgv1.Columns[0].HeaderText = "Họ và tên";
            dgv1.Columns[1].HeaderText = "Tuổi";
            dgv1.Columns[2].HeaderText = "Số điện thoại";
            dgv1.Columns[3].HeaderText = "Địa chỉ Email";
            dgv1.Columns[4].HeaderText = "CMND";
            dgv1.Columns[5].HeaderText = "Ngày bắt đầu làm việc";
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNgayBatDau_Click(object sender, EventArgs e)
        {
           dgv1.DataSource =  BLL_NhanVien.Instance.SapXep("NgayBatDau",BLL_NhanVien.Instance.GetAllNhanVien());
        }

        private void btnTheoCMND_Click(object sender, EventArgs e)
        {
            dgv1.DataSource = BLL_NhanVien.Instance.SapXep("CMND", BLL_NhanVien.Instance.GetAllNhanVien());
        }

        private void btnTheoTuoi_Click(object sender, EventArgs e)
        {
            dgv1.DataSource = BLL_NhanVien.Instance.SapXep("Tuoi", BLL_NhanVien.Instance.GetAllNhanVien());
        }

        private void btnTheoTen_Click(object sender, EventArgs e)
        {
            dgv1.DataSource = BLL_NhanVien.Instance.SapXep("Ten", BLL_NhanVien.Instance.GetAllNhanVien());
        }
    }
}
