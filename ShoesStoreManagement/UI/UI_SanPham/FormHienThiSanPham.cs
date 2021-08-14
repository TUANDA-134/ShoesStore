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

namespace ShoesStoreManagement.UI.UI_SanPham
{//oke
    public partial class FormHienThiSanPham : Form
    {

        public string idShoes { get; set; }
        public delegate void setTT(bool tt, int sl);
        public setTT D { get; set; }
        public FormHienThiSanPham(string id)
        {
            InitializeComponent();
            idShoes = id;
            setGui();
            setCBB();
        }
        public void setCBBDoubleClick()
        {
            tbSoluong.Items.Clear();
            DTO_Shoes s = BLL_HoaDon.Instance.getShoesbyId(idShoes);
            int soluong = s.soluong;

            if (soluong > 0)
            {
                for (int i = 1; i <= soluong; i++)
                {
                    tbSoluong.Items.Add(i);
                }

            }
            else
            {
                tbSoluong.Items.Add(0);
            }
            tbSoluong.SelectedIndex = 0;
        }
        public void setCBB()
        {
            DTO_Shoes d = BLL_HoaDon.Instance.kiemTraSoLuong(idShoes);
            List<DTO_Shoes> listShoe = BLL_HoaDon.Instance.GetListDetailShoesID();

            int soluong = d.soluong;
            foreach (DTO_Shoes i in listShoe)
            {
                if (i.detailShoeId == idShoes)
                {
                    soluong = soluong - i.soluong;
                    txtSoL.Text = soluong.ToString();
                }
            }

            if (soluong > 0)
            {
                for (int i = 1; i <= soluong; i++)
                {
                    tbSoluong.Items.Add(i);
                }

            }
            else
            {
                tbSoluong.Items.Add(0);
            }
            tbSoluong.SelectedIndex = 0;
        }
        public FormHienThiSanPham()
        {
            InitializeComponent();
            setGui();
        }
        public void setGui()
        {
            DTO_Shoes s = BLL_HoaDon.Instance.getShoesbyId(idShoes);
            if (s != null)
            {
                txtid.Text = s.detailShoeId;
                tenGiay.Text = s.TenGiay;
                txtSoL.Text = s.soluong.ToString();
                txtGia.Text = s.gia.ToString();
                txtHang.Text = s.HangGiay;
                txtLoai.Text = s.kieuGiay;
                txtSize.Text = s.size.ToString();
                pBimage.ImageLocation = BLL_DuongDan.Instance.ImagePath() + s.detailShoeId + ".png";
            }
        }

        private void btnExitScreen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idShoes != null && tbSoluong.SelectedItem.ToString() != "0")
            {

                int soluong = tbSoluong.SelectedIndex + 1;
                D(true, soluong);
                this.Dispose();
            }
            else
            {
                FormThongBao.Show("Số lượng là " + tbSoluong.SelectedItem.ToString() + " nên không thể thêm");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }

}
