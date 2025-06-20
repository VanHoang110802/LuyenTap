using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer_02_BLL.Folder_03_Models
{
    public class SanPhamWithHang_bll
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public double Gia { get; set; }
        public int MaHang { get; set; }
        public string TenHang { get; set; }
        public bool TinhTrang { get; set; }
    }
}
