using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public string enteredName { get; set; }
        public string enteredPassword { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {

            string enteredName = textBox1.Text;
            string enteredPassword = textBox2.Text;

            if (enteredName == "admin")
            {

                if (enteredPassword == "admin")
                {

                    Form2 form2 = new Form2();
                    form2.Show();
                }
                else

                
                { MessageBox.Show("Incorrect password. Please try again."); }
            }
            else

            if (enteredName == "Alicia")
            {
                if (enteredPassword == "blanca")
                {

                    Form3 form3 = new Form3();
                    form3.Show();
                }
            }
            else

                if (enteredName == "eriksil")
            {
                if (enteredPassword == "30092006")
                {

                    Form3 form3 = new Form3();
                    form3.Show();
                }
            }
            else

                if (enteredName == "Chad")
            {
                if (enteredPassword == "josephabram1")
                {

                    Form3 form3 = new Form3();
                    form3.Show();
                }
            }
            else

                if (enteredName == "Maika")
            {
                if (enteredPassword == "maikarobe300920")
                {

                    Form3 form3 = new Form3();
                    form3.Show();
                }
            }
            else

                if (enteredName == "Andrew")
            {
                if (enteredPassword == "AdeGreff237")
                {

                    Form3 form3 = new Form3();
                    form3.Show();
                }
            }

            else { MessageBox.Show("Incorrect name. Please try again."); }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
