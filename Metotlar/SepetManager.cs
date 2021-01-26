using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        // naming comnvention
        public void Ekle(Product urun) 
        {
            Console.WriteLine("Sepete Eklendi: " + urun.Adi);               
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat) 
        {
            Console.WriteLine("Tebrikler. Sepete EKlendi : " + urunAdi);   
        
        }
    }
}
