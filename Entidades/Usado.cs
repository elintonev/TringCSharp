using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treino_1.Entidades
{
    class Usado : Produtos
    {
        public DateTime DataFabricacao { get; set; }

        public Usado()
        {
                
        }

        public Usado(string nome, double preco, DateTime data) : base(nome, preco)
        {
            DataFabricacao = data;
        }


        public override string EtiquetaPreco()
        {
            return $"{Nome} (used) $ {Preco.ToString("F2", CultureInfo.InvariantCulture)} (Data de fabricação: {DataFabricacao.ToString("dd/MM/yyyy")})";
        }

    }
}
