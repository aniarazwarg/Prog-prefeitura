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
    public partial class form_msg : Form
    {
        public form_msg()
        {
            InitializeComponent();
        }

        private void bt_enviar_ms_Click(object sender, EventArgs e)
        {
            txbox_msg.Text = "\r\n Nome: " + nome_ms.Text
                + "\r\n E-mail: " + tx_ms_email.Text
                + "\r\n Mensagem: " + tx_msg.Text;
 
              
        }

        private void txbox_msg_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Obrigado(a) por usar o serviço.");
            Application.Exit();

        }
    }
}
