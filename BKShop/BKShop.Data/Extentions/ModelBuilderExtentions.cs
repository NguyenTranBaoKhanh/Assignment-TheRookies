using BKShop.Data.Entities;
using Microsoft.AspNetCore.Identity;
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
                new Category() { Id = 1, Name = "Điện thoại" },
                new Category() { Id = 2, Name = "LapTop" },
                new Category() { Id = 3, Name = "Đồng hồ" },
                new Category() { Id = 4, Name = "Máy tính bảng" },
                new Category() { Id = 5, Name = "Sạc dự phòng" },
                new Category() { Id = 6, Name = "Tai nghe" },
                new Category() { Id = 7, Name = "Loa" },
                new Category() { Id = 8, Name = "Cường lực" },
                new Category() { Id = 9, Name = "Cáp sạc" },
                new Category() { Id = 10, Name = "Ốp lưng" }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    Name = "Oppo Reno 6Z 5G xanh",
                    Color = "Xanh",
                    Price = 1000000,
                    Capacity = "8/128",
                    Stock = 10,
                    Description = "Hệ thống camera sau được trang bị tối tân, trong đó có camera chính 64 MP, camera góc siêu rộng 8 MP và camera macro 2 MP cùng camera trước 32 MP luôn sẵn sàng bắt trọn mọi cảm xúc trong khung hình, giúp người dùng thoải mái ghi lại những khoảnh khắc trong cuộc sống một cách ấn tượng nhất.",
                    Image = "oppo-reno6-z-5g-aurora.jpg",
                    CategoryId = 1,
                    BrandId = 3,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                },
                new Product()
                {
                    Id = 2,
                    Name = "Iphone 12 4/64 đen",
                    Color = "Đen",
                    Price = 1000000,
                    Capacity = "4/64",
                    Stock = 10,
                    Description = "Apple đã trang bị con chip mới nhất của hãng (tính đến 11/2020) cho iPhone 12 đó là A14 Bionic, được sản xuất trên tiến trình 5 nm với hiệu suất ổn định hơn so với chip A13 được trang bị trên phiên bản tiền nhiệm iPhone 11.",
                    Image = "iphone-12-mini-den.jpg",
                    CategoryId = 1,
                    BrandId = 2,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                },
                new Product()
                {
                    Id = 3,
                    Name = "Samsung Galaxy Tab S7 FE xanh",
                    Color = "Xanh",
                    Price = 10000000,
                    Capacity = "4/64",
                    Stock = 10,
                    Description = "Samsung chính thức trình làng mẫu máy tính bảng có tên Galaxy Tab S7 FE, máy trang bị cấu hình mạnh mẽ, màn hình giải trí siêu lớn và điểm ấn tượng nhất là viên pin siêu khủng được tích hợp bên trong, giúp tăng hiệu suất làm việc nhưng vẫn có tính di động cực cao. Galaxy Tab S7 FE sẽ khiến bạn choáng ngợp với dụng lượng pin cực khủng 10090 mAh đảm bảo cho cường độ làm việc, giải trí liên tục trong nhiều giờ liền.",
                    Image = "samsung-galaxy-tab-s7-fe-green.jpg",
                    CategoryId = 2,
                    BrandId = 1,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                },
                new Product()
                {
                    Id = 4,
                    Name = "Xiaomi Redmi 9T",
                    Color = "xanh",
                    Price = 4950000,
                    Capacity = "4/64",
                    Stock = 10,
                    Description = "Xiaomi duy trì sự trẻ trung trong thiết kế của mình từ Redmi 9A, Redmi 9C và đến hiện tại là Redmi 9T, chiếc điện thoại mang đến tùy chọn màu nổi bật, rất phù hợp với cá tính năng động của giới trẻ.",
                    Image = "xiaomi-redmi-9t-xanh.jpg",
                    CategoryId = 1,
                    BrandId = 1,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                },
                new Product()
                {
                    Id = 5,
                    Name = "Xiaomi Mi 11 5G xanh",
                    Color = "xanh",
                    Price = 16990000,
                    Capacity = "8/256",
                    Stock = 10,
                    Description = "Xiaomi Mi 11 một siêu phẩm đến từ Xiaomi, máy cho trải nghiệm hiệu năng hàng đầu với vi xử lý Qualcomm Snapdragon 888, cùng loạt công nghệ đỉnh cao, khiến bất kỳ ai cũng sẽ choáng ngợp về smartphone này. Có thể thấy, điểm sáng trong thiết kế của Mi 11 đến từ cụm 3 camera mặt sau được đặt trong mô-đun hình vuông, được phân tầng với 2 lớp kính tạo nên sự khác biệt và nổi bật ngay từ cái nhìn đầu tiên.",
                    Image = "xiaomi-mi-11-xanhduong.jpg",
                    CategoryId = 1,
                    BrandId = 1,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                },
                new Product()
                {
                    Id = 6,
                    Name = "Iphone 12 4/64 tím",
                    Color = "xanh",
                    Price = 20490000,
                    Capacity = "4/64",
                    Stock = 10,
                    Description = "Apple đã trang bị con chip mới nhất của hãng (tính đến 11/2020) cho iPhone 12 đó là A14 Bionic, được sản xuất trên tiến trình 5 nm với hiệu suất ổn định hơn so với chip A13 được trang bị trên phiên bản tiền nhiệm iPhone 11.",
                    Image = "iphone-12-violet.jpg",
                    CategoryId = 1,
                    BrandId = 5,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                },
                new Product()
                {
                    Id = 7,
                    Name = "Iphone 12 4/64 xanh dương",
                    Color = "xanh",
                    Price = 20490000,
                    Capacity = "4/64",
                    Stock = 10,
                    Description = "Apple đã trang bị con chip mới nhất của hãng (tính đến 11/2020) cho iPhone 12 đó là A14 Bionic, được sản xuất trên tiến trình 5 nm với hiệu suất ổn định hơn so với chip A13 được trang bị trên phiên bản tiền nhiệm iPhone 11.",
                    Image = "iphone-12-xanh-duong.jpg",
                    CategoryId = 1,
                    BrandId = 5,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                },
                new Product()
                {
                    Id = 8,
                    Name = "iphone 12 pro max 6/128 xanh dương",
                    Color = "xanh",
                    Price = 30000000,
                    Capacity = "6/128",
                    Stock = 10,
                    Description = "Năm nay, công nghệ màn hình trên 12 Pro Max cũng được đổi mới và trang bị tốt hơn cùng kích thước lên đến 6.7 inch, lớn hơn so với điện thoại iPhone 12. Với công nghệ màn hình OLED cho khả năng hiển thị hình ảnh lên đến 2778 x 1284 pixels. Bên cạnh đó, màn hình này còn cho độ sáng tối đa cao nhất lên đến 800 nits, luôn đảm bảo cho bạn một độ sáng cao và dễ nhìn nhất ngoài nắng.",
                    Image = "iphone-12-pro-max-xanh-duong.jpg",
                    CategoryId = 1,
                    BrandId = 5,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                },
                new Product()
                {
                    Id = 9,
                    Name = "iphone 12 pro max 6/128 đen",
                    Color = "đen",
                    Price = 30000000,
                    Capacity = "6/128",
                    Stock = 10,
                    Description = "Năm nay, công nghệ màn hình trên 12 Pro Max cũng được đổi mới và trang bị tốt hơn cùng kích thước lên đến 6.7 inch, lớn hơn so với điện thoại iPhone 12. Với công nghệ màn hình OLED cho khả năng hiển thị hình ảnh lên đến 2778 x 1284 pixels. Bên cạnh đó, màn hình này còn cho độ sáng tối đa cao nhất lên đến 800 nits, luôn đảm bảo cho bạn một độ sáng cao và dễ nhìn nhất ngoài nắng.",
                    Image = "iphone-12-pro-max-den.jpg",
                    CategoryId = 1,
                    BrandId = 5,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                },
                new Product()
                {
                    Id = 10,
                    Name = "iphone 12 pro max 6/128 bạc",
                    Color = "bạc",
                    Price = 30000000,
                    Capacity = "6/128",
                    Stock = 10,
                    Description = "Năm nay, công nghệ màn hình trên 12 Pro Max cũng được đổi mới và trang bị tốt hơn cùng kích thước lên đến 6.7 inch, lớn hơn so với điện thoại iPhone 12. Với công nghệ màn hình OLED cho khả năng hiển thị hình ảnh lên đến 2778 x 1284 pixels. Bên cạnh đó, màn hình này còn cho độ sáng tối đa cao nhất lên đến 800 nits, luôn đảm bảo cho bạn một độ sáng cao và dễ nhìn nhất ngoài nắng.",
                    Image = "iphone-12-pro-bac.jpg",
                    CategoryId = 1,
                    BrandId = 5,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                },
                new Product()
                {
                    Id = 11,
                    Name = "iphone 12 pro max 6/128 vàng",
                    Color = "vàng",
                    Price = 30000000,
                    Capacity = "6/128",
                    Stock = 10,
                    Description = "Năm nay, công nghệ màn hình trên 12 Pro Max cũng được đổi mới và trang bị tốt hơn cùng kích thước lên đến 6.7 inch, lớn hơn so với điện thoại iPhone 12. Với công nghệ màn hình OLED cho khả năng hiển thị hình ảnh lên đến 2778 x 1284 pixels. Bên cạnh đó, màn hình này còn cho độ sáng tối đa cao nhất lên đến 800 nits, luôn đảm bảo cho bạn một độ sáng cao và dễ nhìn nhất ngoài nắng.",
                    Image = "iphone-12-pro-max-vang.jpg",
                    CategoryId = 1,
                    BrandId = 5,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                },
                new Product()
                {
                    Id = 12,
                    Name = "iphone 12 pro max 6/256 đen",
                    Color = "đen",
                    Price = 32500000,
                    Capacity = "6/256",
                    Stock = 10,
                    Description = "Năm nay, công nghệ màn hình trên 12 Pro Max cũng được đổi mới và trang bị tốt hơn cùng kích thước lên đến 6.7 inch, lớn hơn so với điện thoại iPhone 12. Với công nghệ màn hình OLED cho khả năng hiển thị hình ảnh lên đến 2778 x 1284 pixels. Bên cạnh đó, màn hình này còn cho độ sáng tối đa cao nhất lên đến 800 nits, luôn đảm bảo cho bạn một độ sáng cao và dễ nhìn nhất ngoài nắng.",
                    Image = "iphone-12-pro-max-den.jpg",
                    CategoryId = 1,
                    BrandId = 5,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                },
                new Product()
                {
                    Id = 13,
                    Name = "iphone 12 pro max 6/256 bạc",
                    Color = "bạc",
                    Price = 32500000,
                    Capacity = "6/256",
                    Stock = 10,
                    Description = "Năm nay, công nghệ màn hình trên 12 Pro Max cũng được đổi mới và trang bị tốt hơn cùng kích thước lên đến 6.7 inch, lớn hơn so với điện thoại iPhone 12. Với công nghệ màn hình OLED cho khả năng hiển thị hình ảnh lên đến 2778 x 1284 pixels. Bên cạnh đó, màn hình này còn cho độ sáng tối đa cao nhất lên đến 800 nits, luôn đảm bảo cho bạn một độ sáng cao và dễ nhìn nhất ngoài nắng.",
                    Image = "iphone-12-pro-bac.jpg",
                    CategoryId = 1,
                    BrandId = 5,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                }
                );

            modelBuilder.Entity<Brand>().HasData(
                new Brand() { Id = 1, Name = "SamSung" },
                new Brand() { Id = 2, Name = "Xiaomi" },
                new Brand() { Id = 3, Name = "Realme" },
                new Brand() { Id = 4, Name = "Oppo" },
                new Brand() { Id = 5, Name = "Apple" },
                new Brand() { Id = 6, Name = "OnePlus" },
                new Brand() { Id = 7, Name = "Vivo" },
                new Brand() { Id = 8, Name = "Khác" }
                );

            modelBuilder.Entity<Review>().HasData(
                new Review() { Id = 1, ProductId = 1, UserId = new Guid("BFF91064-DC92-421E-A233-D1080F630928"), Comment = "Máy đẹp", Star = 5, DateCreated = DateTime.Now },
                new Review() { Id = 2, ProductId = 1, UserId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE"), Comment = "Tuyệt lắm", Star = 4, DateCreated = DateTime.Now },
                new Review() { Id = 3, ProductId = 2, UserId = new Guid("BFF91064-DC92-421E-A233-D1080F630928"), Comment = "Máy hơi yếu", Star = 2, DateCreated = DateTime.Now },
                new Review() { Id = 4, ProductId = 2, UserId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE"), Comment = "Máy còn yếu lắm", Star = 3, DateCreated = DateTime.Now },
                new Review() { Id = 5, ProductId = 2, UserId = new Guid("BFF91064-DC92-421E-A233-D1080F630928"), Comment = "Ngon đó", Star = 4, DateCreated = DateTime.Now },
                new Review() { Id = 6, ProductId = 3, UserId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE"), Comment = "Good", Star = 5, DateCreated = DateTime.Now },
                new Review() { Id = 7, ProductId = 3, UserId = new Guid("BFF91064-DC92-421E-A233-D1080F630928"), Comment = "Yeah", Star = 4, DateCreated = DateTime.Now },
                new Review() { Id = 8, ProductId = 3, UserId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE"), Comment = "Đây là comment", Star = 4, DateCreated = DateTime.Now },
                new Review() { Id = 9, ProductId = 2, UserId = new Guid("BFF91064-DC92-421E-A233-D1080F630928"), Comment = "Màu sắc đẹp", Star = 5, DateCreated = DateTime.Now },
                new Review() { Id = 10, ProductId = 1, UserId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE"), Comment = "Máy mạnh", Star = 5, DateCreated = DateTime.Now }
                );

            modelBuilder.Entity<Order>().HasData(
                new Order { Id = 1, UserId = new Guid("BFF91064-DC92-421E-A233-D1080F630928"), CreatedDate = new DateTime(2022, 5, 21, 12, 45, 0), DeliveryDate = new DateTime(2021, 5, 21, 12, 45, 0), Status = Enums.Status.Completed, Address = "TPHCM", Phone = "0123456789" },
                new Order { Id = 2, UserId = new Guid("BFF91064-DC92-421E-A233-D1080F630928"), CreatedDate = new DateTime(2022, 5, 22, 13, 41, 0), DeliveryDate = new DateTime(2021, 5, 22, 10, 50, 0), Status = Enums.Status.Completed, Address = "TPHCM", Phone = "0123456789" },
                new Order { Id = 3, UserId = new Guid("BFF91064-DC92-421E-A233-D1080F630928"), CreatedDate = new DateTime(2022, 5, 22, 15, 23, 0), DeliveryDate = new DateTime(2021, 5, 23, 9, 34, 0), Status = Enums.Status.Completed, Address = "TPHCM", Phone = "0123456789" },
                new Order { Id = 4, UserId = new Guid("BFF91054-DC92-421E-A233-D1080F630928"), CreatedDate = new DateTime(2022, 5, 23, 12, 11, 0), DeliveryDate = new DateTime(2021, 5, 23, 16, 23, 0), Status = Enums.Status.Completed, Address = "TPHCM", Phone = "0123456789" },
                new Order { Id = 5, UserId = new Guid("BFF91064-DC92-421E-A233-D1080F630928"), CreatedDate = new DateTime(2022, 5, 24, 12, 11, 0), Status = Enums.Status.Shipping, Address = "TPHCM", Phone = "0123456789" },
                new Order { Id = 6, UserId = new Guid("BFF91054-DC92-421E-A233-D1080F630928"), CreatedDate = new DateTime(2022, 5, 24, 12, 30, 0), Status = Enums.Status.Pending, Address = "TPHCM", Phone = "0123456789" }
                );

            modelBuilder.Entity<OrderDetail>().HasData(
                new OrderDetail { OrderId = 1, ProductId = 1, Amount = 2, Price = 10000000 },
                new OrderDetail { OrderId = 2, ProductId = 2, Amount = 1, Price = 10000000 },
                new OrderDetail { OrderId = 3, ProductId = 3, Amount = 1, Price = 10000000 },
                new OrderDetail { OrderId = 3, ProductId = 1, Amount = 2, Price = 10000000 },
                new OrderDetail { OrderId = 4, ProductId = 1, Amount = 1, Price = 10000000 },
                new OrderDetail { OrderId = 5, ProductId = 3, Amount = 1, Price = 10000000 },
                new OrderDetail { OrderId = 5, ProductId = 2, Amount = 1, Price = 10000000 },
                new OrderDetail { OrderId = 6, ProductId = 3, Amount = 1, Price = 10000000 }
                );

            var adminRoleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            var customerRoleId = new Guid("54BA416F-6B89-4C53-873D-4FBD48506E6D");
            var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");
            var customerId = new Guid("BFF91064-DC92-421E-A233-D1080F630928");
            var customerId2 = new Guid("BFF91054-DC92-421E-A233-D1080F630928");
            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    Id = adminRoleId,
                    Name = "admin",
                    NormalizedName = "admin",
                    Description = "Administrator role"
                },
                new Role
                {
                    Id = customerRoleId,
                    Name = "customer",
                    NormalizedName = "customer",
                    Description = "Customer role"
                });

            var hasher = new PasswordHasher<User>();
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = adminId,
                    UserName = "admin",
                    NormalizedUserName = "admin",
                    Email = "khanh@gmail.com",
                    NormalizedEmail = "khanh@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Abcd1234!"),
                    SecurityStamp = string.Empty,
                    Name = "Bao Khanh",
                    Address = "AG",
                    Phone = "0123456789"
                },
                new User
                {
                    Id = customerId,
                    UserName = "customer1",
                    NormalizedUserName = "customer",
                    Email = "customer1@gmail.com",
                    NormalizedEmail = "customer1@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Abcd1234!"),
                    SecurityStamp = string.Empty,
                    Name = "Bao Khanh Customer",
                    Address = "AG",
                    Phone = "0123456789"

                },
                new User
                {
                    Id = customerId2,
                    UserName = "customer2",
                    NormalizedUserName = "customer",
                    Email = "customer2@gmail.com",
                    NormalizedEmail = "customer2@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Abcd1234!"),
                    SecurityStamp = string.Empty,
                    Name = "David",
                    Address = "AG",
                    Phone = "0123456789"

                }
                );

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
                new IdentityUserRole<Guid>
                {
                    RoleId = adminRoleId,
                    UserId = adminId,
                },
                new IdentityUserRole<Guid>
                {
                    RoleId = customerRoleId,
                    UserId = customerId,
                },
                new IdentityUserRole<Guid>
                {
                    RoleId = customerRoleId,
                    UserId = customerId2,
                });

        }
    }
}
