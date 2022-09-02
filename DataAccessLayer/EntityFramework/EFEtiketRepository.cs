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
  public class EFEtiketRepository : IEtiketDAL
  {
    private Context context;

    public EFEtiketRepository()
    {
      context = new Context();
    }

    public void Ekle(Etiket item)
    {
      item.KayitTarihi = DateTime.Now;
      context.Etikets.Add(item);
      context.SaveChanges();
    }

    public Etiket GetByID(int id)
    {
      return context.Etikets.FirstOrDefault(x => x.Silindi == false && x.EtiketID == id);
    }

    public List<Etiket> GetList()
    {
      return context.Etikets.Where(x => x.Silindi == false).ToList();
    }

    public void Guncelle(Etiket item)
    {
      Etiket value = GetByID(item.EtiketID);
      if (value != null)
      {
        value.Adi = item.Adi;
        value.GuncellemeTarihi = DateTime.Now;
        context.SaveChanges();
      }
    }

    public void Sil(int id)
    {
      Etiket value = GetByID(id);
      if (value != null)
      {
        value.Silindi = true;
        context.SaveChanges();
      }
    }
  }
}
