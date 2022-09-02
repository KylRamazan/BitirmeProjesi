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
  public class EFSoruRepository : ISoruDAL
  {
    private Context context;

    public EFSoruRepository()
    {
      context = new Context();
    }

    public void Ekle(Soru item)
    {
      item.Silindi = false;
      item.KayitTarihi = DateTime.Now;
      var entry = context.Entry(item);
      entry.State = EntityState.Added;
      context.SaveChanges();
    }

    public Soru GetByID(int id)
    {
      return context.Sorus.FirstOrDefault(x => x.Silindi == false && x.SoruID == id);
    }

    public List<Soru> GetList()
    {
      throw new NotImplementedException();
    }

    public void Guncelle(Soru item)
    {
      throw new NotImplementedException();
    }

    public void Sil(int id)
    {
      throw new NotImplementedException();
    }
  }
}
