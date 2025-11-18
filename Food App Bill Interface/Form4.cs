using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Food_App_Bill_Interface
{
    public partial class Form4 : Form
    {
        public string Orderitemlist { get; set; }
        public string OrderType { get; set; }
        public Form4()
        {
            InitializeComponent();
            idlabel.Text = "ep001";
            itemlabel.Text = Orderitemlist;
            typelabel.Text = OrderType;

            

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            itemlabel.Text = Orderitemlist;
            typelabel.Text = OrderType;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order is Conformed Enjoy !");
        }
    }
}
