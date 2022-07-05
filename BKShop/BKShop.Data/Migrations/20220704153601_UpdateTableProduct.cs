using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BKShop.Data.Migrations
{
    public partial class UpdateTableProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "Stars",
                table: "Products",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BrandId", "CreatedDate", "UpdatedDate" },
                values: new object[] { 4, new DateTime(2022, 7, 4, 22, 36, 0, 425, DateTimeKind.Local).AddTicks(8104), new DateTime(2022, 7, 4, 22, 36, 0, 425, DateTimeKind.Local).AddTicks(8113) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BrandId", "CreatedDate", "UpdatedDate" },
                values: new object[] { 5, new DateTime(2022, 7, 4, 22, 36, 0, 425, DateTimeKind.Local).AddTicks(8114), new DateTime(2022, 7, 4, 22, 36, 0, 425, DateTimeKind.Local).AddTicks(8115) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 4, 22, 36, 0, 425, DateTimeKind.Local).AddTicks(8117), new DateTime(2022, 7, 4, 22, 36, 0, 425, DateTimeKind.Local).AddTicks(8117) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BrandId", "CreatedDate", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2022, 7, 4, 22, 36, 0, 425, DateTimeKind.Local).AddTicks(8119), new DateTime(2022, 7, 4, 22, 36, 0, 425, DateTimeKind.Local).AddTicks(8119) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BrandId", "CreatedDate", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2022, 7, 4, 22, 36, 0, 425, DateTimeKind.Local).AddTicks(8121), new DateTime(2022, 7, 4, 22, 36, 0, 425, DateTimeKind.Local).AddTicks(8121) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 4, 22, 36, 0, 425, DateTimeKind.Local).AddTicks(8123), new DateTime(2022, 7, 4, 22, 36, 0, 425, DateTimeKind.Local).AddTicks(8123) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 4, 22, 36, 0, 425, DateTimeKind.Local).AddTicks(8125), new DateTime(2022, 7, 4, 22, 36, 0, 425, DateTimeKind.Local).AddTicks(8125) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 4, 22, 36, 0, 425, DateTimeKind.Local).AddTicks(8127), new DateTime(2022, 7, 4, 22, 36, 0, 425, DateTimeKind.Local).AddTicks(8127) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 4, 22, 36, 0, 425, DateTimeKind.Local).AddTicks(8129), new DateTime(2022, 7, 4, 22, 36, 0, 425, DateTimeKind.Local).AddTicks(8129) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 4, 22, 36, 0, 425, DateTimeKind.Local).AddTicks(8137), new DateTime(2022, 7, 4, 22, 36, 0, 425, DateTimeKind.Local).AddTicks(8138) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 4, 22, 36, 0, 425, DateTimeKind.Local).AddTicks(8140), new DateTime(2022, 7, 4, 22, 36, 0, 425, DateTimeKind.Local).AddTicks(8140) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 4, 22, 36, 0, 425, DateTimeKind.Local).AddTicks(8142), new DateTime(2022, 7, 4, 22, 36, 0, 425, DateTimeKind.Local).AddTicks(8142) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 4, 22, 36, 0, 425, DateTimeKind.Local).AddTicks(8144), new DateTime(2022, 7, 4, 22, 36, 0, 425, DateTimeKind.Local).AddTicks(8144) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 7, 4, 22, 36, 0, 425, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 7, 4, 22, 36, 0, 425, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 7, 4, 22, 36, 0, 425, DateTimeKind.Local).AddTicks(8198));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 7, 4, 22, 36, 0, 425, DateTimeKind.Local).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 7, 4, 22, 36, 0, 425, DateTimeKind.Local).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 7, 4, 22, 36, 0, 425, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 7, 4, 22, 36, 0, 425, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 7, 4, 22, 36, 0, 425, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 7, 4, 22, 36, 0, 425, DateTimeKind.Local).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 7, 4, 22, 36, 0, 425, DateTimeKind.Local).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"),
                column: "ConcurrencyStamp",
                value: "82141de6-9c4e-4391-84ec-af7e0d2f45bf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "6eabeab1-cfbb-4bf8-80a5-77a89b258703");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "03540932-6793-45c8-988b-54f52f88b9b0", "AQAAAAEAACcQAAAAEHC/63g0C4tcpvI3c1WT2f5SXBf//39nb4L0uDi0hIi5JlDw6PT0744Qv4X318Eg/Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91054-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4d40108c-b6e5-4c3d-a51c-fe52d38d3cf2", "AQAAAAEAACcQAAAAEBCmg0RFwzCU0az7Kg7Vkj/zhpC35xRhefb4zdXDFBQlF6pehrR/pNtaCnBUi0J9Dg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91064-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b67fbc57-9f2f-400c-99b8-5406388a2b08", "AQAAAAEAACcQAAAAEJm6Hm8kAv51EkvPVc97jonzak0mTiN3ydTYC9to5H0XL9zAQHggXsKJjhTe8Qm6SQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Stars",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BrandId", "CreatedDate", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2022, 6, 30, 17, 37, 54, 760, DateTimeKind.Local).AddTicks(5458), new DateTime(2022, 6, 30, 17, 37, 54, 760, DateTimeKind.Local).AddTicks(5466) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BrandId", "CreatedDate", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2022, 6, 30, 17, 37, 54, 760, DateTimeKind.Local).AddTicks(5468), new DateTime(2022, 6, 30, 17, 37, 54, 760, DateTimeKind.Local).AddTicks(5469) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 30, 17, 37, 54, 760, DateTimeKind.Local).AddTicks(5470), new DateTime(2022, 6, 30, 17, 37, 54, 760, DateTimeKind.Local).AddTicks(5471) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BrandId", "CreatedDate", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2022, 6, 30, 17, 37, 54, 760, DateTimeKind.Local).AddTicks(5472), new DateTime(2022, 6, 30, 17, 37, 54, 760, DateTimeKind.Local).AddTicks(5473) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BrandId", "CreatedDate", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2022, 6, 30, 17, 37, 54, 760, DateTimeKind.Local).AddTicks(5474), new DateTime(2022, 6, 30, 17, 37, 54, 760, DateTimeKind.Local).AddTicks(5475) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 30, 17, 37, 54, 760, DateTimeKind.Local).AddTicks(5476), new DateTime(2022, 6, 30, 17, 37, 54, 760, DateTimeKind.Local).AddTicks(5477) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 30, 17, 37, 54, 760, DateTimeKind.Local).AddTicks(5478), new DateTime(2022, 6, 30, 17, 37, 54, 760, DateTimeKind.Local).AddTicks(5479) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 30, 17, 37, 54, 760, DateTimeKind.Local).AddTicks(5481), new DateTime(2022, 6, 30, 17, 37, 54, 760, DateTimeKind.Local).AddTicks(5481) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 30, 17, 37, 54, 760, DateTimeKind.Local).AddTicks(5483), new DateTime(2022, 6, 30, 17, 37, 54, 760, DateTimeKind.Local).AddTicks(5483) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 30, 17, 37, 54, 760, DateTimeKind.Local).AddTicks(5485), new DateTime(2022, 6, 30, 17, 37, 54, 760, DateTimeKind.Local).AddTicks(5485) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 30, 17, 37, 54, 760, DateTimeKind.Local).AddTicks(5487), new DateTime(2022, 6, 30, 17, 37, 54, 760, DateTimeKind.Local).AddTicks(5487) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 30, 17, 37, 54, 760, DateTimeKind.Local).AddTicks(5489), new DateTime(2022, 6, 30, 17, 37, 54, 760, DateTimeKind.Local).AddTicks(5489) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 30, 17, 37, 54, 760, DateTimeKind.Local).AddTicks(5491), new DateTime(2022, 6, 30, 17, 37, 54, 760, DateTimeKind.Local).AddTicks(5491) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 6, 30, 17, 37, 54, 760, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 6, 30, 17, 37, 54, 760, DateTimeKind.Local).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 6, 30, 17, 37, 54, 760, DateTimeKind.Local).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 6, 30, 17, 37, 54, 760, DateTimeKind.Local).AddTicks(5544));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 6, 30, 17, 37, 54, 760, DateTimeKind.Local).AddTicks(5546));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 6, 30, 17, 37, 54, 760, DateTimeKind.Local).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 6, 30, 17, 37, 54, 760, DateTimeKind.Local).AddTicks(5549));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 6, 30, 17, 37, 54, 760, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 6, 30, 17, 37, 54, 760, DateTimeKind.Local).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 6, 30, 17, 37, 54, 760, DateTimeKind.Local).AddTicks(5554));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"),
                column: "ConcurrencyStamp",
                value: "4358d5e8-fdaa-43f7-9669-bb558a892052");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "ef27abeb-e096-4cdc-a228-002f4d2890da");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9d51021a-94d3-4af6-8e1b-68c4397e41b7", "AQAAAAEAACcQAAAAEK2/met+qOuHyEM8xDX2nbBXxPE836iBdZPr7eZhBRw+1uDorx6oegb9jMaK3WkADg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91054-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "72ce4612-1d60-44f6-8c36-0f150a35d70d", "AQAAAAEAACcQAAAAEIV6b4nDUO8XuuYsFY+QOd9UACxO7DTZk6f8Nt/RbPRdFDbpeYvHUWHG1aJ4pk01jw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91064-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4ac5eb63-5011-44b7-92a5-cb9cdc3b58ef", "AQAAAAEAACcQAAAAEAcEH7zsmM71YX+b8l7NfTTDAlMIsQxIJlQyALaXSX1vnEHq/QKaXkxdhjnC25WuVw==" });
        }
    }
}
