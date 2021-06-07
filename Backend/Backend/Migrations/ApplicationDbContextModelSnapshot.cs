﻿// <auto-generated />
using System;
using Backend.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Backend.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Backend.Model.Account", b =>
                {
                    b.Property<int>("AccountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("AccountID");

                    b.HasIndex("UserID")
                        .IsUnique();

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Backend.Model.DanhGia", b =>
                {
                    b.Property<int>("MaDanhGia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<double>("BaSao")
                        .HasColumnType("float");

                    b.Property<double>("BonSao")
                        .HasColumnType("float");

                    b.Property<double>("HaiSao")
                        .HasColumnType("float");

                    b.Property<double>("MotSao")
                        .HasColumnType("float");

                    b.Property<double>("NamSao")
                        .HasColumnType("float");

                    b.HasKey("MaDanhGia");

                    b.ToTable("danhGias");
                });

            modelBuilder.Entity("Backend.Model.GiaoDich", b =>
                {
                    b.Property<int>("MaGD")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("NgayGD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenCongThanhToan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenGD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int?>("UserID1")
                        .HasColumnType("int");

                    b.HasKey("MaGD");

                    b.HasIndex("UserID");

                    b.HasIndex("UserID1")
                        .IsUnique()
                        .HasFilter("[UserID1] IS NOT NULL");

                    b.ToTable("GiaoDiches");
                });

            modelBuilder.Entity("Backend.Model.HinhAnh", b =>
                {
                    b.Property<int>("HinhID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("TenHinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("sanPhamMaSP")
                        .HasColumnType("int");

                    b.Property<string>("urlHinh")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HinhID");

                    b.HasIndex("sanPhamMaSP");

                    b.ToTable("HinhAnhs");
                });

            modelBuilder.Entity("Backend.Model.HoaDon", b =>
                {
                    b.Property<int>("MaHD")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DiaChiGiaoHang")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MGD")
                        .HasColumnType("int");

                    b.Property<string>("NgayXN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SanPhamInHoaDonMaHD")
                        .HasColumnType("int");

                    b.Property<int?>("SanPhamInHoaDonMaSP")
                        .HasColumnType("int");

                    b.Property<string>("TenHD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tongdon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrangThaiHD")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaHD");

                    b.HasIndex("MGD")
                        .IsUnique();

                    b.HasIndex("SanPhamInHoaDonMaSP", "SanPhamInHoaDonMaHD");

                    b.ToTable("HoaDons");
                });

            modelBuilder.Entity("Backend.Model.SanPham", b =>
                {
                    b.Property<int>("MaSP")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<double>("DonGia")
                        .HasColumnType("float");

                    b.Property<string>("Mota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SanPhamInHoaDonMaHD")
                        .HasColumnType("int");

                    b.Property<int?>("SanPhamInHoaDonMaSP")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("TenNSX")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenSP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TennhomSP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TinhTrang")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("urlHinh")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaSP");

                    b.HasIndex("SanPhamInHoaDonMaSP", "SanPhamInHoaDonMaHD");

                    b.ToTable("SanPhams");
                });

            modelBuilder.Entity("Backend.Model.SanPhamInHoaDon", b =>
                {
                    b.Property<int>("MaSP")
                        .HasColumnType("int");

                    b.Property<int>("MaHD")
                        .HasColumnType("int");

                    b.Property<double>("DonGia")
                        .HasColumnType("float");

                    b.Property<int>("soluong")
                        .HasColumnType("int");

                    b.HasKey("MaSP", "MaHD");

                    b.HasIndex("MaHD");

                    b.ToTable("SanPhamInHoaDons");
                });

            modelBuilder.Entity("Backend.Model.SanPham_Appliance", b =>
                {
                    b.Property<int>("MaAppliance")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CongSuat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DanhGia")
                        .HasColumnType("int");

                    b.Property<string>("DungTich")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Loai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaCT")
                        .HasColumnType("int");

                    b.Property<string>("NoiSanXuat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rong")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TienIch")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaAppliance");

                    b.ToTable("sanPham_Appliances");
                });

            modelBuilder.Entity("Backend.Model.SanPham_Audio", b =>
                {
                    b.Property<int>("MaAudio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CongNghe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CongSac")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DanhGia")
                        .HasColumnType("int");

                    b.Property<int>("MaCT")
                        .HasColumnType("int");

                    b.Property<string>("NoiSanXuat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ThoiGianSuDung")
                        .HasColumnType("float");

                    b.Property<string>("TienIch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TuongThich")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaAudio");

                    b.ToTable("sanPham_Audios");
                });

            modelBuilder.Entity("Backend.Model.SanPham_DienThoai", b =>
                {
                    b.Property<int>("MaDT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("BoNhoTrong")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CameraSau")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CameraTruoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Chip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DanhGia")
                        .HasColumnType("int");

                    b.Property<string>("HeDieuHanh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaCT")
                        .HasColumnType("int");

                    b.Property<string>("MangHinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoiSanXuat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sim")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaDT");

                    b.ToTable("sanPham_DienThoais");
                });

            modelBuilder.Entity("Backend.Model.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("urlHinh")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Backend.Model.Account", b =>
                {
                    b.HasOne("Backend.Model.User", "user")
                        .WithOne("account")
                        .HasForeignKey("Backend.Model.Account", "UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("Backend.Model.GiaoDich", b =>
                {
                    b.HasOne("Backend.Model.User", "user")
                        .WithMany("giaoDiches")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Backend.Model.User", null)
                        .WithOne("GiaoDich")
                        .HasForeignKey("Backend.Model.GiaoDich", "UserID1");

                    b.Navigation("user");
                });

            modelBuilder.Entity("Backend.Model.HinhAnh", b =>
                {
                    b.HasOne("Backend.Model.SanPham", "sanPham")
                        .WithMany()
                        .HasForeignKey("sanPhamMaSP");

                    b.Navigation("sanPham");
                });

            modelBuilder.Entity("Backend.Model.HoaDon", b =>
                {
                    b.HasOne("Backend.Model.GiaoDich", "giaoDich")
                        .WithOne("hoaDon")
                        .HasForeignKey("Backend.Model.HoaDon", "MGD")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend.Model.SanPhamInHoaDon", "SanPhamInHoaDon")
                        .WithMany()
                        .HasForeignKey("SanPhamInHoaDonMaSP", "SanPhamInHoaDonMaHD");

                    b.Navigation("giaoDich");

                    b.Navigation("SanPhamInHoaDon");
                });

            modelBuilder.Entity("Backend.Model.SanPham", b =>
                {
                    b.HasOne("Backend.Model.SanPhamInHoaDon", "SanPhamInHoaDon")
                        .WithMany()
                        .HasForeignKey("SanPhamInHoaDonMaSP", "SanPhamInHoaDonMaHD");

                    b.Navigation("SanPhamInHoaDon");
                });

            modelBuilder.Entity("Backend.Model.SanPhamInHoaDon", b =>
                {
                    b.HasOne("Backend.Model.HoaDon", "hoaDon")
                        .WithMany("SanPhamInHoaDons")
                        .HasForeignKey("MaHD")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Backend.Model.SanPham", "SanPham")
                        .WithMany("SanPhamInHoaDons")
                        .HasForeignKey("MaSP")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("hoaDon");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("Backend.Model.GiaoDich", b =>
                {
                    b.Navigation("hoaDon");
                });

            modelBuilder.Entity("Backend.Model.HoaDon", b =>
                {
                    b.Navigation("SanPhamInHoaDons");
                });

            modelBuilder.Entity("Backend.Model.SanPham", b =>
                {
                    b.Navigation("SanPhamInHoaDons");
                });

            modelBuilder.Entity("Backend.Model.User", b =>
                {
                    b.Navigation("account");

                    b.Navigation("GiaoDich");

                    b.Navigation("giaoDiches");
                });
#pragma warning restore 612, 618
        }
    }
}
