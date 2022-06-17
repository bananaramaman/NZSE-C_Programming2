using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstFormApp
{
    public partial class Form1 : Form   //declaring form name(Form1) derived from Form class
    {
        public Form1()
        {
            InitializeComponent();  //loading the form 
        }
        private void button_Click_1(object sender, EventArgs e) //declaring the button
        {
            //if else statement giving conditions to the button object
            if ((UsernameBox.Text == "User") && (maskedTextBox1.Text == "Admin"))
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username and/or password. PLease try again", "Login Error");
            }
        }
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
