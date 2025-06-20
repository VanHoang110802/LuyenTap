using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer_01_DAL.Folder_01_Entities
{
    public class Hang_dal
    {
        public int MaHang { get; set; }
        public string TenHang { get; set; }

        // muốn sử dụng cả sản phẩm:
        public List<SanPham_dal> SanPham_dals { get; set; }
    }
}
