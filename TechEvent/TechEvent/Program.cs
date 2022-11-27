using System;
using TechEvent.Entities;

namespace TechEvent
{
    public class Program
    {
        static void Main(string[] args)
        {

            TechEventKullanici Kullanici = new TechEventKullanici();
            TechEventKullanici katilimci = new Katilimci();
            Organizator organizator = new Organizator();
            Etkinlik etkinlik = new Etkinlik();
       
            int kullaniciSecimi;

            Console.WriteLine("TechEvent uygulamasına hoş geldiniz.");
            Console.WriteLine();
            Console.WriteLine("1. Uye Ol");
            Console.WriteLine("2. Giriş Yap");

            void kullaniciSec(Kullanicilar kullanicilar)
            {
                switch (kullaniciSecimi)
                {
                    case 1:

                        kullanicilar = Kullanicilar.Organizator;
                        organizator.EtkinlikOLustur();
                        Console.WriteLine("Etkinlik adını giriniz");
                        etkinlik.EtkinlikAdi = Console.ReadLine();
                        Console.WriteLine("Etkinkik Tarihini giriniz");
                        etkinlik.EtkinlikAdi = Console.ReadLine();
                        Console.WriteLine("Etkinliğin gerçekleşeceği şehri giriniz");
                        etkinlik.EtkinlikAdi = Console.ReadLine();
                        Console.WriteLine("Etkinliğin açıklamasını giriniz");
                        etkinlik.EtkinlikAdi = Console.ReadLine();
                        Console.WriteLine("Etkinlik kontenjanını giriniz");
                        etkinlik.EtkinlikAdi = Console.ReadLine();
                        Console.WriteLine("Etkinlik biletli mi ? E \\ H");
                        etkinlik.EtkinlikAdi = Console.ReadLine();
                        TechEventHelper.etkinlikListesi.Add(etkinlik);


                        break;
                    case 2:
                        kullanicilar = Kullanicilar.Katilimci;

                        Kullanici.GirisYap(katilimci.KullaniciAdi, katilimci.Sifre);
                        EtkinlikIslemleri(katilimci);

                        break;
                    default:
                        Console.WriteLine("Böyle bir kullanıcı yok");
                        break;
                }
            }

            int Islemsecim = int.Parse(Console.ReadLine());

            SecimYap((Islemler)Islemsecim);

            void SecimYap(Islemler ıslemler)
            {
                switch (Islemsecim)
                {
                    case 1:
                        UserEkle();
                        kullaniciSecimi = int.Parse(Console.ReadLine());
                        Giris();
                        kullaniciSec((Kullanicilar)kullaniciSecimi);
                        TechEventHelper.kullaniciListesi.Add(Kullanici);

                        break;
                    case 2:
                        Giris();
                        Kullanici.GirisYap(Kullanici.KullaniciAdi, Kullanici.Sifre);
                        break;
                    default:
                        Console.WriteLine("Bu işlem geçersizdir. Tekrar deneyiniz");
                        return;
                }
            }

            void UserEkle()
            {
                Console.Write("Ad:");
                Kullanici.Ad = Console.ReadLine();
                Console.Write("Soyad:");
                Kullanici.SoyAd = Console.ReadLine();
                Console.Write("Kullanıcı Adı:");
                Kullanici.KullaniciAdi = Console.ReadLine();
                Console.Write("Şifre:");
                Kullanici.Sifre = Console.ReadLine();
                Console.Write("Organizatör olarak üye olmak için lütfen 1' e basınız.");
                Console.Write("Katılımcı olarak üye olmak için lütfen 2' ye basınız.");
               

            }
            void Giris()
            {
                Console.Write("Kullanıcı Adı:");
                Kullanici.KullaniciAdi = Console.ReadLine();
                Console.Write("Şifre:");
                Kullanici.Sifre = Console.ReadLine();


            }

            // Katılımcı olarak katılan biri için örnek olarak gösterilecek etkinlikler.

            void OrnekEtkinlik(Katilimci katilimci)
            {
                Etkinlik etkinlik1 = new Etkinlik();
                etkinlik1.EtkinlikAdi = "Kamp";
                etkinlik1.EtkinlikTarihi = DateTime.Parse("2022,07,20");
                etkinlik1.EtkinliginOlduguSehir = "Sivas";
                etkinlik1.Aciklama = "Hava çok soğuk ama kamp yapmaya değer :)";
                Console.WriteLine("1.Etkinlik ");
                Console.WriteLine
                    ("Etkinlik Adı: " + etkinlik1.EtkinlikAdi
                    + "\nEtkinlik Tarihi :" + etkinlik1.EtkinlikTarihi
                    + "\nEtkinliğin olacağı şehir: " + etkinlik1.EtkinliginOlduguSehir
                    + "\nEtkinlik Açıklması: " + etkinlik1.Aciklama);

                Console.WriteLine("2.Etkinlik ");
                Etkinlik etkinlik2 = new Etkinlik();
                etkinlik2.EtkinlikAdi = "Müze gezisi";
                etkinlik2.EtkinlikTarihi = DateTime.Parse("2022,07,20");
                etkinlik2.EtkinliginOlduguSehir = "İstanbul";
                etkinlik2.Aciklama = "Beykoz cam ve Billur Müzesi ve Atatürk müzesi gezilecektir";

                Console.WriteLine
                    ("Etkinlik Adı: " + etkinlik2.EtkinlikAdi
                    + "\n Etkinlik Tarihi :" + etkinlik2.EtkinlikTarihi
                    + "\n Etkinliğin olacağı şehir: " + etkinlik2.EtkinliginOlduguSehir
                    + "\nEtkinlik Açıklması: " + etkinlik2.Aciklama);


            }

            void EtkinlikIslemleri(TechEventKullanici user)
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("1. Etkinlik Oluştur");
                    Console.WriteLine("2. Etkinlikleri Görüntüle");
                    Console.WriteLine("3. Etkinliğe Katıl");
                    Console.WriteLine("4. Bilet Al");


                    int EtkinlikIslemiSec = int.Parse(Console.ReadLine());
                    switch (EtkinlikIslemiSec)
                    {
                        case 1:
                            organizator.EtkinlikOLustur();

                            if (user == katilimci)
                            {
                                Console.WriteLine("Katilimcilar etkinlik oluşturamaz");
                            }
                            break;
                        case 2:
                            OrnekEtkinlik(((Katilimci)katilimci));//Boxing
                            break;
                        case 3:
                            EtkinlikKatilmaIslemleri((Katilimci)katilimci);
                            break;
                        case 4:
                            BiletSatis((Katilimci)katilimci);
                            break;

                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            void BiletSatis(Katilimci katilimci)
            {
                try
                {
                    katilimci.BiletAL();
                }
                catch (Exception ex)
                {
                    foreach (BiletFirmalari item in TechEventHelper.biletFirmalari)
                    {
                        item.EtkinlikleriXMLOlarakAlir();
                        item.EtkinlikleriJSONOlarakAlir();
                    }

                    katilimci.BiletAL();
                }
            }

            void EtkinlikKatilmaIslemleri(Katilimci katilimci)
            {
                Console.WriteLine("Katılmak istediğiniz etkinliği seçin");
                foreach (Etkinlik item in TechEventHelper.etkinlikListesi)
                {
                    Console.WriteLine("1. " + item.EtkinlikAdi);
                }

                int z = int.Parse(Console.ReadLine());
                Etkinlik @event = TechEventHelper.etkinlikListesi[z - 1];

                try
                {
                    katilimci.EtkinligeKatil(@event);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.ReadKey();
        }


    }
}
