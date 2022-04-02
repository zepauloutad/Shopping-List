using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diagrama_Classes
{
    public class Utilizador
    {
        public int ID_Utilizador { get; set; }
        public string Nome { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string País { get; set; }

        public Produto Produto
        {
            get => default;
            set
            {
            }
        }

        public Lista Lista
        {
            get => default;
            set
            {
            }
        }

        public void Login()
        {
            throw new System.NotImplementedException();
        }public void Logout()
        {
            throw new System.NotImplementedException();
        }public void Registar()
        {
            throw new System.NotImplementedException();
        }

        //public image Imagem { get; set; }
    }
}