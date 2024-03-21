using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Mercado_Arquivos.Entities;

namespace Mercado_Arquivos.Entities
{
    internal class Pedido
    {
       
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }

        public Pedido() { }
        public Pedido(Produto produto, int quantidade) { Produto = produto;
        Quantidade = quantidade; }

        public override string ToString()
        {
            return Produto.Id+","+Produto.Nome + "," + Produto.Preco + "," + Quantidade.ToString();
        }




    }
}
