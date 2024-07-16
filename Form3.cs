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
    public partial class Form3 : Form
    {
        public Form3()
        {
            int balance = 765;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string productName = textBox3.Text;

            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[0].Text.Equals(productName, StringComparison.OrdinalIgnoreCase))
                {
                    if (productName=="Otamatone") { MessageBox.Show($"Product exists: {productName} - Price is within range of your current balance.", "Success");}
                    else MessageBox.Show($"Product exists: {productName} - Price exceeds your current balance of 765$UYU.", "Success");
                    return;
                }
            }

            MessageBox.Show($"Product '{productName}' not found.", "Error");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
