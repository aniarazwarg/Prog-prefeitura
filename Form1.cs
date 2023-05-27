using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetop2ds3
{
    public partial class Form_Log : Form
    {
        public Form_Log()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bt_entrar_Click(object sender, EventArgs e)
        {

            Usuario usuario = new Usuario();
            usuario.nome = boxlog.Text;
            usuario.senha = boxsen.Text;

            if (usuario.verificasenha(usuario.nome,usuario.senha))
            {
                
                FormHome home = new FormHome(usuario.nome, usuario.senha);

                this.Hide();
                home.ShowDialog();
            }

         
            else
            {
                MessageBox.Show("login ou senha inválidos.");
            }

            
        }

     
            

        private void boxlog_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_Log_Load(object sender, EventArgs e)
        {

        }

        private void bt_cadastro_Click(object sender, EventArgs e)
        {
          cadastro cadastro = new cadastro();
            cadastro.ShowDialog();
        }
    }
}
