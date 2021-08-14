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

namespace ShoesStoreManagement.UI.UI_ThongKe
{
    public partial class FormBieuDo : Form
    {
        public FormBieuDo()
        {
            InitializeComponent();
            setGUI();
            
        }

        public void setGUI()
        {
            cbbDThu.Items.Add("2019");
            cbbDThu.Items.Add("2020");
            cbbDThu.Items.Add("2021");
            cbbLG.Items.Add("Tháng này");
            cbbLG.Items.Add("Tháng trước");
            cbbtop.Items.Add("Mua nhiều nhất 7 ngày trước");
            cbbtop.Items.Add("Mua nhiều nhất tháng này");
            cbbtop.Items.Add("Mua nhiều nhất tháng trước");
            cbbDThu.Text = "2021";
            cbbLG.Text = "Tháng này";
            cbbtop.Text = "Mua nhiều nhất tháng này";
            lbltdt2.Text = BLL_ThongKe.Instance.tongdoanhthu().ToString() + " $";
            lbltdh2.Text = BLL_ThongKe.Instance.tongdonhang().ToString();
            lbltsp2.Text = BLL_ThongKe.Instance.tongsanpham().ToString();
        }

        public void VeBDDT(string year)
        {
            DateTime tn = new DateTime(Convert.ToInt32(year), 1, 1);
            DateTime dn;
            if (year == DateTime.Now.Year.ToString())
            {
                dn = DateTime.Now;
            }
            else
            {
                dn = new DateTime(Convert.ToInt32(year), 12, 31);
            }
            float[] arr = BLL_ThongKe.Instance.thongke(tn, dn);
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart1.ChartAreas["ChartArea1"].AxisX.Maximum = 12.4;
            chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 8, System.Drawing.FontStyle.Regular);
            chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 8, System.Drawing.FontStyle.Regular);

            String[] months = new string[]
            {
                "Jan", "Feb" , "Mar", "Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec"
            };
           
            for (int i = 1; i < 13; i++)
            {

                chart1.Series["Doanh thu năm"].Points.AddXY(months[i - 1], arr[i]);
            }
        }








        private void cbbDThu_SelectedValueChanged(object sender, EventArgs e)
        {

            if (cbbDThu.SelectedItem.ToString() == "2021")
            {
                VeBDDT(cbbDThu.SelectedItem.ToString());
            }
            else if (cbbDThu.SelectedItem.ToString() == "2020")
            {
                VeBDDT("2020");
            }
            else if (cbbDThu.SelectedItem.ToString() == "2019")
            {

                VeBDDT("2019");
            }

        }

        private void cbbLG_SelectedValueChanged(object sender, EventArgs e)
        {

            if (cbbLG.SelectedItem.ToString() == "Tháng này")
            {
                foreach (var series in chartLG.Series)
                {
                    series.Points.Clear();
                }
                DateTime tn = new DateTime((int)DateTime.Now.Year, (int)DateTime.Now.Month, 1);
                List<DTO_LoaiGiayBan> list = BLL_ThongKe.Instance.gettopLG(tn, DateTime.Now);
                for (int i = 0; i < 5; i++)
                {

                    if (list[i].quantity != 0)
                    {
                        chartLG.Series[0].Points.AddXY(list[i].shoesType, list[i].quantity);
                    }
                }


            }
            else if (cbbLG.SelectedItem.ToString() == "Tháng trước")
            {
                foreach (var series in chartLG.Series)
                {
                    series.Points.Clear();
                }
                int month = (int)DateTime.Now.Month - 1;
                DateTime tn = new DateTime((int)DateTime.Now.Year, (int)DateTime.Now.Month - 1, 1);
                DateTime dn = new DateTime((int)DateTime.Now.Year, (int)DateTime.Now.Month - 1, DateTime.DaysInMonth((int)DateTime.Now.Year, month));
                List<DTO_LoaiGiayBan> list = BLL_ThongKe.Instance.gettopLG(tn, dn);
                chartLG.ChartAreas["ChartArea1"].AxisY.Interval = 1;

                for (int i = 0; i < 5; i++)
                {
                    if (list[i].quantity != 0)
                    {
                        chartLG.Series[0].Points.AddXY(list[i].shoesType, list[i].quantity);
                    }
                }
            }

        }

        private void cbbtop_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbtop.SelectedItem.ToString() == "Mua nhiều nhất 7 ngày trước")
            {
                foreach (var series in chart3.Series)
                {
                    series.Points.Clear();
                }
                DateTime tn = new DateTime((int)DateTime.Now.Year, (int)DateTime.Now.Month, (int)DateTime.Now.Day - 7);
                List<DTO_GiayXuat> list = BLL_ThongKe.Instance.gettop(tn, DateTime.Now);
                for (int i = 0; i < 5; i++)
                {
                    if (list[i].soluong != 0)
                        chart3.Series["Series1"].Points.AddXY(list[i].NameShoes, list[i].soluong);
                }
            }
            else if (cbbtop.SelectedItem.ToString() == "Mua nhiều nhất tháng này")
            {
                foreach (var series in chart3.Series)
                {
                    series.Points.Clear();
                }
                DateTime tn = new DateTime((int)DateTime.Now.Year, (int)DateTime.Now.Month, 1);
                List<DTO_GiayXuat> list = BLL_ThongKe.Instance.gettop(tn, DateTime.Now);
                for (int i = 0; i < 5; i++)
                {
                    if (list[i].soluong != 0)
                        chart3.Series["Series1"].Points.AddXY(list[i].NameShoes, list[i].soluong);
                }
            }
            else if (cbbtop.SelectedItem.ToString() == "Mua nhiều nhất tháng trước")
            {
                foreach (var series in chart3.Series)
                {
                    series.Points.Clear();
                }
                int month = (int)DateTime.Now.Month - 1;
                DateTime tn = new DateTime((int)DateTime.Now.Year, (int)DateTime.Now.Month - 1, 1);
                DateTime dn = new DateTime((int)DateTime.Now.Year, (int)DateTime.Now.Month - 1, DateTime.DaysInMonth((int)DateTime.Now.Year, month));
                List<DTO_GiayXuat> list = BLL_ThongKe.Instance.gettop(tn, dn);
                for (int i = 0; i < 5; i++)
                {
                    if (list[i].soluong != 0)
                        chart3.Series["Series1"].Points.AddXY(list[i].NameShoes, list[i].soluong);
                }
            }
        }
    }
}

