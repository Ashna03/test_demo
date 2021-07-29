using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Shopee
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Shop.ViewProducts();
            Shop.Buy();
        }
    }

    public class Shop
    {
        public int ShopId { get; set; }
        public string Name { get; set; }

        public static List<Product> ShopProducts = new List<Product>();

        public static void ViewProducts() 
        {
            Console.WriteLine("The Available Products for Purchasing are:");
            ShopProducts.Add(new Product() { ItemCode = 101, ItemName = "Bread", Cost = 60 });
            ShopProducts.Add(new Product() { ItemCode = 102, ItemName = "Eggs", Cost = 12 });
            ShopProducts.Add(new Product() { ItemCode = 103, ItemName = "Milk", Cost = 40 });
            ShopProducts.Add(new Product() { ItemCode = 104, ItemName = "Fruits", Cost = 80 });
            ShopProducts.Add(new Product() { ItemCode = 105, ItemName = "Vegetables", Cost = 100 });

            ShopProducts.ForEach((p) =>
            {
                Console.WriteLine($"{nameof(p.ItemCode)} : {p.ItemCode} | {nameof(p.ItemName)} : {p.ItemName} | {nameof(p.Cost)} : {p.Cost}");

            });
        }
        public static int n;
        public static double Buy()
        {
            
            Product pro = new Product();
            Console.WriteLine("Enter the no. of Products to Purchase");
            int count = Convert.ToInt32(Console.ReadLine());
            if (n <= count )
            {
                Console.WriteLine("Enter the Name of the product to purchase");
                string ItemName = Console.ReadLine();
                Console.WriteLine("Enter the Price of the product to purchase");
                int Price = Convert.ToInt32(Console.ReadLine());
                n++;
                pro.Cost += Price;
                

            }
            else
            {
                return 0;
            }

            return pro.Cost;

            Console.WriteLine("The Products for purchase is {itemname}");
           
        }
    }
           


    }

    public class Customer
    {
       public Customer(Guid custid)
       {
        Cust_Id = Guid.NewGuid();
       }
        protected Guid Cust_Id;
        public string Name;


        
    }

