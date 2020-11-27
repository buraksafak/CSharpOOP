using System;

namespace Class
{

    
class Ogrenci{

    //burada Ogrenci sınıfının özelliklerini tanımlıyoruz.
    public int OgrNo { get; set;   
    }   
    public string Ad { get; set; 
    }
    public string Sube { get; set; 
    }
}
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr1 = new Ogrenci();  //burada Ogrenci sınıfından, ogr1 isminde bir nesne tanımlıyoruz.
                ogr1.OgrNo = 1611012229;
                ogr1.Ad = "Burak";
                ogr1.Sube = "A";
                    Console.WriteLine($"Öğrenci No: {ogr1.OgrNo}  Ad: {ogr1.Ad} Sube: {ogr1.Sube}");         
            Ogrenci ogr2 = new Ogrenci();
                ogr2.OgrNo = 1234567890;
                ogr2.Ad = "Burhan";
                ogr2.Sube = "B";
                    Console.WriteLine($"Öğrenci No: {ogr2.OgrNo}  Ad: {ogr2.Ad} Sube: {ogr2 .Sube}");
        Console.WriteLine("*************************************************");            
            Ogrenci ogr3 = new Ogrenci();
                ogr3.OgrNo = 1672931233;
                ogr3.Ad = "Faruk";
                ogr3.Sube = "C";
                    Ogrenci[] ogrenciler = new Ogrenci[3]; //Ogrenci sınıfımız olduğu için , Ogrenci tipinde bir dizi tanımladık.                
                    //3 indisli dizimize , öğrenci bilgilerini ekledik.    
                        ogrenciler[0] = ogr1;
                        ogrenciler[1] = ogr2;
                        ogrenciler[2] = ogr3;
                     //döngü ile tüm öğrenci bilgilerini yazdırmak için for açtık.    
                            for (int i = 0; i < ogrenciler.Length; i++) 
                            {
                                Console.WriteLine($"Öğrenci No: {ogrenciler[i].OgrNo}  Ad: {ogrenciler[i].Ad} Sube: {ogrenciler[i] .Sube}");
                            }








            
        }
    }
}
