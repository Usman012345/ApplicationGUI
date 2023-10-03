using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using task6.BL;

namespace project_GUI
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }
       public int count = 0;
        public string state = "";
        private void Log_In_Click(object sender, EventArgs e)
        {
            string name, role, password;
            name = textBox1.Text;
            password = textBox2.Text;
            role = textBox3.Text;
            if(state=="sign_up")
            signin_up.signup(ref count,name,password,role);
           if(state=="sign_in")
            role=signin_up.signin(ref count, name, password, role);
            if (role=="admin"|| role=="Admin")
            {
                
                Form3 f3 = new Form3();
                f3.Show();
                this.Close();
            }
            else if(role=="Employee"||role=="employee")
            {
                Form11 f11 = new Form11();
                f11.Show();
                this.Close();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close(); 

        }
    }
}
