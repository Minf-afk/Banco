using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    public class Titular
    {
            public string NomeCompleto {  get; set; }
            public int Conta {  get; set; }
            public int Agencia { get; set; }
            public decimal Saldo { get; set; }
            public decimal Limite { get; set; }
    }
    public class Conta
    {
        public Titular Titular { get; set; }
        public int Agencia { get; set; }
        public int NumeroConta { get; set; }
        public decimal Saldo { get; set; }
        public decimal Limite { get; set; }

}
    