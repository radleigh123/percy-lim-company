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
    public partial class Form2 : Form
    {
        public int Quantity { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void enterBut_Click(object sender, EventArgs e)
        {
            string str = valTBox.Text;
            Regex regex = new Regex(@"^[1-9][0-9]*$");

            if (regex.IsMatch(str))
            {
                int qty = Convert.ToInt32(str);

                Quantity = qty;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show(@"Input must be positive and greater than zero");
        }
    }
}
