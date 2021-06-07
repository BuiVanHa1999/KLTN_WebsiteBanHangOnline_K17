using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class update_12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_sanPham_Audios",
                table: "sanPham_Audios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_sanPham_Appliances",
                table: "sanPham_Appliances");

            migrationBuilder.AddColumn<int>(
                name: "MaCT",
                table: "sanPham_DienThoais",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "TuongThich",
                table: "sanPham_Audios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "MaAudio",
                table: "sanPham_Audios",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "MaCT",
                table: "sanPham_Audios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Loai",
                table: "sanPham_Appliances",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "MaAppliance",
                table: "sanPham_Appliances",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "MaCT",
                table: "sanPham_Appliances",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_sanPham_Audios",
                table: "sanPham_Audios",
                column: "MaAudio");

            migrationBuilder.AddPrimaryKey(
                name: "PK_sanPham_Appliances",
                table: "sanPham_Appliances",
                column: "MaAppliance");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_sanPham_Audios",
                table: "sanPham_Audios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_sanPham_Appliances",
                table: "sanPham_Appliances");

            migrationBuilder.DropColumn(
                name: "MaCT",
                table: "sanPham_DienThoais");

            migrationBuilder.DropColumn(
                name: "MaAudio",
                table: "sanPham_Audios");

            migrationBuilder.DropColumn(
                name: "MaCT",
                table: "sanPham_Audios");

            migrationBuilder.DropColumn(
                name: "MaAppliance",
                table: "sanPham_Appliances");

            migrationBuilder.DropColumn(
                name: "MaCT",
                table: "sanPham_Appliances");

            migrationBuilder.AlterColumn<string>(
                name: "TuongThich",
                table: "sanPham_Audios",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Loai",
                table: "sanPham_Appliances",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_sanPham_Audios",
                table: "sanPham_Audios",
                column: "TuongThich");

            migrationBuilder.AddPrimaryKey(
                name: "PK_sanPham_Appliances",
                table: "sanPham_Appliances",
                column: "Loai");
        }
    }
}
