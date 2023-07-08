using System;

namespace Models
{
    public class Usuario
    {
        public string Login { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public void Logar()
        {
            Console.WriteLine("Acessando o sistema...");
        }

    }
}