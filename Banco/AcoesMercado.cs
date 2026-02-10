using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    public class AcoesMercado
    {
        Mercado adicaoProduto = new Mercado();
        void AdicionarPorduto()
        {
            Console.WriteLine("Digite o nome do produto que deseja adicionar ao sistema: ");
            adicaoProduto.Produto = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("");
        }

        void ListarProdutos()
        {
            List <string> ListandoProd = new List<string> ();
            
        }

        void ExcluirProdutos()
        {

        }
    }
}
