using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Project_task2.medicine;
using System.Threading.Tasks;
using Project_task1.Employee;
using System.Windows.Forms;
using Project_task1.DL;

namespace project_GUI
{
    public partial class Form14 : Form
    {
        private List<medicine__info> med__ = new List<medicine__info>();

        internal List<medicine__info> Med__ { get => med__; set => med__ = value; }

        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
          
            int bill=0;
            for (int x = 0; x <Employee_info.bought_medicine.Count; x++)
            {
                foreach (medicine__info data in Medfile.med)
                {
                    if (Employee_info.bought_medicine[x].Medicine==data.Medicine)
                    {
                        data.Quantity = Employee_info.bought_medicine[x].Quantity;
                        Med__.Add(data);
                        bill += data.Price*Employee_info.bought_medicine[x].Quantity;
                    }
            }
            }
            
            dataGridView1.DataSource = Med__;
            label1.Text = bill.ToString();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            f13.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
