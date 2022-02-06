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

namespace Login_registro.Apresentação
{
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }
        agendaEntities3 dbcontext = new agendaEntities3();

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var usuario = dbcontext.usuários.Create();
            usuario.email = metroTextBox1.Text;
            usuario.name = metroTextBox4.Text;
            usuario.observação = "Null";
            usuario.timerFim = "Null";
            usuario.timerInicio = "Null";
                try
            {
                if (metroTextBox2.Text.Equals(metroTextBox3.Text))
                {
                    usuario.senha = metroTextBox3.Text;
                    dbcontext.usuários.Add(usuario);



                    dbcontext.SaveChanges();
                    MessageBox.Show("Cadastrado");

                }
                else
                {
                    MessageBox.Show("As senhas não se correspondem");

                }
            } 
            catch
            {
                MessageBox.Show("Erro");
            }

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
