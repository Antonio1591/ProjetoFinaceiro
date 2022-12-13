using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinaceiro.Modelo.Domain
{
    public class Login
    {
        public Login(string usuario, string senha)
        {
            this.Email = usuario;
            this.senha = senha;
        }


        public string Email;
        public string senha;
        public bool logado;


    }
}
