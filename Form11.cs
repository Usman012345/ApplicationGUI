using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Project_task1.Employee;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_GUI
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Mark_attendance_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
            this.Close();
            
        }

        private void Preparebill_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            f13.Show();
            this.Close();
        }

        private void new_medicine_Click(object sender, EventArgs e)
        {
            Form15 f15 = new Form15();
            f15.Show();
            this.Close();
        }

        private void Print_record_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            
        }

        private void Edit_prices_Click(object sender, EventArgs e)
        {
            
            Form16 f16 = new Form16();
            f16.Show();
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
