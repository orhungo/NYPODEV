using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NYPODEV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "gokcen" && textBox2.Text == "orhun07")
            {
                Form3 form3 = new Form3();
                form3.Show();
            }
            else
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
        }
    }
}
