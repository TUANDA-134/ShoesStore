using ShoesStoreManagement.BLL;
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

namespace ShoesStoreManagement.UI.UI_SanPham
{
    public partial class FormAddSanPham : Form
    {
        List<string> mauSac = new List<string>();
        List<string> size = new List<string>();
        int n = -6;
        List<DetailedSho> ketQua = new List<DetailedSho>();
        public delegate void setData(string id, int sl);
        public setData Dadd { get; set; }
        public string id = null;
        public FormAddSanPham()
        {
            InitializeComponent();
            ketQua = BLL_Giay.Instance.TimKiem(mauSac, size, "", 0, "", "","");
            int m = ketQua.Count;
            Random rng = new Random();
            while (m > 1)
            {
                m--;
                int k = rng.Next(m + 1);
                DetailedSho value = ketQua[k];
                ketQua[k] = ketQua[m];
                ketQua[m] = value;
            }
            btnPrevious.Hide();
            NutPhai();
            GUI();
        }


        public void GUI()
        {
            cbxLoaiGiay.Items.Add(new DTO_CBBLoaiGiay { ShoesType = "ALL", ShoesTypeId = "" });
            foreach (DTO_CBBLoaiGiay i in BLL.BLL_Giay.Instance.GetALL_ShoesTypes())
            {
                cbxLoaiGiay.Items.Add(i);
            }
        }
        private Form currentChildForm;
        public void SetListMau(object sender, string s)
        {
            for (int i = 0; i < mauSac.Count; i++)
            {
                if (mauSac[i].Equals(s))
                {
                    mauSac.RemoveAt(i);
                    ((PictureBox)sender).Image = null;
                    return;
                }
            }
            mauSac.Add(s);
            ((PictureBox)sender).Image = global::ShoesStoreManagement.Properties.Resources.Tick;
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            SetSizeToList(sender, "6");
        }

        private void btn6_5_Click(object sender, EventArgs e)
        {
            SetSizeToList(sender, "6.5");
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            SetSizeToList(sender, "12");
        }

        private void btn11_5_Click(object sender, EventArgs e)
        {
            SetSizeToList(sender, "11.5");
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            SetSizeToList(sender, "11");
        }

        private void btn10_5_Click(object sender, EventArgs e)
        {
            SetSizeToList(sender, "10.5");
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            SetSizeToList(sender, "10");
        }

        private void btn9_5_Click(object sender, EventArgs e)
        {
            SetSizeToList(sender, "9.5");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            SetSizeToList(sender, "9");
        }

        private void btn8_5_Click(object sender, EventArgs e)
        {
            SetSizeToList(sender, "8.5");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            SetSizeToList(sender, "8");
        }

