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
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
        }

        private void bt_insc_Click(object sender, EventArgs e)
        {
            if (txNm_cad.Text == "" || tx_login.Text == "" || tx_senha.Text == "")
            {
                MessageBox.Show("Preencher campos obrigatórios.");
            }
            else
            {

                if (tx_login.Text != "" && tx_senha.Text != "")
                {
                    string mysql = "server=localhost;uid=root;database=db_aniara";
                    string jovem = tx_login.Text;
                    string senhajovem = tx_senha.Text;

                    string senhaCadastrada = "";

                    try
                    {


                        MySqlConnection conn = new MySqlConnection(mysql);
                        conn.Open();
                        //string sql = "insert into senha_usuario from tb_usuario where nm_usuario = @jovem";
                        string sql = "INSERT INTO tb_usuario (nm_usuario, senha_usuario,privilegio_usuario) VALUES('"
                            + jovem
                            +"', '"
                            +senhajovem
                            +"', '"
                            +"usuario"
                            +"')";
                        MySqlCommand inserir = new MySqlCommand(sql, conn);

                        inserir.BeginExecuteNonQuery();


                        String MostraNomes;
                        MostraNomes = "\r\nNome: " + txNm_cad.Text;

                        MessageBox.Show("Inscrição concluída." +
                            "", MostraNomes);

                        this.Close();

                    }

                    
                     catch (MySqlException ex)
                    {
                        MessageBox.Show("erro" + ex);
                    }

                    
                }
                }
        
            }
        }
    }
