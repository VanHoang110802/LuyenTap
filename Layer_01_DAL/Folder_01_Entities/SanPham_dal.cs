using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer_01_DAL.Folder_01_Entities
{
    public class SanPham_dal
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public double Gia { get; set; }

        public int MaHang { get; set; }
        public bool TinhTrang { get; set; }

        // liên kết đến bảng Hang để lấy tên hãng
        public Hang_dal hang_dal { get; set; }
    }
}
