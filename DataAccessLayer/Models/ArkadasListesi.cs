using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace EntityLayer.Models
{
  public class ArkadasListesi
  {
    Context context = new Context();

    public List<Kullanici> ArkadasListesiParcala(Kullanici kullanici)
    {
      List<Kullanici> arkadasListesi = new List<Kullanici>();
      if (kullanici.Arkadaslar != null)
      {
        var parcalar = kullanici.Arkadaslar.Split(',');
        foreach (var item in parcalar)
        {
          if (item != "" && Convert.ToInt32(item) != 0)
          {
            arkadasListesi.Add(context.Kullanicis.FirstOrDefault(x => x.KullaniciID == Convert.ToInt32(item)));
          }
        }
        return arkadasListesi;
      }
      else
      {
        return arkadasListesi;
      }
    }

    public List<Kullanici> OnerilenArkadasListesi(Kullanici kullanici)
    {
      List<Kullanici> tumKullanicilar = context.Kullanicis.Where(x => x.Silindi == false && x.KullaniciID != kullanici.KullaniciID).ToList();

      List<Kullanici> arkadasListesi = new List<Kullanici>();
      List<Kullanici> arkadasOlmayanKisilerListesi = new List<Kullanici>();

      if (kullanici.Arkadaslar != "" && kullanici.Arkadaslar != null)
      {
        ArrayList parcalar = new ArrayList(kullanici.Arkadaslar.Split(','));

        foreach (var item in tumKullanicilar)
        {
          foreach (var arkadasID in parcalar)
          {
            if ((string)arkadasID != "")
            {
              if (item.KullaniciID == Convert.ToInt32(arkadasID))
              {
                arkadasListesi.Add(item);
                break;
              }
            }
          }
        }

        arkadasOlmayanKisilerListesi = tumKullanicilar.Except(arkadasListesi).ToList();

        if (arkadasOlmayanKisilerListesi.Count > 5)
          {
            return arkadasOlmayanKisilerListesi.OrderBy(u => Guid.NewGuid()).Take(5).ToList();
          }
          else
          {
            return arkadasOlmayanKisilerListesi;
          }
        
      }
      else
      {
        arkadasOlmayanKisilerListesi = context.Kullanicis.Where(x => x.Silindi == false && x.KullaniciID != kullanici.KullaniciID).ToList();
        return arkadasOlmayanKisilerListesi.OrderBy(u => Guid.NewGuid()).Take(5).ToList();
      }
    }
  }
}
