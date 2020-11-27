using System;

namespace OOP
{
    class Product{
        public string Name { get; set; }  

        public double Price { get; set; }
    
        public string Description { get; set; }      
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç adet ürün gireceksiniz ? ");
            int adet = int.Parse(Console.ReadLine());
            Product[] products = new Product[adet]; //Product sınıfından, dizi türünde bir nesne oluşturduk.
            int i = 0;
            Product prd;
            do
            {
                prd = new Product();
                    Console.Write("Ürün adı : ");
                    prd.Name = Console.ReadLine();

                    Console.Write("Ürün Fiyat : ");
                    prd.Price = double.Parse(Console.ReadLine());

                    Console.Write("Açıklama : ");
                    prd.Description = Console.ReadLine();

                    products[i] = prd;
                    i++;       
            } while (adet>i);
            Console.WriteLine("*****************************");

            for (int j = 0; j < products.Length; j++) {
                Console.WriteLine($"Ürün Adı:  {products[j].Name} Ürün Fiyatı: {products[j].Price}  Ürün Açıklaması : {products[j].Description}");
            }
        }
    }
}
