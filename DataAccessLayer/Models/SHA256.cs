using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Models
{
  public class SHA256
  {
    // SHA256 Kodlari
    public static string SHA256Sifreleme(string gelenVeri)
    {
      StringBuilder sb = new StringBuilder();
      SHA256CryptoServiceProvider sha256Sifrele = new SHA256CryptoServiceProvider();
      byte[] bt = Encoding.UTF8.GetBytes(gelenVeri);
      bt = sha256Sifrele.ComputeHash(bt);
      foreach (byte item in bt)
      {
        sb.Append(item.ToString());
      }
      return sb.ToString();

    }
  }
}
