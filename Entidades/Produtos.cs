using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treino_1.Entidades
{
    public class Produtos
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produtos()
        {

        }

        public Produtos(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public virtual string  EtiquetaPreco() {

            return $"{Nome}: $ {Preco}";

        }

    }
}
