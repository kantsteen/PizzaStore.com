using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.com
{
    internal class Customer
    {

        #region instance field

        private string _name;
        private string _phoneNumber;
        private string _address;
        private string _paymentMethod;

        #endregion





        #region constructors
        public Customer(string name, string phoneNumber, string adress, string paymentMethod)
        {
            _name = name;
            _address = adress;
            _phoneNumber = phoneNumber;
            _paymentMethod = paymentMethod;

        }
        #endregion





        #region properties

        public string Name 
        { 
            get { return _name; } 
            set { _name = value; }
        }

        public string Adress
        { 
            get { return _address; } 
            set { _address = value; }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public string PaymentMethod
        { 
            get { return _paymentMethod; }
            set { _paymentMethod = value; } 
        }



        #endregion

        #region ToString
        public override string ToString()
        {
            return $"Name: {Name} - Adress: {Adress} - Phone number: {PhoneNumber} - Payment method: {PaymentMethod}";
        }

        #endregion



    }
}
