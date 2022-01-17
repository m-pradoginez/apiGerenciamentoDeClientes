using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace GerenciamentoDeClientes.Core
{
    public class DbClient : IDbClient
    {
        private readonly IMongoCollection<Cliente> _clientes;
        public DbClient(IOptions<ClienteDbConfig> clienteDbConfig)
        {
            var client = new MongoClient(clienteDbConfig.Value.MongoConnectionString);
            var database = client.GetDatabase(clienteDbConfig.Value.DatabaseName);
            _clientes = database.GetCollection<Cliente>(clienteDbConfig.Value.Clientes_Collection_Name);

        }
        public IMongoCollection<Cliente> GetClientesCollection() => _clientes;
    }
}
