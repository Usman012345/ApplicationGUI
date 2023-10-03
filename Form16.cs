using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_task2.medicine;
using Project_task1.BL;
using Project_task1.DL;
using System.Windows.Forms;
using Project_task1.Employee;

namespace project_GUI
{
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            string name;
            int price;
            name = textBox.Text;
            price = int.Parse(textBox1.Text);
            Employee_info.edit_prices(name, price);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
            this.Close();
        }
    }
}
