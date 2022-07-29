using System;
using System.Collections.Generic;

namespace CrudCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Menu Cliente:");
                Console.WriteLine("1 - cadastrar cliente");
                Console.WriteLine("2 - editar cliente");
                Console.WriteLine("3 - listar cliente");
                Console.WriteLine("4 - excluir cliente");
                Console.WriteLine("5 - sair");

                var opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        CadastrarCliente();
                        break;
                    case "2":
                        Console.Clear();
                        EditarCliente();

                        break;

                    case "3":
                        Console.Clear();
                        ListarClientes();
                        break;
                    case "4":
                        Console.Clear();
                        ExcluirCliente();
                        ListarClientes();
                        break;
                    case "5":
                        System.Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Opção não encontrada.");
                        break;
                }
            }

        }

        static void CadastrarCliente()
        {
            Console.WriteLine("Informe nome:");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe CPF:");
            var cpf = Console.ReadLine();
            Console.WriteLine("Informe idade:");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe senha:");
            var senha = Console.ReadLine();
            var variavelCliente = new Cliente(nome, cpf, senha, idade);
            Console.WriteLine(variavelCliente.Cpf);
            ListaDeCLiente.SalvarCliente(variavelCliente);
        }

        static void EditarCliente()
        {
            ListarClientes();
            Console.WriteLine("Informe o CPF que deseja editar:");
            var clienteCpfEditar = Console.ReadLine();
            var clienteEditar = ListaDeCLiente.BuscarClientePorCpf(clienteCpfEditar);
            if (clienteEditar == null)
            {
                Console.WriteLine("Cliente não encontrado.");
                return;
            }

            Console.WriteLine("Cliente:");
            Console.WriteLine("Nome atual: " + clienteEditar.Nome);
            Console.WriteLine("Digite novo nome caso queria atualizar:");
            var editarNome = Console.ReadLine();
            if (editarNome.Length>0)
            {
                clienteEditar.Nome = editarNome;
            }
            Console.WriteLine("Cpf atual: " + clienteEditar.Cpf);
            Console.WriteLine("Digite novo CPF caso queria atualizar:");
            var editarCpf = Console.ReadLine();
            if (editarCpf.Length>0)
            {
                clienteEditar.Cpf = editarCpf;
            }
            Console.WriteLine("Senha atual: " + clienteEditar.Senha);
            Console.WriteLine("Digite novo Senha caso queria atualizar:");
            var editarSenha = Console.ReadLine();
            if (editarSenha.Length>0)
            {
                clienteEditar.Senha = editarSenha;
            }
            Console.WriteLine("Idade atual: " + clienteEditar.Idade);
            Console.WriteLine("Digite novo Idade caso queria atualizar:");
            var editarIdade = Console.ReadLine();
            if (editarIdade.Length>0)
            {
                clienteEditar.Idade = int.Parse(editarIdade);
            }
            Console.WriteLine(clienteEditar.Nome + " " + clienteEditar.Cpf + " " + clienteEditar.Senha);
        }

        static void ExcluirCliente()
        {
            ListarClientes();
            Console.WriteLine("Informe o CPF que deseja excluir:");
            var clienteCpfExcluir = Console.ReadLine();
            if (ListaDeCLiente.ExcluirCliente(clienteCpfExcluir))
            {
                Console.WriteLine("Cliente excluido com sucesso.");
            }
            else
            {
                Console.WriteLine("Cliente não encontra");
            }
        }

        static void ListarClientes()
        {
            foreach (Cliente c in ListaDeCLiente.Clientes)
            {
                Console.WriteLine("Nome: " + c.Nome + " CPF: " + c.Cpf + " Idade: " + c.Idade + " Senha: " + c.Senha);
            }
        }

    }
}
