﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
  public interface IKullaniciDAL
  {
    List<Kullanici> GetList();
    Kullanici GetByID(int id);
    void Ekle(Kullanici item);
    void Guncelle(Kullanici item);
    void SifreGuncelle(String item);
    void Sil(int id);
  }
}
