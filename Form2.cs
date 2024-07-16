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
    public partial class Form2 : Form
    {
        public string enteredName { get; set; }
        public string enteredPassword { get; set; }

        public Form2()
        {
            InitializeComponent();


        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string productName = textBox1.Text;
            string imageUrl = textBox2.Text;

            
            try
            {
                System.Net.WebRequest request = System.Net.WebRequest.Create(imageUrl);
                using (System.Net.WebResponse response = request.GetResponse())
                using (System.IO.Stream stream = response.GetResponseStream())
                {
                    Image image = Image.FromStream(stream);
                    imageList1.Images.Add(productName, image);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Error");
                return;
            }

           
            ListViewItem item = new ListViewItem(new[] { productName, "$0.00" });
            item.ImageKey = productName;
            listView1.Items.Add(item);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string productName = textBox3.Text;

            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[0].Text.Equals(productName, StringComparison.OrdinalIgnoreCase))
                {
                    listView1.Items.Remove(item);
                    MessageBox.Show($"Removed: {productName}", "Success");
                    return;
                }
            }

            MessageBox.Show($"Product '{productName}' not found.", "Error");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
