using Layer_01_DAL.Folder_01_Entities;
using Layer_01_DAL.Folder_04_DALServices;
using Layer_02_BLL.Folder_01_IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer_02_BLL.Folder_02_Services
{
    public class XuLyHangService_bll : IXuLyHangService_bll
    {
        private readonly HangService_dal _hang_dal;
        public XuLyHangService_bll()
        {
            _hang_dal = new HangService_dal();
        }

        public bool TaoThemHang_Bll(Hang_dal hang)
        {
            return _hang_dal.TaoThemHang_Dal(hang);
        }
        public List<Hang_dal> DocLayToanBoHang_Bll()
        {
            return _hang_dal.DocLayToanBoHang_Dal();
        }
        public Hang_dal DocLayIdHang_Bll(int id)
        {
            return _hang_dal.DocLayIdHang_Dal(id);
        }
        public bool CapNhatHang_Bll(Hang_dal hang)
        {
            return _hang_dal.CapNhatHang_Dal(hang);

        }
        public bool XoaHang_Bll(int id)
        {
            return _hang_dal.XoaHang_Dal(id);
        }
    }
}
