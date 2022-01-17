using System.Collections.Generic;

namespace GerenciamentoDeClientes.Core
{
    public interface IClienteServices
    {
        List<Cliente> GetClientes();
        Cliente GetCliente(string id);
        Cliente AddCliente(Cliente cliente);
        void DeleteCliente(string id);
        Cliente UpdateCliente(Cliente cliente);
    }
}
