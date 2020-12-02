using System;

namespace Properties
{
    class Product
    {
        private string _name;
        private double _price;

        // double Price; şeklinde tanımladığımızda default private olarak tanımlar.

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if(!string.IsNullOrEmpty(value)) // string boş değilse 
                    _name = value;
                else
                    throw new Exception("Name alanını boş bırakamazsınız"); //hata mesajı

            }

        }

        //Price 
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value < 0)   //burada value değeri Price'a gelen değeri kontrol eder.
                    _price = 0;
                else
                    _price = value;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Product();
            // p.Name = ""; boş bıraktığımız taktirde hata mesajımız çalışır.
            p.Name = "Huawei P30 Pro";
                Console.WriteLine(p.Name);

            p.Price = 9000;
                Console.WriteLine(p.Price);
            p.Price = -3000;
                Console.WriteLine(p.Price);

        }Q
    }
}
