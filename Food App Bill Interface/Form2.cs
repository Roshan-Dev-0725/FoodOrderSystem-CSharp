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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string id = textBox2.Text;

            if(name=="" || id=="")
            {
                MessageBox.Show("Please Enter All credintial "," ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            Form3 f2 = new Form3();
            f2.Show();
            this.Hide();
        }
    }
}
