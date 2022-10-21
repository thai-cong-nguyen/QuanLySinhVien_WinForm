using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QuanLySinhVien
{
    public class SV
    {
        private string mssv;
        private string hoten;
        private string malop;
        private double dtb;

        public SV()
        {
        }
        public SV(string mssv, string hoten, string malop, double dtb)
        {
            Mssv = mssv;
            Hoten = hoten;
            Malop = malop;
            Dtb = dtb;
        }
        public SV(string mssv, string hoten, string malop, string dtb)
        {
            Mssv = mssv;
            Hoten = hoten;
            Malop = malop;
            Dtb = Convert.ToDouble(dtb);
        }

        public string Mssv
        {
            get { return mssv; }
            set { mssv = value; }
        }

        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }

        public string Malop
        {
            get { return malop; }
            set { malop = value; }
        }

        public double Dtb
        {
            get { return dtb; }
            set { dtb = value; }
        }
        public bool Equals(SV otherSv)
        {
            return (mssv == otherSv.Mssv && hoten == otherSv.Hoten && malop == otherSv.Malop && dtb == otherSv.Dtb);
        }
        public void Output()
        {
            Console.WriteLine(mssv + "\t" + hoten + "\t" + malop + "\t" + dtb);
        }

        public override string ToString()
        {
            return mssv + "|" + hoten + "|" + malop + "|" + dtb.ToString();
        }
    }
}
