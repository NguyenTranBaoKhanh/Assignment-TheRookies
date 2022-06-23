using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BKShop.Data.Migrations
{
    public partial class V1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 6, 21, 1, 2, 53, 711, DateTimeKind.Local).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 6, 21, 1, 2, 53, 711, DateTimeKind.Local).AddTicks(2615));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 6, 21, 1, 2, 53, 711, DateTimeKind.Local).AddTicks(2617));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 6, 21, 1, 2, 53, 711, DateTimeKind.Local).AddTicks(2619));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 6, 21, 1, 2, 53, 711, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 6, 21, 1, 2, 53, 711, DateTimeKind.Local).AddTicks(2622));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 6, 21, 1, 2, 53, 711, DateTimeKind.Local).AddTicks(2624));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 6, 21, 1, 2, 53, 711, DateTimeKind.Local).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 6, 21, 1, 2, 53, 711, DateTimeKind.Local).AddTicks(2627));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 6, 21, 1, 2, 53, 711, DateTimeKind.Local).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"),
                column: "ConcurrencyStamp",
                value: "e0db8cee-f6aa-4d25-8516-7660e255733b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "407c5516-6f40-4fdf-9686-4aec2cd334f0");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a62a7677-4b87-4986-8e25-506ae04e66b5", "AQAAAAEAACcQAAAAED3smuTZt23MMNIA6B0KXWywzmqNye7Qn7f+86ECc4z+bMG4LBXULgq3S1rEybKdYQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91054-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b3f3457c-da0e-4887-a046-763f8c6500ec", "AQAAAAEAACcQAAAAEBtyEZTgaG+8nP6RiwmtoiTDwrvCULaQIx2gv4865imXH2ehgaV1/r5BHuWyzSxb4g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91064-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4cdd6a7b-cc0f-46b7-99b1-e4324a109c0a", "AQAAAAEAACcQAAAAELz2ux/XkTZRpFxtA0vVdrjYF5SbL2cBo+cT4rnF6whQBeJZkrk7XimwuFH5jmidqQ==" });
        }
    }
}
