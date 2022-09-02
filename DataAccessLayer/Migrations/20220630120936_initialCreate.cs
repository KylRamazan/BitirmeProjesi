using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arkadas",
                columns: table => new
                {
                    ArkadasID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arkadas", x => x.ArkadasID);
                });

            migrationBuilder.CreateTable(
                name: "Bolums",
                columns: table => new
                {
                    BolumID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Silindi = table.Column<bool>(type: "bit", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolums", x => x.BolumID);
                });

            migrationBuilder.CreateTable(
                name: "Etikets",
                columns: table => new
                {
                    EtiketID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Silindi = table.Column<bool>(type: "bit", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etikets", x => x.EtiketID);
                });

            migrationBuilder.CreateTable(
                name: "Lises",
                columns: table => new
                {
                    LiseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Silindi = table.Column<bool>(type: "bit", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lises", x => x.LiseID);
                });

            migrationBuilder.CreateTable(
                name: "Sayfas",
                columns: table => new
                {
                    SayfaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnaSayfaID = table.Column<int>(type: "int", nullable: true),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ControllerAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViewAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sayfas", x => x.SayfaID);
                });

            migrationBuilder.CreateTable(
                name: "Universites",
                columns: table => new
                {
                    UniversiteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bolumler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Silindi = table.Column<bool>(type: "bit", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Universites", x => x.UniversiteID);
                });

            migrationBuilder.CreateTable(
                name: "Yetkis",
                columns: table => new
                {
                    YetkiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Silindi = table.Column<bool>(type: "bit", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yetkis", x => x.YetkiID);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicis",
                columns: table => new
                {
                    KullaniciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cinsiyet = table.Column<bool>(type: "bit", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OkulAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BolumAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Arkadaslar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mezun = table.Column<bool>(type: "bit", nullable: false),
                    Resim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YeniSifre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YetkiID = table.Column<int>(type: "int", nullable: true),
                    Silindi = table.Column<bool>(type: "bit", nullable: false),
                    EtiketDurumu = table.Column<bool>(type: "bit", nullable: false),
                    UniversiteEtiketi = table.Column<int>(type: "int", nullable: true),
                    IlgiAlaniEtiketi = table.Column<int>(type: "int", nullable: true),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicis", x => x.KullaniciID);
                    table.ForeignKey(
                        name: "FK_Kullanicis_Yetkis_YetkiID",
                        column: x => x.YetkiID,
                        principalTable: "Yetkis",
                        principalColumn: "YetkiID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cevaps",
                columns: table => new
                {
                    CevapID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KullaniciID = table.Column<int>(type: "int", nullable: true),
                    Puan = table.Column<int>(type: "int", nullable: true),
                    SoruId = table.Column<int>(type: "int", nullable: true),
                    Silindi = table.Column<bool>(type: "bit", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cevaps", x => x.CevapID);
                    table.ForeignKey(
                        name: "FK_Cevaps_Kullanicis_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "Kullanicis",
                        principalColumn: "KullaniciID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mesajs",
                columns: table => new
                {
                    MesajID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GonderenKullaniciId = table.Column<int>(type: "int", nullable: true),
                    AlanKullaniciId = table.Column<int>(type: "int", nullable: true),
                    Silindi = table.Column<bool>(type: "bit", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KullaniciID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesajs", x => x.MesajID);
                    table.ForeignKey(
                        name: "FK_Mesajs_Kullanicis_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "Kullanicis",
                        principalColumn: "KullaniciID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sorus",
                columns: table => new
                {
                    SoruID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KullaniciID = table.Column<int>(type: "int", nullable: true),
                    UniversiteEtiketi = table.Column<int>(type: "int", nullable: true),
                    IlgiAlaniEtiketi = table.Column<int>(type: "int", nullable: true),
                    Silindi = table.Column<bool>(type: "bit", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sorus", x => x.SoruID);
                    table.ForeignKey(
                        name: "FK_Sorus_Kullanicis_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "Kullanicis",
                        principalColumn: "KullaniciID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cevaps_KullaniciID",
                table: "Cevaps",
                column: "KullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicis_YetkiID",
                table: "Kullanicis",
                column: "YetkiID");

            migrationBuilder.CreateIndex(
                name: "IX_Mesajs_KullaniciID",
                table: "Mesajs",
                column: "KullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_Sorus_KullaniciID",
                table: "Sorus",
                column: "KullaniciID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Arkadas");

            migrationBuilder.DropTable(
                name: "Bolums");

            migrationBuilder.DropTable(
                name: "Cevaps");

            migrationBuilder.DropTable(
                name: "Etikets");

            migrationBuilder.DropTable(
                name: "Lises");

            migrationBuilder.DropTable(
                name: "Mesajs");

            migrationBuilder.DropTable(
                name: "Sayfas");

            migrationBuilder.DropTable(
                name: "Sorus");

            migrationBuilder.DropTable(
                name: "Universites");

            migrationBuilder.DropTable(
                name: "Kullanicis");

            migrationBuilder.DropTable(
                name: "Yetkis");
        }
    }
}
