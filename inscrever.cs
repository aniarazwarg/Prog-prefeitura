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
    public partial class inscrever : Form
    {
        public inscrever()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt_insc_Click(object sender, EventArgs e)
        {
            if(textNome.Text =="" || ddd.Text == "" || tel.Text == "" || txemail.Text == "" || txend.Text == "")
            {
                MessageBox.Show("Preencher campos obrigatórios.");
            }
            else
            {
                String MostraNomes;
                MostraNomes = "\r\nNome: " + textNome.Text
                + "\r\n DDD: " + ddd.Text
                + "Tel: " + tel.Text;

                MessageBox.Show("Inscrição concluída." +
                    "",MostraNomes);
                
            }
           
        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            //FormHome home = new FormHome();
            // home.ShowDialog();

            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            
                MessageBox.Show("Obrigado(a) por usar o serviço.");
                Application.Exit();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
