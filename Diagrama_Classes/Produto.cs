using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diagrama_Classes
{
    public class Produto
    {        
        public int ID_Produto { get; set; }
        public string Descrição { get; set; }
        public double Quantidade { get; set; }
        public string Categoria { get; set; }
        public bool Venda { get; set; }

        public void Registar_Produto()
        {
            throw new System.NotImplementedException();
        }
        public void Editar_Produto()
        {
            throw new System.NotImplementedException();
        }
        public void Remover_Produto()
        {
            throw new System.NotImplementedException();
        }
        public void Comprar_Produto()
        {
            throw new System.NotImplementedException();
        }
    }
}