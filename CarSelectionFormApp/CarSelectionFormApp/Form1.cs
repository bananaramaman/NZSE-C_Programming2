using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSelectionFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                int parsedValue;
                if (!String.IsNullOrEmpty(textBox1.Text) && int.TryParse(maskedTextBox1.Text, out parsedValue))
                {
                    MessageBox.Show("Access Granted", "Notification");
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }
            }
            catch (DivideByZeroException exc)
            {
                MessageBox.Show("Please check login credentials and try again", exc.Message);
                return;
            }
            catch (SystemException exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
               
            }
        }
    }
}
