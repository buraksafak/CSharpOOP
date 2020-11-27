using System;
namespace MethodUygulama
{ 
    class Araba{
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public bool Otomatik { get; set; } //true = otomatik , false = manuel   
            public void Start(){
                Console.WriteLine($"{this.Marka} {this.Model} çalıştırıldı.");
            }    
            public void Stop(){
                Console.WriteLine($"{this.Marka} {this.Model} durduruldu.");
            }
            public void Yavasla(){
                Console.WriteLine($"{this.Marka} {this.Model} yavaşladı.");
            }
            public void Hizlan(){
                Console.WriteLine($"{this.Marka} {this.Model} Hızlandı");
            }
            public void Menu(){
                string komut = "";
                do
                {
                    Console.WriteLine("1-Start 2-Hızlan 3-Yavaşla 4-Stop Çıkış-Ç");
                    Console.WriteLine("Seçiminiz :");
                    komut = Console.ReadLine();
                    switch (komut)
                    {
                        case "1":
                        this.Start();
                            break;
                        case "2":
                        this.Hizlan();
                            break;
                        case "3":
                        this.Yavasla();
                            break;
                        case "4":
                        this.Stop();
                            break;
                        default:
                        Console.WriteLine("Programdan çıkılıyor.");
                            break;
                    }
                }
                 while (komut!="ç");
            }        
    }
    class Program   
    {   
        static void Main(string[] args)
        {
            var opel = new Araba();
                opel.Marka = "Opel";
                opel.Model = "Insignia";
                opel.Renk = "Kırmızı";
                opel.Otomatik = true;

            var bmw = new Araba();
                bmw.Marka = "BMW";
                bmw.Model ="5.25";
                bmw.Renk = "Kırmızı";
                bmw.Otomatik = false;

                 //opel.Menu();
                bmw.Menu();
                    

        }
    }
}