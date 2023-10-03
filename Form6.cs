using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_GUI
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            dataGridView1.DataSource = Expired;
        }
        private List<string> expired = new List<string>();

        public List<string> Expired { get => expired; set => expired = value; }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Close();
        }
    }
}
