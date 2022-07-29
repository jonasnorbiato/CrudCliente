using System;

namespace CrudCliente
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Cpf { get; set; }
        public int Idade { get; set; }
        public Cliente(string nome, string cpf, string senha, int idade)
        {     
            Nome = nome;
            Cpf = cpf;
            Senha = senha;
            Idade = idade;
        }   
    }
}
