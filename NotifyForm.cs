using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class NotifyForm : Form
    {
        private System.Windows.Forms.Timer tmr;
        public NotifyForm(string _textNotify)
        {
            InitializeComponent();
            tmr = new System.Windows.Forms.Timer();
            tmr.Tick += delegate {
                this.Close();
            };
            tmr.Interval = (int)TimeSpan.FromMinutes(2.5/60).TotalMilliseconds;
            tmr.Start();
            labelNotify.Text = _textNotify;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
