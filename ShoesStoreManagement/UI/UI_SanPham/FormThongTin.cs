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
    public partial class FormThongTin : Form
    {
        public FormThongTin(string maSp)
        {
            InitializeComponent();
            DetailedSho thongTin = new DetailedSho();
            thongTin = BLL_Giay.Instance.GetDetailedShoes(maSp);
           
            lblTen.Text = thongTin.Sho.shoesName;
            lblKichThuoc.Text = thongTin.shoesSize.ToString();
            lblMauSac.Text = thongTin.shoesColor.ToString();
            lblSoLuong.Text = thongTin.shoesQuantity.ToString();
        }
    }
}
