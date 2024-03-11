using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PercyLimCompany
{
    public partial class Form1 : Form
    {
        private List<Order> orders;
        private Form2 form2;
        private double total;

        public Form1()
        {
            InitializeComponent();
            orders = new List<Order>();
            form2 = new Form2();
            total = 0.0;
            smallRadio.Checked = true;

            // pre-defined inputs
            custTBox.Text = "John Doe";
            orderTBox.Text = "12345";
        }

        private void addBut_Click(object sender, EventArgs e)
        {
            int qty;
            if (total > 0)
            {
                total = 0;
                orders = new List<Order>();
                form2 = new Form2();
            }

            if (ValidateInput(out qty))
            {
                qtyTBox.Text = qty.ToString();
                qtyTBox.BackColor = Color.Aquamarine;
                custTBox.Enabled = false;
                orderTBox.Enabled = false;

                orders.Add(new Order
                {
                    Quantity = qty,
                    Size = 
                        smallRadio.Checked ? "Small" : 
                        medRadio.Checked ? "Medium" : 
                        largeRadio.Checked ? "Large" : 
                        large2Radio.Checked ? "Extra Large" : "XXL",
                    HasMonogram = monoCheckBox.Checked,
                    HasPockets = pocketCheckBox.Checked
                });
            }
        }

        private bool ValidateInput(out int qty)
        {
            qty = 0;

            if (custTBox.Text == "" || orderTBox.Text == "" || qtyTBox.Text == "")
            {
                MessageBox.Show(@"Empty input is not allowed");
                return false;
            }

            if (new Regex(@"^[1-9][0-9]*$").IsMatch(qtyTBox.Text))
            {
                qty = Convert.ToInt32(qtyTBox.Text);
                return true;
            }
            else
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    qty = form2.Quantity;
                    return true;
                }
                
                MessageBox.Show(@"Invalid quantity input");
            }

            qtyTBox.BackColor = Color.White;
            return false;
        }

        private void clearBut_Click(object sender, EventArgs e)
        {
            qtyTBox.Text = "";
            qtyTBox.BackColor = Color.White;
            smallRadio.Checked = true;
            monoCheckBox.Checked = false;
            pocketCheckBox.Checked = false;
        }

        private void displayBut_Click(object sender, EventArgs e)
        {
            if (total == 0)
            {
                MessageBox.Show(@"Complete the orders first");
                return;
            }

            // Display number of shirts, number of orders, and total amount of orders
            MessageBox.Show(@"Number of shirts: " + orders.Sum(x => x.Quantity) + "\n" +
                                                       "Number of orders: " + orders.Count + "\n" +
                                                                                  "Total amount: " + total.ToString("C"));
        }

        private void completeBut_Click(object sender, EventArgs e)
        {
            total = 0;
            if (orders.Count > 0)
            {
                foreach (Order order in orders)
                    total += order.GetTotalPrice();

                //MessageBox.Show(@"Total: " + total.ToString("C"));
                MessageBox.Show(@"Order completed");
                custTBox.Enabled = true;
                orderTBox.Enabled = true;
                qtyTBox.BackColor = Color.White;
                return;
            }

            MessageBox.Show(@"No orders to complete");
        }
    }

    public class Order
    {
        public int Quantity { get; set; }
        public string Size { get; set; }
        public bool HasMonogram { get; set; }
        public bool HasPockets { get; set; }
        public double Price { get; set; }

        public double GetTotalPrice()
        {
            double price = 0.0;
            int sizePrice = 0;

            switch (Size)
            {
                case "Small":
                    sizePrice = 10;
                    break;
                case "Medium":
                    sizePrice = 20;
                    break;
                case "Large":
                    sizePrice = 30;
                    break;
                case "Extra Large":
                    sizePrice = 40;
                    break;
                case "XXL":
                    sizePrice = 50;
                    break;
            }

            price += (sizePrice * Quantity);
            if (HasMonogram)
                price += (5 * Quantity);
            if (HasPockets)
                price += (5 * Quantity);

            return price;
        }
    }
}
