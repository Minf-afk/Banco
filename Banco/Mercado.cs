using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Banco
{
    public class Mercado
    {
        public string Produto { get; set; } = "";
        public string Marca { get; set; } = "";
        public int Quantidade { get; set; }

        public int DisponiveisEmEstoque { get; private set; }

        public void InicializarEstoque()
        {
            DisponiveisEmEstoque = Quantidade;
        }
    }

}

