using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechEvent.Abstract;

namespace TechEvent
{
    public class TechEventKullanici:IEntity
    {
        public string Ad { get; set; }
        public string SoyAd { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string OrganizatorMuKatilimciMi { get; set; }
        public Islemler Islemler { get; set; }// üye ol ve kayıt ol işlemleri


        public bool GirisYap(string kullaniciAdi, string sifre)
        {
            foreach (TechEventKullanici item in TechEventHelper.kullaniciListesi)
            {
                if (item.KullaniciAdi == kullaniciAdi && item.Sifre == sifre)
                {
                    Console.WriteLine("Giriş Başarılı");

                }
                Console.WriteLine("Giriş Başarısız");
            }

            return false;
        }
        public bool UyeOl(TechEventKullanici kullanici)
        {
            foreach (TechEventKullanici item in TechEventHelper.kullaniciListesi)
            {
                if (item.KullaniciAdi == kullanici.KullaniciAdi)
                {
                    Console.WriteLine("Bu kullanıcı adı zaten kayıtlı");
                }
            }
            if (kullanici.Sifre.Length < 6 || TechEventHelper.BuyukHarfliSifre(kullanici.Sifre) == false || TechEventHelper.KucukHarfliSifre(kullanici.Sifre) == false)
            {
                Console.WriteLine("Şifre en az 6 karakterli olmalı ve en az 2 büyük ve küçük harf içermelidir");
            }

            return true; ;

        }

    }
}
