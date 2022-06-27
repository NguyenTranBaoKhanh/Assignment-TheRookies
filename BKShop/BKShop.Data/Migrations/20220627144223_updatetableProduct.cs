using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BKShop.Data.Migrations
{
    public partial class updatetableProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 21, 42, 22, 374, DateTimeKind.Local).AddTicks(2993), new DateTime(2022, 6, 27, 21, 42, 22, 374, DateTimeKind.Local).AddTicks(3006) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 21, 42, 22, 374, DateTimeKind.Local).AddTicks(3009), new DateTime(2022, 6, 27, 21, 42, 22, 374, DateTimeKind.Local).AddTicks(3010) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 21, 42, 22, 374, DateTimeKind.Local).AddTicks(3012), new DateTime(2022, 6, 27, 21, 42, 22, 374, DateTimeKind.Local).AddTicks(3013) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 6, 27, 21, 42, 22, 374, DateTimeKind.Local).AddTicks(3074));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 6, 27, 21, 42, 22, 374, DateTimeKind.Local).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 6, 27, 21, 42, 22, 374, DateTimeKind.Local).AddTicks(3083));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 6, 27, 21, 42, 22, 374, DateTimeKind.Local).AddTicks(3086));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 6, 27, 21, 42, 22, 374, DateTimeKind.Local).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 6, 27, 21, 42, 22, 374, DateTimeKind.Local).AddTicks(3091));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 6, 27, 21, 42, 22, 374, DateTimeKind.Local).AddTicks(3094));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 6, 27, 21, 42, 22, 374, DateTimeKind.Local).AddTicks(3097));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 6, 27, 21, 42, 22, 374, DateTimeKind.Local).AddTicks(3099));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 6, 27, 21, 42, 22, 374, DateTimeKind.Local).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"),
                column: "ConcurrencyStamp",
                value: "02a03b3c-cfc1-4929-a92c-4fb1ea72a8af");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "651b5b55-39f0-4eab-8137-68da081ca175");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "be4cf96f-3277-4a71-916f-bfa4470a2a28", "AQAAAAEAACcQAAAAECYhCiHG15QE9eSM84xvT+jAzcxWatbZrBjJcgIwh7yYPKNVWKj0fjg1OyBo18JTVg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91054-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "feb51ab5-c023-433f-ae97-1c53597f4d1f", "AQAAAAEAACcQAAAAECsL6qFcU7W9Lb5hkopnUtI2jdIH76I0xce/yKmMEgzGVBDuLsO0+gjDJygxLOlXMw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91064-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5c2bd5f2-14de-415a-b1ba-23618cfc971c", "AQAAAAEAACcQAAAAEPPzUOB/a7u6tWQjTuVewLw2bSdzDWIhbDTly3IlIR9e1w99vVGcLeiSHGAJJuF6DA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 6, 23, 1, 3, 5, 276, DateTimeKind.Local).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 6, 23, 1, 3, 5, 276, DateTimeKind.Local).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 6, 23, 1, 3, 5, 276, DateTimeKind.Local).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 6, 23, 1, 3, 5, 276, DateTimeKind.Local).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 6, 23, 1, 3, 5, 276, DateTimeKind.Local).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 6, 23, 1, 3, 5, 276, DateTimeKind.Local).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 6, 23, 1, 3, 5, 276, DateTimeKind.Local).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 6, 23, 1, 3, 5, 276, DateTimeKind.Local).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 6, 23, 1, 3, 5, 276, DateTimeKind.Local).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 6, 23, 1, 3, 5, 276, DateTimeKind.Local).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"),
                column: "ConcurrencyStamp",
                value: "14607d96-10c1-4993-a92c-718231d68793");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "5a40f906-40db-45a4-86e6-cf749538712b");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c91a7bf7-b40a-4ded-bd6b-d45f122c39e0", "AQAAAAEAACcQAAAAEPq603p3FnDN6qm28ni6iDM1DhGGd4TNlLLkLX1QBXz5L+rUzf3P7wOaKRT30JqE/Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91054-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ad167f4f-958f-48f3-b698-edaaa95c4ef0", "AQAAAAEAACcQAAAAEIrGawJsO3eesvzhxRujRwC+nkPf9d99hkkR4tOqbEK+sSPhpGg1PYa4AM7+hGGJnA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91064-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "521cd808-2c64-44b4-bb6b-aea851363348", "AQAAAAEAACcQAAAAEInX3MvKa/rU8SgsugsR2U4FM3qbvtgGBAl8VPAKBnzWfKImdqSXyusYgCwCj19Now==" });
        }
    }
}
