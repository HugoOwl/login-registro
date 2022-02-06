using Login_registro.Apresentação;
using Login_registro.sql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_registro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
{
            Registrar cad = new Registrar();
            cad.Show();
        }
        agendaEntities3 dbcontext = new agendaEntities3();
        private void Entrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(dbcontext.usuários.Where(r=>r.name==metroTextBox1.Text && r.senha==metroTextBox2.Text).Count()>0){
                    MessageBox.Show("Logado");
                    BemVindo BemVindo = new BemVindo();
                    BemVindo.TheValue = this.metroTextBox1.Text.ToString();
                    BemVindo.Show();
                }
            }
            catch
            {
                MessageBox.Show("Login incorreto");
            }
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
