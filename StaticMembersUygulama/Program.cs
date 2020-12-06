using System;

//Sanal veritabanı yerine geçecek bir uygulama.
namespace StaticMembersUygulama
{
    class Product
    {
        //ürün id 
        public int ProductId { get; set; }

        //ürün ismi
        public string ProductName { get; set; }

        //ürün fiyatı
        public double Price { get; set; }

        //ürün satış durumu
        public bool IsApproved { get; set; }
    }
    static class ProductManager
    {
        static Product[] Products;

        //Static sınıfın constructor'ı da static olmak zorunda.
        static ProductManager()
        {
            Products = new Product[4];
            Products[0] = new Product { ProductId = 1, ProductName = "Iphone 12 Pro", Price = 16000, IsApproved = false };
            Products[1] = new Product { ProductId = 2, ProductName = "Iphone X ", Price = 10000, IsApproved = true };
            Products[2] = new Product { ProductId = 3, ProductName = "Huawei P40 Pro", Price = 9000, IsApproved = true };
            Products[3] = new Product { ProductId = 4, ProductName = "Iphone 11 Pro", Price = 11000, IsApproved = false };
        }
        public static Product[] GetProducts()
        {
            return Products;
        }

        // id'ye göre ürün gönderen static sınıf.
        public static Product GetProductById(int id)
        {
            Product product = null;
            //Gelen id'ye göre ürünü döndürür,yoksa null döndürür.
            foreach (var p in Products)
            {
                if(p.ProductId == id)
                    product = p;
            }
            return product;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {

            var product = ProductManager.GetProductById(2);
            Console.WriteLine($"Product Name: {product.ProductName} \nProduct Price: {product.Price}");
           
            //var products = ProductManager.GetProducts();
            // foreach (var p in products)
            // {
            //     Console.WriteLine($"Product Name: {p.ProductName} \nProduct Price: {p.Price}");
            // }
        }
    }
}
