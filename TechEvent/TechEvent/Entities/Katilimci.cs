using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechEvent.Entities
{
   public class Katilimci:TechEventKullanici
    {
        public void EtkinligeKatil(Etkinlik etkinlik)
        {
            if (etkinlik.KatilacakKisiler.Count < etkinlik.Kontenjan)
            {
                etkinlik.KatilacakKisiler.Add(this);
            }
            else
            {
                throw new Exception("Etkinliğin kontenjanı dolmuştur");
            }

        }
        public void BiletAL()
        {
            foreach (BiletFirmalari item in TechEventHelper.biletFirmalari)
            {
                if (!item.DataCekildiMi)
                {
                    throw new Exception($"{item.FirmaAdi} firmasında biletler henüz satışa çıkmamıştır");
                }
            }

            Console.WriteLine("Aşağıdaki adreslerden bilet alabilirsiniz");
            TechEventHelper.biletFirmalari.ForEach(firma =>
            {
                Console.WriteLine($"{firma.FirmaAdi} -> {firma.WebSitesi}");
            });

        }
    }
}
