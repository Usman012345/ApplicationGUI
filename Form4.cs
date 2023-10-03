using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_task2.medicine;
using Project_task1.DL;

namespace project_GUI
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void add_medicine()
        {
            string name;
            DateTime expiry=new DateTime();
            int price;
            name = textBox.Text;
            expiry =DateTime.Parse(textBox3.Text);
            price = int.Parse(textBox4.Text);
            medicine__info.add(name, price, expiry);
        }

        private void Register_Click(object sender, EventArgs e)
        {
             add_medicine();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Close();
        }
    }
}
