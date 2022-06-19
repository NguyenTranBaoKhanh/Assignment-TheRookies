using BKShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKShop.Data.Extentions
{
    public static class ModelBuilderExtentions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, Name = "SmartPhone" },
                new Category() { Id = 2, Name = "Tablet" },
                new Category() { Id = 3, Name = "LapTop" }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product() {
                    Id = 1,
                    Name = "Oppo Reno 6Z 5G xanh",
                    Color = "Xanh",
                    Price = 1,
                    Capacity = "8/128",
                    Stock = 10,
                    Description = "Hệ thống camera sau được trang bị tối tân, trong đó có camera chính 64 MP, camera góc siêu rộng 8 MP và camera macro 2 MP cùng camera trước 32 MP luôn sẵn sàng bắt trọn mọi cảm xúc trong khung hình, giúp người dùng thoải mái ghi lại những khoảnh khắc trong cuộc sống một cách ấn tượng nhất.",
                    Image = "",
                    CategoryId = 1,
                    BrandId = 1
                },
                new Product()
                {
                    Id = 2,
                    Name = "Iphone 12 4/64 đen",
                    Color = "Đen",
                    Price = 1,
                    Capacity = "4/64",
                    Stock = 10,
                    Description = "Apple đã trang bị con chip mới nhất của hãng (tính đến 11/2020) cho iPhone 12 đó là A14 Bionic, được sản xuất trên tiến trình 5 nm với hiệu suất ổn định hơn so với chip A13 được trang bị trên phiên bản tiền nhiệm iPhone 11.",
                    Image = "",
                    CategoryId = 1,
                    BrandId = 1
                },
                new Product()
                {
                    Id = 3,
                    Name = "Samsung Galaxy Tab S7 FE xanh",
                    Color = "Xanh",
                    Price = 1,
                    Capacity = "4/64",
                    Stock = 10,
                    Description = "Samsung chính thức trình làng mẫu máy tính bảng có tên Galaxy Tab S7 FE, máy trang bị cấu hình mạnh mẽ, màn hình giải trí siêu lớn và điểm ấn tượng nhất là viên pin siêu khủng được tích hợp bên trong, giúp tăng hiệu suất làm việc nhưng vẫn có tính di động cực cao. Galaxy Tab S7 FE sẽ khiến bạn choáng ngợp với dụng lượng pin cực khủng 10090 mAh đảm bảo cho cường độ làm việc, giải trí liên tục trong nhiều giờ liền.",
                    Image = "",
                    CategoryId = 1,
                    BrandId = 1
                }
                );
            modelBuilder.Entity<Brand>().HasData(
                new Brand() { Id = 1, Name = "SamSung" },
                new Brand() { Id = 2, Name = "Apple" },
                new Brand() { Id = 3, Name = "Oppo" }
                );
        }
    }
}
