using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Project_task1.DL;
using Project_task1.Employee;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_GUI
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Mark_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
           bool value= Employee_info.mark_attendance(name);
            if(value==false)
            {
                MessageBox.Show("Wrong input");
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
            this.Close();
        }
    }
}
