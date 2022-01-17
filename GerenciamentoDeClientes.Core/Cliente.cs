using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace GerenciamentoDeClientes.Core
{
    public class Cliente
    {
        [BsonId]
        public string Id { get; set; }
        public string Nome { get; set; }
        public string NickName { get; set; }
        public List<string> Contato { get; set; } = new List<string>();
    }
}
