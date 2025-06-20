using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layer_01_DAL.Folder_01_Entities;

namespace Layer_01_DAL.Folder_03_IDALServices
{
    public interface IHangService_dal
    {
        bool TaoThemHang_Dal(Hang_dal hang);
        List<Hang_dal> DocLayToanBoHang_Dal();
        Hang_dal DocLayIdHang_Dal(int id);
        bool CapNhatHang_Dal(Hang_dal hang);
        bool XoaHang_Dal(int id);
    }
}
