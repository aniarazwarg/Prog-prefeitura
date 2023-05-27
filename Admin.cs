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
    public partial class form_adm : Form
    {
        public form_adm()
        {
            InitializeComponent();
        }
        public string mySqlString = "server=localhost;port3306;uid=root;database=db_atividade";
        

        private void form_adm_Load(object sender, EventArgs e)
        {
  
        MySqlConnection conn = new MySqlConnection(mySqlString);
        string sql = "select * from tb_usuario";
        MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
        DataTable data = new DataTable();
        adapter.Fill(data);

    try
        {
    conn.Open();
    cmd.BeginExecuteNonQuery();
    dataGridViewAdm.DataSource = data;
    
    }

    catch(MySqlException ex)
    {
        throw new Exception( $"Erro ao carregar a tabela: {ex.Message}");
    }
    finally
    {
    if(conn.State == ConnectionState.Open) conn.Close();    
    }
        }


    }
  
}
