// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220630122441_initiaCreate")]
    partial class initiaCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.Concrete.Arkadas", b =>
                {
                    b.Property<int>("ArkadasID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Silindi")
                        .HasColumnType("bit");

                    b.HasKey("ArkadasID");

                    b.ToTable("Arkadas");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Bolum", b =>
                {
                    b.Property<int>("BolumID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Silindi")
                        .HasColumnType("bit");

                    b.HasKey("BolumID");

                    b.ToTable("Bolums");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Cevap", b =>
                {
                    b.Property<int>("CevapID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Baslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Icerik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int?>("KullaniciID")
                        .HasColumnType("int");

                    b.Property<int?>("Puan")
                        .HasColumnType("int");

                    b.Property<bool>("Silindi")
                        .HasColumnType("bit");

                    b.Property<int?>("SoruId")
                        .HasColumnType("int");

                    b.HasKey("CevapID");

                    b.HasIndex("KullaniciID");

                    b.ToTable("Cevaps");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Etiket", b =>
                {
                    b.Property<int>("EtiketID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Silindi")
                        .HasColumnType("bit");

                    b.HasKey("EtiketID");

                    b.ToTable("Etikets");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Kullanici", b =>
                {
                    b.Property<int>("KullaniciID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdSoyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Arkadaslar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BolumAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Cinsiyet")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("EMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EtiketDurumu")
                        .HasColumnType("bit");

                    b.Property<int?>("IlgiAlaniEtiketi")
                        .HasColumnType("int");

                    b.Property<DateTime?>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("KullaniciAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Mezun")
                        .HasColumnType("bit");

                    b.Property<string>("OkulAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Silindi")
                        .HasColumnType("bit");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UniversiteEtiketi")
                        .HasColumnType("int");

                    b.Property<string>("YeniSifre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("YetkiID")
                        .HasColumnType("int");

                    b.HasKey("KullaniciID");

                    b.HasIndex("YetkiID");

                    b.ToTable("Kullanicis");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Lise", b =>
                {
                    b.Property<int>("LiseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Silindi")
                        .HasColumnType("bit");

                    b.HasKey("LiseID");

                    b.ToTable("Lises");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Mesaj", b =>
                {
                    b.Property<int>("MesajID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AlanKullaniciId")
                        .HasColumnType("int");

                    b.Property<string>("Baslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GonderenKullaniciId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Icerik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int?>("KullaniciID")
                        .HasColumnType("int");

                    b.Property<bool>("Silindi")
                        .HasColumnType("bit");

                    b.HasKey("MesajID");

                    b.HasIndex("KullaniciID");

                    b.ToTable("Mesajs");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Sayfa", b =>
                {
                    b.Property<int>("SayfaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AnaSayfaID")
                        .HasColumnType("int");

                    b.Property<string>("ControllerAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Silindi")
                        .HasColumnType("bit");

                    b.Property<string>("ViewAdi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SayfaID");

                    b.ToTable("Sayfas");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Soru", b =>
                {
                    b.Property<int>("SoruID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Baslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Icerik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IlgiAlaniEtiketi")
                        .HasColumnType("int");

                    b.Property<DateTime?>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int?>("KullaniciID")
                        .HasColumnType("int");

                    b.Property<bool>("Silindi")
                        .HasColumnType("bit");

                    b.Property<int?>("UniversiteEtiketi")
                        .HasColumnType("int");

                    b.HasKey("SoruID");

                    b.HasIndex("KullaniciID");

                    b.ToTable("Sorus");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Universite", b =>
                {
                    b.Property<int>("UniversiteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bolumler")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Silindi")
                        .HasColumnType("bit");

                    b.HasKey("UniversiteID");

                    b.ToTable("Universites");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Yetki", b =>
                {
                    b.Property<int>("YetkiID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Silindi")
                        .HasColumnType("bit");

                    b.HasKey("YetkiID");

                    b.ToTable("Yetkis");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Cevap", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Kullanici", "Kullanici")
                        .WithMany("Cevaps")
                        .HasForeignKey("KullaniciID");

                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Kullanici", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Yetki", "Yetki")
                        .WithMany("Kullanicis")
                        .HasForeignKey("YetkiID");

                    b.Navigation("Yetki");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Mesaj", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Kullanici", "Kullanici")
                        .WithMany("Mesajs")
                        .HasForeignKey("KullaniciID");

                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Soru", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Kullanici", "Kullanici")
                        .WithMany("Sorus")
                        .HasForeignKey("KullaniciID");

                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Kullanici", b =>
                {
                    b.Navigation("Cevaps");

                    b.Navigation("Mesajs");

                    b.Navigation("Sorus");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Yetki", b =>
                {
                    b.Navigation("Kullanicis");
                });
#pragma warning restore 612, 618
        }
    }
}
