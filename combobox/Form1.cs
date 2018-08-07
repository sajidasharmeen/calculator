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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            comboBox1.SelectedItem = "milk";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // for single item add
            comboBox1.Items.Add("honey");

            // for multi-item adding
            string[] items = { "lux", "vicks", "tea" };
            comboBox1.Items.AddRange(items);

            //through textbox
            comboBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox2.SelectedIndex.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox2.SelectedItem.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //comboBox1.Items.RemoveAt(1);
            comboBox3.Items.Remove(textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {




            comboBox2.Items.Add("weekdays");
            comboBox2.Items.Add("year");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            
            if (comboBox2.SelectedItem == "weekdays")
            {
                comboBox3.Items.Add("Sunday");
                comboBox3.Items.Add("Monday");
                comboBox3.Items.Add("Tuesday");
            }
            else if (comboBox2.SelectedItem == "year")
            {
                comboBox3.Items.Add("2012");
                comboBox3.Items.Add("2013");
                comboBox3.Items.Add("2014");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
