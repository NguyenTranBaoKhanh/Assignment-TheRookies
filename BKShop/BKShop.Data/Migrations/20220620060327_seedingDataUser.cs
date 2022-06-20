using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BKShop.Data.Migrations
{
    public partial class seedingDataUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 4, "Oneplus" },
                    { 5, "Nokia" },
                    { 6, "Realme" },
                    { 7, "Xiaomi" },
                    { 8, "Vivo" },
                    { 9, "Khác" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Điện thoại");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Máy tính bảng");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 9, "Cáp sạc" },
                    { 8, "Cường lực" },
                    { 10, "Ốp lưng" },
                    { 6, "Tai nghe" },
                    { 5, "Sạc dự phòng" },
                    { 4, "Đồng hồ" },
                    { 7, "Loa" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "BrandId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "BrandId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CategoryId",
                value: 2);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), "2ac8b042-6590-4c28-91a6-48370f6a4f9c", "Administrator role", "admin", "admin" },
                    { new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"), "d090169f-4e7c-41ed-96ff-faeab909a45c", "Customer role", "customer", "customer" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"), new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"), new Guid("bff91054-dc92-421e-a233-d1080f630928") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 0, "AG", "19e72c1e-71cc-40cf-a0a1-01c0cc640126", "khanh@gmail.com", true, false, null, "Bao Khanh", "khanh@gmail.com", "admin", "AQAAAAEAACcQAAAAEMRHfyd9HVpOsBAv1PTzYcsL1YEfAyqJnZ8ZF9XjrQ5P3Yc8yj6mcRLdoy5K7Ynmew==", "0123456789", null, false, "", false, "admin" },
                    { new Guid("bff91064-dc92-421e-a233-d1080f630928"), 0, "AG", "6ec6fd73-ee06-4396-bf87-b10ceceb9e50", "customer1@gmail.com", true, false, null, "Bao Khanh Customer", "customer1@gmail.com", "customer", "AQAAAAEAACcQAAAAEItvOCe0/AYd6HRq9fp93VcTAmDuCRT20NnoQHG8q3nC2qaSK9YBrPbsHQwVWJLrrA==", "0123456789", null, false, "", false, "customer1" },
                    { new Guid("bff91054-dc92-421e-a233-d1080f630928"), 0, "AG", "11e0f157-be9f-42bd-ac17-e3bdd5ea73ee", "customer2@gmail.com", true, false, null, "David", "customer2@gmail.com", "customer", "AQAAAAEAACcQAAAAEDVwbbC1gpxeRav1k2U6KK3irIsInCYrBSO0UoJ9neRZZfSckSlt1+wDyQ7YawlIzw==", "0123456789", null, false, "", false, "customer2" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "CreatedDate", "DeliveryDate", "Phone", "Status", "UserId" },
                values: new object[,]
                {
                    { 1, "TPHCM", new DateTime(2022, 5, 21, 12, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 21, 12, 45, 0, 0, DateTimeKind.Unspecified), "0123456789", 4, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 2, "TPHCM", new DateTime(2022, 5, 22, 13, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 22, 10, 50, 0, 0, DateTimeKind.Unspecified), "0123456789", 4, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 3, "TPHCM", new DateTime(2022, 5, 22, 15, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 23, 9, 34, 0, 0, DateTimeKind.Unspecified), "0123456789", 4, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 5, "TPHCM", new DateTime(2022, 5, 24, 12, 11, 0, 0, DateTimeKind.Unspecified), null, "0123456789", 2, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 4, "TPHCM", new DateTime(2022, 5, 23, 12, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 23, 16, 23, 0, 0, DateTimeKind.Unspecified), "0123456789", 4, new Guid("bff91054-dc92-421e-a233-d1080f630928") },
                    { 6, "TPHCM", new DateTime(2022, 5, 24, 12, 30, 0, 0, DateTimeKind.Unspecified), null, "0123456789", 0, new Guid("bff91054-dc92-421e-a233-d1080f630928") }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "DateCreated", "DateDeleted", "DateModified", "ProductId", "Star", "UserId" },
                values: new object[,]
                {
                    { 2, "Tuyệt lắm", new DateTime(2022, 6, 20, 13, 3, 27, 323, DateTimeKind.Local).AddTicks(706), null, null, 1, 4, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { 4, "Máy còn yếu lắm", new DateTime(2022, 6, 20, 13, 3, 27, 323, DateTimeKind.Local).AddTicks(732), null, null, 2, 3, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { 6, "Good", new DateTime(2022, 6, 20, 13, 3, 27, 323, DateTimeKind.Local).AddTicks(740), null, null, 3, 5, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { 8, "Đây là comment", new DateTime(2022, 6, 20, 13, 3, 27, 323, DateTimeKind.Local).AddTicks(746), null, null, 3, 4, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { 10, "Máy mạnh", new DateTime(2022, 6, 20, 13, 3, 27, 323, DateTimeKind.Local).AddTicks(751), null, null, 1, 5, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { 1, "Máy đẹp", new DateTime(2022, 6, 20, 13, 3, 27, 322, DateTimeKind.Local).AddTicks(1631), null, null, 1, 5, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 3, "Máy hơi yếu", new DateTime(2022, 6, 20, 13, 3, 27, 323, DateTimeKind.Local).AddTicks(728), null, null, 2, 2, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 5, "Ngon đó", new DateTime(2022, 6, 20, 13, 3, 27, 323, DateTimeKind.Local).AddTicks(737), null, null, 2, 4, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 7, "Yeah", new DateTime(2022, 6, 20, 13, 3, 27, 323, DateTimeKind.Local).AddTicks(743), null, null, 3, 4, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 9, "Màu sắc đẹp", new DateTime(2022, 6, 20, 13, 3, 27, 323, DateTimeKind.Local).AddTicks(748), null, null, 2, 5, new Guid("bff91064-dc92-421e-a233-d1080f630928") }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderId", "ProductId", "Amount", "Price" },
                values: new object[,]
                {
                    { 1, 1, 2, 10000000m },
                    { 2, 2, 1, 10000000m },
                    { 3, 3, 1, 10000000m },
                    { 3, 1, 2, 10000000m },
                    { 5, 3, 1, 10000000m },
                    { 5, 2, 1, 10000000m },
                    { 4, 1, 1, 10000000m },
                    { 6, 3, 1, 10000000m }
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
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91054-dc92-421e-a233-d1080f630928"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91064-dc92-421e-a233-d1080f630928"));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "SmartPhone");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Tablet");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "BrandId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "BrandId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CategoryId",
                value: 1);
        }
    }
}
