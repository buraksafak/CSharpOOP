using System;

namespace MethotsParameters
{
    class Islem{
       
        // z değerine bir parametre göndermediğimiz taktirde default olarak "0" atar,hata vermez.fakat x ve y değişkenlerine parametre göndermemiz zorunludur.Default atamalar yalnızca sondakilere yapılır.y değişkenine de default tanımlanabilir.
        public int Toplama(int x,int y,int z=0) 
        {
            Console.WriteLine("x: " + x);
            Console.WriteLine("y: " + y);
            Console.WriteLine("z: " + z);
            return  x + y;
        } 

        //kaç adet parametre göndereceğimizi bilmediğimiz durumlarda params int[] kullanılır.
        public int Toplama2(params int[] sayilar) 
        {
            int toplam = 0;
            foreach (var sayi in  sayilar) //foreach ile sayi'dan sayilar'a kadar döndürerek saydırabiliriz.
            {
               toplam += sayi;
            }
            return toplam;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var islem = new Islem();
                //Console.WriteLine(islem.Toplama(5,6,10)); //sırası ile x =5, y=6, z=10 parametrelerini gönderir.
                Console.WriteLine(islem.Toplama(y:5,z:6,x:10)); //isimlendirme ile istediğimiz sırada istediğimiz parametreyi göndeririz.
                
                // Toplama2 metodunda params kullandığımız için , istediğimiz kadar parametre gönderebiliriz
                Console.WriteLine(islem.Toplama2(10));
                Console.WriteLine(islem.Toplama2(10,20));
                Console.WriteLine(islem.Toplama2(10,20,30));
                Console.WriteLine(islem.Toplama2(10,20,30,40));


        }
    }
}
