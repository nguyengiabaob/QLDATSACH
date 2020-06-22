using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH4.modules
{
    class XLNHANVIEN : XLBANG
    {
        public XLNHANVIEN() : base("NHANVIEN") { }
        public XLNHANVIEN(string pquery) : base("NHANVIEN", pquery) { }
    }
}
