using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Project_task2.Class;
using Project_task1.DL;
using System.Threading.Tasks;
using Project_task2.medicine;
using System.Windows.Forms;

namespace project_GUI
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Medicine_Click(object sender, EventArgs e)
        {

        }

        private void Remove_Click(object sender, EventArgs e)
        {
            
            string name = textBox.Text;

           bool value= medicine__info.Remove_medicine(Medfile.med, name);
            if(value==false)
            {
                MessageBox.Show("Wrong input");
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
