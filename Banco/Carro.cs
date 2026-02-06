using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Banco
{

    public class Carro
    {
        public string Modelo;
        public int Velocidade;
        public string Tipo_combustivel;
        public string Segurança;

        public void InfoCarro()
        {
            Console.WriteLine($"O carro {Modelo} tem velocidade máxima de {Velocidade} e tem o tipo de combustível {Tipo_combustivel} e possui o acessório de Segurança: {Segurança}\n");
        }
        public void Acelerar()
        {
            Console.WriteLine($"O {Modelo} tem velocidade máxima de {Velocidade}\n");
        }
        public void Frear()
        {
            Console.WriteLine($"O {Modelo} está freando\n");
        }

        public void Buzinar()
        {
            Console.WriteLine($"BIIIIIIIIIIII!!!\n");
        }
    }

}
