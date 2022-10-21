using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    internal interface IStudentStorage
    {
        void Read();
        void Write(SV sv);
        void Write(string sv);
        void Edit(SV beforeSV, SV afterSV);
    }
}
