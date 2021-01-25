using System;
using System.Collections.Generic;
using System.Text;
namespace GameSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            IKullaniciService kullanici = new KullaniciManager();
            IKampanyaService kampanya = new KampanyaManager();
            ISaleService sale = new SaleManager(kampanya);

            EDevletService eDevlet = new EDevletService();
            Kullanici kullanici1 = new Kullanici()
            {
                Id = 1,
                TcNo = "234567890",
                UserName = "YusufEnes",
                Password = "5511144",
                FirstName = "Yusuf Enes",
                LastName = "Aras",
            };
           
            KullaniciManager kullaniciManager = new KullaniciManager();
            kullaniciManager.Add(kullanici1,eDevlet);

            Urun urun = new Urun()
            {
                Id = 1,
                CategoryId = 1,
                Name = "Call of Duty: Modern Warfare 2",
                Price = 88,
                UnitInStock = 5,
            };

            sale.Sale(kullanici1, urun);
        }
    }
    interface IKullaniciService
    {
        void Add(Kullanici kullanici, EDevletService eDevletService);
        void Delete(Kullanici kullanici);
        void Update(Kullanici kullanici);
    }
    interface IKampanya
    {
        public string KampanyaName { get; set; }
        public decimal IndirimOrani { get; set; }
        void Teklif(Kullanici kullanici, Urun urun);
    }
     interface IKampanyaService
    {
        void Add(IKampanya kampanya);
        void Delete(IKampanya kampanya);
        void Update(IKampanya kampanya);
        IKampanya GetKampanya(Kullanici kullanici);
        void Show(IKampanya kampanya, Kullanici kullanici, Urun urun);
    }
    interface ISaleService
    {
        void Sale(Kullanici kullanici,Urun urun);
    }
}
