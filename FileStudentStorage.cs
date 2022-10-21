using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    internal class FileStudentStorage :  IStudentStorage
    {
        List<SV> listSV = new List<SV>();
        string fileName = "dssv.txt";

        public List<SV> ListSV 
        { 
            set { listSV = value; }
            get { return listSV; } 
        }
        public void Read()
        {
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sReader = new StreamReader(fs);
            while (sReader.Peek() >= 0)
            {
                SV sv = new SV();
                string line = sReader.ReadLine();
                string[] listInfo = line.Split('|');
                sv.Mssv = listInfo[0];
                sv.Hoten = listInfo[1];
                sv.Malop = listInfo[2];
                sv.Dtb = Convert.ToDouble(listInfo[3]);
                listSV.Add(sv);
            }
            sReader.Close();
            fs.Close();
        }

        public void Write(SV sv)
        {
            FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            StreamWriter sWriter = new StreamWriter(fs);
            sWriter.WriteLine(sv);
            sWriter.Flush();
            fs.Close();
            listSV.Add(sv);
        }
        public void Write(string sv)
        {
            FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            StreamWriter sWriter = new StreamWriter(fs);
            sWriter.WriteLine(sv);
            sWriter.Flush();
            fs.Close();
            string[] splitSV = sv.Split('|');
            SV sv2 = new SV(splitSV[0], splitSV[1], splitSV[2], splitSV[3]);
            listSV.Add(sv2);
        }

        public void Edit(SV beforeSV, SV afterSV)
        {
            Read();
            FileStream fs = new FileStream(fileName, FileMode.Truncate, FileAccess.Write);
            StreamWriter sWriter = new StreamWriter(fs);
            for (int i = 0; i < listSV.Count; i++)
            {
                SV sv = listSV[i];
                if (sv.Equals(beforeSV))
                {
                    listSV[i] = afterSV;
                    break;
                }
            }
            foreach (SV sv in listSV)
            {
                sWriter.WriteLine(sv);
            }
            sWriter.Flush();
            fs.Close();

        }
    }
}
