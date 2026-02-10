using System;

namespace Banco
{
    public class Titular
    {
        public string NomeCompleto { get; set; } = "";
        public int Rg { get; set; }
        public long Cpf { get; set; }
    }

    public class Conta
    {
        public Titular Titular { get; set; } = new Titular();
        public int Agencia { get; set; }
        public int NumeroConta { get; set; }
        public decimal Saldo { get; set; }
        public decimal Limite { get; set; }

        public string MostrarInfo =>
            $"O Sr(a) {Titular.NomeCompleto} está logado na conta {Agencia}/{NumeroConta} possuindo o saldo de: {Saldo:C} e limite: {Limite:C}.";
    }
}
