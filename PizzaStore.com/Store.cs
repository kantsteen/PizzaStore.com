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

            Pizza p1 = new Pizza($"Margherita", "Tomat og ost", "Medium", 55);
            Pizza p2 = new Pizza($"Pepperoni", "Tomat, ost og pepperoni", "Medium", 65);
            Pizza p3 = new Pizza($"Hawaii", "Tomat, ost, skinke og ananas", "Medium", 70);

            Customer c1 = new Customer("Jens Jensen", "12345678", "loppehaven 2", "Kreditkort");
            Customer c2 = new Customer("Niels Nielsen", "23456789", "Blomsterhaven 4", "Kreditkort");
            Customer c3 = new Customer("Peter Petersen", "34567890", "Flimmerhaven 26", "MobilePay");

            Order o1 = new Order("561", p1, c1);
            Order o2 = new Order("672", p2, c2);
            Order o3 = new Order("118", p3, c3);

            Console.WriteLine(o1);
            Console.WriteLine(o2);
            Console.WriteLine(o3);
            

        }
    }
}