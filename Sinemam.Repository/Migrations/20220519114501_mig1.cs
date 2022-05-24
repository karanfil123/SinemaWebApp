using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sinemam.Repository.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 5, 19, 14, 45, 0, 866, DateTimeKind.Local).AddTicks(3806), new DateTime(2022, 5, 19, 14, 45, 0, 866, DateTimeKind.Local).AddTicks(3806) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 5, 19, 14, 45, 0, 866, DateTimeKind.Local).AddTicks(3810), new DateTime(2022, 5, 19, 14, 45, 0, 866, DateTimeKind.Local).AddTicks(3810) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 5, 19, 14, 45, 0, 866, DateTimeKind.Local).AddTicks(3813), new DateTime(2022, 5, 19, 14, 45, 0, 866, DateTimeKind.Local).AddTicks(3814) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 5, 19, 14, 45, 0, 866, DateTimeKind.Local).AddTicks(3817), new DateTime(2022, 5, 19, 14, 45, 0, 866, DateTimeKind.Local).AddTicks(3817) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 5, 19, 14, 45, 0, 866, DateTimeKind.Local).AddTicks(3820), new DateTime(2022, 5, 19, 14, 45, 0, 866, DateTimeKind.Local).AddTicks(3821) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsActive", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 5, 19, 14, 45, 0, 866, DateTimeKind.Local).AddTicks(7742), true, new DateTime(2022, 5, 19, 14, 45, 0, 866, DateTimeKind.Local).AddTicks(7745) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 5, 19, 14, 45, 0, 866, DateTimeKind.Local).AddTicks(9812), new DateTime(2022, 5, 19, 14, 45, 0, 866, DateTimeKind.Local).AddTicks(9813) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 5, 19, 14, 45, 0, 867, DateTimeKind.Local).AddTicks(970), new DateTime(2022, 5, 19, 14, 45, 0, 867, DateTimeKind.Local).AddTicks(971) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 5, 14, 1, 13, 17, 596, DateTimeKind.Local).AddTicks(6493), new DateTime(2022, 5, 14, 1, 13, 17, 596, DateTimeKind.Local).AddTicks(6505) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 5, 14, 1, 13, 17, 596, DateTimeKind.Local).AddTicks(6508), new DateTime(2022, 5, 14, 1, 13, 17, 596, DateTimeKind.Local).AddTicks(6508) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 5, 14, 1, 13, 17, 596, DateTimeKind.Local).AddTicks(6510), new DateTime(2022, 5, 14, 1, 13, 17, 596, DateTimeKind.Local).AddTicks(6510) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 5, 14, 1, 13, 17, 596, DateTimeKind.Local).AddTicks(6512), new DateTime(2022, 5, 14, 1, 13, 17, 596, DateTimeKind.Local).AddTicks(6512) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 5, 14, 1, 13, 17, 596, DateTimeKind.Local).AddTicks(6514), new DateTime(2022, 5, 14, 1, 13, 17, 596, DateTimeKind.Local).AddTicks(6514) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsActive", "UpdatedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 5, 14, 1, 13, 17, 597, DateTimeKind.Local).AddTicks(4659), new DateTime(2022, 5, 14, 1, 13, 17, 597, DateTimeKind.Local).AddTicks(4668) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 5, 14, 1, 13, 17, 597, DateTimeKind.Local).AddTicks(5882), new DateTime(2022, 5, 14, 1, 13, 17, 597, DateTimeKind.Local).AddTicks(5891) });
        }
    }
}
