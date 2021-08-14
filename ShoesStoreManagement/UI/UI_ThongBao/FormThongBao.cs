using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoesStoreManagement.UI.UI_ThongBao
{
    public partial class FormThongBao : Form
    {
        private FormThongBao(string thongBao)
        {
            InitializeComponent();
            lblThongBao.Text = thongBao;
        }
        internal static void Show(string thongBao)
        {
            FormThongBao _ThongBao = new FormThongBao(thongBao);
            _ThongBao.ShowDialog();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
