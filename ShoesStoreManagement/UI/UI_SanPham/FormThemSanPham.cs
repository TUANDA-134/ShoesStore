using ShoesStoreManagement.DTO;
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
using ShoesStoreManagement.UI.UI_ThongBao;

namespace ShoesStoreManagement.UI.UI_SanPham
{
    public partial class FormThemSanPham : Form
    {

        int pnlMauWidth, pnlMauHeight;

        List<ucSP> listucSP = new List<ucSP>();
        List<string> mauSac = new List<string>();
        int soPhanTuDaLuu = 0;//xác định có bao nhiêu ucSP đang được lưu 
        bool chedo1 = true;
        bool _NganChanTextChanged = false;

        public FormThemSanPham()
        {
            InitializeComponent();
            GUI();
            pnlMauHeight = pnlMau.Height;
            pnlMauWidth = pnlMau.Width;
        }
        public void GUI()
        {
            foreach (DTO_CBBLoaiGiay i in BLL.BLL_Giay.Instance.GetALL_ShoesTypes())
            {
                cbbLoaiGiay.Items.Add(i);
            }
            cbbLoaiGiay.SelectedIndex = 0;
            SetlblMaGiay();
            lblMaGiay1.Hide();
            cbbMaGiay.Hide();
            _NganChanTextChanged = true;
            SetCBBMaGiay();
            _NganChanTextChanged = false;
        }
        public void SetCBBMaGiay()
        {
            cbbMaGiay.Items.Clear();
            foreach (DTO_CBBMaGiay i in BLL_Giay.Instance.MaGiay())
            {
                cbbMaGiay.Items.Add(i);
            }
        }
        public void SetlblMaGiay()
        {
            tbxMaGiay.Text = BLL_Giay.Instance.GetMa(((DTO_CBBLoaiGiay)cbbLoaiGiay.SelectedItem).ShoesTypeId);
            //tbxMaGiay.ForeColor = Color.Black;
        }
        private void FormSanPham_MaximumSizeChanged(object sender, EventArgs e)
        {
            FormThongBao.Show("");
        }
        private void btnThemMau_Click(object sender, EventArgs e)
        {
            //
            ucSP s;
            s = new ucSP(tbxMaGiay.Text);
            s.Size = new System.Drawing.Size(pnlMauWidth, pnlMauHeight);
            pnlMau.Controls.Add(s);
            s.Dock = DockStyle.Top;
            s.BringToFront();
            s.AutoSize = false;
            s.d = XoaUCSP;
            listucSP.Add(s);

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (chedo1)
            {
                if (tbxTenGiay.Text.Equals(""))
                {
                    FormThongBao.Show("Vui lòng nhập tên");
                    return;
                }
                if (tbxGia.Text.Equals(""))
                {
                    FormThongBao.Show("Vui lòng nhập giá!!!");
                    return;
                }
                Sho giayMoi = new Sho();
                giayMoi.shoesId = tbxMaGiay.Text;
                giayMoi.shoesName = tbxTenGiay.Text;
                giayMoi.shoesTypeId = ((DTO_CBBLoaiGiay)cbbLoaiGiay.SelectedItem).ShoesTypeId.ToString();
                giayMoi.shoesDescription = rtbMoTa.Text;
                giayMoi.shoesBrand = tbxHang.Text;
                if (listucSP != null)
                {
                    if (kiemTraMau(0))
                    {

                    }
                    else
                    {
                        return;
                    }
                }
                try
                {
                    giayMoi.shoesCost = (float)Convert.ToDouble(tbxGia.Text);
                    BLL_Giay.Instance.AddSho(giayMoi);
                }
                catch
                {
                    FormThongBao.Show("Lỗi kiểm tra lại thông tin");//
                    return;
                }
                if (listucSP.Count > 0)
                {

                    for (int i = 0; i < listucSP.Count; i++)
                    {
                        BLL_Giay.Instance.AddMauSize(listucSP[i], giayMoi, listucSP[i].GetMau());
                    }
                }
                FormThongBao.Show("Thành công!!!");
                btnThemMoi_Click(sender, e);
                listucSP.Clear();
            }
            else
            {
                Sho s = new Sho();
                try
                {
                    s.shoesCost = Convert.ToDouble(tbxGia.Text);
                    s.shoesDescription = rtbMoTa.Text;
                    s.shoesId = tbxMaGiay.Text;
                    BLL_Giay.Instance.AddSho(s);
                }
                catch
                {
                    FormThongBao.Show("Vui lòng nhập đúng giá");
                    return;
                }
            
                if (listucSP.Count > soPhanTuDaLuu)
                {
                    if (kiemTraMau(soPhanTuDaLuu))
                    {
                        for (int i = soPhanTuDaLuu; i < listucSP.Count; i++)
                        {
                            BLL_Giay.Instance.AddMauSize(listucSP[i], s, listucSP[i].GetMau());
                            listucSP[i].SetDisable(true);
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                soPhanTuDaLuu = listucSP.Count;
            }
        }
        public bool kiemTraMau(int m)
        {

            for (int i = m; i < listucSP.Count; i++)
            {

                switch (listucSP[i].KiemTra())
                {
                    case 1:
                        FormThongBao.Show("Vui lòng điền ít nhất một số lượng cho 1 sản phẩm");
                        return false;
                    case 2:
                        FormThongBao.Show("Vui lòng điền màu cho sản phẩm");
                        return false;
                    case 3:
                        FormThongBao.Show("Vui lòng thêm ảnh");
                        return false;
                }
            }
            mauSac.Clear();
            for (int i = 0; i < listucSP.Count; i++)
            {
                mauSac.Add(listucSP[i].GetMau());
                //FormThongBao.Show(mauSac[i]);
            }

            if (mauSac.Count >= 2)
            {
                for (int i = 0; i < mauSac.Count; i++)
                {
                    for (int j = i + 1; j < mauSac.Count; j++)
                    {
                        //FormThongBao.Show(mauSac[i] + " " + mauSac[j]);
                        if (mauSac[i].Equals(mauSac[j]))
                        {
                            FormThongBao.Show("Trùng màu, vui lòng sửa lại!!!");
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        private void CbbLoaiGiay_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetlblMaGiay();
        }

        private void btnThemTuGiayCoSan_Click(object sender, EventArgs e)
        {
            if (btnThemTuGiayCoSan.Text.Equals("Thêm màu từ giày có sẵn"))
            {
                soPhanTuDaLuu = 0;
                cbbMaGiay.SelectedIndex = 0;
                listucSP.Clear();
                btnThemMoi_Click(sender, e);
                pnlMau.Controls.Clear();
                cbbMaGiay.Visible = true;
                lblMaGiay1.Visible = true;
                btnThemTuGiayCoSan.Text = "Thêm giày mới";
                btnLuu.Text = "Cập nhật";
                btnXoa.Hide();
                chedo1 = false;
                cbbLoaiGiay.Hide();
                SetCBBMaGiay();
                cbbMaGiay.SelectedIndex = 0;
                cbbMaGiay_SelectedIndexChanged(sender, e);
                lblLoaiGiay.Hide();
                //Khi đang ở chế độ 1 không có màu nào được lưu

            }
            else
            {
                listucSP.Clear();
                btnThemMoi_Click(sender, e);
                chedo1 = true;
                btnXoa.Visible = true;
                btnLuu.Text = "Lưu";
                btnThemTuGiayCoSan.Text = "Thêm màu từ giày có sẵn";
                cbbMaGiay.Visible = false;
                lblMaGiay1.Visible = false;
                SetlblMaGiay();
                cbbLoaiGiay.Visible = true;
                lblLoaiGiay.Visible = true;
                soPhanTuDaLuu = 0;
                SetCBBMaGiay();
            }
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            pnlMau.Controls.Clear();
            SetlblMaGiay();
            tbxGia.Text = "";
            tbxHang.Text = "";
            tbxTenGiay.Text = "";
            rtbMoTa.Text = "";
        }
        public void XoaUCSP()
        {
            for (int i = 0; i < listucSP.Count; i++)
            {
                if (listucSP[i].coXoa)
                {
                    pnlMau.Controls.Remove(listucSP[i]);
                    listucSP.RemoveAt(i);
                    return;
                }
            }
        }

        private void cbbMaGiay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cbbMaGiay_SelectedIndexChanged(sender, e);
            }
        }

        private void cbbMaGiay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_NganChanTextChanged)
            {
                return;
            }
            string maGiay = cbbMaGiay.Text;
            Sho s = BLL_Giay.Instance.GetThongTinGiay(maGiay);
            if (s == null)
            {
                FormThongBao.Show("Không tồn tại mã giày như vậy");
                return;
            }
            listucSP.Clear();
            pnlMau.Hide();
            tbxMaGiay.Text = s.shoesId;
            tbxGia.Text = s.shoesCost.ToString();
            tbxHang.Text = s.shoesBrand.ToString();
            tbxTenGiay.Text = s.shoesName;
            rtbMoTa.Text = s.shoesDescription;
            List<string> mau = BLL_Giay.Instance.CountMau(cbbMaGiay.Text);// đếm màu từ csdl
            pnlMau.Controls.Clear();
            if (mau.Count > 0)
            {
                for (int i = 0; i < mau.Count; i++)
                {
                    ucSP d = new ucSP(BLL_Giay.Instance.GetKichThuocTheoMau(mau[i], cbbMaGiay.Text), mau[i], BLL_Giay.Instance.GetMaSPDauTien(cbbMaGiay.Text, mau[i]), cbbMaGiay.Text);
                    //pnlMau.Controls.Add(d);
                    listucSP.Add(d);
                    mauSac.Add(mau[i]);
                    d.Size = new System.Drawing.Size(pnlMauWidth, pnlMauHeight);
                    d.Dock = DockStyle.Top;
                    d.BringToFront();
                    d.AutoSize = false;
                    d.d = XoaUCSP;
                }
                soPhanTuDaLuu = listucSP.Count;//SỐ n này chỉ số màu đã được lưu 
                //FormThongBao.Show(n.ToString());
                pnlMau.Controls.AddRange(listucSP.ToArray());
                pnlMau.Visible = true;
            }
            //pnlMau.Controls.Remove(pnlCheDay);

        }
    }
    public class PanelDoubleBuffered : System.Windows.Forms.Panel
    {
        public PanelDoubleBuffered()
        {
            this.DoubleBuffered = true;
            this.UpdateStyles();
        }
    }
}
