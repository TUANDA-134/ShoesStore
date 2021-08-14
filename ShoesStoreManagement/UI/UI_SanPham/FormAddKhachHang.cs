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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoesStoreManagement.UI.UI_Customer
{
    public partial class FormAddKhachHang : Form
    {

        public static int count = 0;
        public delegate void MyDelAdd(Customer c);
        public MyDelAdd dAdd;
        public FormAddKhachHang()
        {
            InitializeComponent();
            pnlShowWidth = panel1.Width;
            pnlShowHeight = panel1.Height;
            tbxMaKhachHang.Text = BLL_KhachHang.Instance.SetIDKhachHangAddForm();
            tbxMaKhachHang.ReadOnly = true;
            count++;
        }
        public void AddSDTKH(string str)
        {
            tbxSoDienThoai.Text = str;
            tbxSoDienThoai.ReadOnly = true;
        }
        private void FormAddKhachHang_SizeChanged(object sender, EventArgs e)
        {
            pnlShowWidth = panel1.Width;
            pnlShowHeight = panel1.Height;
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
        private bool CheckSDT(string text)
        {
            for (int i = 65; i <= 122; i++)
            {
                if (text.Contains(Convert.ToChar(i)))
                {
                    return false;
                }
            }
            return true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if ((rbtnNam.Checked || rbtnNu.Checked) && tbxSoDienThoai.Text != "" && tbxHoVaTen.Text != "" && CheckSDT(tbxSoDienThoai.Text) && CheckHoTen(tbxHoVaTen.Text))
            {
                Customer customer = new Customer();
                customer.customerName = tbxHoVaTen.Text;
                customer.customerGender = rbtnNam.Checked ? true : false;
                customer.customerBirthday = ((DateTime)dtprNgaySinh.Value);
                customer.customerTelephoneNumber = tbxSoDienThoai.Text;
                customer.customerId = tbxMaKhachHang.Text;
                BLL_KhachHang.Instance.AddKhachHang(customer);
                dAdd(BLL_KhachHang.Instance.getCustomer(customer));
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
            else if (!rbtnNam.Checked || !rbtnNu.Checked)
            {
                FormThongBao.Show("Vui lòng chọn giới tính");
            }
            else
            {

            }
        }

        private void btnExitScreen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
