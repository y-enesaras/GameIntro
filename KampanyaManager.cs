using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation
{
    class KampanyaManager :IKampanyaService
    {
        public void Add(IKampanya kampanya)
        {
            Console.WriteLine("Yeni kampanya eklendi");
        }

        public void Delete(IKampanya kampanya)
        {
            Console.WriteLine("Kampanya silindi");
        }

        public IKampanya GetKampanya(Kullanici kullanici)
        {
            throw new NotImplementedException();
        }

        //public IKampanya GetKampanya(Kullanici kullanici)
        //{
        //    Console.WriteLine("{0} kullanıcısı aramıza yeni katıldı.",kullanici.UserName);
        //    return new yeniKullaniciKampanyaManager();
        //}

        public void Show(IKampanya kampanya, Kullanici kullanici, Urun urun)
        {
            kampanya.Teklif(kullanici, urun);
        }

        public void Update(IKampanya kampanya)
        {
            Console.WriteLine("Kampanya güncellendi");
        }
    }
}
