using System;

namespace yapiciMetotlar
{
    class Araba
    {

        public Araba() // Yapıcı metod, sınıf ile  aynı isimde olmak zorunda.
        {
            Console.WriteLine("Yapıcı metot çağırıldı.(Parametre almayan)");
            this.MaxHiz = 150;

        }
        public Araba(int maxHiz) // Yapıcı metod, sınıf ile  aynı isimde olmak zorunda.
        {
            Console.WriteLine("Yapıcı metot çağırıldı.(Parametre alan)");
            this.MaxHiz = maxHiz;
        }
        public Araba(string marka, string model, string renk, bool otomatik, int maxHiz) // Yapıcı metod, sınıf ile  aynı isimde olmak zorunda.
        {
            Console.WriteLine("Yapıcı metot çağırıldı.(Parametre alan)");
            this.Marka = marka;
            this.Model = model;
            this.Renk = renk;
            this.Otomatik = otomatik;
            this.MaxHiz = maxHiz;
        }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public bool Otomatik { get; set; } //true = otomatik , false = manuel   
        public int MaxHiz { get; set; }
        public void Start()
        {
            Console.WriteLine($"{this.Marka} {this.Model} çalıştırıldı.");
        }
        public void Stop()
        {
            Console.WriteLine($"{this.Marka} {this.Model} durduruldu.");
        }
        public void Yavasla()
        {
            Console.WriteLine($"{this.Marka} {this.Model} yavaşladı.");
        }
        public void Hizlan()
        {
            Console.WriteLine($"{this.Marka} {this.Model} Hızlandı");
        }
        public void Hizlan(int km)
        {
            if (km > this.MaxHiz)
                Console.WriteLine("Max. hızı aşamayız");
            else
                Console.WriteLine($"{this.Marka} {this.Model} {this.MaxHiz} ulaştırılıyor.");
        }


        public void Menu()
        {
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

                        if (secim == "e")
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
            while (komut != "ç");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var opel = new Araba(200);
            Console.WriteLine(opel.MaxHiz);
            // opel.Marka = "Opel";
            // opel.Model = "Insignia";
            // opel.Renk = "Kırmızı";
            // opel.Otomatik = true;

            var bmw = new Araba("BMW","xDrive","Beyaz",true,200);
            Console.WriteLine(bmw.Marka);
            Console.WriteLine(bmw.Model);
            Console.WriteLine(bmw.Renk);
            //Otomatik true ise otomatik yazdır, değil ise manuel yazdır.
            if(bmw.Otomatik == true)
                Console.WriteLine("Otomatik");
            else
                Console.WriteLine("Manuel");
            Console.WriteLine(bmw.MaxHiz);
            // bmw.Marka = "BMW";
            // bmw.Model = "5.25";
            // bmw.Renk = "Kırmızı";
            // bmw.Otomatik = false;
            // bmw.MaxHiz = 260;
            //opel.Menu();
            // bmw.Menu();


        }
    }
}