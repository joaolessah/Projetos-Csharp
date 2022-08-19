namespace BancoCSharp.Entities
{
    public class Titular
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco {get; set; } // vou precisar instanciar um objeto do tipo enderço

        public Titular (string nome, string cpf, string telefone)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
        }

        public Titular (string nome, string cpf, string telefone, Endereco endereco):this(nome, cpf, telefone){
            Endereco = endereco;
        }
         
    }
}