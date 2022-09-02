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
  public class EFCevapRepository : ICevapDAL
  {
    private Context context;

    public EFCevapRepository()
    {
      context = new Context();
    }
    public void Ekle(Cevap item)
    {
      item.Silindi = false;
      item.KayitTarihi = DateTime.Now;
      var entry = context.Entry(item);
      entry.State = EntityState.Added;
      context.SaveChanges();
    }

    public Cevap GetByID(int id)
    {
      throw new NotImplementedException();
    }

    public List<Cevap> GetList()
    {
      throw new NotImplementedException();
    }

    public void Guncelle(Cevap item)
    {
      throw new NotImplementedException();
    }

    public void Sil(int id)
    {
      throw new NotImplementedException();
    }
  }
}
