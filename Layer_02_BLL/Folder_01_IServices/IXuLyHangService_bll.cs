using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layer_01_DAL.Folder_01_Entities;

namespace Layer_02_BLL.Folder_01_IServices
{
    public interface IXuLyHangService_bll
    {
        bool TaoThemHang_Bll(Hang_dal hang);
        List<Hang_dal> DocLayToanBoHang_Bll();
        Hang_dal DocLayIdHang_Bll(int id);
        bool CapNhatHang_Bll(Hang_dal hang);
        bool XoaHang_Bll(int id);
    }
}
