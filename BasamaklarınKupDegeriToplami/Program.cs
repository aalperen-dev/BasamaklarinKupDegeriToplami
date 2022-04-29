using System;

namespace BasamaklarınKupDegeriToplami
{
    class Program
    {
        static void Main(string[] args)
        {
            //1'den 999'a kadar olan tam sayılar içerisinden basamaklarının
            //küp değeri toplamı kendisine eşit olan değerleri ekrana yazdıran C# programını yazın.

            int sayi = 1;
            int yuzler = 0;
            int onlar = 0;
            int birler = 0;
            int kuptoplam = 0;

            while (sayi < 999)
            {
                yuzler = sayi / 100;
                onlar = (sayi - (yuzler * 100)) / 10;
                birler = sayi - ((yuzler * 100) + (onlar * 10));

                kuptoplam = (yuzler * yuzler * yuzler) + (onlar * onlar * onlar) + (birler * birler * birler);

                if (sayi == kuptoplam)
                {
                    Console.WriteLine("Kurala uyan sayı : " + sayi);
                }
                sayi = sayi + 1;
            }

        }
    }
}
