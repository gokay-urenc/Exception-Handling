using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hata_Yonetimleri
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Derleme Hataları
            // console.Writeline("") => Hatalı yazımdır. Sistem bunu Error List'te bulur ve gösterir.
            #endregion

            #region Mantık Hataları
            // İki sayının ortalamasını söyleyen program
            int sayi1 = 4, sayi2 = 8, sonuc;
            sonuc = sayi1 + sayi2 / 2;
            Console.WriteLine(sonuc);
            #endregion

            #region Çalışma Sırası Hataları
            Console.Write("Sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int a = Convert.ToInt32("2"); // Doğru
            // int b = Convert.ToInt32("z2"); // Yanlış -> FormatException
            bool c = Convert.ToBoolean("false"); // Doğru
            // bool d = Convert.ToBoolean("doğru"); // Yanlış -> FormatException
            // byte deger = Convert.ToByte(300); OverFlowException
            string str = null;
            Console.WriteLine(str); // Ekrana herhangi birşey gelmez.
            #endregion

            Console.ReadKey();
        }
    }
}
/* Hata Yönetimi Ve Hata Çeşitleri
   * Syntax Errors (Derleme Hataları)
   * Runtime Errors (Çalışma Sırasında Oluşan Hatalar)
   * Logical Errors (Mantıksal Hatalar)
   Derleme hataları yanlış kod yazımından kaynaklanan hatalardır. Bulunması ve yönetilmesi en kolay hata çeşididir.
   Çalışan programın hatalı çalışmasına mantık hatası denir. Hatalardan en tehlikelisidir. %100 olarak yazılımcı kaynaklıdır. Bu hataları bulabilmek için Debug Mod'da (breakpoint) ile çalışarak hatalar tespit edilir.
   Tip dönüşümleri farklı tiplerdeki değerlerin dönüşümüdür. Dönüşüm esnasında değerin formatı düzgün olmalıdır. Değilse hata kaçınılmazdır. Bu tür hatalar çalışma sırası hatalarıdır.
   FormatException (Tip dönüşümü Hataları): Çalışma sırasında gerçekleşen bir hatanın program hata verirken kapanmamasını sağlar.
   OverFlowException (Taşma Hataları): Dönüştürme yaparken veri tipinin sahip olduğu değer aralığının dışına çıkıyorsa bu hata gelir.
   Bu hataların detaylarını Exception adında bir komut dosyası sayesinde görebiliriz. Her hatanın bir exception sınıfı karışılığı vardır.
   Exception, bütün hata sınıflarının temelidir.
*/