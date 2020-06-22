using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH4.modules
{
    class XLSANPHAM : XLBANG
    {
        public XLSANPHAM() : base("SANPHAM") { }
        public XLSANPHAM(string pquery) : base("SANPHAM", pquery) { }
    }
}
