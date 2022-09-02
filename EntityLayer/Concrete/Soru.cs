﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
  public class Soru
  {
    [Key]
    public int SoruID { get; set; }
    public string Baslik { get; set; }
    public string Icerik { get; set; }
    public int? KullaniciID { get; set; }
    public int? UniversiteEtiketi { get; set; }
    public int? IlgiAlaniEtiketi { get; set; }
    public bool Silindi { get; set; }
    public DateTime? KayitTarihi { get; set; }
    public DateTime? GuncellemeTarihi { get; set; }
    public Kullanici Kullanici { get; set; }
  }
}
