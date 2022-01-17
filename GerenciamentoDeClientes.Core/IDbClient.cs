using MongoDB.Driver;

namespace GerenciamentoDeClientes.Core
{
    public interface IDbClient
    {
        IMongoCollection<Cliente> GetClientesCollection();
    }
}
