using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layer_01_DAL.Folder_01_Entities;

namespace Layer_01_DAL.Folder_02_DatabaseContext
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Hang_dal> Hang_dals { get; set; }
        public DbSet<SanPham_dal> SanPham_dals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Server=MAY-08\\SQLEXPRESS;Database=SOF2052_FINAL_TEST;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hang_dal>(entity =>
            {
                entity.ToTable("Hang");           // Tên bảng trong DB
                entity.HasKey(e => e.MaHang);      // Khóa chính
                entity.Property(e => e.TenHang).IsRequired().HasMaxLength(100);
            });


            modelBuilder.Entity<SanPham_dal>(entity =>
            {
                entity.ToTable("SanPham");             // Tên bảng trong DB
                entity.HasKey(e => e.MaSP);        // Khóa chính
                entity.HasOne(d => d.hang_dal)     // Mối quan hệ với bảng PhanQuyen
                      .WithMany(p => p.SanPham_dals).HasForeignKey(d => d.MaHang)  // RoleId là khóa ngoại
                      .OnDelete(DeleteBehavior.Restrict); // Giới hạn hành động xóa
            });
        }
    }
}