        private void btn7_5_Click(object sender, EventArgs e)
        {
            SetSizeToList(sender, "7.5");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            SetSizeToList(sender, "7");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            n = -6;
            string loaiGiay = "";
            if (cbxLoaiGiay.Text.Equals("Loại giày"))
            {
                //
            }
            else
            {
                loaiGiay = ((DTO_CBBLoaiGiay)cbxLoaiGiay.SelectedItem).ShoesTypeId;
            }
            string hang;
            if (cbxHang.Text.Equals("ALL") || cbxHang.Text.Equals("Hãng"))
            {
                hang = "";
            }
            else
            {
                hang = cbxHang.Text.ToLower();
            }
            int indexOfcbxMucGia = 0;
            if (cbxMucGia.Text.Equals("Mức giá"))
            {

            }
            else
            {
                indexOfcbxMucGia = cbxMucGia.SelectedIndex;
            }
            ketQua = BLL_Giay.Instance.TimKiem(mauSac, size, tbxMaGiay.Text, indexOfcbxMucGia, hang, loaiGiay, tbxTenGiay.Text);
            if (ketQua.Count > 6)
            {
                btnNext.Visible = true;
            }
            btnPrevious.Hide();
            NutPhai();
        }
        public void NutPhai()
        {
            n = n + 6;
            for (int i = n; i < n + 6; i++)
            {
                SetPicBox(i);
            }

            if (n + 6 >= ketQua.Count - 1)
            {
                btnNext.Hide();
            }
            if (n != 0)
            {
                btnPrevious.Visible = true; ;
            }
        }
        public void SetPicBox(int i)
        {
            if (i % 6 == 0)
            {
                if (i < ketQua.Count)
                {
                    pbxImage1.Visible = true;
                    pbxImage1.ImageLocation = BLL_DuongDan.Instance.ImagePath() + ketQua[i].detailedShoesId + ".png";
                    lblPic1.Text = ketQua[i].detailedShoesId;
                    pbxImage1.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    pbxImage1.Image = null;
                    lblPic1.Text = "";
                    pbxImage1.BackColor = Color.Silver;
                    pbxImage1.Enabled = false;
                }
            }
            if (i % 6 == 1)
            {
                if (i < ketQua.Count)
                {
                    pbxImage2.ImageLocation = BLL_DuongDan.Instance.ImagePath() + ketQua[i].detailedShoesId + ".png";
                    lblPic2.Text = ketQua[i].detailedShoesId;
                    pbxImage2.BackColor = Color.FromArgb(224, 224, 224);
                    pbxImage2.Visible = true;
                }
                else
                {
                    pbxImage2.Image = null;
                    lblPic2.Text = "";
                    pbxImage2.BackColor = Color.Silver;
                    pbxImage2.Visible = false;
                }
            }
            if (i % 6 == 2)
            {
                if (i < ketQua.Count)
                {
                    pbxImage3.ImageLocation = BLL_DuongDan.Instance.ImagePath() + ketQua[i].detailedShoesId + ".png";
                    lblPic3.Text = ketQua[i].detailedShoesId;
                    pbxImage3.Visible = true;
                    pbxImage3.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    pbxImage3.Image = null;
                    lblPic3.Text = "";
                    pbxImage3.BackColor = Color.Silver;
                    pbxImage3.Visible = false;
                }
            }
            if (i % 6 == 3)
            {
                if (i < ketQua.Count)
                {
                    pbxImage4.ImageLocation = BLL_DuongDan.Instance.ImagePath() + ketQua[i].detailedShoesId + ".png";
                    lblPic4.Text = ketQua[i].detailedShoesId;
                    pbxImage4.Visible = true;
                    pbxImage4.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    pbxImage4.Image = null;
                    lblPic4.Text = "";
                    pbxImage4.BackColor = Color.Silver;
                    pbxImage4.Visible = false;
                }
            }
            if (i % 6 == 4)
            {
                if (i < ketQua.Count)
                {
                    pbxImage5.ImageLocation = BLL_DuongDan.Instance.ImagePath() + ketQua[i].detailedShoesId + ".png";
                    lblPic5.Text = ketQua[i].detailedShoesId;
                    pbxImage5.Visible = true;
                    pbxImage5.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    pbxImage5.Image = null;
                    lblPic5.Text = "";
                    pbxImage5.BackColor = Color.Silver;
                    pbxImage5.Visible = false;
                }
            }
            if (i % 6 == 5)
            {
                if (i < ketQua.Count)
                {
                    pbxImage6.ImageLocation = BLL_DuongDan.Instance.ImagePath() + ketQua[i].detailedShoesId + ".png";

                    lblPic6.Text = ketQua[i].detailedShoesId;
                    pbxImage6.Visible = true;
                    pbxImage6.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    pbxImage6.Image = null;
                    lblPic6.Text = "";
                    pbxImage6.BackColor = Color.Silver;
                    pbxImage6.Visible = false;
                }
            }
        }
        private void btn5_5_Click(object sender, EventArgs e)
        {
            SetSizeToList(sender, "5.5");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            NutPhai();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (n > 0)
            {
                n = n - 6;
            }
            for (int i = n; i < (n + 6); i++)
            {
                SetPicBox(i);
            }
            if (0 <= n || n <= 6)
            {
                btnPrevious.Hide();
            }
            if (n != 0)
            {
                btnPrevious.Visible = true;
            }
            if (n + 6 < ketQua.Count)
            {
                btnNext.Visible = true;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            SetSizeToList(sender, "5");
        }

        private void btn4_5_Click(object sender, EventArgs e)
        {
            SetSizeToList(sender, "4.5");
        }

        void SetSizeToList(object sender, string s)
        {
            for (int i = 0; i < size.Count; i++)
            {
                if (size[i].Equals(s))
                {
                    size.RemoveAt(i);
                    ((Button)sender).ForeColor = Color.Black;
                    return;
                }
            }
            size.Add(s);
            ((Button)sender).ForeColor = Color.Red;
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            SetSizeToList(sender, "4");
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
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(childForm);
            this.panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
       
        public void trangThai(bool tt, int sl)
        {
            if (tt)
            {
                Dadd(id, sl);
                this.Dispose();
            }
        }
        private void pbxImage2_Click(object sender, EventArgs e)
        {
            string url = ((PictureBox)sender).ImageLocation.ToString();
            id = BLL_HoaDon.Instance.ChuyenUrlforId(url);
            FormHienThiSanPham f = new FormHienThiSanPham(id);
            f.D += new FormHienThiSanPham.setTT(trangThai);
            f.Show();

        }

        private void pbxImage3_Click(object sender, EventArgs e)
        {
            string url = ((PictureBox)sender).ImageLocation.ToString();
            id = BLL_HoaDon.Instance.ChuyenUrlforId(url);
            FormHienThiSanPham f = new FormHienThiSanPham(id);
            f.D += new FormHienThiSanPham.setTT(trangThai);
            f.Show();
        }

        private void pbxImage4_Click(object sender, EventArgs e)
        {
            string url = ((PictureBox)sender).ImageLocation.ToString();
            id = BLL_HoaDon.Instance.ChuyenUrlforId(url);
            FormHienThiSanPham f = new FormHienThiSanPham(id);
            f.D += new FormHienThiSanPham.setTT(trangThai);
            f.Show();
        }


        private void pbxImage5_Click(object sender, EventArgs e)
        {
            string url = ((PictureBox)sender).ImageLocation.ToString();
            id = BLL_HoaDon.Instance.ChuyenUrlforId(url);
            FormHienThiSanPham f = new FormHienThiSanPham(id);
            f.D += new FormHienThiSanPham.setTT(trangThai);
            f.Show();
        }

        private void pbxImage6_Click(object sender, EventArgs e)
        {
            string url = ((PictureBox)sender).ImageLocation.ToString();
            id = BLL_HoaDon.Instance.ChuyenUrlforId(url);
            FormHienThiSanPham f = new FormHienThiSanPham(id);
            f.D += new FormHienThiSanPham.setTT(trangThai);
            f.Show();
        }

        private void pbxImage1_Click(object sender, EventArgs e)
        {


            string url = ((PictureBox)sender).ImageLocation.ToString();
            id = BLL_HoaDon.Instance.ChuyenUrlforId(url);
            FormHienThiSanPham f = new FormHienThiSanPham(id);
            f.D += new FormHienThiSanPham.setTT(trangThai);
            f.Show();
        }


        private void pbxDo_Click(object sender, EventArgs e)
        {
            SetListMau(sender, "red");
        }
        private void pbxVang_Click(object sender, EventArgs e)
        {
            SetListMau(sender, "yellow");
        }

        private void pbxXanhLaCay_Click(object sender, EventArgs e)
        {
            SetListMau(sender, "green");
        }

        private void pbxHong_Click(object sender, EventArgs e)
        {
            SetListMau(sender, "pink");
        }

        private void pbxDen_Click(object sender, EventArgs e)
        {
            SetListMau(sender, "black");
        }

        private void pbxTrang_Click(object sender, EventArgs e)
        {
            SetListMau(sender, "white");
        }

        private void pbxTim_Click(object sender, EventArgs e)
        {
            SetListMau(sender, "violet");
        }

        private void pbxXanhDuong_Click(object sender, EventArgs e)
        {
            SetListMau(sender, "blue");
        }
        private void pbxCam_Click(object sender, EventArgs e)
        {
            SetListMau(sender, "orange");
        }
    }
}
