 namespace TeduShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BANGLUONGCT",
                c => new
                    {
                        MaLuong = c.String(nullable: false, maxLength: 128),
                        LuongCB = c.Int(nullable: false),
                        ChucVu = c.String(nullable: false),
                        NgayNhap = c.DateTime(nullable: false),
                        LuongThuong = c.Int(),
                        NgaySua = c.DateTime(nullable: false),
                        LyDo = c.String(maxLength: 200),
                        GhiChu = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.MaLuong);
            
            CreateTable(
                "dbo.BOPHAN",
                c => new
                    {
                        MaBoPhan = c.String(nullable: false, maxLength: 128),
                        TenBoPhan = c.String(nullable: false),
                        NgayThanhLap = c.DateTime(nullable: false),
                        GhiChu = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.MaBoPhan);
            
            CreateTable(
                "dbo.ChamCong",
                c => new
                    {
                        MaCC = c.String(nullable: false, maxLength: 128),
                        NgayChamCong = c.DateTime(nullable: false),
                        SoNgayCong = c.Int(nullable: false),
                        SoNgayNghi = c.Int(nullable: false),
                        SoGioLamThem = c.Int(nullable: false),
                        MaLuong = c.String(nullable: false, maxLength: 128),
                        GhiChu = c.String(maxLength: 500),
                        HoTenNV = c.String(nullable: false),
                        TenBoPhan = c.String(maxLength: 256),
                        TenPhong = c.String(maxLength: 256),
                        LuongTViec = c.Int(),
                    })
                .PrimaryKey(t => t.MaCC)
                .ForeignKey("dbo.BANGLUONGCT", t => t.MaLuong, cascadeDelete: true)
                .Index(t => t.MaLuong);
            
            CreateTable(
                "dbo.HOSOXINVIEC",
                c => new
                    {
                        MaHoSoNV = c.String(nullable: false, maxLength: 128),
                        MaNV = c.String(nullable: false, maxLength: 128),
                        MaPhong = c.String(nullable: false, maxLength: 128),
                        HoTenNV = c.String(nullable: false),
                        NgaySinh = c.DateTime(nullable: false),
                        GioiTinh = c.String(nullable: false),
                        DiaChi = c.String(nullable: false),
                        TDHocVan = c.String(nullable: false),
                        ViTriThuViec = c.String(nullable: false),
                        NgayLamviec = c.DateTime(nullable: false),
                        GhiChu = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.MaHoSoNV)
                .ForeignKey("dbo.NHANVIEN", t => t.MaNV, cascadeDelete: true)
                .ForeignKey("dbo.PHONGBAN", t => t.MaPhong, cascadeDelete: true)
                .Index(t => t.MaNV)
                .Index(t => t.MaPhong);
            
            CreateTable(
                "dbo.NHANVIEN",
                c => new
                    {
                        MaNV = c.String(nullable: false, maxLength: 128),
                        MaBoPhan = c.String(nullable: false, maxLength: 128),
                        MaCC = c.String(nullable: false, maxLength: 128),
                        MaPhong = c.String(nullable: false, maxLength: 128),
                        MaLuong = c.String(nullable: false, maxLength: 128),
                        HoTenNV = c.String(nullable: false),
                        NgaySinh = c.DateTime(nullable: false),
                        GioiTinh = c.String(nullable: false),
                        TTHonNhan = c.String(nullable: false),
                        CMTND = c.String(),
                        NoiCap = c.String(nullable: false),
                        ChucVu = c.String(nullable: false),
                        LoaiHD = c.String(nullable: false),
                        NgayKy = c.DateTime(nullable: false),
                        NgayHetHan = c.DateTime(nullable: false),
                        GhiChu = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.MaNV)
                .ForeignKey("dbo.BANGLUONGCT", t => t.MaLuong, cascadeDelete: true)
                .ForeignKey("dbo.BOPHAN", t => t.MaBoPhan, cascadeDelete: true)
                .ForeignKey("dbo.ChamCong", t => t.MaCC, cascadeDelete: true)
                .ForeignKey("dbo.PHONGBAN", t => t.MaPhong, cascadeDelete: true)
                .Index(t => t.MaBoPhan)
                .Index(t => t.MaCC)
                .Index(t => t.MaPhong)
                .Index(t => t.MaLuong);
            
            CreateTable(
                "dbo.PHONGBAN",
                c => new
                    {
                        MaPhong = c.String(nullable: false, maxLength: 128),
                        MaBoPhan = c.String(nullable: false, maxLength: 128),
                        TenPhong = c.String(nullable: false),
                        NgayThanhLap = c.DateTime(nullable: false),
                        GhiChu = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.MaPhong)
                .ForeignKey("dbo.BOPHAN", t => t.MaBoPhan, cascadeDelete: true)
                .Index(t => t.MaBoPhan);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HOSOXINVIEC", "MaPhong", "dbo.PHONGBAN");
            DropForeignKey("dbo.HOSOXINVIEC", "MaNV", "dbo.NHANVIEN");
            DropForeignKey("dbo.NHANVIEN", "MaPhong", "dbo.PHONGBAN");
            DropForeignKey("dbo.PHONGBAN", "MaBoPhan", "dbo.BOPHAN");
            DropForeignKey("dbo.NHANVIEN", "MaCC", "dbo.ChamCong");
            DropForeignKey("dbo.NHANVIEN", "MaBoPhan", "dbo.BOPHAN");
            DropForeignKey("dbo.NHANVIEN", "MaLuong", "dbo.BANGLUONGCT");
            DropForeignKey("dbo.ChamCong", "MaLuong", "dbo.BANGLUONGCT");
            DropIndex("dbo.PHONGBAN", new[] { "MaBoPhan" });
            DropIndex("dbo.NHANVIEN", new[] { "MaLuong" });
            DropIndex("dbo.NHANVIEN", new[] { "MaPhong" });
            DropIndex("dbo.NHANVIEN", new[] { "MaCC" });
            DropIndex("dbo.NHANVIEN", new[] { "MaBoPhan" });
            DropIndex("dbo.HOSOXINVIEC", new[] { "MaPhong" });
            DropIndex("dbo.HOSOXINVIEC", new[] { "MaNV" });
            DropIndex("dbo.ChamCong", new[] { "MaLuong" });
            DropTable("dbo.PHONGBAN");
            DropTable("dbo.NHANVIEN");
            DropTable("dbo.HOSOXINVIEC");
            DropTable("dbo.ChamCong");
            DropTable("dbo.BOPHAN");
            DropTable("dbo.BANGLUONGCT");
        }
    }
}
