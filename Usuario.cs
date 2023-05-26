using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        public bool verificasenha(string usuario, string senha) // esse metodo vai ver se é true ou false por isso retorna o tipo boolean

        {
         
            if(usuario !=""&& senha!="")
            {
                return true;
           
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
