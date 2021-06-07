using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class update_eleven : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageData",
                table: "HinhAnhs");

            migrationBuilder.AddColumn<string>(
                name: "urlHinh",
                table: "HinhAnhs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "danhGias",
                columns: table => new
                {
                    MaDanhGia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MotSao = table.Column<double>(type: "float", nullable: false),
                    HaiSao = table.Column<double>(type: "float", nullable: false),
                    BaSao = table.Column<double>(type: "float", nullable: false),
                    BonSao = table.Column<double>(type: "float", nullable: false),
                    NamSao = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_danhGias", x => x.MaDanhGia);
                });

            migrationBuilder.CreateTable(
                name: "sanPham_Appliances",
                columns: table => new
                {
                    Loai = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DungTich = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CongSuat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TienIch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoiSanXuat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanhGia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sanPham_Appliances", x => x.Loai);
                });

            migrationBuilder.CreateTable(
                name: "sanPham_Audios",
                columns: table => new
                {
                    TuongThich = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CongSac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CongNghe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSuDung = table.Column<double>(type: "float", nullable: false),
                    TienIch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoiSanXuat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanhGia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sanPham_Audios", x => x.TuongThich);
                });

            migrationBuilder.CreateTable(
                name: "sanPham_DienThoais",
                columns: table => new
                {
                    MaDT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MangHinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeDieuHanh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CameraTruoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CameraSau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Chip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoNhoTrong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoiSanXuat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanhGia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sanPham_DienThoais", x => x.MaDT);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "danhGias");

            migrationBuilder.DropTable(
                name: "sanPham_Appliances");

            migrationBuilder.DropTable(
                name: "sanPham_Audios");

            migrationBuilder.DropTable(
                name: "sanPham_DienThoais");

            migrationBuilder.DropColumn(
                name: "urlHinh",
                table: "HinhAnhs");

            migrationBuilder.AddColumn<byte[]>(
                name: "ImageData",
                table: "HinhAnhs",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
