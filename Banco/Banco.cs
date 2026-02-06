using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    public class ContaBanco
    {
        public int numero_indicador;
        public string titular;
        public double saldo;
        public int senha;

        public void ExibirInformacoes()
        {
            Console.WriteLine($"A conta do(a) {titular} tem o saldo de {saldo}");
            return;
        }
    }
}
    