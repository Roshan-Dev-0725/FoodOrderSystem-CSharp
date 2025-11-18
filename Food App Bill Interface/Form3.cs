using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_App_Bill_Interface
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result =MessageBox.Show("Are Your Sure You Want to Confirm This Order"," ",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if(result == DialogResult.Yes)
            {
                string Orderitems = "";

                if(checkBox1.Checked)
                {
                    Orderitems += "SpringRoll \n";
                }
                if(checkBox2.Checked)
                {
                    Orderitems += "Pasta \n";
                }
                if(checkBox3.Checked)
                {
                    Orderitems += "Cofee \n";
                }
                if(checkBox4.Checked)
                {
                    Orderitems += "Garlic Bread \n";
                }
                if(checkBox5.Checked)
                {
                    Orderitems += "Grilled Chicken \n";
                }
                if(checkBox6.Checked)
                {
                    Orderitems += "Juice \n";
                }

                string ordertype = "";
                if(radioButton1.Checked)
                {
                    ordertype = "Dine-in";
                }
                if(radioButton2.Checked)
                {
                    ordertype = "TakeAway";
                }
                if(radioButton3.Checked)
                {
                    ordertype = "Delivary";
                }

                
                
                Form4 f4 = new Form4();
                
                f4.Orderitemlist = Orderitems;
                f4.OrderType = ordertype;
               
                f4.Show();
                this.Hide();



            }
        }
    }
}
