using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; 

namespace projetop2ds3
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }
       

        public FormHome(string login, string senha)
        {
            InitializeComponent();
        }


        //criando sobrecarga para definir o que será exibido para cada usuario, trazendo o nome de login e usando na saudação.
        public FormHome(string login)
        {
            InitializeComponent();
            lbhome.Text = "Bem vindo(a/e) " + login;

            int length = lbhome.Text.Length;

         

            lbhome.Location= new Point(299 - length, 107);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form_atv atividade = new form_atv();
            atividade.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inscrever inscrever = new inscrever();
            inscrever.ShowDialog();
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Obrigado(a) por usar o serviço.");
            Application.Exit();
        }

        private void bt_msg_Click(object sender, EventArgs e)
        {
            form_msg mensagem = new form_msg();
            mensagem.ShowDialog();

        }

        private void atividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                form_atv atividade = new form_atv();
                atividade.ShowDialog();
            }
        }

        private void inscriçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                inscrever inscrever = new inscrever();
                inscrever.ShowDialog();
            }
        }

        private void mensagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                form_msg mensagem = new form_msg();
                mensagem.ShowDialog();

            }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                Sobre sobre = new Sobre();
                sobre.ShowDialog();

            }
        }

        private void FormHome_Load(object sender, EventArgs e)
        {

        }

        private void lbhome_Click(object sender, EventArgs e)
        {

        }

        private void admToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_adm Admin = new form_adm();
            Admin.ShowDialog();
        }
    }
}
