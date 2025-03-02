﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Cadastro_Pessoa_FS1.Classes;

Console.WriteLine(@$"
*******************************************
|...Bem vindo ao sistema de cadastro de...|
|.......pessoas físicas e juridicas.......|
*******************************************
");

BarraCarregamento("Carregando", 500);

List<PessoaFisica> listaPf = new List<PessoaFisica>();
//List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

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

            string? opcaoPf;
            do
            {
                Console.WriteLine(@$"
    ===========================================
    |      Escolha uma das opções abaixo:     |
    |-----------------------------------------|
    |        1 - Cadastrar Pessoa Física      |
    |        2 - Listar Pessoas Físicas       |
    |                                         |
    |        0 - Voltar ao menu anterior      |
    ===========================================
    ");
                opcaoPf = Console.ReadLine();

                switch (opcaoPf)
                {
                    case "1":
                        PessoaFisica novaPf = new PessoaFisica();
                        Endereco novoEnd = new Endereco();

                        Console.WriteLine($"Digite o nome da Pessoa que deseja cadastrar: ");
                        novaPf.nome = Console.ReadLine();
                        
                        bool dataValida;
                        do
                        {
                            Console.WriteLine($"Digite a data de nascimento Ex: DD/MM/AAA: ");
                            string? dataNasc = Console.ReadLine();

                            dataValida = metodoPf.ValidarDataNascimento(dataNasc);
                            if (dataValida){
                                novaPf.dataNascimento = dataNasc;
                            } else{
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"Data digitada é inválida, por favor digite uma data válida");
                                Console.ResetColor();    
                            };
                            
                        } while (dataValida == false);

                        Console.WriteLine($"Digite o número do CPF");
                        novaPf.cpf= Console.ReadLine();

                        Console.WriteLine($"Digite o rendimento mensal (Somente números):  ");
                        novaPf.rendimento = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o logradouro");
                        novoEnd.logradouro= Console.ReadLine();

                        Console.WriteLine($"Digite o CEP");
                        novoEnd.cep = Console.ReadLine();

                        Console.WriteLine($"Digite o número do endereço");
                        novoEnd.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o complemento do endereço(Aperte ENTER para vazio) :");
                        novoEnd.complemento = Console.ReadLine();

                        Console.WriteLine($"Digite a cidade:");
                        novoEnd.cidade = Console.ReadLine();

                        Console.WriteLine($"Digite o estado:");
                        novoEnd.estado = Console.ReadLine();

                        Console.WriteLine($"Este endereço é residencial? S/N");
                        string EndCom = Console.ReadLine().ToUpper();

                        if (EndCom == "S"){
                            novoEnd.endResidencial = true;
                        } else {
                            novoEnd.endResidencial = false;
                        }                       

                        novaPf.endereco = novoEnd;
                        //***************************************************
                        //listaPf.Add(novaPf);

                        //StreamWriter sw = new StreamWriter($"{novaPf.nome}.text");
                        //sw.Write(novaPf.nome);
                        //sw.Close();
                        // Garante o fechamento sem o precisar usar o "sw.CLose();" :
                        using (StreamWriter sw = new StreamWriter($"{novaPf.nome}.txt"))
                        {
                            sw.WriteLine(@$"
                            Nome:{novaPf.nome}
                            Data de Nascimento: {novaPf.dataNascimento}
                            CPF: {novaPf.cpf}
                            Logradouro: {novaPf.endereco.logradouro}
                            CEP: {novaPf.endereco.cep}
                            Número: {novaPf.endereco.numero}
                            Complemento: {novaPf.endereco.complemento}
                            Cidade: {novaPf.endereco.cidade}
                            Estado: {novaPf.endereco.estado}
                            ");
                        }

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Cadastro realizado com sucesso!");
                        Thread.Sleep(3000);
                        Console.ResetColor();

                        break;
                    case "2":
                        Console.Clear();

                        if (listaPf.Count > 0)
                        {
                            foreach (PessoaFisica cadaPessoa in listaPf)
                            {
                                
                                Console.WriteLine(@$"
                                Nome: {cadaPessoa.nome}
                                Endereço: {cadaPessoa.endereco.logradouro}, numero: {cadaPessoa.endereco.numero}, complemento: {cadaPessoa.endereco.complemento}
                                Data de Nascimento: {cadaPessoa.dataNascimento}
                                Taxa de imposto a ser paga é: {metodoPf.PagarImposto(cadaPessoa.rendimento).ToString("C")}
                                ");
                        Console.WriteLine($"Aperte 'ENTER' para continuar");
                        Console.ReadLine();
                            }                            
                        } else {
                            Console.WriteLine($"Lista vazia!");
                            Thread.Sleep(2500);
                            
                        }

                        using (StreamReader sr =  new StreamReader("Joelma Regina.txt"))
                        {
                            string linha;
                            while ((linha = sr.ReadLine()) != null)
                            {
                              Console.WriteLine($"{linha}");
                            }
                        }
                        
                        Console.WriteLine($"Aperte 'ENTER' para continuar");
                        Console.ReadLine();

                        break;
                    case "0":
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine($"Opção inválida, por favor digite 1 para pessoa Fisica, 2 para Pessoa Juridica, ou 0 para Sair");
                        Thread.Sleep(5500);
                        
                        break;
                }
                               
            } while (opcaoPf != "0");
            break;
        case "2":
            PessoaJuridica metodoPj = new PessoaJuridica();

                        string? opcaoPj;
                        do
                        {
                            Console.WriteLine(@$"
                ===========================================
                |      Escolha uma das opções abaixo:     |
                |-----------------------------------------|
                |      1 - Cadastrar Pessoa Juridica      |
                |       2 - Listar Pessoas Juridica       |
                |                                         |
                |       0 - Voltar ao menu anterior       |
                ===========================================
                ");
                            opcaoPj = Console.ReadLine();

                            switch (opcaoPj)
                            {
                                case "1":
                                    PessoaJuridica novaPj = new PessoaJuridica();
                                    Endereco novoEnd = new Endereco();

                                    Console.WriteLine($"Digite o nome da Empresa que deseja cadastrar: ");
                                    novaPj.nome = Console.ReadLine();
                                    
                                    bool cnpjValido;
                                    do
                                    {
                                        Console.WriteLine($"Digite o CNPJ: ");
                                        string? cnpj = Console.ReadLine();

                                        cnpjValido = metodoPj.ValidadrCnpj(cnpj);
                                        if (cnpjValido){
                                            novaPj.cnpj = cnpj;
                                        } else{
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine($"o CNPJ digitado é inválido, por favor digite um CNPJ válido");
                                            Console.ResetColor();    
                                        };
                                        
                                    } while (cnpjValido == false);

                                    Console.WriteLine($"Digite a razão social");
                                    novaPj.razaoSocial = Console.ReadLine();

                                    Console.WriteLine($"Digite o rendimento mensal (Somente números):  ");
                                    novaPj.rendimento = float.Parse(Console.ReadLine());

                                    Console.WriteLine($"Digite o logradouro");
                                    novoEnd.logradouro= Console.ReadLine();

                                    Console.WriteLine($"Digite o CEP");
                                    novoEnd.cep = Console.ReadLine();

                                    Console.WriteLine($"Digite o número do endereço");
                                    novoEnd.numero = int.Parse(Console.ReadLine());

                                    Console.WriteLine($"Digite o complemento do endereço(Aperte ENTER para vazio) :");
                                    novoEnd.complemento = Console.ReadLine();

                                    Console.WriteLine($"Digite a cidade:");
                                    novoEnd.cidade = Console.ReadLine();

                                    Console.WriteLine($"Digite o estado:");
                                    novoEnd.estado = Console.ReadLine();

                                    Console.WriteLine($"Este endereço é residencial? S/N");
                                    string EndCom = Console.ReadLine().ToUpper();

                                    if (EndCom == "S"){
                                        novoEnd.endResidencial = true;
                                    } else {
                                        novoEnd.endResidencial = false;
                                    }                       

                                    novaPj.endereco = novoEnd;

                                    metodoPj.Inserir(novaPj);

                                    //listaPj.Add(novaPj);


                                    // Escreve um arquivo TXT:
                                    // using (StreamWriter sw = new StreamWriter($"{novaPj.nome}.txt"))
                                    // {
                                    //     sw.WriteLine(@$"
                                    //     Nome da empresa:{novaPj.nome}
                                    //     Razão Social: {novaPj.razaoSocial}
                                    //     CNPJ: {novaPj.cnpj}
                                    //     Logradouro: {novaPj.endereco.logradouro}
                                    //     CEP: {novaPj.endereco.cep}
                                    //     Número: {novaPj.endereco.numero}
                                    //     Complemento: {novaPj.endereco.complemento}
                                    //     Cidade: {novaPj.endereco.cidade}
                                    //     Estado: {novaPj.endereco.estado}
                                    //     ");
                                    // }

                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine($"Cadastro realizado com sucesso!");
                                    Thread.Sleep(3000);
                                    Console.ResetColor();

                                    break;
                                case "2":
                                    Console.Clear();

                                    List<PessoaJuridica> listaPj = metodoPj.Ler();

                                    foreach (PessoaJuridica cadaItem in listaPj)
                                    {
                                        Console.WriteLine(@$"
                                        Nome da empresa:{cadaItem.nome}
                                        Razão Social: {cadaItem.razaoSocial}
                                        CNPJ: {cadaItem.cnpj}
                                        ");
                                    }

                                    // if (listaPj.Count > 0)
                                    // {
                                    //     foreach (PessoaJuridica cadaPessoa in listaPj)
                                    //     {                                            
                                    //         Console.WriteLine(@$"
                                    //         Nome: {cadaPessoa.nome}
                                    //         Razão Social: {cadaPessoa.razaoSocial}
                                    //         CNPJ: {cadaPessoa.cnpj}
                                    //         Endereço: {cadaPessoa.endereco.logradouro}, numero: {cadaPessoa.endereco.numero}, complemento: {cadaPessoa.endereco.complemento}
                                    //         Taxa de imposto a ser paga é: {cadaPessoa.PagarImposto(cadaPessoa.rendimento).ToString("C")}
                                    //         ");
                                    //     }

                                    //     Console.WriteLine($"Aperte 'ENTER' para continuar");
                                    //     Console.ReadLine();                           
                                    // } else {
                                    //     Console.WriteLine($"Lista vazia!");
                                    //     Thread.Sleep(2500);
                                    // }                      
                                    break;
                                case "0":
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine($"Opção inválida, por favor digite 1 para pessoa Fisica, 2 para Pessoa Juridica, ou 0 para Sair");
                                    Thread.Sleep(5500);
                                    
                                    break;
                            }
                                        
                        } while (opcaoPj != "0");
                        
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