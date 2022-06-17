using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CarSelectionFormApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime givenDate = DateTime.Parse(dob.Text);
            int days = now.Subtract(givenDate).Days;
            double age = Math.Floor(days / 365.24219);

            if (age >= 18.0)

            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You are not of legal age to purchase an MBT. Please exit the site and report yourself to the nearest law enforcement agency", "Security breach");
            }
        }
    }
}
