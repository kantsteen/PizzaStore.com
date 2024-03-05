using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzaStore.com
{
    internal class Store
    {
        public void Start() 
        {
            // public Pizza(string name, string topping, string size, int price)

            Pizza p1 = new Pizza($"Margherita", "tomat og ost", "medium", 55);
            Pizza p2 = new Pizza($"Pepperoni", "tomat, ost og pepperoni", "medium", 65);
            Pizza p3 = new Pizza($"Hawaii", "tomat, ost, skinke og ananas", "medium", 70);


            Customer c1 = new Customer("Jens Jensen", "12345678", "loppehaven 2", "kreditkort");
            Customer c2 = new Customer("Niels Nielsen", "23456789", "blomsterhaven 4", "kreditkort");
            Customer c3 = new Customer("Peter Petersen", "34567890", "flimmerhaven 26", "MobilePay");

            Order o1 = new Order("561", p1, c1);
            Order o2 = new Order("672", p2, c2);
            Order o3 = new Order("118", p3, c3);

            Console.WriteLine(o1);
            Console.WriteLine(o2);
            Console.WriteLine(o3);






        }





    }
}
