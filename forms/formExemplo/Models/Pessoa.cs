using System;

namespace Models
{
    public class Pessoa : Usuario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Endereco { get; set; }
        public bool Vivo { get; set; }

        public Pessoa(
            string nome,
            string endereco,
            int idade,
            bool vivo,
            string email
        )
        {
            this.Nome = nome;
            this.Endereco = endereco;
            this.Idade = idade;
            this.Vivo = vivo;
            this.Email = email;

            Repositories.PessoaRepository.addPessoa(this);
        }

        public static List<Models.Pessoa> ListPessoas()
        {
            return Repositories.PessoaRepository.ListPessoas();
        }

        public static Pessoa? GetPessoa(int index)
        {
            return Repositories.PessoaRepository.GetPessoa(index);
        }

        public static void UpdatePessoa(
            int index,
            string nome,
            string endereco,
            int idade,
            bool vivo,
            string email
        )
        {
            Pessoa pessoa = Pessoa.GetPessoa(index);
            if (pessoa != null)
            {
                pessoa.Nome = nome;
                pessoa.Endereco = endereco;
                pessoa.Idade = idade;
                pessoa.Vivo = vivo;
                pessoa.Email = email;

                Repositories.PessoaRepository.UpdatePessoa(index, pessoa);
            }
        }

        public static void DeletePessoa(int index)
        {
            Pessoa pessoa = Pessoa.GetPessoa(index);
            if (pessoa != null)
            {
                Repositories.PessoaRepository.DeletePessoa(index);
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}. E tenho {Idade} anos. Moro em {Endereco}");
        }
        public void Despedida()
        {
            Console.WriteLine("Txau");
        }

        public override string ToString()
        {
            return $"----\n Nome: {Nome}\nIdade: {Idade}\nEndereço: {Endereco}\n Login: {Login}\n Email: {Email}\n Senha: {Senha} \n ----- \n";
        }

    }
}