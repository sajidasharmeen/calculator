using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combobox
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        public static string abc="";


        private void button1_Click(object sender, EventArgs e)
        {


          abc=textBox1.Text;

            Form4 obj = new Form4();

            obj.Show();

            this.Hide();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
