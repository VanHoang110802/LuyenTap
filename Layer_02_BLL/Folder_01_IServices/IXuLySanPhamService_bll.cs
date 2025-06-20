using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layer_01_DAL.Folder_01_Entities;
using Layer_02_BLL.Folder_03_Models;

namespace Layer_02_BLL.Folder_01_IServices
{
    public interface IXuLySanPhamService_bll
    {
        bool TaoThemSanPham_Bll(SanPham_dal sanPham);
        List<SanPham_dal> DocLayToanBoSanPham_Bll();
        SanPham_dal DocLayIdSanPham_Bll(int id);
        bool CapNhatSanPham_Bll(SanPham_dal sanPham);
        bool XoaSanPham_Bll(int id);
        List<SanPham_dal> TimKiemSanPhamBll(string keyword);

        List<SanPhamWithHang_bll> DocLaySanPhamWithHang_Bll();
    }
}
