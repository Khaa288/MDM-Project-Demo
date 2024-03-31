using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MDM_API.Migrations
{
    /// <inheritdoc />
    public partial class futabus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChuyenXe",
                columns: table => new
                {
                    MaChuyenXe = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenChuyenXe = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChuyenXe", x => x.MaChuyenXe);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoan",
                columns: table => new
                {
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiTinh = table.Column<int>(type: "int", nullable: false),
                    NgaySinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgheNghiep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoan", x => x.Email);
                });

            migrationBuilder.InsertData(
                table: "ChuyenXe",
                columns: new[] { "MaChuyenXe", "TenChuyenXe" },
                values: new object[,]
                {
                    { 1, "Chuyen Xe 1" },
                    { 2, "Chuyen Xe 2" },
                    { 3, "Chuyen Xe 3" },
                    { 4, "Chuyen Xe 4" },
                    { 5, "Chuyen Xe 5" }
                });

            migrationBuilder.InsertData(
                table: "TaiKhoan",
                columns: new[] { "Email", "DiaChi", "GioiTinh", "HoTen", "MatKhau", "NgaySinh", "NgheNghiep", "SDT" },
                values: new object[] { "admin@gmail.com", "HCM", 1, "", "123", "1/1/2024", "", "123456789" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChuyenXe");

            migrationBuilder.DropTable(
                name: "TaiKhoan");
        }
    }
}
