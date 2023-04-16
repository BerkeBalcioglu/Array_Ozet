using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Sort_IndexOf

    internal class Program
    {
        static void Main(string[] args)
        {
         string[] isimler = new string[] { "mercedes", "bmw ", "mazda", " nissan", "toyota", "lexus", "mitsubishi" }; //7 elemanlı isimler dizisi.
            Console.WriteLine(isimler.Length);       //isimler dizisindeki bütün elamaları ekrana yaz. 
            Console.WriteLine(isimler[0]);           // dizide'ki sıfırıncı elemana ulaş "MERCEDES".
            isimler[1] = "FİAT";                     // isimler dizisindeki 1 numaralı elemanı "bmw"yi , "FİAT" oalrak değiştir.
            Array.Clear(isimler, 0, 1);              // Dizideki 0 ve 1. elemanı sil.

            for (int i = 0; i<isimler.Length; i++)   // isimler dizisindeki eleman uzunluğunu for döngüsü ile 1 er tane arttır.
            {
                Console.WriteLine(isimler[i]);       // arttırılan dönügdeki elemanlaro isimler dizisindeki eş gelen kelimleri yazdır - ARRAY YAZDIRMA FOR DÖNGÜSÜ İLE.
            }
            Console.ReadKey();

            //**************************************************************************************************************************************************************

            //BAZI ARAY FONKSİYONALRI YAZDIRILIKEN FOR DÖNGÜSÜNDE YAZILIR HER ARRAYIN ALTINDA BİR FOR DÖNGÜSÜ OLMAKTADIR

            Array.Sort(isimler);                      // isimleri alfabetik olarak sıralar - Yukarıdaki gibi FOR döngüsü gerekir.
            Array.Reverse(isimler);                   // sırayı tersine çevirir.
            for (int i = 0; i<isimler.Length; i++)    // isimler dizisindeki eleman uzunluğunu for döngüsü ile 1 er tane arttır.
            {
                Console.WriteLine(isimler[i]);        // arttırılan dönügdeki elemanlaro isimler dizisindeki eş gelen kelimleri yazdır - ARRAY YAZDIRMA FOR DÖNGÜSÜ İLE.
            }
            Console.ReadKey();


            Array.IndexOf(isimler, "toyota,");        // İsimler dizisindeki "toyota" kelimesi kaçıncı eleman olduğunu bulur. (0 dan aramaya  başlar)
            Array.LastIndexOf(isimler, " toyota");    // İsimler dizisindeki "toyota" kelimesinden birtane daha varsa en sondaki elemanı bulur.
            



        }
    }
}
