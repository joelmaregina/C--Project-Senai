# :computer: ClientLab System :woman_student:

System developed by the company Troppo, with the objective of developing a customized system for registering and managing clients.

_Sistema desenvolvido pela empresa Troppo, com o objetivo de desenvolver um sistema customizado de cadastro e gestão de clientes._

<br>

## 📌 Features _(Funcionalidades)_ :

#### ♦ The developed system has these characteristics and functionalities _(O sistema desenvolvido possui as demais caracteristicas e funcionalides)_ :
-  The system stores the records of  natural people and juridical people; _(O sistema armazena os cadastros das pessoas físicas e jurídicas)_ ;
- The registration of  natural people is done with the following data: name, CPF and date of birth; _(O cadastro das pessoas físicas é feito com os seguintes dados: nome, CPF e data de nascimento)_;
- The registration of juridical people is done with the following data: name, CNPJ and corporate name; _(O cadastro das pessoas jurídicas é feito com os seguintes dados: nome, CNPJ e razão social)_;
- Both have an address and indicate whether the address is business or residential; _(Ambos possuem um endereço e indicam se o endereço é comercial ou residencial)_;
- The system stores the records in files (".txt" and ".csv" extensions). _(O sistema armazena os registros em arquivos (extensões ".txt" e ".csv"))_.

<br>

## :hammer_and_wrench: Technologies used _(Tecnologias usadas)_ :
<br>
<img src ="https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white"/>

[![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)](https://dotnet.microsoft.com/en-us/download)

<br>

## 	:bookmark_tabs: Project organization _(Organização do projeto)_ :

- Superclass: "Pessoa : IPessoa":
    - Subclass: "PessoaFisica : IPessoaFisica" and "Pessoa Juridica : IPessoaJuridica";
    - Class for "Pessoa" Composition: "Endereco".
- Interfaces:
    - IPessoa;
        - Method : PagarImposto();
    - IPessoaFisica;
        - Method: ValidarDataNascimento(); 
    - IPessoaJuridica;
        - Method: ValidadrCnpj().

<br>

 ## :heavy_check_mark: Installation prerequisites _(Pré-requisitos de instalação)_ :

- This project was developed with Windows 10 OS, Visual Studio Code IDE and DotNet 6.0 Framework (SDK) _(Este projeto foi desenvolvido com o SO Windows 10, IDE Visual Studio Code e o Framework DotNet 6.0 (SDK))_.

[![Visual Studio Code](https://img.shields.io/badge/VisualStudioCode-0078d7.svg?style=for-the-badge&logo=visual-studio-code&logoColor=white"/)](https://code.visualstudio.com/)
[![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)](https://dotnet.microsoft.com/en-us/download)

<br>

## 	:arrow_forward: Application execution _(Execucção da aplicação)_ :

To run the program, you must have downloaded and installed the [**.NET 6 SDK**](https://dotnet.microsoft.com/en-us/download) or higher, and follow these steps _(Para executar o programa é necessário ter realizado o download e instalação do .NET 6 SDK ou superior e seguir os seguintes passos)_ :

1. Open the terminal of your choice and clone the project _(Abra o terminal da sua preferencia e clone o projeto)_ :

````
git clone https://github.com/joelmaregina/CSharp-Project-Senai
````

2. Enter in the directory and run the project _(Entre no diretório e execute o projeto)_ :

`````
  cd Cadastro Pessoa FS1
  dotnet run
`````

<br>

## :warning: Common errors _(Erros comuns)_ :

1. Be sure for have download the correct version of the DotNet framework, you can check this up by terminal typing _(Certifique-se de ter baixado a versão correta do framework DotNet, você pode verificar isso digitando no terminal)_ : 

````
dotnet --version
````
2. Be sure of being in the correct path/folder before run the application _(Certifique-se de estar no caminho/pasta correto antes de executar o aplicativo)_ .

<br>
<hr>

## :handshake: Contributors (Contribuidores):

♦ [Joelma Regina - Junior FullStack Developer (Troppo)](https://github.com/joelmaregina)
<hr>

###### ***This work is part of the activities of the Senai EAD school's Fullstack course. _(Este trabalho faz parte das atividades do curso Fullstack da escola Senai EAD;)_;
###### ***Troppo is a fictitious company used during to the development of this activity. _(A Troppo é uma empresa fictícia utilizada durante o desenvolvimento desta atividade)_
