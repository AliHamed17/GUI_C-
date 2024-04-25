using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
    internal class Cart
    {
        Pizza[] arr;
        int index;

        public Cart()
        {
            arr = new Pizza[0];
            index = 0;
        }

        public bool IsEmpty()
        {
            return index == 0;
        }

        public int Length => index;

        public Cart(Cart cart)
        {
            arr = new Pizza[cart.Length];
            Array.Copy(cart.arr, arr, cart.Length);
            index = cart.Length;
        }

        public void AddPizza(Pizza pizza)
        {
            Array.Resize(ref arr, index + 1);
            arr[index] = pizza;
            index++;
        }

        public Pizza RemovePizza()
        {
            if (IsEmpty())
            {
                MessageBox.Show("Cart is empty");
                return null;
            }

            Pizza pizza = arr[0];
            for (int i = 1; i < index; i++)
                arr[i - 1] = arr[i];

            index--;
            Array.Resize(ref arr, index);
            return pizza;
        }

        public string PrintCart()
        {
            if (IsEmpty())
            {
                MessageBox.Show("Cart is empty");
                return string.Empty;
            }

            StringBuilder sb = new StringBuilder();
            foreach (Pizza pizza in arr)
                sb.AppendLine(pizza.Print());

            return sb.ToString();
        }
    }
}
