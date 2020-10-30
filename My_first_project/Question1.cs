using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_first_project
{
    class Product : IComparable<Product>
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int Rating { get; set; }
        public int CompareTo(Product a)
        {
            if (this.Price > a.Price)
                return 1;
            else if (this.Price < a.Price)
                return -1;
            else return 0;
        }

    }
    //class Comparer : IComparable<Product>
    //{
    //    public int CompareTo(Product a)
    //    {
    //        if (a.Price > this.Price)
    //            return 1;
    //        else if (a.Price < b.Price)
    //            return -1;
    //        else return 0;
    //    }
    //}
    class Question1
    {
        public static void Main(string [] args)
        {
            
            //Product c = new Product();
            List<Product> p = new List<Product>();
            while (true)
            {
                Product c = new Product();
                Console.WriteLine("enter the values ContactNo, ContactName, CellNo");
                int ProdId = int.Parse(Console.ReadLine());
                c.ProductName = Console.ReadLine();
                c.Price = int.Parse(Console.ReadLine());
                c.Rating = int.Parse(Console.ReadLine());
                p.Add(new Product() { ProductId = ProdId, ProductName = c.ProductName, Price = c.Price, Rating = c.Rating });
                c.CompareTo(c);
                foreach (object o in p)
                {
                    Console.WriteLine(o);
                }
                Console.ReadLine();
            }
            
        }

    }

}
