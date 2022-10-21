using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        FileStudentStorage fileStudentStorage = new FileStudentStorage();
        string sv = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.ShowDialog();
        }

        private void save_Click(object sender, EventArgs e)
        {
            string mssv = mssv_textBox.Text;
            string ten = ten_textBox.Text;
            string malop = malop_textBox.Text;
            string dtb = dtb_textBox.Text;
            if (mssv == "" || ten == "" || malop == "" || dtb == "")
            {
                NotifyForm notify = new NotifyForm("Chưa Nhập Thông Tin");
                notify.ShowDialog();
            }
            else
            {
                sv = mssv + "|" + ten + "|" + malop + "|" + dtb;
                fileStudentStorage.Write(sv);
                sv = "";
                NotifyForm notify = new NotifyForm("Thêm thành công");
                notify.ShowDialog();
                mssv_textBox.Text = "";
                ten_textBox.Text = "";
                malop_textBox.Text = "";
                dtb_textBox.Text = "";
            }
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
