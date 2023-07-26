﻿// <auto-generated />
using System;
using BanGiayTheThao.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppC5Data.Migrations
{
    [DbContext(typeof(GiayDBcontext))]
    [Migration("20230609105928_appc5")]
    partial class appc5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BanGiayTheThao.Models.Anh", b =>
                {
                    b.Property<Guid>("IdAnh")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DuongDanAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("IdSanPham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IdAnh");

                    b.HasIndex("IdSanPham");

                    b.ToTable("Anhs");
                });

            modelBuilder.Entity("BanGiayTheThao.Models.ChatLieu", b =>
                {
                    b.Property<Guid>("IdChatLieu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaChatLieu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenChatLieu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdChatLieu");

                    b.ToTable("ChatLieus");
                });

            modelBuilder.Entity("BanGiayTheThao.Models.ChucVu", b =>
                {
                    b.Property<Guid>("IdChucVu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenCV")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IdChucVu");

                    b.ToTable("ChucVus");
                });

            modelBuilder.Entity("BanGiayTheThao.Models.GiamGia", b =>
                {
                    b.Property<Guid>("IdGiamGia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaGiamGia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("SoTienDaGiam")
                        .HasColumnType("float");

                    b.Property<string>("TenGiamGia")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdGiamGia");

                    b.ToTable("GiamGias");
                });

            modelBuilder.Entity("BanGiayTheThao.Models.GioHang", b =>
                {
                    b.Property<Guid>("IdGioHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdNguoiDung")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdGioHang");

                    b.HasIndex("IdNguoiDung");

                    b.ToTable("GioHangs");
                });

            modelBuilder.Entity("BanGiayTheThao.Models.GioHangChiTiet", b =>
                {
                    b.Property<Guid>("IdGioHangCT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdGioHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdPhanLoaiSP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("SoLuong")
                        .HasColumnType("int");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IdGioHangCT");

                    b.HasIndex("IdGioHang");

                    b.HasIndex("IdPhanLoaiSP");

                    b.ToTable("GioHangChiTiets");
                });

            modelBuilder.Entity("BanGiayTheThao.Models.HoaDon", b =>
                {
                    b.Property<Guid>("IdHoaDon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("IDGiamGia")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IDNguoiDung")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("NgayDat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayGiao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<double?>("TongTien")
                        .HasColumnType("float");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IdHoaDon");

                    b.HasIndex("IDGiamGia");

                    b.HasIndex("IDNguoiDung");

                    b.ToTable("HoaDons");
                });

            modelBuilder.Entity("BanGiayTheThao.Models.HoaDonChiTiet", b =>
                {
                    b.Property<Guid>("IdHoaDonChiTiet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double?>("GiaTien")
                        .HasColumnType("float");

                    b.Property<Guid?>("IDhoaDon")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdPhanLoaiSP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("IdHoaDonChiTiet");

                    b.HasIndex("IDhoaDon");

                    b.HasIndex("IdPhanLoaiSP");

                    b.ToTable("HoaDonChiTiets");
                });

            modelBuilder.Entity("BanGiayTheThao.Models.KhuyenMai", b =>
                {
                    b.Property<Guid>("IdKhuyenMai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaKhuyenMai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("NgayBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayKetThuc")
                        .HasColumnType("datetime2");

                    b.Property<double?>("SoTienGiam")
                        .HasColumnType("float");

                    b.HasKey("IdKhuyenMai");

                    b.ToTable("KhuyenMais");
                });

            modelBuilder.Entity("BanGiayTheThao.Models.KmSanPham", b =>
                {
                    b.Property<Guid>("IDKMSP")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("idKhuyenMai")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("idSanPham")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IDKMSP");

                    b.HasIndex("idKhuyenMai");

                    b.HasIndex("idSanPham");

                    b.ToTable("KhSanPhams");
                });

            modelBuilder.Entity("BanGiayTheThao.Models.Mau", b =>
                {
                    b.Property<Guid>("IdMau")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaMau")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenMau")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdMau");

                    b.ToTable("Maus");
                });

            modelBuilder.Entity("BanGiayTheThao.Models.NguoiDung", b =>
                {
                    b.Property<Guid>("IdNguoiDung")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GioiTinh")
                        .HasColumnType("int");

                    b.Property<string>("Ho")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("IdChucVu")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MatKhau")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SDT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenDangNhap")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IdNguoiDung");

                    b.HasIndex("IdChucVu");

                    b.ToTable("NguoiDungs");
                });

            modelBuilder.Entity("BanGiayTheThao.Models.NSX", b =>
                {
                    b.Property<Guid>("IdNSX")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaNSX")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenNSX")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IdNSX");

                    b.ToTable("NSXs");
                });

            modelBuilder.Entity("BanGiayTheThao.Models.PhanLoaiSP", b =>
                {
                    b.Property<Guid>("IdPhanLoaiSP")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IDChatLieu")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IDNSX")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IDmau")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdSanPham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdSize")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Soluong")
                        .HasColumnType("int");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IdPhanLoaiSP");

                    b.HasIndex("IDChatLieu");

                    b.HasIndex("IDNSX");

                    b.HasIndex("IDmau");

                    b.HasIndex("IdSanPham");

                    b.HasIndex("IdSize");

                    b.ToTable("PhanLoaiSps");
                });

            modelBuilder.Entity("BanGiayTheThao.Models.SanPham", b =>
                {
                    b.Property<Guid>("IdSanPham")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double?>("ChieuCaoDeGiay")
                        .HasColumnType("float");

                    b.Property<double?>("GiaBan")
                        .HasColumnType("float");

                    b.Property<double?>("GiaNhap")
                        .HasColumnType("float");

                    b.Property<string>("MaSanPham")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenSanPham")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IdSanPham");

                    b.ToTable("SanPhams");
                });

            modelBuilder.Entity("BanGiayTheThao.Models.Size", b =>
                {
                    b.Property<Guid>("IdSize")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("SoSize")
                        .HasColumnType("int");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IdSize");

                    b.ToTable("Sizess");
                });

            modelBuilder.Entity("BanGiayTheThao.Models.Anh", b =>
                {
                    b.HasOne("BanGiayTheThao.Models.SanPham", "SanPham")
                        .WithMany("Anhs")
                        .HasForeignKey("IdSanPham");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("BanGiayTheThao.Models.GioHang", b =>
                {
                    b.HasOne("BanGiayTheThao.Models.NguoiDung", "NguoiDung")
                        .WithMany("GioHangs")
                        .HasForeignKey("IdNguoiDung");

                    b.Navigation("NguoiDung");
                });

            modelBuilder.Entity("BanGiayTheThao.Models.GioHangChiTiet", b =>
                {
                    b.HasOne("BanGiayTheThao.Models.GioHang", "GioHang")
                        .WithMany("GioHangChiTiets")
                        .HasForeignKey("IdGioHang");

                    b.HasOne("BanGiayTheThao.Models.PhanLoaiSP", "PhanLoaiSp")
                        .WithMany("GioHangChiTiets")
                        .HasForeignKey("IdPhanLoaiSP");

                    b.Navigation("GioHang");

                    b.Navigation("PhanLoaiSp");
                });

            modelBuilder.Entity("BanGiayTheThao.Models.HoaDon", b =>
                {
                    b.HasOne("BanGiayTheThao.Models.GiamGia", "GiamGia")
                        .WithMany("HoaDons")
                        .HasForeignKey("IDGiamGia");

                    b.HasOne("BanGiayTheThao.Models.NguoiDung", "NguoiDung")
                        .WithMany("HoaDon")
                        .HasForeignKey("IDNguoiDung");

                    b.Navigation("GiamGia");

                    b.Navigation("NguoiDung");
                });

            modelBuilder.Entity("BanGiayTheThao.Models.HoaDonChiTiet", b =>
                {
                    b.HasOne("BanGiayTheThao.Models.HoaDon", "HoaDon")
                        .WithMany("HoaDonChiTiet")
                        .HasForeignKey("IDhoaDon");

                    b.HasOne("BanGiayTheThao.Models.PhanLoaiSP", "PhanLoaiSp")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("IdPhanLoaiSP");

                    b.Navigation("HoaDon");

                    b.Navigation("PhanLoaiSp");
                });

            modelBuilder.Entity("BanGiayTheThao.Models.KmSanPham", b =>
                {
                    b.HasOne("BanGiayTheThao.Models.KhuyenMai", "KhuyenMai")
                        .WithMany("KmSanPhams")
                        .HasForeignKey("idKhuyenMai");

                    b.HasOne("BanGiayTheThao.Models.SanPham", "SanPham")
                        .WithMany("KmSanPhams")
                        .HasForeignKey("idSanPham");

                    b.Navigation("KhuyenMai");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("BanGiayTheThao.Models.NguoiDung", b =>
                {
                    b.HasOne("BanGiayTheThao.Models.ChucVu", "ChucVus")
                        .WithMany("NguoiDung")
                        .HasForeignKey("IdChucVu");

                    b.Navigation("ChucVus");
                });

            modelBuilder.Entity("BanGiayTheThao.Models.PhanLoaiSP", b =>
                {
                    b.HasOne("BanGiayTheThao.Models.ChatLieu", "CChatLieu")
                        .WithMany("PPhanLoaiSps")
                        .HasForeignKey("IDChatLieu");

                    b.HasOne("BanGiayTheThao.Models.NSX", "Nsx")
                        .WithMany("PhanLoaiSps")
                        .HasForeignKey("IDNSX");

                    b.HasOne("BanGiayTheThao.Models.Mau", "Mau")
                        .WithMany("PhanLoaiSps")
                        .HasForeignKey("IDmau");

                    b.HasOne("BanGiayTheThao.Models.SanPham", "SanPham")
                        .WithMany("PhanLoaiSps")
                        .HasForeignKey("IdSanPham");

                    b.HasOne("BanGiayTheThao.Models.Size", "Size")
                        .WithMany("PPhanLoaiSps")
                        .HasForeignKey("IdSize");

                    b.Navigation("CChatLieu");

                    b.Navigation("Mau");

                    b.Navigation("Nsx");

                    b.Navigation("SanPham");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("BanGiayTheThao.Models.ChatLieu", b =>
                {
                    b.Navigation("PPhanLoaiSps");
                });

            modelBuilder.Entity("BanGiayTheThao.Models.ChucVu", b =>
                {
                    b.Navigation("NguoiDung");
                });

            modelBuilder.Entity("BanGiayTheThao.Models.GiamGia", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("BanGiayTheThao.Models.GioHang", b =>
                {
                    b.Navigation("GioHangChiTiets");
                });

            modelBuilder.Entity("BanGiayTheThao.Models.HoaDon", b =>
                {
                    b.Navigation("HoaDonChiTiet");
                });

            modelBuilder.Entity("BanGiayTheThao.Models.KhuyenMai", b =>
                {
                    b.Navigation("KmSanPhams");
                });

            modelBuilder.Entity("BanGiayTheThao.Models.Mau", b =>
                {
                    b.Navigation("PhanLoaiSps");
                });

            modelBuilder.Entity("BanGiayTheThao.Models.NguoiDung", b =>
                {
                    b.Navigation("GioHangs");

                    b.Navigation("HoaDon");
                });

            modelBuilder.Entity("BanGiayTheThao.Models.NSX", b =>
                {
                    b.Navigation("PhanLoaiSps");
                });

            modelBuilder.Entity("BanGiayTheThao.Models.PhanLoaiSP", b =>
                {
                    b.Navigation("GioHangChiTiets");

                    b.Navigation("HoaDonChiTiets");
                });

            modelBuilder.Entity("BanGiayTheThao.Models.SanPham", b =>
                {
                    b.Navigation("Anhs");

                    b.Navigation("KmSanPhams");

                    b.Navigation("PhanLoaiSps");
                });

            modelBuilder.Entity("BanGiayTheThao.Models.Size", b =>
                {
                    b.Navigation("PPhanLoaiSps");
                });
#pragma warning restore 612, 618
        }
    }
}
