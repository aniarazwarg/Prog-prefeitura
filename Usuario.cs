using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace projetop2ds3
{

    public class Usuario
    { 
        public Usuario() //construtor (objeto e tudo que ele contem, o que podera ser instanciado)
        {
            nome = "";
            login = "";
            senha = "";
            privilegio = "";
            sexo = "";

            
        }

        //propriedades , mostrando que o que foi declarado no construtor sao classes/variaveis.
        public string nome;
        public string login;
        public string senha;
        public string privilegio;
        public string sexo;


        //metodos (funçoes)


        public bool verificasenha(string usuario, string senhaUsuario) // esse metodo vai ver se é true ou false por isso retorna o tipo boolean
        {

            if (usuario != "" && senha != "")
            {
                string mysql = "server=localhost;uid=root;database=db_aniara";
                string jovem = usuario;
                string senhajovem = senhaUsuario;

                string senhaCadastrada = "";

                try
                {


                    MySqlConnection conn = new MySqlConnection(mysql);
                    string sql = "select senha_usuario from tb_usuario where nm_usuario = @jovem";
                    MySqlCommand consulta = new MySqlCommand(sql, conn);
                    consulta.Parameters.AddWithValue("@jovem", jovem);
                    conn.Open();
                    MySqlDataReader registro;
                    registro = consulta.ExecuteReader();
                    registro.Read();


                    if (registro.HasRows)
                    {
                        senhaCadastrada = registro["senha_usuario"].ToString();
                        if (senhaCadastrada == senha)
                        {
                            return true;
                        
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                catch(MySqlException ex)
                
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
               
        }

        public string mostrarNome()
        {
            return nome;
        }

        public string mostrarSenha()
        {
            return senha;
        }
        public string mostrarPrivilegio()
        {
            return privilegio;
        }
    }
}
