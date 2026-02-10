using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    public class AcoesMercado
    {
        Mercado adicaoProduto = new Mercado();

        private List<Mercado> ListandoProd = new List<Mercado>();

        void AdicionarPorduto()
        {
            Console.WriteLine("Digite o nome do produto que deseja adicionar ao sistema: \n");
            adicaoProduto.Produto = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Digite a marca do produto: \n");
            adicaoProduto.Marca = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Digite a quantidade: \n");
            adicaoProduto.Quantidade = int.Parse(Console.ReadLine()  ?? "0");
            Console.Clear();

            ListandoProd.Add(adicaoProduto);
            Console.Clear();
            Thread.Sleep(1000);
        }

        void ListarProdutos()
        {
            
            
        }

        void ExcluirProdutos()
        {

        }
    }
}
