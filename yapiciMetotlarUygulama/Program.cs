using System;

namespace yapiciMetotlarUygulama
{

    class Comment
    { //ürüne yapılan yorumları taşıyacak olan  sınıf.

        public int CommentId { get; set; }

        public string Text { get; set; }

    }
    class Product
    { //ürün bilgilerini tutacak olan sınıf.


        // yapıcı metot. (ctor kısayolu)

        public Product()
        {
            this.ProductId = (new Random()).Next(1111, 9999);
            this.Comments = new Comment[3];
        }



        public Product(int productId)
        {
            this.ProductId = productId;
        }

        // :this() sözcüğü sayesinde ilk çalışacak constructor'ı belirliyoruz.
        public Product(int productId, string name, double price, bool isApproved) : this()
        {
            this.ProductId = productId;
            this.Name = name;
            this.Price = price;
            this.IsApproved = isApproved;
        }
        public int ProductId { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public bool IsApproved { get; set; }

        public Comment[] Comments { get; set; } //Comment tipi dizi oluşturabiliyoruz.
    }
    class Program
    {
        static void Main(string[] args)
        {

            var c1 = new Comment
            {
                CommentId = 1,
                Text = "Cihazı beğendim"
            };

            var p = new Product();

            p.Comments[0] = c1; //oluşturduğumuz comments dizisinin 0. indisine c1 nesnesindeki yorumu ekledik.

            Console.WriteLine(p.ProductId);
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Price);
            Console.WriteLine(p.IsApproved);
            Console.WriteLine(p.Comments[0].Text);

            Console.WriteLine("--------------------------------");

            var p1 = new Product(9876, "iphone 10 pro", 10.000, true);
            p1.Comments[0] = c1; //oluşturduğumuz comments dizisinin 0. indisine c1 nesnesindeki yorumu ekledik.

            Console.WriteLine(p1.ProductId);
            Console.WriteLine(p1.Name);
            Console.WriteLine(p1.Price);
            Console.WriteLine(p1.IsApproved);
            Console.WriteLine(p1.Comments[0].Text);


            Console.WriteLine("--------------------------------");

            var p2 = new Product(5050);
            p2.Comments[0] = c1; //oluşturduğumuz comments dizisinin 0. indisine c1 nesnesindeki yorumu ekledik.

            Console.WriteLine(p2.ProductId);
            Console.WriteLine(p2.Name);
            Console.WriteLine(p2.Price);
            Console.WriteLine(p2.IsApproved);
            Console.WriteLine(p2.Comments[0].Text);
        }
    }
}
