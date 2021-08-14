using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoesStoreManagement.DTO;
using ShoesStoreManagement.BLL;
using ShoesStoreManagement.UI.UI_Customer;
using ShoesStoreManagement.UI.UI_ThongBao;

namespace ShoesStoreManagement.UI
{
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
            SetDGV();
            tbxSearch.BringToFront();
            SetCBBSapXep();
        }
        void SetDGV()
        {
            dgv1.DataSource = BLL_KhachHang.Instance.GetAllKhachHang();
            dgv1.Columns[0].HeaderText = "Mã khách hàng";
            dgv1.Columns[1].HeaderText = "Tên khách hàng";
            dgv1.Columns[2].HeaderText = "Giới tính";
            dgv1.Columns[3].HeaderText = "Ngày sinh";
            dgv1.Columns[4].HeaderText = "Số điện thoại";
        }

        private void btnXemThongTin_Click(object sender, EventArgs e)
        {
            if(tbxSearch.Text == "" || tbxSearch.Text == ".........")
            {
                lblSearch.Visible = true;
            }else
            {
                FormThongBao.Show(BLL_KhachHang.Instance.GetInfoKhachHangByIdOrNameOrSDTForSearch(tbxSearch.Text));
            }
        }

        private void tbxSearch_Enter(object sender, EventArgs e)
        {
            tbxSearch.Text = "";
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if ((tbxSearch.Text == "" || tbxSearch.Text == ".........") && dgv1.SelectedRows.Count == 0)
            {
                FormThongBao.Show("Vui lòng nhập thông tin khách hàng cần thay đổi vào ô " +
                    "tìm kiếm hoặc chọn một khách hàng ở bảng dưới để thay đổi thông tin khách hàng!!!");
            }
            else if (dgv1.SelectedRows.Count > 1)
            {
                FormThongBao.Show("Chỉ chọn một khách hàng để thay đổi thông tin");
            }
            else if (dgv1.SelectedRows.Count == 1)
            {
                DataGridViewSelectedRowCollection data = dgv1.SelectedRows;
                Customer customer = new Customer();
                foreach (DataGridViewRow r in data)
                {
                    customer.customerId = r.Cells["IdKhachHang"].Value.ToString();
                    customer.customerGender = (bool)r.Cells["Gender"].Value;
                    customer.customerTelephoneNumber = r.Cells["SDT"].Value.ToString();
                    customer.customerName = r.Cells["TenKhachHang"].Value.ToString();
                    customer.customerBirthday = (DateTime)r.Cells["Birthday"].Value;
                }
                FormUpdateKhachHang FUKH = new FormUpdateKhachHang(customer);
                FUKH.ShowDialog();
            }
            else
            {
                Customer customer = BLL_KhachHang.Instance.GetInfoKhachHangByIdOrNameOrSDTForEdit(tbxSearch.Text);
                if (customer != null)
                {
                    FormUpdateKhachHang FUKH = new FormUpdateKhachHang(customer);
                    FUKH.ShowDialog();
                }
                else
                {
                    FormThongBao.Show("Không tồn tại thông tin");
                }
            }
            SetDGV();

        }
        private void SetCBBSapXep()
        {
            foreach(DataGridViewColumn col in dgv1.Columns)
            {
                cbxSapXep.Items.Add("Sắp xếp theo " + col.HeaderText.ToLower());
            }
            cbxSapXep.SelectedIndex = 0;
        }
        private void btnSapXep_Click(object sender, EventArgs e)
        {
            dgv1.DataSource = BLL_KhachHang.Instance.SapXep(cbxSapXep.Text,BLL_KhachHang.Instance.GetAllKhachHang());
        }
    }
}
