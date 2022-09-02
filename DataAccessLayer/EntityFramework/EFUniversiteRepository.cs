using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
  public class EFUniversiteRepository : IUniversiteDAL
  {
    private Context context;

    public EFUniversiteRepository()
    {
      context = new Context();
    }

    public void Ekle(Universite item)
    {
      item.KayitTarihi = DateTime.Now;
      context.Universites.Add(item);
      context.SaveChanges();
    }

    public Universite GetByID(int id)
    {
      return context.Universites.FirstOrDefault(x => x.Silindi == false && x.UniversiteID == id);
    }

    public List<Universite> GetList()
    {
      return context.Universites.Where(x => x.Silindi == false).ToList();
    }

    public void Guncelle(Universite item)
    {
      Universite value = GetByID(item.UniversiteID);
      if (value != null)
      {
        value.Ad = item.Ad;
        value.Bolumler = item.Bolumler;
        context.SaveChanges();
      }
    }

    public void Sil(int id)
    {
      Universite value = GetByID(id);
      if (value != null)
      {
        value.Silindi = true;
        context.SaveChanges();
      }
    }
  }
}
