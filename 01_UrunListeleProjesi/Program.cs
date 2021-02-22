using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_UrunListeleProjesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Products products1 = new Products();
            products1.Id = 1;
            products1.Name = "Laptop";
            products1.Category = "Computer";
            products1.InStock = 20;

            Products products2 = new Products();
            products2.Id = 1;
            products2.Name = "TEA";
            products2.Category = "Fruit";
            products2.InStock = 10;

            Products products3 = new Products();
            products3.Id = 3;
            products3.Name = "IPhone";
            products3.Category = "Phone";
            products3.InStock = 12;

            Products[] pro ={ products1, products2, products3 };
            foreach (var item in pro)
            {
                Console.WriteLine("ürün ID :" +item.Id);
                Console.WriteLine("Ürün NAme :" +item.Name);
                Console.WriteLine("ÜRün KAtegori :" +item.Category);
                Console.WriteLine("ÜRün stok :" +item.InStock);
            }

            Console.ReadKey();

        }
    }
}
