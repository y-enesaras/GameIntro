using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation
{
    class KullaniciManager:IKullaniciService
    {
        public void Add(Kullanici kullanici,EDevletService eDevletService)
        {
            eDevletService.Dogrulama();
            Console.WriteLine("Yeni kullanici eklendi.");
        }
        public void Delete(Kullanici kullanici)
        {
            Console.WriteLine("Kullanici silindi.");
        }
        public void Update(Kullanici kullanici)
        {
            Console.WriteLine("Kullanici bilgileri guncellendi.");
        }
    }
}
