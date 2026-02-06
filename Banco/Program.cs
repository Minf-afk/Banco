using Banco;

ContaBanco Maria = new ContaBanco();

Maria.numero_indicador = 1;
Maria.titular = "Maria de Jesus";
Maria.saldo = 1542.23;
Maria.senha = 123456;

Console.WriteLine($"Digite seu nome completo:  \n");
string digitacaoTitular = Console.ReadLine();
if (digitacaoTitular == Maria.titular)
{
    Console.WriteLine("Usuário autenticado devidamente \n");
}
else
{
    Console.WriteLine("Usuário não reconhecido\n");
}
Console.WriteLine("Digite a senha do usuário: \n");
int senhaUsuario = int.Parse(Console.ReadLine());
if (senhaUsuario == Maria.senha)
{
    Console.WriteLine($"Usuário logado, saldo da conta: {Maria.saldo}");
}
else
{
    Console.WriteLine("Senha errado, favor tentar novamente;");
}


Maria.ExibirInformacoes();

Carro Fox = new Carro();
Fox.seguranca = "Air Bag";
Fox.velocidade = 200;
Fox.modelo = "Fox 2010 1.6";
Fox.tipo_combustivel = "Flex";

Fox.InfoCarro();
Fox.Buzinar();
Fox.Acelerar();
Fox.Frear();