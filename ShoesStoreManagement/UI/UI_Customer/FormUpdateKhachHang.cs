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

namespace ShoesStoreManagement.UI.UI_Customer
{
    public partial class FormUpdateKhachHang : Form
    {
        public static int pnlShowWidth, pnlShowHeight;
        public static int count = 0;
        public FormUpdateKhachHang()
        {
            InitializeComponent();
            pnlShowWidth = panel1.Width;
            pnlShowHeight = panel1.Height;
            FormUpdateKhachHang.count++;
        }
        public FormUpdateKhachHang(Customer customer)
        {
            InitializeComponent();
            BLL_KhachHang.Instance.mF.SetTitle("Cập nhật thông tin");
            tbxMaKhachHang.Text = customer.customerId;
            tbxHoVaTen.Text = customer.customerName;
            tbxSoDienThoai.Text = customer.customerTelephoneNumber;
            if ((bool)customer.customerGender)
            {
                rbtnNam.Checked = true;
                rbtnNu.Checked = false;
            }
            else
            {
                rbtnNam.Checked = false;
                rbtnNu.Checked = true;
            }
            dtprNgaySinh.Value = (DateTime)customer.customerBirthday;
            tbxMaKhachHang.ReadOnly = true;
            FormUpdateKhachHang.count++;
        }

        private void btnCancel_Click(object sender, EventArgs e)
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
        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            pnlShowHeight = panel1.Height;
            pnlShowWidth = panel1.Width;
        }
        private void btnExitScreen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(BLL_KhachHang.Instance.CheckSDT(tbxSoDienThoai.Text)>1)
            {
                FormThongBao.Show("Số điện thoại bị trùng");
                return;
            }
            if (tbxSoDienThoai.Text != "" && tbxHoVaTen.Text != "" && CheckSDT(tbxSoDienThoai.Text) && CheckHoTen(tbxHoVaTen.Text))
            {
                Customer customer = new Customer();
                customer.customerName = tbxHoVaTen.Text;
                customer.customerId = tbxMaKhachHang.Text;
                customer.customerGender = rbtnNam.Checked ? true : false;
                customer.customerBirthday = (DateTime)dtprNgaySinh.Value;
                customer.customerTelephoneNumber = tbxSoDienThoai.Text;
                BLL_KhachHang.Instance.EditKhachHang(customer);
                FormThongBao.Show("Thành công!!!");
                this.Close();
            }
            else if (tbxHoVaTen.Text == "")
            {
                FormThongBao.Show("Vui lòng nhập họ và tên");
            }
            else if (tbxSoDienThoai.Text == "")
            {
                FormThongBao.Show("Vui lòng nhập số điện thoại");
            }
            else if (!CheckSDT(tbxSoDienThoai.Text))
            {
                FormThongBao.Show("Lỗi số điện thoại");
            }
            else if (!CheckHoTen(tbxHoVaTen.Text))
            {
                FormThongBao.Show("Lỗi họ và tên");
            }
            else
            {

            }
        }
    }
}
