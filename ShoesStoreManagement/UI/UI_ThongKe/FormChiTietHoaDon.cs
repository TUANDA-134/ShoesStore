using ShoesStoreManagement.BLL;
using ShoesStoreManagement.DTO;
using ShoesStoreManagement.UI.UI_SanPham;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoesStoreManagement.UI.UI_ThongKe
{
    public partial class FormChiTietHoaDon : Form
    {
        private string IdBill;
        public delegate void setForm(Form f);
        public setForm DaddForm { get; set; }
        public FormChiTietHoaDon(string idbill)
        {
            InitializeComponent();
            IdBill = idbill;
            setGUI();
        }

        private void btnExitScreen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void setGUI()
        {
            int tongsl = 0;
            DateTime t = new DateTime(2018, 1, 1);
            foreach (DTO_BaoCaoView p in BLL_BaoCao.Instance.GetListBCView(t, DateTime.Now, ""))
            {
                if (IdBill == p.IdBill)
                {
                    txtKH.Text = p.TenKhachHang.ToString();
                    txtMHD.Text = p.IdBill;
                    txtNguoiBan.Text = p.TenNhanVien;
                    dateTimePicker1.Value = (DateTime)p.NgayXuat;
                    txtTongTien.Text = p.TongTien.ToString() + "$";
                }
            };
            dataGridView1.DataSource = BLL_BaoCao.Instance.GetAllDetailBillView(IdBill);

            txtTongSL.Text = BLL_BaoCao.Instance.getTSLBan(IdBill);
        }
        private Form currentChildForm;
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
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(childForm);
            this.panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            string id = "";
            int sl = 0;
            BLL_HoaDon.Instance.listShoe.Clear();
            FormHoaDon f1 = new FormHoaDon(txtMHD.Text);
            DaddForm(f1);
            
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                id = dataGridView1.Rows[i].Cells[0].Value.ToString();
                sl = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value.ToString());
                BLL_HoaDon.Instance.GetDetailShoesID(id, sl);
            }
            
            f1.Show();
            f1.setDatetime(dateTimePicker1.Value);
            f1.setGuiKhachHanh(BLL_BaoCao.Instance.getKhachhangByIdBill(txtMHD.Text));
            f1.show();
            this.Close();
        }
    }
}
