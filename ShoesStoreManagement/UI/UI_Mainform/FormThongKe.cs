using ShoesStoreManagement.BLL;
using ShoesStoreManagement.DTO;
using ShoesStoreManagement.UI.UI_ThongKe;
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
    public partial class FormBaoCao : Form
    {
        public FormBaoCao()
        {
            InitializeComponent();
            Show(dtprTuNgay.Value, dtprDenNgay.Value, tbxTimKiem.Text);
        }
        public void Show(DateTime start, DateTime end, string search)
        {
            dgvDSHD.DataSource = BLL_BaoCao.Instance.GetListBCView(start, end, search);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Show(dtprTuNgay.Value, dtprDenNgay.Value, tbxTimKiem.Text);

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
        private void setgui(Form f)
        {
            OpenChildForm(f);
        }
        private void dgvDSHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(BLL_Login.HienHanh().ChucVu.ToLower().Equals("staff"))
            {
                return;
            }
            if (e.RowIndex != -1 && dgvDSHD.CurrentCell != null && dgvDSHD.CurrentCell.Value != null)
            {
                string idbill = dgvDSHD.Rows[e.RowIndex].Cells[0].Value.ToString();
                FormChiTietHoaDon f = new FormChiTietHoaDon(idbill);
                f.DaddForm += new FormChiTietHoaDon.setForm(setgui);
                f.Show();
                
            }
        }
        private void dgvDSHD_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<DTO_BaoCaoView> list = BLL_BaoCao.Instance.GetListBCView(dtprTuNgay.Value, dtprDenNgay.Value, tbxTimKiem.Text);
            string s = dgvDSHD.Columns[e.ColumnIndex].HeaderText;
            switch (s)
            {
                case "Ngày xuất":
                    dgvDSHD.DataSource = BLL_BaoCao.Instance.Sort(list, "Sắp xếp theo Ngày Xuất Hóa Đơn");
                    break;
                case "Tên khách hàng":
                    dgvDSHD.DataSource = BLL_BaoCao.Instance.Sort(list, "Sắp xếp theo Tên Khách Hàng");
                    break;
                case "Tên nhân viên":
                    dgvDSHD.DataSource = BLL_BaoCao.Instance.Sort(list, "Sắp xếp theo Tên Nhân Viên");
                    break;
                case "Tổng tiền":
                    dgvDSHD.DataSource = BLL_BaoCao.Instance.Sort(list, "Sắp xếp theo Tổng tiền");
                    break;
            }
        }

        private void btnBieuDoThongKe_Click(object sender, EventArgs e)
        {
            if (BLL_Login.HienHanh().ChucVu.ToLower().Equals("staff"))
            {
                return;
            }
            else
            {
                FormBieuDo f = new FormBieuDo();
                OpenChildForm(f);
            }    
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            Show(dtprTuNgay.Value, dtprDenNgay.Value, tbxTimKiem.Text);
        }

        private void dgvDSHD_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<DTO_BaoCaoView> list = BLL_BaoCao.Instance.GetListBCView(dtprTuNgay.Value, dtprDenNgay.Value, tbxTimKiem.Text);
            string s = dgvDSHD.Columns[e.ColumnIndex].HeaderText;
            switch (s)
            {
                case "Ngày xuất":
                    dgvDSHD.DataSource = BLL_BaoCao.Instance.Sort(list, "Sắp xếp theo Ngày Xuất Hóa Đơn giảm");
                    break;

                case "Tổng tiền":
                    dgvDSHD.DataSource = BLL_BaoCao.Instance.Sort(list, "Sắp xếp theo Tổng tiền giảm");
                    break;
            }
        }
    }

}
