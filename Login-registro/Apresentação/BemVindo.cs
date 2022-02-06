using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_registro.Apresentação
{
    public partial class BemVindo : Form
    {
        public BemVindo()
        {
            InitializeComponent();
           
        }
            private void metroLabel1_Click(object sender, EventArgs e)
        {
           
        }
        public string TheValue { get; set; }
        int i = 10;

        private void BemVindo_Load(object sender, EventArgs e)
        {
            metroLabel1.Text = "Bem Vindo! " + TheValue;
            
                metroLabel3.Text = DateTime.Now.ToString();

            
        }
        agendaEntities3 dbcontext = new agendaEntities3();

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {
        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
