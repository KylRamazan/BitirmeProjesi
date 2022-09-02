using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
  public class Sayfa
  {
    [Key]
    public int SayfaID { get; set; }
    public int? AnaSayfaID { get; set; }
    public string Adi { get; set; }
    public string ControllerAdi { get; set; }
    public string ViewAdi { get; set; }
    public bool Silindi { get; set; }
  }
}
