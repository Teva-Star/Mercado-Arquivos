using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado_Arquivos.Entities
{
    internal class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco{ get; set; }
        
        public Produto(string nome, double preco,int id)
        {
            Id = id;
            Nome = nome;
            Preco = preco;

        }



    }
}
