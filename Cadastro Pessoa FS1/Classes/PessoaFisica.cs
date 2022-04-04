using Cadastro_Pessoa_FS1.Interfaces;

namespace Cadastro_Pessoa_FS1.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica

    {

        public string ?cpf { get; set; }

        public String ?dataNascimento { get; set; }     
        
               
        public bool ValidarDataNascimento(DateTime dataNasc)
        {
            DateTime dataAtual = DateTime.Today;
            
            double anos = (dataAtual - dataNasc).TotalDays/365;

            Console.WriteLine($"{anos}");

            if (anos >=18)
            {
                return true;
            }

            return false;  
        }

        public bool ValidarDataNascimento(String dataNasc)
        {
            DateTime dataConvertida;
            if (DateTime.TryParse(dataNasc, out dataConvertida))
            {
            DateTime dataAtual = DateTime.Today;
            
            double anos = (dataAtual - dataConvertida).TotalDays/365;

            Console.WriteLine($"{anos}");

            if (anos >=18){
                return true;
            }

            return false;
            }

            return false;
        }

        public override float PagarImposto(float rendimento){
            throw new NotImplementedException();
        }
    }
}