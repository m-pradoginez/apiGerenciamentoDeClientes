using MongoDB.Driver;
using System.Collections.Generic;

namespace GerenciamentoDeClientes.Core
{
    public class ClienteServices : IClienteServices
    {
        private readonly IMongoCollection<Cliente> _clientes;
        public ClienteServices(IDbClient dbClient)
        {
            _clientes = dbClient.GetClientesCollection();
        }

        public Cliente AddCliente(Cliente cliente)
        {
            _clientes.InsertOne(cliente);
            return cliente;
        }

        public void DeleteCliente(string id)
        {
            _clientes.DeleteOne(cliente => cliente.Id == id);
        }

        public Cliente GetCliente(string id) => _clientes.Find(cliente => cliente.Id == id).First();

        public List<Cliente> GetClientes() => _clientes.Find(cliente => true).ToList();

        public Cliente UpdateCliente(Cliente cliente)
        {
            GetCliente(cliente.Id);
            _clientes.ReplaceOne(c => c.Id == cliente.Id, cliente);
            return cliente;
        }
    }
}
