using System;

namespace overLoading
{

    class Araba{
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public bool Otomatik { get; set; } //true = otomatik , false = manuel   
        public int MaxHiz { get; set; }
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
            public void Hizlan(int km){
                if(km > this.MaxHiz)
                    Console.WriteLine("Max. hızı aşamayız");
                else
                    Console.WriteLine($"{this.Marka} {this.Model} {this.MaxHiz} ulaştırılıyor.");
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
                        Console.WriteLine("Hız bilgisi girmek istiyor musunuz ?");
                        string secim = Console.ReadLine();

                        if(secim == "e")
                        {
                            Console.Write("Hiz : ");
                            int km = int.Parse(Console.ReadLine());
                            this.Hizlan(km);

                        }
                        else
                            this.Hizlan();

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
            // var opel = new Araba();
            //    opel.Marka = "Opel";
            //    opel.Model = "Insignia";
            //    opel.Renk = "Kırmızı";
            //     opel.Otomatik = true;

            var bmw = new Araba();
                bmw.Marka = "BMW";
                bmw.Model ="5.25";
                bmw.Renk = "Kırmızı";
                bmw.Otomatik = false;
                bmw.MaxHiz = 260;
                 //opel.Menu();
                bmw.Menu();
                    

        }
    }
}