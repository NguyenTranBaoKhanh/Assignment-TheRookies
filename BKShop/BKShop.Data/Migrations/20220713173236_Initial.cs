using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BKShop.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Capacity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    Group = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stars = table.Column<double>(type: "float", nullable: false, defaultValue: 0.0),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => new { x.ProductID, x.UserId });
                    table.ForeignKey(
                        name: "FK_Carts_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Star = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => new { x.OrderId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "SamSung" },
                    { 2, "Xiaomi" },
                    { 3, "Realme" },
                    { 4, "Oppo" },
                    { 5, "Apple" },
                    { 6, "OnePlus" },
                    { 7, "Vivo" },
                    { 8, "Khác" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Điện thoại" },
                    { 2, "LapTop" },
                    { 3, "Đồng hồ" },
                    { 4, "Máy tính bảng" },
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
                    { new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"), "3e818270-f05d-4df6-89d0-610f15841506", "Customer role", "customer", "customer" },
                    { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), "4d098527-53b9-4ce3-a77c-a56527dbf4de", "Administrator role", "admin", "admin" }
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
                    { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 0, "AG", "fcb65454-b670-4035-91af-9b88afa7dcaa", "khanh@gmail.com", true, false, null, "Bao Khanh", "khanh@gmail.com", "admin", "AQAAAAEAACcQAAAAEPH6p7Te8JqGPwp09LHTqVP3iwUynGNcssoz+3rLQFtPVopgR9JEsF9cSO/8KERlWA==", "0123456789", null, false, "", false, "admin" },
                    { new Guid("bff91054-dc92-421e-a233-d1080f630928"), 0, "AG", "0a0f63fa-e174-424c-91c9-e1acf08c5975", "customer2@gmail.com", true, false, null, "David", "customer2@gmail.com", "customer", "AQAAAAEAACcQAAAAEJqSrbKZ+e0SCQq2wsAtZXhEeE1uuLTNvbH1H0Y9FIXChLcLWvZu7SDoZg6LgQRs0A==", "0123456789", null, false, "", false, "customer2" },
                    { new Guid("bff91064-dc92-421e-a233-d1080f630928"), 0, "AG", "7da374a3-4d7e-4d0c-8b96-6597e91cb5e5", "customer1@gmail.com", true, false, null, "Bao Khanh Customer", "customer1@gmail.com", "customer", "AQAAAAEAACcQAAAAEI5p0d9yYVlRfScfbLuMBx+wvR/IWrEEAI7BRvZAJ3C0oz966GcAA/4QDIaIXD5LnA==", "0123456789", null, false, "", false, "customer1" }
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
                columns: new[] { "Id", "BrandId", "Capacity", "CategoryId", "Color", "CreatedDate", "Description", "Group", "Image", "Name", "Price", "Stock", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 4, "8/128", 1, "Xanh", new DateTime(2022, 7, 14, 0, 32, 36, 413, DateTimeKind.Local).AddTicks(8505), "Hệ thống camera sau được trang bị tối tân, trong đó có camera chính 64 MP, camera góc siêu rộng 8 MP và camera macro 2 MP cùng camera trước 32 MP luôn sẵn sàng bắt trọn mọi cảm xúc trong khung hình, giúp người dùng thoải mái ghi lại những khoảnh khắc trong cuộc sống một cách ấn tượng nhất.", "reno6z", "oppo-reno6-z-5g-aurora.jpg", "Oppo Reno 6Z 5G xanh", 1000000, 10, new DateTime(2022, 7, 14, 0, 32, 36, 413, DateTimeKind.Local).AddTicks(8514) },
                    { 2, 5, "4/64", 1, "Đen", new DateTime(2022, 7, 14, 0, 32, 36, 413, DateTimeKind.Local).AddTicks(8526), "Apple đã trang bị con chip mới nhất của hãng (tính đến 11/2020) cho iPhone 12 đó là A14 Bionic, được sản xuất trên tiến trình 5 nm với hiệu suất ổn định hơn so với chip A13 được trang bị trên phiên bản tiền nhiệm iPhone 11.", "ip12", "iphone-12-mini-den.jpg", "Iphone 12 4/64 đen", 1000000, 10, new DateTime(2022, 7, 14, 0, 32, 36, 413, DateTimeKind.Local).AddTicks(8527) },
                    { 3, 1, "4/64", 2, "Xanh", new DateTime(2022, 7, 14, 0, 32, 36, 413, DateTimeKind.Local).AddTicks(8530), "Samsung chính thức trình làng mẫu máy tính bảng có tên Galaxy Tab S7 FE, máy trang bị cấu hình mạnh mẽ, màn hình giải trí siêu lớn và điểm ấn tượng nhất là viên pin siêu khủng được tích hợp bên trong, giúp tăng hiệu suất làm việc nhưng vẫn có tính di động cực cao. Galaxy Tab S7 FE sẽ khiến bạn choáng ngợp với dụng lượng pin cực khủng 10090 mAh đảm bảo cho cường độ làm việc, giải trí liên tục trong nhiều giờ liền.", "ts7fe", "samsung-galaxy-tab-s7-fe-green.jpg", "Samsung Galaxy Tab S7 FE xanh", 10000000, 10, new DateTime(2022, 7, 14, 0, 32, 36, 413, DateTimeKind.Local).AddTicks(8531) },
                    { 4, 2, "4/64", 1, "xanh", new DateTime(2022, 7, 14, 0, 32, 36, 413, DateTimeKind.Local).AddTicks(8533), "Xiaomi duy trì sự trẻ trung trong thiết kế của mình từ Redmi 9A, Redmi 9C và đến hiện tại là Redmi 9T, chiếc điện thoại mang đến tùy chọn màu nổi bật, rất phù hợp với cá tính năng động của giới trẻ.", "red9t", "xiaomi-redmi-9t-xanh.jpg", "Xiaomi Redmi 9T", 4950000, 10, new DateTime(2022, 7, 14, 0, 32, 36, 413, DateTimeKind.Local).AddTicks(8534) },
                    { 5, 2, "8/256", 1, "xanh", new DateTime(2022, 7, 14, 0, 32, 36, 413, DateTimeKind.Local).AddTicks(8537), "Xiaomi Mi 11 một siêu phẩm đến từ Xiaomi, máy cho trải nghiệm hiệu năng hàng đầu với vi xử lý Qualcomm Snapdragon 888, cùng loạt công nghệ đỉnh cao, khiến bất kỳ ai cũng sẽ choáng ngợp về smartphone này. Có thể thấy, điểm sáng trong thiết kế của Mi 11 đến từ cụm 3 camera mặt sau được đặt trong mô-đun hình vuông, được phân tầng với 2 lớp kính tạo nên sự khác biệt và nổi bật ngay từ cái nhìn đầu tiên.", "m11", "xiaomi-mi-11-xanhduong.jpg", "Xiaomi Mi 11 5G xanh", 16990000, 10, new DateTime(2022, 7, 14, 0, 32, 36, 413, DateTimeKind.Local).AddTicks(8537) },
                    { 6, 5, "4/64", 1, "xanh", new DateTime(2022, 7, 14, 0, 32, 36, 413, DateTimeKind.Local).AddTicks(8540), "Apple đã trang bị con chip mới nhất của hãng (tính đến 11/2020) cho iPhone 12 đó là A14 Bionic, được sản xuất trên tiến trình 5 nm với hiệu suất ổn định hơn so với chip A13 được trang bị trên phiên bản tiền nhiệm iPhone 11.", "ip12", "iphone-12-violet.jpg", "Iphone 12 4/64 tím", 20490000, 10, new DateTime(2022, 7, 14, 0, 32, 36, 413, DateTimeKind.Local).AddTicks(8541) },
                    { 7, 5, "4/64", 1, "xanh", new DateTime(2022, 7, 14, 0, 32, 36, 413, DateTimeKind.Local).AddTicks(8543), "Apple đã trang bị con chip mới nhất của hãng (tính đến 11/2020) cho iPhone 12 đó là A14 Bionic, được sản xuất trên tiến trình 5 nm với hiệu suất ổn định hơn so với chip A13 được trang bị trên phiên bản tiền nhiệm iPhone 11.", "ip12", "iphone-12-xanh-duong.jpg", "Iphone 12 4/64 xanh dương", 20490000, 10, new DateTime(2022, 7, 14, 0, 32, 36, 413, DateTimeKind.Local).AddTicks(8544) },
                    { 8, 5, "6/128", 1, "xanh", new DateTime(2022, 7, 14, 0, 32, 36, 413, DateTimeKind.Local).AddTicks(8547), "Năm nay, công nghệ màn hình trên 12 Pro Max cũng được đổi mới và trang bị tốt hơn cùng kích thước lên đến 6.7 inch, lớn hơn so với điện thoại iPhone 12. Với công nghệ màn hình OLED cho khả năng hiển thị hình ảnh lên đến 2778 x 1284 pixels. Bên cạnh đó, màn hình này còn cho độ sáng tối đa cao nhất lên đến 800 nits, luôn đảm bảo cho bạn một độ sáng cao và dễ nhìn nhất ngoài nắng.", "ip12pm", "iphone-12-pro-max-xanh-duong.jpg", "iphone 12 pro max 6/128 xanh dương", 30000000, 10, new DateTime(2022, 7, 14, 0, 32, 36, 413, DateTimeKind.Local).AddTicks(8547) },
                    { 9, 5, "6/128", 1, "đen", new DateTime(2022, 7, 14, 0, 32, 36, 413, DateTimeKind.Local).AddTicks(8550), "Năm nay, công nghệ màn hình trên 12 Pro Max cũng được đổi mới và trang bị tốt hơn cùng kích thước lên đến 6.7 inch, lớn hơn so với điện thoại iPhone 12. Với công nghệ màn hình OLED cho khả năng hiển thị hình ảnh lên đến 2778 x 1284 pixels. Bên cạnh đó, màn hình này còn cho độ sáng tối đa cao nhất lên đến 800 nits, luôn đảm bảo cho bạn một độ sáng cao và dễ nhìn nhất ngoài nắng.", "ip12pm", "iphone-12-pro-max-den.jpg", "iphone 12 pro max 6/128 đen", 30000000, 10, new DateTime(2022, 7, 14, 0, 32, 36, 413, DateTimeKind.Local).AddTicks(8551) },
                    { 10, 5, "6/128", 1, "bạc", new DateTime(2022, 7, 14, 0, 32, 36, 413, DateTimeKind.Local).AddTicks(8553), "Năm nay, công nghệ màn hình trên 12 Pro Max cũng được đổi mới và trang bị tốt hơn cùng kích thước lên đến 6.7 inch, lớn hơn so với điện thoại iPhone 12. Với công nghệ màn hình OLED cho khả năng hiển thị hình ảnh lên đến 2778 x 1284 pixels. Bên cạnh đó, màn hình này còn cho độ sáng tối đa cao nhất lên đến 800 nits, luôn đảm bảo cho bạn một độ sáng cao và dễ nhìn nhất ngoài nắng.", "ip12pm", "iphone-12-pro-bac.jpg", "iphone 12 pro max 6/128 bạc", 30000000, 10, new DateTime(2022, 7, 14, 0, 32, 36, 413, DateTimeKind.Local).AddTicks(8554) },
                    { 11, 5, "6/128", 1, "vàng", new DateTime(2022, 7, 14, 0, 32, 36, 413, DateTimeKind.Local).AddTicks(8556), "Năm nay, công nghệ màn hình trên 12 Pro Max cũng được đổi mới và trang bị tốt hơn cùng kích thước lên đến 6.7 inch, lớn hơn so với điện thoại iPhone 12. Với công nghệ màn hình OLED cho khả năng hiển thị hình ảnh lên đến 2778 x 1284 pixels. Bên cạnh đó, màn hình này còn cho độ sáng tối đa cao nhất lên đến 800 nits, luôn đảm bảo cho bạn một độ sáng cao và dễ nhìn nhất ngoài nắng.", "ip12pm", "iphone-12-pro-max-vang.jpg", "iphone 12 pro max 6/128 vàng", 30000000, 10, new DateTime(2022, 7, 14, 0, 32, 36, 413, DateTimeKind.Local).AddTicks(8557) },
                    { 12, 5, "6/256", 1, "đen", new DateTime(2022, 7, 14, 0, 32, 36, 413, DateTimeKind.Local).AddTicks(8560), "Năm nay, công nghệ màn hình trên 12 Pro Max cũng được đổi mới và trang bị tốt hơn cùng kích thước lên đến 6.7 inch, lớn hơn so với điện thoại iPhone 12. Với công nghệ màn hình OLED cho khả năng hiển thị hình ảnh lên đến 2778 x 1284 pixels. Bên cạnh đó, màn hình này còn cho độ sáng tối đa cao nhất lên đến 800 nits, luôn đảm bảo cho bạn một độ sáng cao và dễ nhìn nhất ngoài nắng.", "ip12pm", "iphone-12-pro-max-den.jpg", "iphone 12 pro max 6/256 đen", 32500000, 10, new DateTime(2022, 7, 14, 0, 32, 36, 413, DateTimeKind.Local).AddTicks(8561) },
                    { 13, 5, "6/256", 1, "bạc", new DateTime(2022, 7, 14, 0, 32, 36, 413, DateTimeKind.Local).AddTicks(8563), "Năm nay, công nghệ màn hình trên 12 Pro Max cũng được đổi mới và trang bị tốt hơn cùng kích thước lên đến 6.7 inch, lớn hơn so với điện thoại iPhone 12. Với công nghệ màn hình OLED cho khả năng hiển thị hình ảnh lên đến 2778 x 1284 pixels. Bên cạnh đó, màn hình này còn cho độ sáng tối đa cao nhất lên đến 800 nits, luôn đảm bảo cho bạn một độ sáng cao và dễ nhìn nhất ngoài nắng.", "ip12pr", "iphone-12-pro-bac.jpg", "iphone 12 pro max 6/256 bạc", 32500000, 10, new DateTime(2022, 7, 14, 0, 32, 36, 413, DateTimeKind.Local).AddTicks(8564) }
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
                    { 1, "Máy đẹp", new DateTime(2022, 7, 14, 0, 32, 36, 413, DateTimeKind.Local).AddTicks(8635), null, null, 1, 5, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 2, "Tuyệt lắm", new DateTime(2022, 7, 14, 0, 32, 36, 413, DateTimeKind.Local).AddTicks(8640), null, null, 1, 4, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { 3, "Máy hơi yếu", new DateTime(2022, 7, 14, 0, 32, 36, 413, DateTimeKind.Local).AddTicks(8643), null, null, 2, 2, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 4, "Máy còn yếu lắm", new DateTime(2022, 7, 14, 0, 32, 36, 413, DateTimeKind.Local).AddTicks(8645), null, null, 2, 3, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { 5, "Ngon đó", new DateTime(2022, 7, 14, 0, 32, 36, 413, DateTimeKind.Local).AddTicks(8648), null, null, 2, 4, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 6, "Good", new DateTime(2022, 7, 14, 0, 32, 36, 413, DateTimeKind.Local).AddTicks(8651), null, null, 3, 5, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { 7, "Yeah", new DateTime(2022, 7, 14, 0, 32, 36, 413, DateTimeKind.Local).AddTicks(8653), null, null, 3, 4, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 8, "Đây là comment", new DateTime(2022, 7, 14, 0, 32, 36, 413, DateTimeKind.Local).AddTicks(8656), null, null, 3, 4, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { 9, "Màu sắc đẹp", new DateTime(2022, 7, 14, 0, 32, 36, 413, DateTimeKind.Local).AddTicks(8659), null, null, 2, 5, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 10, "Máy mạnh", new DateTime(2022, 7, 14, 0, 32, 36, 413, DateTimeKind.Local).AddTicks(8661), null, null, 1, 5, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
