using System;
using System.Collections.Generic;

namespace Repositories
{
    public class PessoaRepository
    {
        static List<Models.Pessoa> pessoas = new List<Models.Pessoa>();

        public static void addPessoa(Models.Pessoa pessoa)
        {
            pessoas.Add(pessoa);
        }

        public static List<Models.Pessoa> ListPessoas()
        {
            return pessoas;
        }

        public static Models.Pessoa? GetPessoa(int index)
        {
            if (index < 0 || index >= pessoas.Count)
            {
                return null;
            }
            else
            {
                return pessoas[index];
            }
        }

        public static void UpdatePessoa(int index, Models.Pessoa pessoa)
        {
            pessoas[index] = pessoa;
        }

        public static void DeletePessoa(int index)
        {
            pessoas.RemoveAt(index);
        }

    }
}