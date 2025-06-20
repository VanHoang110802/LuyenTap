using Microsoft.EntityFrameworkCore;
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
    public class SanPhamService_dal : ISanPhamService_dal
    {
        private readonly DatabaseContext _context;
        public SanPhamService_dal()
        {
            _context = new DatabaseContext();
        }
        public bool TaoThemSanPham_Dal(SanPham_dal sanPham)
        {
            _context.SanPham_dals.Add(sanPham);
            return _context.SaveChanges() > 0;
        }
        public List<SanPham_dal> DocLayToanBoSanPham_Dal()
        {
            return _context.SanPham_dals.OrderBy(sp => sp.TenSP).ToList();
        }
        public SanPham_dal DocLayIdSanPham_Dal(int id)
        {
            return _context.SanPham_dals.Find(id);
        }
        public bool CapNhatSanPham_Dal(SanPham_dal sanPham)
        {
            _context.Attach(sanPham);
            _context.Entry(sanPham).State = EntityState.Modified;
            return _context.SaveChanges() > 0;
        }
        public bool XoaSanPham_Dal(int id)
        {
            var sp = _context.SanPham_dals.Find(id);
            if (sp == null) return false;

            _context.SanPham_dals.Remove(sp);
            return _context.SaveChanges() > 0;
        }

        public List<SanPham_dal> TimKiemSanPhamTheoTen_Dal(string keyword)
        {
            using (var context = new DatabaseContext())
            {
                return context.SanPham_dals.Include(sp => sp.hang_dal) // để lấy cả tên hãng
                       .Where(sp => sp.TenSP.Contains(keyword) || sp.hang_dal.TenHang.Contains(keyword)).ToList();
            }
        }
    }
}
