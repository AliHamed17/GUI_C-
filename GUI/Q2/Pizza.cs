using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
    internal class Pizza
    {
        string name;
        uint price;
        static uint counter = 0;
        readonly uint pizzaNum;
        static int total = 0;

        public string GetName()
        {
            return name;
        }
        public uint GetPrice()
        {
            return price;
        }
        public uint GetNumber() { return pizzaNum; }
        public uint GetTotalPrice()
        {
            return price * GetNumber();
        }
        public Pizza(string name, uint price)
        {
            this.name = name;
            this.price = price;
            counter++;
            pizzaNum = counter;
        }
        public Pizza() : this("name", 0)
        {
        }

        public string Print() 
        {
            string str = "";
            str += "The pizza: " + GetName() +"\n";
            str += "With" + GetPrice()+"$\n";
            str += "The Total Price is:" + GetTotalPrice() + "\n\n";
            return str;
        }
    } 
       
}
