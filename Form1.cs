using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using task6.DL;
using Project_task1.DL;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_GUI
{
    public partial class Form1 : Form
    {
        public static int count = 0;
        public Form1()
        {
            InitializeComponent();
            signdata.read_count(ref count);
            employee_data.readfile();
            Medfile.readfile(Medfile.med);
        }

        private void Sign_UP_Click(object sender, EventArgs e)
        {
            
            Form2 F2 = new Form2();
            F2.count = count;
            F2.state = "sign_up";
            F2.Show();
           
        }

        private void Sign_IN_Click(object sender, EventArgs e)
        {
                Form2 F2 = new Form2();
            F2.count = count;
            F2.state = "sign_in";
            F2.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
