using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzaStore.com
{
    internal class Order
    {
        #region instance field
        private string _orderID;
        private double _taxPct;
        private int _deliveryCosts;
        Customer customer;
        Pizza pizza;


        #endregion


        #region constructors
        public Order(string orderID, Pizza p, Customer c)
        {
            TaxPct = 1.25;
            DeliveryCosts = 40;
            _orderID = orderID;
            pizza = p;
            customer = c;
        }
        #endregion


        #region properties


        public string OrderID 
        { 
            get { return _orderID; } 
            set { _orderID = value; }
        }

        public double TaxPct
        {
            get { return _taxPct; }
            set { _taxPct = value; }
        }

        public int DeliveryCosts
        {
            get { return _deliveryCosts;}
            set { _deliveryCosts = value; }
        }

        #endregion


        #region ToString
        public override string ToString()
        {
            return $" - OrderID: {OrderID} - Pizza: {pizza.Name} - Customer: {customer.Name} - Total: {CalculateTotalPrice()} DKK";
        }

        #endregion

        public double CalculateTotalPrice()
        {
            return pizza.Price * TaxPct + DeliveryCosts;
        }


    }
}
