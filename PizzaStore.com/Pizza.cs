using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.com
{
    internal class Pizza
    {
        #region instance field

        private string _name;
        private string _size;
        private string _topping;
        private int _price;

        #endregion


        #region constructors

        public Pizza(string name, string topping, string size, int price)
        {
            _name = name;
            _price = price;
            _size = size;
            _topping = topping;
        }

        #endregion
       

        #region properties

        public string Name
        { 
            get { return _name; } 
            set { _name = value; }
        }
        public string Topping
        {
            get { return _topping; }
            set { _topping = value; }
        }

        public string Size
        { 
            get { return _size; } 
            set { _size = value; }
        }
        public int Price 
        {
            get { return _price; }
            set { _price = value; }
        }

        #endregion


        #region ToString

        public override string ToString()
        {
            return $"Name: {Name} - Topping: {Topping} - Size: {Price} - Price: {Price}";
        }

        #endregion


    }
}
