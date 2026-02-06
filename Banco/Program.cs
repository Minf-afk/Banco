using Banco;

ContaBanco Maria =  new ContaBanco();

Maria.numero_indicador = 1;
Maria.titular = "Maria de Jesus";
Maria.saldo = 1542.23;
Maria.senha = 123456;

Console.WriteLine($"Digite por favor seu nome completo:  \n");
string digitacaoTitular = Console.ReadLine();
if (digitacaoTitular != Maria.titular)
{
    Console.WriteLine("Usuário autenticado devidamente ");
}
else
{
    Console.WriteLine("Usuário não reconhecido");
}