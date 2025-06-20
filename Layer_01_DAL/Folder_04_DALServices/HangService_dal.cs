using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layer_01_DAL.Folder_01_Entities;
using Layer_01_DAL.Folder_02_DatabaseContext;
using Layer_01_DAL.Folder_03_IDALServices;

namespace Layer_01_DAL.Folder_04_DALServices
{
    public class HangService_dal : IHangService_dal
    {
        private readonly DatabaseContext _context;
        public HangService_dal()
        {
            _context = new DatabaseContext();
        }
        public bool TaoThemHang_Dal(Hang_dal hang)
        {
            _context.Hang_dals.Add(hang);
            return _context.SaveChanges() > 0;
        }
        public List<Hang_dal> DocLayToanBoHang_Dal()
        {
            return _context.Hang_dals.ToList();
        }
        public Hang_dal DocLayIdHang_Dal(int id)
        {
            return _context.Hang_dals.Find(id);
        }
        public bool CapNhatHang_Dal(Hang_dal hang)
        {
            _context.Hang_dals.Update(hang);
            return _context.SaveChanges() > 0;
        }
        public bool XoaHang_Dal(int id)
        {
            var hang = _context.Hang_dals.Find(id);
            if (hang == null) return false;

            _context.Hang_dals.Remove(hang);
            return _context.SaveChanges() > 0;
        }
    }
}
