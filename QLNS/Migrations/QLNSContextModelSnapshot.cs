﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QLNS.Data;

#nullable disable

namespace QLNS.Migrations
{
    [DbContext(typeof(QLNSContext))]
    partial class QLNSContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("QLNS.Models.ChamCong", b =>
                {
                    b.Property<int>("MaCC")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaCC"), 1L, 1);

                    b.Property<string>("MaNV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayChamCong")
                        .HasColumnType("datetime2");

                    b.Property<int>("SoGioLamViec")
                        .HasColumnType("int");

                    b.HasKey("MaCC");

                    b.ToTable("ChamCong");
                });

            modelBuilder.Entity("QLNS.Models.ChucVu", b =>
                {
                    b.Property<string>("MaChucVu")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TenChucVu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaChucVu");

                    b.ToTable("ChucVu");
                });

            modelBuilder.Entity("QLNS.Models.HopDongLaoDong", b =>
                {
                    b.Property<string>("MaHDLD")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ChucVu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiaDiemLamViec")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LoaiHDLD")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaLuong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaNV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PhuCap")
                        .HasColumnType("float");

                    b.Property<double>("ThoiHan")
                        .HasColumnType("float");

                    b.HasKey("MaHDLD");

                    b.ToTable("HopDongLaoDong");
                });

            modelBuilder.Entity("QLNS.Models.LuongNhanVien", b =>
                {
                    b.Property<string>("MaLuong")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("LCBan")
                        .HasColumnType("float");

                    b.Property<string>("MaNV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaLuong");

                    b.ToTable("LuongNhanVien");
                });

            modelBuilder.Entity("QLNS.Models.NhanVien", b =>
                {
                    b.Property<string>("MaNV")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GioiTinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("HeSoLuong")
                        .HasColumnType("float");

                    b.Property<string>("MaBac")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaChucVu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaNganh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaPB")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<double>("PhuCap")
                        .HasColumnType("float");

                    b.Property<string>("TenNV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaNV");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("QLNS.Models.PhongBan", b =>
                {
                    b.Property<string>("MaPB")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenPB")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaPB");

                    b.ToTable("PhongBan");
                });
#pragma warning restore 612, 618
        }
    }
}
