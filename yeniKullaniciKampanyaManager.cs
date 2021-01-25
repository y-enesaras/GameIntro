using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation
{
    class yeniKullaniciKampanyaManager
    {
        public string KampanyaName { get; set; } = "Kaydolma Kampanyası";
        public decimal IndirimOrani { get; set; } = 0.5M;
        public void Teklif(Kullanici kullanici, Urun urun)
        {
            decimal mainPrice = urun.Price;
            urun.Price = urun.Price * IndirimOrani;
            Console.WriteLine($"{urun.Name}: {mainPrice}TL. {KampanyaName} ile size özel {urun.Price}TL");
        }
    }
}
