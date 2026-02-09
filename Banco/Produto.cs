using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    public class Produto
    {
        public string Nome { get; set; }
        public string Marca { get; set; }

        private decimal _preco;
        private int _estoque;
        public decimal Preco { get => _preco; set
            {
                if (value >= 0)
                    _preco = value;
            }
        }
        public int Estoque
        {
            get => _estoque; set
            {
                if (value >= 0)
                    _estoque = value;
            }
        }
        public string InfoProd => $"O {Nome} da {Marca} tem o preço de: {_preco} e possuimos {Estoque} em estoque!"; 
    }
}
