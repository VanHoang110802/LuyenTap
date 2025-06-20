using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layer_01_DAL.Folder_01_Entities;
using Layer_01_DAL.Folder_02_DatabaseContext;
using Layer_01_DAL.Folder_04_DALServices;
using Layer_02_BLL.Folder_01_IServices;
using Layer_02_BLL.Folder_03_Models;
using Microsoft.EntityFrameworkCore;

namespace Layer_02_BLL.Folder_02_Services
{
    public class XuLySanPhamService_bll : IXuLySanPhamService_bll
    {
        private readonly SanPhamService_dal _sanPhamService;
        private readonly DatabaseContext _context;

        public XuLySanPhamService_bll()
        {
            _sanPhamService = new SanPhamService_dal();
            _context = new DatabaseContext();
        }

        public bool TaoThemSanPham_Bll(SanPham_dal sanPham)
        {
            return _sanPhamService.TaoThemSanPham_Dal(sanPham);
        }
        public List<SanPham_dal> DocLayToanBoSanPham_Bll()
        {
            return _sanPhamService.DocLayToanBoSanPham_Dal();
        }
        public SanPham_dal DocLayIdSanPham_Bll(int id)
        {
            return _sanPhamService.DocLayIdSanPham_Dal(id);
        }
        public bool CapNhatSanPham_Bll(SanPham_dal sanPham)
        {
            return _sanPhamService.CapNhatSanPham_Dal(sanPham);
        }
        public bool XoaSanPham_Bll(int id)
        {
            return _sanPhamService.XoaSanPham_Dal(id);
        }
        public List<SanPham_dal> TimKiemSanPhamBll(string keyword)
        {
            return _sanPhamService.TimKiemSanPhamTheoTen_Dal(keyword);
        }

        public List<SanPhamWithHang_bll> DocLaySanPhamWithHang_Bll()
        {
            return _context.SanPham_dals.Include(sp => sp.hang_dal).Select(sp => new SanPhamWithHang_bll
            {
                MaSP = sp.MaSP,
                TenSP = sp.TenSP,
                Gia = sp.Gia,
                MaHang = sp.MaHang,
                TenHang = sp.hang_dal.TenHang,
                TinhTrang = sp.TinhTrang
            }).ToList();
        }
    }
}
