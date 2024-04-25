using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
    public partial class Form1 : Form
    {
        const int TIME_FINISH = 30;
        int tickes;
        Cart queue;
        public Form1()
        {
            tickes = 0;
            InitializeComponent();
            queue = new Cart();
            Timer.Enabled = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          btnmenu.Visible= false;
          btnabtus.Visible= false;
            content.Visible = false;
          btneatingin.Visible= true;
          btnback.Visible= true;
         
        }

        private void btnabtus_Click(object sender, EventArgs e)
        {
            btnmenu.Visible = false;
            btnabtus.Visible = false;
            btnback.Visible = true;
            lbl_abtus.Visible = true;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            btnmenu.Visible = true;
            btnabtus.Visible = true;
            content.Visible = true;
            btnback.Visible = false;
            btneatingin.Visible = false;
            piccheesemix.Visible = false;
            piconions.Visible = false;
            picvegie.Visible = false;
            btncheesemix.Visible = false;
            btnonimato.Visible = false;
            btnvegie.Visible = false;
            lbl_abtus.Visible=false;
            RichPizza.Visible = false;
            btn_Buy.Visible = false;
            ClearBtn.Visible = false;
            btnDelete.Visible = false;
        }

        private void btndelivery_Click(object sender, EventArgs e)
        {
            btneatingin.Visible = false;
            piccheesemix.Visible = true;
            piconions.Visible = true;
            picvegie.Visible = true;
            btncheesemix.Visible = true;
            btnonimato.Visible = true;
            btnvegie.Visible = true;
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            piccheesemix.Visible = true;
            picvegie.Visible = true;
            piconions.Visible = true;
        }

        private void piconionstomato_Click(object sender, EventArgs e)
        {

        }

        private void btnvegie_Click(object sender, EventArgs e)
        {
            Pizza pizza = new Pizza("Vegan", 65);
            queue.AddPizza(pizza);
            RichPizza.Text = pizza.Print();
            MessageBox.Show("Item has been added to the cart");
            //listPizza.Items.Add(pizza);
        }

        private void btncheesemix_Click(object sender, EventArgs e)
        {
            Pizza pizza = new Pizza("Cheese Mix", 75);
            queue.AddPizza(pizza);
            RichPizza.Text = pizza.Print();
            MessageBox.Show("Item has been added to the cart");
            //listPizza.Items.Add(pizza);

        }

        private void btnonimato_Click(object sender, EventArgs e)
        {
            Pizza pizza = new Pizza("Onimato", 70);
            RichPizza.Text = pizza.Print();
            queue.AddPizza(pizza);
            MessageBox.Show("Item has been added to the cart");
            //listPizza.Items.Add(pizza);

        }

        private void btneatingin_Click(object sender, EventArgs e)
        {
            btneatingin.Visible = false;

            grppizzaBox.Visible = true;
        

        }

        private void lbl_abtus_Click(object sender, EventArgs e)
        {

        }

        private void btn_cart_Click(object sender, EventArgs e)
        {
            RichPizza.Visible = true;
            btn_Buy.Visible = true;
            ClearBtn.Visible = true;
            btnDelete.Visible = true;  
            ClearBtn.Visible = true;
            btn_Buy.Visible = true;
            content.Visible = true;
            string result = queue.PrintCart();
            if(result != null)
            {
                RichPizza.Text = result;
            }
            grppizzaBox.Visible = false;
            //MessageBox.Show("the pizza has been added");

        }


        private void grppizzaBox_Enter(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Pizza temp = queue.RemovePizza();
            if (temp != null)
            {
                MessageBox.Show("Pizza number#" + temp.GetNumber() + "has been removed");
            }
            RichPizza.Text = "";

        }

        private void listPizza_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            RichPizza.Text = "";
        }

        private void btn_Buy_Click(object sender, EventArgs e)
        {
           DialogResult res= MessageBox.Show("are u sure?", "buy", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                MessageBox.Show("Purchase has been confirmed");
                Application.Exit();

            }
            else
                MessageBox.Show("Purchase has been canceled");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            int time_left = TIME_FINISH - tickes;
            tickes++;
            if (time_left == 0)
            {
                
                Timer.Stop();
                TimeLbl.Text = "Time is Passed!";
                
            }
            else if (time_left <= 10)
            { TimeLbl.Text = "You Have Left " + time_left + " to Finsh"; }
        }

        private void RichPizza_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
