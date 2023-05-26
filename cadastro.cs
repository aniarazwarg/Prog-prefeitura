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
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
        }

        private void bt_insc_Click(object sender, EventArgs e)
        {
            if (txNm_cad.Text == "" || tx_login.Text =="" || tx_senha.Text =="")
            {
                MessageBox.Show("Preencher campos obrigatórios.");
            }
            else
            {
                String MostraNomes;
                MostraNomes = "\r\nNome: " + txNm_cad.Text;

                MessageBox.Show("Inscrição concluída." +
                    "", MostraNomes);

                this.Close();

            }
        }

        private void cad_NB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cad_fem_CheckedChanged(object sender, EventArgs e)
        {
         
        }
    }
}
