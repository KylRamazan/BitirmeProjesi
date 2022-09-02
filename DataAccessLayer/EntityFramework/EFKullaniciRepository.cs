using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
  public class EFKullaniciRepository : IKullaniciDAL
  {
    private Context context;

    public EFKullaniciRepository()
    {
      context = new Context();
    }
    public void Ekle(Kullanici item)
    {
      item.Arkadaslar = "0,";
      item.Silindi = false;
      item.KayitTarihi = DateTime.Now;
      item.YetkiID = 2;
      var entry = context.Entry(item);
      entry.State = EntityState.Added;
      context.SaveChanges();
    }

    public Kullanici GetByID(int id)
    {
      return context.Kullanicis.FirstOrDefault(x => x.Silindi == false && x.KullaniciID == id);
    }

    public List<Kullanici> GetList()
    {
      return context.Kullanicis.Where(x => x.Silindi == false).ToList();
    }

    public void Guncelle(Kullanici item)
    {
      Kullanici value = GetByID(item.KullaniciID);
      if (value != null)
      {
        value.AdSoyad = item.AdSoyad;
        value.Cinsiyet = item.Cinsiyet;
        value.DogumTarihi = item.DogumTarihi;
        value.OkulAdi = item.OkulAdi;
        value.BolumAdi = item.BolumAdi;
        value.Arkadaslar = item.Arkadaslar;
        value.Mezun = item.Mezun;
        value.Resim = item.Resim;
        value.EMail = item.EMail;
        value.Telefon = item.Telefon;
        value.KullaniciAdi = item.KullaniciAdi;
        value.EtiketDurumu = item.EtiketDurumu;


        context.SaveChanges();
      }
    }

    public void SifreGuncelle(string item)
    {
      throw new NotImplementedException();
    }

    public void Sil(int id)
    {
      Kullanici value = GetByID(id);
      if (value != null)
      {
        value.Silindi = true;
        context.SaveChanges();
      }
    }
  }
}
