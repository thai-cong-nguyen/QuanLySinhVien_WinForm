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
    public partial class SearchForm : Form 
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void search_Click(object sender, EventArgs e)
        {
            NotifyForm notifyForm;
            if (mssv_search_textBox.Text == "")
            {
                notifyForm = new NotifyForm("Chưa nhập thông tin");
                notifyForm.ShowDialog();
                return;
            }
            FileStudentStorage fileStudentStorage = new FileStudentStorage();
            fileStudentStorage.Read();
            int flag = 0;
            string mssv = mssv_search_textBox.Text;
            SV foundSV = new SV();
            List<SV> listSV = fileStudentStorage.ListSV;
            foreach (SV sv in listSV)
            {
                if (mssv == sv.Mssv)
                {
                    flag = 1;
                    foundSV = sv;
                    break;
                }
            }
            if (flag == 0)
            {
                notifyForm = new NotifyForm("Không tìm thấy sinh viên");
                notifyForm.ShowDialog();
                return;
            }
            EditForm editform = new EditForm(foundSV);
            editform.ShowDialog();
        }

        private void enter_Press(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mssv_search_textBox.Text = mssv_search_textBox.Text.Trim();
                search_Click(this, new EventArgs());
            }
        }
    }
}
