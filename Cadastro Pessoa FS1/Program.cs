// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Cadastro_Pessoa_FS1.Classes;

Console.WriteLine(@$"
*******************************************
|...Bem vindo ao sistema de cadastro de...|
|.......pessoas físicas e juridicas.......|
*******************************************
");

BarraCarregamento("Carregando", 500);

string? opcao;
do
{
    Console.Clear();
    Console.WriteLine(@$"
    ===========================================
    |      Escolha uma das opções abaixo:     |
    |-----------------------------------------|
    |           1 - Pessoa Física             |
    |          2 - Pessoa Jurídica            |
    |                                         |
    |                0 - Sair                 |
    ===========================================
    ");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":

            PessoaFisica metodoPf = new PessoaFisica();

            PessoaFisica novaPf = new PessoaFisica();
            Endereco novoEnd = new Endereco();

            novaPf.nome = "Joelma";
            novaPf.dataNascimento = "16/06/1992";
            novaPf.cpf = "123456789";
            novaPf.rendimento = 15000.5f;

            novoEnd.logradouro = "Rua Senai";
            novoEnd.cep = "4000000";
            novoEnd.numero = 07;
            novoEnd.complemento = "Do lado da Mercado Big";
            novoEnd.cidade = "Salvador";
            novoEnd.estado = "Bahia";
            novoEnd.endResidencial = true;

            novaPf.endereco = novoEnd;


            // bool dataValida = metodoPf.ValidarDataNascimento(novaPf.dataNascimento);

            //Console.WriteLine("Nome: " + novaPF.nome);
            // Console.WriteLine($"Nome: {novaPf.nome}");
            // Console.WriteLine($"Endereço: {novaPf.endereco.logradouro}, numero: {novaPf.endereco.numero}, complemento: {novaPf.endereco.complemento}");
            
            Console.Clear();

            Console.WriteLine(@$"
            Nome: {novaPf.nome}
            Endereço: {novaPf.endereco.logradouro}, numero: {novaPf.endereco.numero}, complemento: {novaPf.endereco.complemento}
            Maior de idade: {(metodoPf.ValidarDataNascimento(novaPf.dataNascimento) ? "Sim" : "Não" )}
            Taxa de imposto a ser paga é: {metodoPf.PagarImposto(novaPf.rendimento).ToString("C")}
            ");


            novaPf.ValidarDataNascimento(new DateTime (1992,09,16));
            novaPf.ValidarDataNascimento("06/10/1989");

            Console.WriteLine($"Aperte 'Enter' para continuar");
            Console.ReadLine();

            break;
        case "2":
            PessoaJuridica metodoPj = new PessoaJuridica();

            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();

            novaPj.nome = "Nome pj";
            novaPj.cnpj = "00.000.000/0001-00";
            novaPj.razaoSocial= "Devcenter";
            novaPj.rendimento = 15000;

            novoEndPj.logradouro = "Rua Federal";
            novoEndPj.cep = "4100000";
            novoEndPj.numero = 06;
            novoEndPj.complemento = "Do lado da Farmacia D+";
            novoEndPj.cidade = "Salvador";
            novoEndPj.estado = "Bahia";
            novoEndPj.endResidencial = false;

            novaPj.endereco = novoEndPj;

            Console.Clear();

            Console.WriteLine(@$"
            Nome: {novaPj.nome}
            Razão Social: {novaPj.razaoSocial}
            CNPJ: {novaPj.cnpj}
            CNPJ válido: {(metodoPj.ValidadrCnpj(novaPj.cnpj) ? "Sim" : "Não")}
            Endereço: {novaPj.endereco.logradouro}, numero: {novaPj.endereco.numero}, complemento: {novaPj.endereco.complemento}
            Taxa de imposto a ser paga é: {metodoPj.PagarImposto(novaPj.rendimento).ToString("C")}
            ");

            //  Console.WriteLine($"{metodoPj.ValidadrCnpj("00.000.000/0000-00")}");
            Console.WriteLine($"{metodoPj.ValidadrCnpj("00000000000100")}");
            
            Console.WriteLine($"Aperte 'Enter' para continuar");
            Console.ReadLine();
            
            break;

        case "0":
            Console.Clear();
            Console.WriteLine("Obrigada por usar nosso sistema!");
            Thread.Sleep(2000);
            BarraCarregamento("Finalizando", 300);
           
            break;

        default:
            Console.Clear();
            Console.WriteLine($"Opção inválida, por favor digite 1 para pessoa Fisica, 2 para Pessoa Juridica, ou 0 para Sair");
            Thread.Sleep(5500);
            break;
    }   
} while (opcao != "0");

static void BarraCarregamento (string texto, int tempo){    
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.Write($"{texto} ");

            for (var i = 0; i < 10; i++)
            {
                Console.Write(". ");
                Thread.Sleep(tempo);  
            }
            Console.ResetColor();

}