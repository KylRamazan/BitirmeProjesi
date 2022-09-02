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
  public class EFBolumRepository : IBolumDAL
  {
    private Context context;

    public EFBolumRepository()
    {
      context = new Context();
    }

    public void Ekle(Bolum item)
    {
      item.KayitTarihi = DateTime.Now;
      context.Bolums.Add(item);
      context.SaveChanges();
    }

    public Bolum GetByID(int id)
    {
      return context.Bolums.FirstOrDefault(x => x.Silindi == false && x.BolumID == id);
    }

    public List<Bolum> GetList()
    {
      return context.Bolums.Where(x => x.Silindi == false).ToList();
    }

    public void Guncelle(Bolum item)
    {
      Bolum value = GetByID(item.BolumID);
      if (value != null)
      {
        value.Ad = item.Ad;
        value.GuncellemeTarihi = DateTime.Now;
        context.SaveChanges();
      }
    }

    public void Sil(int id)
    {
      Bolum value = GetByID(id);
      if (value != null)
      {
        value.Silindi = true;
        context.SaveChanges();
      }
    }
  }
}
