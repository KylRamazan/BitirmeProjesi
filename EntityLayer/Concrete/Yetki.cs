﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
  public class Yetki
  {
    [Key]
    public int YetkiID { get; set; }
    public string Adi { get; set; }
    public bool Silindi { get; set; }
    public DateTime? KayitTarihi { get; set; }
    public DateTime? GuncellemeTarihi { get; set; }
    public List<Kullanici> Kullanicis { get; set; }
  }
}
