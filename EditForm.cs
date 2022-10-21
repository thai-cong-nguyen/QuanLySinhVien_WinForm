using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class EditForm : Form
    {
        FileStudentStorage fileStudentStorage = new FileStudentStorage();
        SV currentSV = new SV();
        public EditForm(SV sv)
        {
            InitializeComponent();
            mssv_textBox.Text = sv.Mssv;
            ten_textBox.Text = sv.Hoten;
            malop_textBox.Text = sv.Malop;
            dtb_textBox.Text = sv.Dtb.ToString();
            currentSV = sv;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            NotifyForm notifyForm;
            string mssv = mssv_textBox.Text;
            string ten = ten_textBox.Text;
            string malop = malop_textBox.Text;
            string dtb = dtb_textBox.Text;
            if (mssv == currentSV.Mssv && ten == currentSV.Hoten && malop == currentSV.Malop && dtb == currentSV.Dtb.ToString())
            {
                notifyForm = new NotifyForm("Không có thông tin nào thay đổi");
                notifyForm.ShowDialog();
                return;
            }
            SV afterSV = new SV(mssv, ten, malop, dtb);
            fileStudentStorage.Edit(currentSV, afterSV);
            notifyForm = new NotifyForm("Chỉnh sửa thông tin thành công");
            notifyForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mssv_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ten_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void malop_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void dtb_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void enter_Press(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mssv_textBox.Text = mssv_textBox.Text.Trim();
                ten_textBox.Text = ten_textBox.Text.Trim();
                malop_textBox.Text = malop_textBox.Text.Trim();
                dtb_textBox.Text = dtb_textBox.Text.Trim();
                save_Click(this, new EventArgs());
            }
        }
    }
}
