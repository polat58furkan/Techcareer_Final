using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechEvent.Abstract;
using TechEvent.Entities;

namespace TechEvent
{
    public class Etkinlik:IEntity
    {
        public string EtkinlikAdi { get; set; }
        public DateTime EtkinlikTarihi { get; set; }
        public string EtkinliginOlduguSehir { get; set; }
        public string Aciklama { get; set; }
        public int Kontenjan { get; set; }
        public bool BiletliMi { get; set; }
        public List<Katilimci> KatilacakKisiler { get; set; }

        void EtkinlikTarihiKontrolEt(DateTime dateTime)
        {
            if (dateTime < DateTime.Now.AddMonths(1))
            {
                throw new Exception("Etkinlik tarihi en erken 1 ay sonra olmalıdır");
            }
        }

        void EtkinlikSehriniKontrolEt(string sehir)
        {
            string[] sehirler = { "Sivas", "Istanbul", "Ankara", "Izmir" };
            if (!sehirler.Contains(sehir))
            {
                throw new Exception("Şu an için Sivas,İstanbul,Ankara ve İzmir'de etkinlik düzenlenebilir");
            }
        }

        void KisiSayisiniKontrolEt(int sayi)
        {
            if (sayi < 15)
            {
                throw new Exception("En az 15 kişilik etkinlik oluşturulabilir");
            }
        }
    }
}
