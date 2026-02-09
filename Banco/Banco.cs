using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    public class ContaBanco
    {
        public int Numero_indicador { get; set; }
        public string Titular {  get; set; }
        public double Saldo { get; set; }
        public int Senha { get; set; }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"A conta do(a) {Titular} tem o saldo de {Saldo}");
            return;
        }
    }
}
    