# C-Simples



using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INumeratorINumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingBasket basketObj = new ShoppingBasket();
            foreach (Products product in basketObj)
            {
                Console.WriteLine("Urun: {0}, Fiyat: {1}" , product.Name, product.Price);
            }
            Console.ReadLine();
        }
    }
    public class Products
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    public class ShoppingBasket:IEnumerable
    {
        public Products[] ProductList { get; set; }
        public ShoppingBasket()
        {
            ProductList = new Products[]
            {
                new Products() { Name = "Computer", Price = 6250.99m},
                new Products() { Name = "Ipad", Price = 2200.00m }
            };
        }
        public IEnumerator GetEnumerator()
        {
            return ProductList.GetEnumerator();
        }
    }
    //class ShoppingBasketEnumerator : IEnumerator
    //{

    //}
}
