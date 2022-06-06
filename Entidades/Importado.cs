using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treino_1.Entidades;

namespace Treino_1
{
    class Importado : Produtos
    {
        public double Imposto { get; set; }

        public Importado()
        {
                
        }

        public Importado(string nome, double preco, double imposto) : base(nome, preco)
        {
            Imposto = imposto;

        }

        public void TaxaImportacao(double imposto) {
                Preco += imposto;
        
        }

        public override string EtiquetaPreco()
        {
            return  $"{Nome}: {Preco.ToString("F2", CultureInfo.InvariantCulture)} (Taxa de importação: $ {Imposto.ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
