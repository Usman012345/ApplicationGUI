using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_task1.Employee;
using Project_task1.DL;
using System.Windows.Forms;

namespace project_GUI
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        public void add_employee()
        {
            string name, role;
            int pay;
            float attendance;
            name = textBox1.Text;
            role = textBox2.Text;
            attendance = float.Parse(textBox3.Text);
            pay = int.Parse(textBox4.Text);
            Employee_info.add(name,role,pay,attendance);

        }
        private void Register_Click(object sender, EventArgs e)
        {
            add_employee();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Close();
        }
    }
}
