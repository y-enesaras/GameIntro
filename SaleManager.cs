using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation
{
    class SaleManager : ISaleService
    {
        private IKampanyaService _kampanyaService;
        public SaleManager(IKampanyaService kampanyaService)
        {
            _kampanyaService = kampanyaService;
        }
        public void Sale(Kullanici kullanici, Urun urun)
        {
            IKampanya kampanya = _kampanyaService.GetKampanya(kullanici);
            kampanya.Teklif(kullanici, urun);
            Console.WriteLine($"{urun.Name}, {kullanici.UserName} tarafından {urun.Price}TL karşılığında alındı");
        }
    }
}
