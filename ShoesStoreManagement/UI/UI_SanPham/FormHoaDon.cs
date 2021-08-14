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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoesStoreManagement.UI.UI_SanPham
{
    public partial class FormHoaDon : Form
    {
        private Form currentChildForm;
        public string idBill { get; set; }
        public string detailID { get; set; }
        public string idShoe { get; set; }
        public delegate void AddSDT(string str);
        public AddSDT addSDT;
        public FormHoaDon(string id)
        {
            InitializeComponent();
            idBill = id;
        }
        public void show()
        {
            var bindingList = new BindingList<DTO_Shoes>(BLL_HoaDon.Instance.GetListDetailShoesID());
            var source = new BindingSource(bindingList, null);
            dgvSanPham.DataSource = source;
        }
        public void setGui(string id, int sl)
        {
            if (id != null && sl > 0)
            {
                BLL_HoaDon.Instance.GetDetailShoesID(id, sl);
                show();
            }
        }
        public void setDatetime(DateTime d)
        {
            dtprNgayMuaHang.Value = d;
        }
        public void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            //childForm.Dock = DockStyle.Top;
            this.panel1.Controls.Add(childForm);
            this.panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        public void addKhachHang()
        {
            Customer customer = new Customer();
            customer.customerName = txtName.Text;
            customer.customerGender = txtGioiTinh.Text == "Nam" ? true : false;
            customer.customerBirthday = Convert.ToDateTime(txtNS.Text);
            customer.customerTelephoneNumber = txtSDT.Text;
            customer.customerId = txtId.Text;
            BLL_KhachHang.Instance.AddKhachHang(customer);
        }
        private void UpdateHoaDon()
        {
            BLL_HoaDon.Instance.updateHoaDon(idBill, dtprNgayMuaHang.Value);
            DetailedSho ds = new DetailedSho();
            foreach (DTO_Shoes i in BLL_HoaDon.Instance.listShoe)
            {
                DetailedBill db = new DetailedBill();
                db.detailedBillId = BLL_HoaDon.Instance.setIdDetailBillAdd();
                db.billId = idBill;
                detailID = i.detailShoeId;
                db.detailedShoesId = detailID;
                db.shoesCost = i.gia;
                db.shoesOrderedAmount = i.soluong;
                BLL_HoaDon.Instance.addDetaiBill(db);
            }
            FormThongBao.Show("Đã cập nhật hóa đơn!");
            BLL_HoaDon.Instance.listShoe.Clear();
            show();
        }
        private void AddHoaDon()
        {
            Bill b = new Bill();
            b.billId = BLL_HoaDon.Instance.setIdBillAdd();
            addKhachHang();
            b.staffId = BLL_Login.HienHanh().StaffID;
            b.customerId = txtId.Text;
            b.billEstablishedDate = ((DateTime)dtprNgayMuaHang.Value);
            BLL_HoaDon.Instance.addBill(b);
            DetailedSho ds = new DetailedSho();
            foreach (DTO_Shoes i in BLL_HoaDon.Instance.listShoe)
            {
                DetailedBill db = new DetailedBill();
                db.detailedBillId = BLL_HoaDon.Instance.setIdDetailBillAdd();
                db.billId = b.billId;
                detailID = i.detailShoeId;
                db.detailedShoesId = detailID;
                db.shoesCost = i.gia;
                db.shoesOrderedAmount = i.soluong;
                BLL_HoaDon.Instance.addDetaiBill(db);
            }
            FormThongBao.Show("Đã lưu hóa đơn");
            BLL_HoaDon.Instance.listShoe.Clear();
            show();
        }
        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Contains("CM") && BLL_HoaDon.Instance.GetListDetailShoesID().Count > 0)
            {
                ExecuteDB();
            }
            else
            {
                FormThongBao.Show("Chưa nhập khách hàng hoặc chưa thêm giày vào giỏ hàng");
            }


        }
        public void ExecuteDB()
        {
            bool check = BLL_HoaDon.Instance.checkBillInDB(idBill);
            if (check)
            {
                UpdateHoaDon();
            }
            else
            {
                AddHoaDon();
            }
        }
        public void setGuiKhachHanh(Customer c)
        {
            txtId.Text = c.customerId;
            txtName.Text = c.customerName;
            txtNS.Text = ((DateTime)c.customerBirthday).ToString("yyyy/MM/dd");
            if (c.customerGender == true)
            {
                txtGioiTinh.Text = "Nam";
            }
            else
            {
                txtGioiTinh.Text = "Nữ";
            }
            txtSDT.Text = c.customerTelephoneNumber;

        }



        private void btAdd_Click(object sender, EventArgs e)
        {
            FormAddSanPham fsp = new FormAddSanPham();
            fsp.Dadd += new FormAddSanPham.setData(setGui);
            fsp.Show();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            List<string> l = new List<string>();
            string id;
            if (dgvSanPham.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in dgvSanPham.SelectedRows)
                {
                    id = i.Cells[0].Value.ToString();
                    l.Add(id);
                }
            }
            BLL_HoaDon.Instance.deleteSV_BLL(l);
            show();
        }

        private void txtKiemTra_Click(object sender, EventArgs e)
        {
            txtKiemTra.Text = "";

        }

        private void btnTinhTien_Click_1(object sender, EventArgs e)
        {
            txtTien.Text = BLL_HoaDon.Instance.TongTien(BLL_HoaDon.Instance.GetListDetailShoesID()).ToString() + "$";
        }
        public static bool CheckSDT(string number)
        {
            return Regex.Match(number, @"^\d{10}$").Success;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (CheckSDT(txtKiemTra.Text))
            {
                if (txtKiemTra.Text.ToString().Trim() != "")
                {
                    if (BLL_KhachHang.Instance.kiemtraSDT(txtKiemTra.Text.ToString().Trim()))
                    {
                        setGuiKhachHanh(BLL_KhachHang.Instance.getKhachHangBySDT(txtKiemTra.Text.ToString().Trim()));
                    }
                    else
                    {
                        FormAddKhachHang f = new FormAddKhachHang();
                        f.dAdd += new FormAddKhachHang.MyDelAdd(setGuiKhachHanh);
                        addSDT += f.AddSDTKH;
                        addSDT.Invoke(txtKiemTra.Text);
                        f.Show();
                    }
                }
                else
                {
                    FormThongBao.Show("Bạn phải nhập số điện thoại của khách hàng để kiểm tra");
                }
            }
            else
            {
                FormThongBao.Show("Lỗi số điện thoại");
            }

        }
        private void setSL(bool t, int sl)
        {
            BLL_HoaDon.Instance.setSLSanPham(t, sl, idShoe);
            show();
        }

        private void dgvSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && dgvSanPham.CurrentCell != null && dgvSanPham.CurrentCell.Value != null)
            {
                idShoe = dgvSanPham.Rows[e.RowIndex].Cells[0].Value.ToString();
                FormHienThiSanPham f = new FormHienThiSanPham(idShoe);
                f.setGui();
                f.setCBBDoubleClick();
                f.D += new FormHienThiSanPham.setTT(setSL);
                f.Show();
            }

        }
    }
}
