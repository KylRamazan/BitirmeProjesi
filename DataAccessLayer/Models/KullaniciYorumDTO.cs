using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
  public class KullaniciYorumDTO
  {
    public string AdSoyad { get; set; }
    public string BolumAdi { get; set; }
    public bool Mezun { get; set; }
    public bool Cinsiyet { get; set; }
    public string Cevap { get; set; }
  }
}
