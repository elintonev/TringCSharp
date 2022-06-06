using System;
using Treino_1.Entidades;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treino_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaProdutos = new List<Produtos>();
            Console.Write("Entre com o número de produtos: ");
            int quantidadeProdutos = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantidadeProdutos; i++)
            {

                Console.WriteLine($"Dados do produto #{i}");
                Console.Write("Comum, usado ou importado (c/u/i) ? ");
                string tipoProduto = Console.ReadLine();

                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (tipoProduto == "c") {

                    listaProdutos.Add(new Produtos(nome, preco));

                }
                else if (tipoProduto == "u") {

                    Console.Write("Data de Fabricação (DD/MM/YYYY): ");
                    var dataFabricacao = DateTime.Parse(Console.ReadLine());

                    listaProdutos.Add(new Usado(nome, preco, dataFabricacao));

                }
                else {

                    Console.Write("Taxas de importação: ");
                    var imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    var importado = new Importado(nome, preco, imposto);
                    importado.TaxaImportacao(imposto);

                    listaProdutos.Add(importado);
                }
            }
            Console.WriteLine();

            foreach (var produto in listaProdutos)
            {
                Console.WriteLine(produto.EtiquetaPreco());
            }
            Console.ReadLine();
        }
    }
}
