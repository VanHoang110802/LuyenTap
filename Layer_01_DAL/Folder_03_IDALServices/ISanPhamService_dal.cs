using Layer_01_DAL.Folder_01_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer_01_DAL.Folder_03_IDALServices
{
    public interface ISanPhamService_dal
    {
        bool TaoThemSanPham_Dal(SanPham_dal sanPham);
        List<SanPham_dal> DocLayToanBoSanPham_Dal();
        SanPham_dal DocLayIdSanPham_Dal(int id);
        bool CapNhatSanPham_Dal(SanPham_dal sanPham);
        bool XoaSanPham_Dal(int id);

        List<SanPham_dal> TimKiemSanPhamTheoTen_Dal(string keyword);
    }
}
