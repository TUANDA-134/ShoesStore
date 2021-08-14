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
    public partial class Time : Form
    {
        int formWidth;
        int formHeight;
        public Time()
        {
            InitializeComponent();
            TimeMainForm.Enabled = true;
            TimeMainForm.Start();
            formWidth = this.Width;
            formHeight = this.Height;
            SetLocationOfLabelTime();
        }

        private void TimeMainForm_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss");
        }
        private void SetLocationOfLabelTime()
        {
            lblTime.Left = Convert.ToInt32((formWidth - lblTime.Size.Width) / 10);
            lblTime.Top = Convert.ToInt32((formHeight - lblTime.Size.Height) / 2);
        }
    }
}
