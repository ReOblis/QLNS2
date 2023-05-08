using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using QLNS.Data;
using System;
using System.Linq;
namespace QLNS.Models;
public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new QLNSContext(
            serviceProvider.GetRequiredService<
            DbContextOptions<QLNSContext>>()))
        {
            // Look for any movies.
            if (context.NhanVien.Any())
            {
                return;   // DB has been seeded
            }
            context.NhanVien.AddRange(
                new NhanVien
                {
                    MaNV = "NV0001",
                    TenNV = "Tran Thi B",
                    GioiTinh = "Nu",
                    NgaySinh = new System.DateTime(1998, 2, 2),
                    DiaChi = "Ho Chi Minh",
                    MaNganh = "Marketing",
                    MaBac = "Bac2",
                    HeSoLuong = 2.0,
                    PhuCap = 2000000,
                    MaChucVu = "CV2",
                    MaPB = "PB2"
                },
            new NhanVien
            {
                MaNV = "NV0002",
                TenNV = "Nguyen Van A",
                GioiTinh = "Nam",
                NgaySinh = new System.DateTime(1995, 1, 1),
                DiaChi = "Ha Noi",
                MaNganh = "IT",
                MaBac = "Bac1",
                HeSoLuong = 1.5,
                PhuCap = 1000000,
                MaChucVu = "CV1",
                MaPB = "PB1"
            },
            new NhanVien
            {
                MaNV = "NV0003",
                TenNV = "Tran Van D",
                GioiTinh = "Nam",
                NgaySinh = new System.DateTime(1993, 4, 15),
                DiaChi = "Da Nang",
                MaNganh = "Kinh doanh",
                MaBac = "Bac2",
                HeSoLuong = 2.5,
                PhuCap = 2500000,
                MaChucVu = "CV2",
                MaPB = "PB2"
            },
            new NhanVien
            {
                MaNV = "NV0004",
                TenNV = "Nguyen Thi E",
                GioiTinh = "Nu",
                NgaySinh = new System.DateTime(1994, 3, 12),
                DiaChi = "Hai Phong",
                MaNganh = "IT",
                MaBac = "Bac1",
                HeSoLuong = 1.5,
                PhuCap = 1500000,
                MaChucVu = "CV1",
                MaPB = "PB1"
            },
            new NhanVien
            {
                MaNV = "NV0005",
                TenNV = "Pham Van F",
                GioiTinh = "Nam",
                NgaySinh = new System.DateTime(1995, 2, 19),
                DiaChi = "Ha Noi",
                MaNganh = "Marketing",
                MaBac = "Bac2",
                HeSoLuong = 2.0,
                PhuCap = 2000000,
                MaChucVu = "CV2",
                MaPB = "PB3"
            },
            new NhanVien
            {
                MaNV = "NV0006",
                TenNV = "Tran Thi G",
                GioiTinh = "Nu",
                NgaySinh = new System.DateTime(1996, 1, 25),
                DiaChi = "Ho Chi Minh",
                MaNganh = "Ke toan",
                MaBac = "Bac3",
                HeSoLuong = 3.0,
                PhuCap = 3000000,
                MaChucVu = "CV3",
                MaPB = "PB1"
            },
            new NhanVien
            {
                MaNV = "NV0007",
                TenNV = "Le Van H",
                GioiTinh = "Nam",
                NgaySinh = new System.DateTime(1997, 2, 28),
                DiaChi = "Da Nang",
                MaNganh = "Kinh doanh",
                MaBac = "Bac2",
                HeSoLuong = 2.5,
                PhuCap = 2500000,
                MaChucVu = "CV2",
                MaPB = "PB2"
            },
            new NhanVien
            {
                MaNV = "NV0008",
                TenNV = "Nguyen Van I",
                GioiTinh = "Nam",
                NgaySinh = new System.DateTime(1994, 5, 15),
                DiaChi = "Da Nang",
                MaNganh = "Sales",
                MaBac = "Bac2",
                HeSoLuong = 2.2,
                PhuCap = 2200000,
                MaChucVu = "CV2",
                MaPB = "PB3"
            },
            new NhanVien
            {
                MaNV = "NV0009",
                TenNV = "Tran Van J",
                GioiTinh = "Nam",
                NgaySinh = new System.DateTime(1992, 9, 25),
                DiaChi = "Ha Noi",
                MaNganh = "IT",
                MaBac = "Bac3",
                HeSoLuong = 3.0,
                PhuCap = 3000000,
                MaChucVu = "CV3",
                MaPB = "PB1"
            },
            new NhanVien
            {
                MaNV = "NV0010",
                TenNV = "Tran Thi O",
                GioiTinh = "Nu",
                NgaySinh = new System.DateTime(1999, 12, 3),
                DiaChi = "Can Tho",
                MaNganh = "Marketing",
                MaBac = "Bac1",
                HeSoLuong = 1.8,
                PhuCap = 1800000,
                MaChucVu = "CV1",
                MaPB = "PB2"
            }
            );
            if (context.ChamCong.Any())
            {
                return;   // DB has been seeded
            }
            context.ChamCong.AddRange(
                new ChamCong { MaCC = 331, MaNV = "NV0001", NgayChamCong = new DateTime(2023, 5, 1), SoGioLamViec = 8 },
                new ChamCong { MaCC = 332, MaNV = "NV0002", NgayChamCong = new DateTime(2023, 5, 1), SoGioLamViec = 7 },
                new ChamCong { MaCC = 333, MaNV = "NV0003", NgayChamCong = new DateTime(2023, 5, 1), SoGioLamViec = 6 },
                new ChamCong { MaCC = 334, MaNV = "NV0004", NgayChamCong = new DateTime(2023, 5, 1), SoGioLamViec = 8 },
                new ChamCong { MaCC = 335, MaNV = "NV0005", NgayChamCong = new DateTime(2023, 5, 1), SoGioLamViec = 7 },
                new ChamCong { MaCC = 336, MaNV = "NV0006", NgayChamCong = new DateTime(2023, 5, 1), SoGioLamViec = 6 },
                new ChamCong { MaCC = 337, MaNV = "NV0007", NgayChamCong = new DateTime(2023, 5, 1), SoGioLamViec = 8 },
                new ChamCong { MaCC = 338, MaNV = "NV0008", NgayChamCong = new DateTime(2023, 5, 1), SoGioLamViec = 7 },
                new ChamCong { MaCC = 339, MaNV = "NV0009", NgayChamCong = new DateTime(2023, 5, 1), SoGioLamViec = 6 },
                new ChamCong { MaCC = 340, MaNV = "NV0010", NgayChamCong = new DateTime(2023, 5, 1), SoGioLamViec = 8 },
                new ChamCong { MaCC = 341, MaNV = "NV0001", NgayChamCong = new DateTime(2023, 5, 2), SoGioLamViec = 7 },
                new ChamCong { MaCC = 342, MaNV = "NV0002", NgayChamCong = new DateTime(2023, 5, 2), SoGioLamViec = 8 },
                new ChamCong { MaCC = 343, MaNV = "NV0003", NgayChamCong = new DateTime(2023, 5, 2), SoGioLamViec = 8 },
                new ChamCong { MaCC = 344, MaNV = "NV0004", NgayChamCong = new DateTime(2023, 5, 2), SoGioLamViec = 7 },
                new ChamCong { MaCC = 345, MaNV = "NV0005", NgayChamCong = new DateTime(2023, 5, 2), SoGioLamViec = 6 },
                new ChamCong { MaCC = 346, MaNV = "NV0006", NgayChamCong = new DateTime(2023, 5, 2), SoGioLamViec = 7 },
                new ChamCong { MaCC = 347, MaNV = "NV0007", NgayChamCong = new DateTime(2023, 5, 2), SoGioLamViec = 8 },
                new ChamCong { MaCC = 348, MaNV = "NV0008", NgayChamCong = new DateTime(2023, 5, 2), SoGioLamViec = 8 },
                new ChamCong { MaCC = 349, MaNV = "NV0009", NgayChamCong = new DateTime(2023, 5, 2), SoGioLamViec = 8 },
                new ChamCong { MaCC = 350, MaNV = "NV0010", NgayChamCong = new DateTime(2023, 5, 2), SoGioLamViec = 8 },
                new ChamCong { MaCC = 351, MaNV = "NV0001", NgayChamCong = new DateTime(2023, 5, 3), SoGioLamViec = 7 },
                new ChamCong { MaCC = 352, MaNV = "NV0002", NgayChamCong = new DateTime(2023, 5, 3), SoGioLamViec = 8 },
                new ChamCong { MaCC = 353, MaNV = "NV0003", NgayChamCong = new DateTime(2023, 5, 3), SoGioLamViec = 6 },
                new ChamCong { MaCC = 354, MaNV = "NV0004", NgayChamCong = new DateTime(2023, 5, 3), SoGioLamViec = 8 },
                new ChamCong { MaCC = 355, MaNV = "NV0005", NgayChamCong = new DateTime(2023, 5, 3), SoGioLamViec = 5 },
                new ChamCong { MaCC = 356, MaNV = "NV0006", NgayChamCong = new DateTime(2023, 5, 3), SoGioLamViec = 8 },
                new ChamCong { MaCC = 357, MaNV = "NV0007", NgayChamCong = new DateTime(2023, 5, 3), SoGioLamViec = 7 },
                new ChamCong { MaCC = 358, MaNV = "NV0008", NgayChamCong = new DateTime(2023, 5, 3), SoGioLamViec = 8 },
                new ChamCong { MaCC = 359, MaNV = "NV0009", NgayChamCong = new DateTime(2023, 5, 3), SoGioLamViec = 6 },
                new ChamCong { MaCC = 360, MaNV = "NV0010", NgayChamCong = new DateTime(2023, 5, 3), SoGioLamViec = 8 }
            );
            if (context.PhongBan.Any())
            {
                return;   // DB has been seeded
            }
            context.PhongBan.AddRange(
                new PhongBan
                {
                    MaPB = "PB1",
                    TenPB = "Ban Giám Đốc",
                    DiaChi = "Công ty TNHH Vạn Phát chi nhánh 1"
                },
            new PhongBan
            {
                MaPB = "PB2",
                TenPB = "Ban Quản Lý",
                DiaChi = "Công ty TNHH Vạn Phát chi nhánh 2"
            },
            new PhongBan
            {
                MaPB = "PB3",
                TenPB = "Phòng Marketing",
                DiaChi = "Công ty TNHH Vạn Phát chi nhánh 2"
            }
            );
            if (context.LuongNhanVien.Any())
            {
                return;   // DB has been seeded
            }
            context.LuongNhanVien.AddRange(
                new LuongNhanVien
                {
                    MaLuong = "LB1",
                    MaNV = "NV0008",
                    LCBan = 4500000
                },
            new LuongNhanVien
            {
                MaLuong = "LB2",
                MaNV = "NV0003",
                LCBan = 5000000
            },
            new LuongNhanVien
            {
                MaLuong = "LB3",
                MaNV = "NV0006",
                LCBan = 4700000
            },
            new LuongNhanVien
            {
                MaLuong = "LB4",
                MaNV = "NV0009",
                LCBan = 6200000
            }
            );
            if (context.ChucVu.Any())
            {
                return;   // DB has been seeded
            }
            context.ChucVu.AddRange(
                new ChucVu
                {
                    MaChucVu = "CV1",
                    TenChucVu = "Trưởng phòng"
                },
            new ChucVu
            {
                MaChucVu = "CV2",
                TenChucVu = "Phó phòng"
            },
            new ChucVu
            {
                MaChucVu = "CV3",
                TenChucVu = "Nhân viên marketing"
            },
            new ChucVu
            {
                MaChucVu = "CV4",
                TenChucVu = "Nhân viên giám sát"
            },
            new ChucVu
            {
                MaChucVu = "CV5",
                TenChucVu = "Kế toán"
            },
            new ChucVu
            {
                MaChucVu = "CV6",
                TenChucVu = "Dev"
            }
            );
            if (context.HopDongLaoDong.Any())
            {
                return;   // DB has been seeded
            }
            context.HopDongLaoDong.AddRange(
                new HopDongLaoDong
                {
                    MaHDLD = "HDT1",
                    MaNV = "NV0001",
                    LoaiHDLD = "Hợp đồng thời vụ",
                    ThoiHan = 3,
                    DiaDiemLamViec = "Chi nhánh 1",
                    MaLuong = "LB1",
                    PhuCap = 1000000,
                    ChucVu = "CV1"
                },
            new HopDongLaoDong
            {
                MaHDLD = "HDT2",
                MaNV = "NV0002",
                LoaiHDLD = "Hợp đồng thử việc",
                ThoiHan = 2,
                DiaDiemLamViec = "Chi nhánh 2",
                MaLuong = "LB2",
                PhuCap = 1200000,
                ChucVu = "CV2"
            },
            new HopDongLaoDong
            {
                MaHDLD = "HDT3",
                MaNV = "NV0003",
                LoaiHDLD = "Hợp đồng hợp tác",
                ThoiHan = 8,
                DiaDiemLamViec = "Chi nhánh 2",
                MaLuong = "LB4",
                PhuCap = 1900000,
                ChucVu = "CV4"
            },
            new HopDongLaoDong
            {
                MaHDLD = "HDT4",
                MaNV = "NV0004",
                LoaiHDLD = "Hợp đồng xác định thời hạn",
                ThoiHan = 12,
                DiaDiemLamViec = "Chi nhánh 3",
                MaLuong = "LB3",
                PhuCap = 1500000,
                ChucVu = "CV2"
            },
            new HopDongLaoDong
            {
                MaHDLD = "HDT5",
                MaNV = "NV0005",
                LoaiHDLD = "Hợp đồng xác định thời hạn",
                ThoiHan = 12,
                DiaDiemLamViec = "Chi nhánh 2",
                MaLuong = "LB3",
                PhuCap = 1700000,
                ChucVu = "CV3"
            },
            new HopDongLaoDong
            {
                MaHDLD = "HDT6",
                MaNV = "NV0006",
                LoaiHDLD = "Hợp đồng học việc",
                ThoiHan = 6,
                DiaDiemLamViec = "Chi nhánh 1",
                MaLuong = "LB1",
                PhuCap = 1200000,
                ChucVu = "CV1"
            },
            new HopDongLaoDong
            {
                MaHDLD = "HDT7",
                MaNV = "NV0007",
                LoaiHDLD = "Hợp đồng thử việc",
                ThoiHan = 2,
                DiaDiemLamViec = "Chi nhánh 1",
                MaLuong = "LB1",
                PhuCap = 1000000,
                ChucVu = "CV1"
            },
            new HopDongLaoDong
            {
                MaHDLD = "HDT8",
                MaNV = "NV0008",
                LoaiHDLD = "Hợp đồng thời vụ",
                ThoiHan = 3,
                DiaDiemLamViec = "Chi nhánh 1",
                MaLuong = "LB3",
                PhuCap = 1500000,
                ChucVu = "CV2"
            },
            new HopDongLaoDong
            {
                MaHDLD = "HDT9",
                MaNV = "NV0009",
                LoaiHDLD = "Hợp đồng thời vụ",
                ThoiHan = 3,
                DiaDiemLamViec = "Chi nhánh 1",
                MaLuong = "LB3",
                PhuCap = 1500000,
                ChucVu = "CV3"
            },
            new HopDongLaoDong
            {
                MaHDLD = "HDT10",
                MaNV = "NV0010",
                LoaiHDLD = "Hợp đồng thời vụ",
                ThoiHan = 3,
                DiaDiemLamViec = "Chi nhánh 1",
                MaLuong = "LB3",
                PhuCap = 1500000,
                ChucVu = "CV1"
            }
            );
            // Thêm dữ liệu cho bảng ChamCong
            context.SaveChanges();
        }
    }
}