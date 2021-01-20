using System;
using System.Collections.Generic;
using System.Text;

namespace UcNokta
{
    class SepetManager
    {
        //naming convention
        public void Ekle(Urun urun)//Class
        {
            Console.WriteLine("Sepete eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi) //Class değil
        {
            Console.WriteLine("Sepete eklendi : " + urunAdi);
        }
    }
        

    
}

