using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    public class Titular
    {
            public string NomeCompleto {  get; set; }
            public int Rg {  get; set; }
            public long Cpf { get; set; }
    }
    public class Conta
    {
        public Titular;
        public int Agencia { get; set; }
        public int NumeroConta { get; set; }
        public decimal Saldo { get; set; }
        public decimal Limite { get; set; }

        public string MostrarInfo => $"O Sr(a) {Titular} está logado na conta {Agencia}/{NumeroConta} possuindo o valor de : {Saldo} e Limite : {Limite} ";
    }
}   
    