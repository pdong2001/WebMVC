using Microsoft.EntityFrameworkCore;
using Models.Entity;
using System;

namespace Models
{
    public class DataContext : DbContext
    {
        public DbSet<ArticleType> ArticleTypes { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<CanBo> CanBos { get; set; }
        public DbSet<User> Users { get; set; }

        public DataContext(DbContextOptions options):base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            int Count = 1;
            modelBuilder.Entity<CanBo>().HasData(
                new CanBo {ID = Count, Address = "Hưng Yên - Việt Nam", Name = $"Cán bộ {Count++}", PhoneNumber="0987654321"},
                new CanBo {ID = Count,  Address = "Hưng Yên - Việt Nam", Name = $"Cán bộ {Count++}", PhoneNumber="0987654321"},
                new CanBo {ID = Count,  Address = "Hưng Yên - Việt Nam", Name = $"Cán bộ {Count++}", PhoneNumber="0987654321"},
                new CanBo {ID = Count,  Address = "Hưng Yên - Việt Nam", Name = $"Cán bộ {Count++}", PhoneNumber="0987654321"},
                new CanBo {ID = Count, Address = "Hưng Yên - Việt Nam", Name = $"Cán bộ {Count++}", PhoneNumber="0987654321"}
                );
            Count = 1;
            modelBuilder.Entity<User>().HasData(
                new User { ID = Guid.NewGuid(), Address = "Hưng Yên - Việt Nam", Name = $"Người dùng {Count}", PhoneNumber = "0987654321", DateOfBirth=DateTime.Now.AddDays(-15000), Domicile="Việt nam", Email="Email.NguoiDung@mail.mail", RegistryDate=DateTime.Now, AccName=$"Taikhoan{Count++}"},
                new User { ID = Guid.NewGuid(), Address = "Hưng Yên - Việt Nam", Name = $"Người dùng {Count}", PhoneNumber = "0987654321", DateOfBirth=DateTime.Now.AddDays(-15000), Domicile="Việt nam", Email="Email.NguoiDung@mail.mail", RegistryDate=DateTime.Now, AccName=$"Taikhoan{Count++}"},
                new User { ID = Guid.NewGuid(), Address = "Hưng Yên - Việt Nam", Name = $"Người dùng {Count}", PhoneNumber = "0987654321", DateOfBirth=DateTime.Now.AddDays(-15000), Domicile="Việt nam", Email="Email.NguoiDung@mail.mail", RegistryDate=DateTime.Now, AccName=$"Taikhoan{Count++}"},
                new User { ID = Guid.NewGuid(), Address = "Hưng Yên - Việt Nam", Name = $"Người dùng {Count}", PhoneNumber = "0987654321", DateOfBirth=DateTime.Now.AddDays(-15000), Domicile="Việt nam", Email="Email.NguoiDung@mail.mail", RegistryDate=DateTime.Now, AccName=$"Taikhoan{Count++}"},
                new User { ID = Guid.NewGuid(), Address = "Hưng Yên - Việt Nam", Name = $"Người dùng {Count}", PhoneNumber = "0987654321", DateOfBirth=DateTime.Now.AddDays(-15000), Domicile="Việt nam", Email="Email.NguoiDung@mail.mail", RegistryDate=DateTime.Now, AccName=$"Taikhoan{Count++}"},
                new User { ID = Guid.NewGuid(), Address = "Hưng Yên - Việt Nam", Name = $"Người dùng {Count}", PhoneNumber = "0987654321", DateOfBirth=DateTime.Now.AddDays(-15000), Domicile="Việt nam", Email="Email.NguoiDung@mail.mail", RegistryDate=DateTime.Now, AccName=$"Taikhoan{Count++}"},
                new User { ID = Guid.NewGuid(), Address = "Hưng Yên - Việt Nam", Name = $"Người dùng {Count}", PhoneNumber = "0987654321", DateOfBirth=DateTime.Now.AddDays(-15000), Domicile="Việt nam", Email="Email.NguoiDung@mail.mail", RegistryDate=DateTime.Now, AccName=$"Taikhoan{Count++}"}
                );
        }
    }
}
