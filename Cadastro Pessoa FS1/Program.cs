// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Cadastro_Pessoa_FS1.Classes;

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


bool dataValida = metodoPf.ValidarDataNascimento(novaPf.dataNascimento);

//Console.WriteLine("Nome: " + novaPF.nome);
// Console.WriteLine($"Nome: {novaPf.nome}");
// Console.WriteLine($"Endereço: {novaPf.endereco.logradouro}, numero: {novaPf.endereco.numero}, complemento: {novaPf.endereco.complemento}");

Console.WriteLine(@$"
Nome: {novaPf.nome}
Endereço: {novaPf.endereco.logradouro}, numero: {novaPf.endereco.numero}, complemento: {novaPf.endereco.complemento}
Maior de idade: {dataValida}
");



novaPf.ValidarDataNascimento(new DateTime (1992,09,16));
novaPf.ValidarDataNascimento("06/10/1989");
