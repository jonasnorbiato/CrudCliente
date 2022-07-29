using System;
using System.Collections.Generic;

namespace CrudCliente
{
    class ListaDeCLiente
    {
        public static List<Cliente> Clientes { get; set; }

        static ListaDeCLiente()
        {
            Clientes = new List<Cliente>();
        }
        public static void SalvarCliente(Cliente cliente)
        {
            Clientes.Add(cliente);
        }

       
        public static bool ExcluirCliente(string cpf)
        {
            var clienteExcluir = ListaDeCLiente.BuscarClientePorCpf(cpf);
            if (clienteExcluir != null)
            {
                Clientes.Remove(clienteExcluir);
                return true;
            }
            return false;
        }

        public static Cliente BuscarClientePorCpf(string cpf)
        {
            foreach (Cliente c in Clientes)
            {
                if (c.Cpf == cpf)
                { 
                    return c;
                }
            }
            return null;
        }
    }
}
