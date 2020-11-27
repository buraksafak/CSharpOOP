using System;

namespace Methods
{
    class Person{
        public string Name { get; set; }
        public int Year { get; set; }

        //burada ekrana bastırma metodu oluşturduk.
        public void Intro(){
            Console.WriteLine($"Name: {this.Name} Year: {this.CalculateAge()}"); //This sözcüğü,aşağıda tanımladığımız p1,p2,p3'ü temsil eder.Burada yapacağımız bir değişiklik,hepsini kapsar.Tüm nesnelerde değişiklik yapmamıza gerek kalmaz.Daha dinamik bir yapı oluşur.This.CalculateAge ile , bir altta oluşturduğumuz metodu çağırıp,yaş hesaplatma işlemi yapabiliriz.
        }   
        //burada yaş hesaplatan bir metod oluşturuyoruz.
        public int CalculateAge(){
            return DateTime.Now.Year-this.Year;
        }
    }    
    class Program
    {
        static void Main(string[] args)
        {
            //burada nesneleri oluşturduk.
            var p1 = new Person{Name = "Burak",Year = 1994}; 
            var p2 = new Person{Name = "Burhan",Year = 1994}; ;
            var p3 = new Person{Name = "Faruk",Year = 1995}; ;
            
            //burada nesnelere bağlı metotları çağırdık.
            p1.Intro();
            p2.Intro();
            p2.Intro();
        }
    }
}
