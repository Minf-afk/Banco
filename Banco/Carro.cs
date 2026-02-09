using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Banco
{

    public class Carro
    {

        public string Modelo { get; set; }
        public int Velocidade { get; set; }
        public string Tipo_combustivel { get; set; }
        public string Seguranca { get; set; }
        public string DescricaoDetalhada => $"Modelo do carro: {this.Modelo} atingindo a velocidade máxima de : {this.Velocidade} com o combustível: {this.Tipo_combustivel} e possuí o método de segurança {this.Seguranca}";
        //public void Acelerar()
        //{
        //    Console.WriteLine($"O {Modelo} tem velocidade máxima de {Velocidade}\n");
        //}
        //public void Frear()
        //{
        //    Console.WriteLine($"O {Modelo} está freando\n");
        //}

        //public void Buzinar()
        //{
        //    Console.WriteLine($"BIIIIIIIIIIII!!!\n");
        //}
    }

}
