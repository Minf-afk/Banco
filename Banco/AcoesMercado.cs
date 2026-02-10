using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Banco
{
    public class AcoesMercado
    {
        private List<Mercado> ListandoProd = new List<Mercado>();

        public void AdicionarProduto()
        {
            Mercado adicaoProduto = new Mercado();

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
            Console.WriteLine("Produto adicionado com sucesso!\n");
            Console.Clear();
            Thread.Sleep(1000);
        }

        public void ListarProdutos()
        {
            if (ListandoProd.Count == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado !\n");
                Console.ReadLine();
                return;
            }
            int i = 1;
            foreach (var item in ListandoProd)
            {
                Console.WriteLine($"{i}.Produto: {item.Produto} | Marca: {item.Marca} | Quantidade: {item.Quantidade} | Disponíveis: {item.DisponiveisEmEstoque}\n");
                i ++;
            }
            Console.ReadLine() ;

        }

        public void ExcluirProdutos()
        {
            ListarProdutos();

            Console.WriteLine("Digite o número do produto que deseja excluir: \n");
            int indice = int.Parse((Console.ReadLine() ?? "0"));

            int posicao = indice - 1;
            
            if(posicao < 0)
            {
                Console.WriteLine("Indice Inválido!");
                return;
            }

            ListandoProd.RemoveAt(posicao);
            Console.WriteLine("Produto removido de acordo !");

        }
    }
}
