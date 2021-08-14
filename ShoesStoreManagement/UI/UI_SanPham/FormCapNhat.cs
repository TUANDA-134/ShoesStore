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
{
    public partial class FormCapNhat : Form
    {
        internal delegate void myDel(List<DTO_KichThuoc> kichThuoc);
        internal myDel d;
        List<DTO_KichThuoc> kThuocBanDau = new List<DTO_KichThuoc>();
        List<DTO_KichThuoc> kThuocCapNhat = new List<DTO_KichThuoc>();
        bool check = true;
        string mauSac = null;
        string maGiay = null;
        string pathAnh = null;
        internal FormCapNhat(List<DTO_KichThuoc> KThuoc, string mau, string ID, string pathAnh1)
        {
            InitializeComponent();
            SetTextBox(KThuoc);//đưa dữ liệu lên UI
            mauSac = mau;//mau giay
            maGiay = ID;//Ma san pham
            pathAnh = pathAnh1;//Đường dẫn ảnh 
        }
        public void TextChanged(object sender, EventArgs e, float n)
        {
            DTO_KichThuoc d;
            if (((TextBox)(sender)).Text.Equals(""))
            {

                d = kThuocCapNhat.Where(p => p.Size.Equals(n)).FirstOrDefault();
                if (d == null)
                {
                }
                else
                {
                    kThuocCapNhat.Remove(d);
                }
            }
            else
            {
                if (((TextBox)(sender)).Text.Equals("0"))
                {
                    d = kThuocCapNhat.Where(p => p.Size.Equals(n)).FirstOrDefault();
                    if (d == null)
                    {
                    }
                    else
                    {
                        kThuocCapNhat.Remove(d);
                    }
                }
                else
                if (!((TextBox)(sender)).Text.Equals(""))
                {
                    try
                    {
                        d = kThuocCapNhat.Where(p => p.Size.Equals(n)).SingleOrDefault();
                        int t = Convert.ToInt32(((TextBox)(sender)).Text);
                        if (d == null)
                        {
                            d = new DTO_KichThuoc();
                            d.Size = n;
                            d.SoLuong = t;
                            kThuocCapNhat.Add(d);
                        }
                        else
                        {
                            kThuocCapNhat.Remove(d);
                            d.SoLuong = t;
                            kThuocCapNhat.Add(d);
                        }

                    }
                    catch
                    {
                        FormThongBao.Show("Vui lòng nhập số");
                        ((TextBox)(sender)).Text = ((TextBox)(sender)).Text.Remove(((TextBox)(sender)).Text.Length - 1);
                        return;
                    }
                }
            }
        }
        internal void SetTextBox(List<DTO_KichThuoc> kichThuoc)
        {
            kThuocBanDau = kichThuoc;
            for (int i = 0; i < kichThuoc.Count; i++)
            {
                string t = kichThuoc[i].SoLuong.ToString();
                if (kichThuoc[i].Size == 4)
                {
                    tbx4.Text = t;
                    continue;
                }
                if (kichThuoc[i].Size == 4.5)
                {

                    tbx4_5.Text = t;
                    continue;
                }
                if (kichThuoc[i].Size == 5)
                {
                    tbx5.Text = t;
                    continue;
                }
                if (kichThuoc[i].Size == 5.5)
                {
                    tbx5_5.Text = t;
                    continue;
                }
                if (kichThuoc[i].Size == 6)
                {
                    tbx6.Text = t;
                    continue;
                }
                if (kichThuoc[i].Size == 6.5)
                {
                    tbx6_5.Text = t;
                    continue;
                }
                if (kichThuoc[i].Size == 7)
                {
                    tbx7.Text = t;
                    continue;
                }
                if (kichThuoc[i].Size == 7.5)
                {
                    tbx7_5.Text = t;
                    continue;
                }
                if (kichThuoc[i].Size == 8)
                {
                    tbx8.Text = t;
                    continue;
                }
                if (kichThuoc[i].Size == 8.5)
                {
                    tbx8_5.Text = t;
                    continue;
                }
                if (kichThuoc[i].Size == 9)
                {
                    tbx9.Text = t;
                    continue;
                }
                if (kichThuoc[i].Size == 9.5)
                {
                    tbx9_5.Text = t;
                    continue;
                }
                if (kichThuoc[i].Size == 10)
                {
                    tbx10.Text = t;
                    continue;
                }
                if (kichThuoc[i].Size == 10.5)
                {
                    tbx10_5.Text = t;
                    continue;
                }
                if (kichThuoc[i].Size == 11)
                {
                    tbx11.Text = t;
                    continue;
                }
                if (kichThuoc[i].Size == 11.5)
                {
                    tbx11_5.Text = t;
                    continue;
                }
                if (kichThuoc[i].Size == 12)
                {
                    tbx12.Text = t;
                    continue;
                }

            }
        }
        private void lblNhapHang_Click(object sender, EventArgs e)
        {
            check = true;
            pnlNhapHang.BackColor = Color.AliceBlue;
            lblNhapHang.ForeColor = Color.Black;
            pnlXuatHang.BackColor = Color.FromArgb(26, 25, 62);
            lblXuatHang.ForeColor = Color.White;
        }

        private void lblXuatHang_Click(object sender, EventArgs e)
        {
            check = false;
            pnlNhapHang.BackColor = Color.FromArgb(26, 25, 62); ;
            lblNhapHang.ForeColor = Color.White;
            pnlXuatHang.BackColor = Color.AliceBlue;
            lblXuatHang.ForeColor = Color.Black;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            List<DTO_KichThuoc> kThuocSauCapNhat = new List<DTO_KichThuoc>();
            if (check)
            {
                for (int i = 0; i < kThuocCapNhat.Count; i++)
                {
                    bool ktr = false;
                    for (int j = 0; j < kThuocBanDau.Count; j++)
                    {
                        if (kThuocCapNhat[i].Size.Equals(kThuocBanDau[j].Size))
                        {
                            FormThongBao.Show((kThuocBanDau[j].SoLuong.ToString()) + (kThuocCapNhat[i].SoLuong.ToString()));
                            kThuocSauCapNhat.Add(new DTO_KichThuoc { Size = kThuocBanDau[j].Size, SoLuong = ((kThuocBanDau[j].SoLuong) + (kThuocCapNhat[i].SoLuong)) });
                            ktr = true;
                            break;
                        }
                    }
                    if (!ktr)
                    {
                        kThuocSauCapNhat.Add(kThuocCapNhat[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < kThuocCapNhat.Count; i++)
                {
                    bool co = false;
                    for (int j = 0; j < kThuocBanDau.Count; j++)
                    {
                        if (kThuocBanDau[j].Size.Equals(kThuocCapNhat[i].Size))
                        {
                            if (kThuocBanDau[j].SoLuong >= kThuocCapNhat[i].SoLuong)
                            {
                                kThuocSauCapNhat.Add(new DTO_KichThuoc { Size = kThuocBanDau[j].Size, SoLuong = kThuocBanDau[j].SoLuong - kThuocCapNhat[i].SoLuong });
                                co = true;
                                break;
                            }
                            else
                            {
 //                               //FormThongBao.Show(kThuocBanDau[j].SoLuong.ToString() + "" + kThuocCapNhat[i].SoLuong.ToString());
                                string t = "Size " + kThuocCapNhat[i].Size.ToString() + " có số lượng sản phẩm xuất kho vượt số sản phẩm hiện tại";
                                FormThongBao.Show(t);
                                return;
                            }
                        }

                    }
                    if (!co)
                    {
                        string t = "Size " + kThuocCapNhat[i].Size.ToString() + " hiện không tồn tại sản phẩm trong kho";
                        FormThongBao.Show(t);
                        return;
                    }
                }

            }
            BLL_Giay.Instance.CapNhatGiay(kThuocSauCapNhat, mauSac, maGiay, pathAnh);
            d(kThuocSauCapNhat);
            this.Close();
        }

        private void tb4_TextChanged(object sender, EventArgs e)
        {
            TextChanged(sender, e, 4);
        }

        private void tb4_5_TextChanged(object sender, EventArgs e)
        {
            TextChanged(sender, e, (float)4.5);
        }

        private void tb5_TextChanged(object sender, EventArgs e)
        {
            TextChanged(sender, e, 5);
        }

        private void tb5_5_TextChanged(object sender, EventArgs e)
        {
            TextChanged(sender, e, (float)5.5);
        }

        private void tb6_TextChanged(object sender, EventArgs e)
        {
            TextChanged(sender, e, 6);
        }

        private void tb6_5_TextChanged(object sender, EventArgs e)
        {
            TextChanged(sender, e, (float)6.5);
        }

        private void tb7_TextChanged(object sender, EventArgs e)
        {
            TextChanged(sender, e, 7);
        }

        private void tb7_5_TextChanged(object sender, EventArgs e)
        {
            TextChanged(sender, e, (float)7.5);
        }

        private void tb8_TextChanged(object sender, EventArgs e)
        {
            TextChanged(sender, e, 8);
        }

        private void tb8_5_TextChanged(object sender, EventArgs e)
        {
            TextChanged(sender, e, (float)8.5);
        }

        private void tb9_TextChanged(object sender, EventArgs e)
        {
            TextChanged(sender, e, 9);
        }

        private void tb9_5_TextChanged(object sender, EventArgs e)
        {
            TextChanged(sender, e, (float)9.5);
        }

        private void tb10_TextChanged(object sender, EventArgs e)
        {
            TextChanged(sender, e, 10);
        }

        private void tb10_5_TextChanged(object sender, EventArgs e)
        {
            TextChanged(sender, e, (float)10.5);
        }

        private void tb11_TextChanged(object sender, EventArgs e)
        {
            TextChanged(sender, e, 11);
        }

        private void tb11_5_TextChanged(object sender, EventArgs e)
        {
            TextChanged(sender, e, (float)11.5);
        }

        private void tb12_TextChanged(object sender, EventArgs e)
        {
            TextChanged(sender, e, 12);
        }


    }
}
