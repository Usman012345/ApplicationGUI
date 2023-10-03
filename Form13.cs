using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_task1.Employee;
using System.Windows.Forms;
using Project_task2.medicine;

namespace project_GUI
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }
        

        private void Medicinea_Click(object sender, EventArgs e)
        {

        }

        private void Buy_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int quantity =int.Parse( textBox2.Text);
            medicine__info m = new medicine__info(quantity, name);
           Employee_info .bought_medicine.Add(m);
            dataGridView1.DataSource =Employee_info .bought_medicine;
        }

        private void Prepare_bill_Click(object sender, EventArgs e)
        {
            Form14 f14 = new Form14();
            f14.Show();
            this.Close();

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
            this.Close();
        }
    }
}
