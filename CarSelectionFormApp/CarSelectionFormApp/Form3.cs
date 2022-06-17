using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CarSelectionFormApp
{
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            form6.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
