using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BKShop.Data.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "SamSung" },
                    { 2, "Apple" },
                    { 3, "Oppo" },
                    { 4, "Oneplus" },
                    { 5, "Nokia" },
                    { 6, "Realme" },
                    { 7, "Xiaomi" },
                    { 8, "Vivo" },
                    { 9, "Khác" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Điện thoại" },
                    { 2, "Máy tính bảng" },
                    { 3, "LapTop" },
                    { 4, "Đồng hồ" },
                    { 5, "Sạc dự phòng" },
                    { 6, "Tai nghe" },
                    { 7, "Loa" },
                    { 8, "Cường lực" },
                    { 9, "Cáp sạc" },
                    { 10, "Ốp lưng" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"), "e0db8cee-f6aa-4d25-8516-7660e255733b", "Customer role", "customer", "customer" },
                    { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), "407c5516-6f40-4fdf-9686-4aec2cd334f0", "Administrator role", "admin", "admin" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"), new Guid("bff91054-dc92-421e-a233-d1080f630928") },
                    { new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"), new Guid("bff91064-dc92-421e-a233-d1080f630928") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 0, "AG", "a62a7677-4b87-4986-8e25-506ae04e66b5", "khanh@gmail.com", true, false, null, "Bao Khanh", "khanh@gmail.com", "admin", "AQAAAAEAACcQAAAAED3smuTZt23MMNIA6B0KXWywzmqNye7Qn7f+86ECc4z+bMG4LBXULgq3S1rEybKdYQ==", "0123456789", null, false, "", false, "admin" },
                    { new Guid("bff91054-dc92-421e-a233-d1080f630928"), 0, "AG", "b3f3457c-da0e-4887-a046-763f8c6500ec", "customer2@gmail.com", true, false, null, "David", "customer2@gmail.com", "customer", "AQAAAAEAACcQAAAAEBtyEZTgaG+8nP6RiwmtoiTDwrvCULaQIx2gv4865imXH2ehgaV1/r5BHuWyzSxb4g==", "0123456789", null, false, "", false, "customer2" },
                    { new Guid("bff91064-dc92-421e-a233-d1080f630928"), 0, "AG", "4cdd6a7b-cc0f-46b7-99b1-e4324a109c0a", "customer1@gmail.com", true, false, null, "Bao Khanh Customer", "customer1@gmail.com", "customer", "AQAAAAEAACcQAAAAELz2ux/XkTZRpFxtA0vVdrjYF5SbL2cBo+cT4rnF6whQBeJZkrk7XimwuFH5jmidqQ==", "0123456789", null, false, "", false, "customer1" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "CreatedDate", "DeliveryDate", "Phone", "Status", "UserId" },
                values: new object[,]
                {
                    { 1, "TPHCM", new DateTime(2022, 5, 21, 12, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 21, 12, 45, 0, 0, DateTimeKind.Unspecified), "0123456789", 4, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 2, "TPHCM", new DateTime(2022, 5, 22, 13, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 22, 10, 50, 0, 0, DateTimeKind.Unspecified), "0123456789", 4, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 3, "TPHCM", new DateTime(2022, 5, 22, 15, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 23, 9, 34, 0, 0, DateTimeKind.Unspecified), "0123456789", 4, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 4, "TPHCM", new DateTime(2022, 5, 23, 12, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 23, 16, 23, 0, 0, DateTimeKind.Unspecified), "0123456789", 4, new Guid("bff91054-dc92-421e-a233-d1080f630928") },
                    { 5, "TPHCM", new DateTime(2022, 5, 24, 12, 11, 0, 0, DateTimeKind.Unspecified), null, "0123456789", 2, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 6, "TPHCM", new DateTime(2022, 5, 24, 12, 30, 0, 0, DateTimeKind.Unspecified), null, "0123456789", 0, new Guid("bff91054-dc92-421e-a233-d1080f630928") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "Capacity", "CategoryId", "Color", "Description", "Image", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 1, 3, "8/128", 1, "Xanh", "Hệ thống camera sau được trang bị tối tân, trong đó có camera chính 64 MP, camera góc siêu rộng 8 MP và camera macro 2 MP cùng camera trước 32 MP luôn sẵn sàng bắt trọn mọi cảm xúc trong khung hình, giúp người dùng thoải mái ghi lại những khoảnh khắc trong cuộc sống một cách ấn tượng nhất.", "", "Oppo Reno 6Z 5G xanh", 1m, 10 },
                    { 2, 2, "4/64", 1, "Đen", "Apple đã trang bị con chip mới nhất của hãng (tính đến 11/2020) cho iPhone 12 đó là A14 Bionic, được sản xuất trên tiến trình 5 nm với hiệu suất ổn định hơn so với chip A13 được trang bị trên phiên bản tiền nhiệm iPhone 11.", "", "Iphone 12 4/64 đen", 1m, 10 },
                    { 3, 1, "4/64", 2, "Xanh", "Samsung chính thức trình làng mẫu máy tính bảng có tên Galaxy Tab S7 FE, máy trang bị cấu hình mạnh mẽ, màn hình giải trí siêu lớn và điểm ấn tượng nhất là viên pin siêu khủng được tích hợp bên trong, giúp tăng hiệu suất làm việc nhưng vẫn có tính di động cực cao. Galaxy Tab S7 FE sẽ khiến bạn choáng ngợp với dụng lượng pin cực khủng 10090 mAh đảm bảo cho cường độ làm việc, giải trí liên tục trong nhiều giờ liền.", "", "Samsung Galaxy Tab S7 FE xanh", 1m, 10 }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderId", "ProductId", "Amount", "Price" },
                values: new object[,]
                {
                    { 1, 1, 2, 10000000m },
                    { 2, 2, 1, 10000000m },
                    { 3, 1, 2, 10000000m },
                    { 3, 3, 1, 10000000m },
                    { 4, 1, 1, 10000000m },
                    { 5, 2, 1, 10000000m },
                    { 5, 3, 1, 10000000m },
                    { 6, 3, 1, 10000000m }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "DateCreated", "DateDeleted", "DateModified", "ProductId", "Star", "UserId" },
                values: new object[,]
                {
                    { 1, "Máy đẹp", new DateTime(2022, 6, 21, 1, 2, 53, 711, DateTimeKind.Local).AddTicks(2600), null, null, 1, 5, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 2, "Tuyệt lắm", new DateTime(2022, 6, 21, 1, 2, 53, 711, DateTimeKind.Local).AddTicks(2615), null, null, 1, 4, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { 3, "Máy hơi yếu", new DateTime(2022, 6, 21, 1, 2, 53, 711, DateTimeKind.Local).AddTicks(2617), null, null, 2, 2, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 4, "Máy còn yếu lắm", new DateTime(2022, 6, 21, 1, 2, 53, 711, DateTimeKind.Local).AddTicks(2619), null, null, 2, 3, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { 5, "Ngon đó", new DateTime(2022, 6, 21, 1, 2, 53, 711, DateTimeKind.Local).AddTicks(2620), null, null, 2, 4, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 6, "Good", new DateTime(2022, 6, 21, 1, 2, 53, 711, DateTimeKind.Local).AddTicks(2622), null, null, 3, 5, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { 7, "Yeah", new DateTime(2022, 6, 21, 1, 2, 53, 711, DateTimeKind.Local).AddTicks(2624), null, null, 3, 4, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 8, "Đây là comment", new DateTime(2022, 6, 21, 1, 2, 53, 711, DateTimeKind.Local).AddTicks(2625), null, null, 3, 4, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { 9, "Màu sắc đẹp", new DateTime(2022, 6, 21, 1, 2, 53, 711, DateTimeKind.Local).AddTicks(2627), null, null, 2, 5, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 10, "Máy mạnh", new DateTime(2022, 6, 21, 1, 2, 53, 711, DateTimeKind.Local).AddTicks(2629), null, null, 1, 5, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"), new Guid("bff91054-dc92-421e-a233-d1080f630928") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"), new Guid("bff91064-dc92-421e-a233-d1080f630928") });

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91054-dc92-421e-a233-d1080f630928"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91064-dc92-421e-a233-d1080f630928"));
        }
    }
}
