using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Project_task1.Employee;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_task2.medicine;
using System.Windows.Forms;

namespace project_GUI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Close();
        }

        private void Print_medicine_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();

        }

        private void check_expiry_Click(object sender, EventArgs e)
        {
          List<string> expired=  medicine__info.checkexpiry();
            if(expired==null)
            {
                MessageBox.Show("No medicine expired");
            }
            else
            {
                Form6 f6 = new Form6();
                f6.Expired = expired;
                f6.Show();
                this.Close();

            }
        }

        private void remove_medicine_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
            this.Close();


        }

        private void add_employee_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
            this.Close();

        }

        private void print_employee_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
            this.Close();

        }

        private void print_employee_requested_medicine_Click(object sender, EventArgs e)
        {
            string names="";
            foreach(string data in Employee_info.medicine_new)
            {
                names += ","+data;
            }
                MessageBox.Show(names);
        }

        private void remove_employee_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
            this.Close();

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Close();
        }
    }
}
