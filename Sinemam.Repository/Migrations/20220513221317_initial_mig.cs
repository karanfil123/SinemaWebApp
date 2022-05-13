using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sinemam.Repository.Migrations
{
    public partial class initial_mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Director = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Imdb = table.Column<double>(type: "float", nullable: false),
                    MinuteSize = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shows_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subject = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(2500)", maxLength: 2500, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ShowId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Shows_ShowId",
                        column: x => x.ShowId,
                        principalTable: "Shows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "IsDelete", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 14, 1, 13, 17, 596, DateTimeKind.Local).AddTicks(6493), "Aksiyon kategorisi deneme açıklaması", true, false, "Aksiyon", new DateTime(2022, 5, 14, 1, 13, 17, 596, DateTimeKind.Local).AddTicks(6505) },
                    { 2, new DateTime(2022, 5, 14, 1, 13, 17, 596, DateTimeKind.Local).AddTicks(6508), "Macera kategorisi deneme açıklaması", true, false, "Macera", new DateTime(2022, 5, 14, 1, 13, 17, 596, DateTimeKind.Local).AddTicks(6508) },
                    { 3, new DateTime(2022, 5, 14, 1, 13, 17, 596, DateTimeKind.Local).AddTicks(6510), "Aksiyon kategorisi deneme açıklaması", true, false, "Gerilim", new DateTime(2022, 5, 14, 1, 13, 17, 596, DateTimeKind.Local).AddTicks(6510) },
                    { 4, new DateTime(2022, 5, 14, 1, 13, 17, 596, DateTimeKind.Local).AddTicks(6512), "Yerli Dizi kategorisi deneme açıklaması", true, false, "Yerli Dizi", new DateTime(2022, 5, 14, 1, 13, 17, 596, DateTimeKind.Local).AddTicks(6512) },
                    { 5, new DateTime(2022, 5, 14, 1, 13, 17, 596, DateTimeKind.Local).AddTicks(6514), "Yabancı Dizi kategorisi deneme açıklaması", true, false, "Yabancı Dizi", new DateTime(2022, 5, 14, 1, 13, 17, 596, DateTimeKind.Local).AddTicks(6514) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "Email", "ImageUrl", "IsActive", "IsDelete", "Password", "Role", "UpdatedDate", "Username" },
                values: new object[] { 1, new DateTime(2022, 5, 14, 1, 13, 17, 597, DateTimeKind.Local).AddTicks(5882), "abc@outlook.com", "https://cdn.pixabay.com/photo/2020/07/14/13/07/icon-5404125_1280.png", true, false, "111", "Ziyaretçi", new DateTime(2022, 5, 14, 1, 13, 17, 597, DateTimeKind.Local).AddTicks(5891), "bulent" });

            migrationBuilder.InsertData(
                table: "Shows",
                columns: new[] { "Id", "CategoryId", "Country", "CreatedDate", "Description", "Director", "ImageUrl", "Imdb", "IsActive", "IsDelete", "MinuteSize", "Name", "UpdatedDate", "Year" },
                values: new object[] { 1, 1, "ABD", new DateTime(2022, 5, 14, 1, 13, 17, 597, DateTimeKind.Local).AddTicks(4659), "John Wick, emekliye ayrılmış bir tetikçidir. Emekliliğinin tadını çıkarırken karısının yakalandığı amansız hastalıkla hayatı altüst olur. Karısından kendisine kalan en değerli varlığı ve can yoldaşı köpeğidir. Ancak evine dalan üç gangster onu da öldürür.", "Chad Stahelski", "https://tr.web.img2.acsta.net/pictures/14/10/14/15/30/266211.jpg", 8.5, true, false, 90, "John Wick", new DateTime(2022, 5, 14, 1, 13, 17, 597, DateTimeKind.Local).AddTicks(4668), 2014 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "CreatedDate", "IsActive", "IsDelete", "ShowId", "Subject", "UpdatedDate", "UserId" },
                values: new object[] { 1, "John Wick Filmi Hakkında test yorumu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, 1, "John Wick Filmi Hakkında", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ShowId",
                table: "Comments",
                column: "ShowId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Shows_CategoryId",
                table: "Shows",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Shows");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
