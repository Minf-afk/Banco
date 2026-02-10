using Banco;

//ContaBanco Maria = new ContaBanco();

//Maria.Numero_indicador = 1;
//Maria.Titular = "Maria de Jesus";
//Maria.Saldo = 1542.23;
//Maria.Senha = 123456;

//Console.WriteLine($"Digite seu nome completo:  \n");
//string digitacaoTitular = Console.ReadLine();
//if (digitacaoTitular == Maria.Titular)
//{
//    Console.WriteLine("Usuário autenticado devidamente \n");
//}
//else
//{
//    Console.WriteLine("Usuário não reconhecido\n");
//}
//Console.WriteLine("Digite a senha do usuário: \n");
//int senhaUsuario = int.Parse(Console.ReadLine());
//if (senhaUsuario == Maria.Senha)
//{
//    Console.WriteLine($"Usuário logado, saldo da conta: {Maria.Saldo}");
//}
//else
//{
//    Console.WriteLine("Senha errado, favor tentar novamente;");
//}

//Maria.ExibirInformacoes();


//Carro Fox = new Carro();
//Fox.Seguranca = "Air Bag";
//Fox.Velocidade = 200;
//Fox.Modelo = "Fox 2010 1.6";
//Fox.Tipo_combustivel = "Flex";

//Console.WriteLine(Fox.DescricaoDetalhada);

//Fox.Buzinar();
//Fox.Acelerar();
//Fox.Frear();

//Produto Arroz = new Produto();

//Arroz.Nome = "Arroz Branco";
//Arroz.Marca = "Tio João";
//Arroz.Preco = 15.85M;
//Arroz.Estoque = 155;

//Console.WriteLine(Arroz.InfoProd);

//Produto produtos = new Produto();

//Console.WriteLine("Digite o produto que deseja adicionar ao estoque: \n");
//produtos.Nome = Console.ReadLine();
//Console.Clear();

//Console.WriteLine("Digite a marca do produto: \n");
//produtos.Marca = Console.ReadLine();
//Console.Clear();

//Console.WriteLine("Digite o preço: \n");
//produtos.Preco = decimal.Parse(Console.ReadLine());
//Console.Clear();

//Console.WriteLine("Digite a quantidade em estoque: \n");
//produtos.Estoque = int.Parse(Console.ReadLine());
//Console.Clear();

//Console.WriteLine("Produto adicionado devidamente!");
//Thread.Sleep(2000);
//Console.Clear();

//Console.WriteLine(produtos.InfoProd);

//Titular Roberto = new Titular();    
//Conta Bradesco = new Conta();

//Roberto.NomeCompleto = "Roberto da Silva Souza";
//Roberto.Cpf = 12345645612;
//Roberto.Rg = 551852351;

//Bradesco.Agencia = 1589;
//Bradesco.NumeroConta = 123456;
//Bradesco.Titular = Roberto;
//Bradesco.Saldo = 1251;
//Bradesco.Limite = 3500;

//Console.WriteLine(Bradesco.MostrarInfo);

AcoesMercado acoes = new AcoesMercado();

while (true)
{
    Console.Clear();
    Console.WriteLine("Estoque do seu Zé!!\n");
    Console.WriteLine("1 - Adicionar produto");
    Console.WriteLine("2 - Listar produtos");
    Console.WriteLine("3 - Excluir produto");
    Console.WriteLine("0 - Sair");

    int opcao = int.Parse(Console.ReadLine() ?? "0");

    switch (opcao)
    {
        case 1:
            acoes.AdicionarProduto();
            break;
        case 2:
            acoes.ListarProdutos();
            break;
        case 3:
            acoes.ExcluirProdutos();
            break;
        case 0:
            return;
        default:
            Console.WriteLine("Opção inválida!");
            Console.ReadLine();
            break;
    }
}
