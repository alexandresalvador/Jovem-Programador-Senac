using System;
using System.Collections.Generic;

namespace Controllers
{
    public class PessoaController
    {
        public static void AddPessoa(
            string nome,
            string endereco,
            int idade,
            bool vivo,
            string email
        )
        {
            new Models.Pessoa(
                nome,
                endereco,
                idade,
                vivo,
                email
            );
        }

        public static List<Models.Pessoa> ListPessoas()
        {
            return Models.Pessoa.ListPessoas();
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
            Models.Pessoa.UpdatePessoa(
                index,
                nome,
                endereco,
                idade,
                vivo,
                email
            );
        }

        public static void DeletePessoa(int index)
        {
            Models.Pessoa.DeletePessoa(index);
        }

    }
}