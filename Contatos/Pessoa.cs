using System;
using SQLite;

namespace Contatos
{
    public class Pessoa
    {
        [PrimaryKey, AutoIncrement]
        public uint ID { get; set; }
        public String Nome { get; set; }
        public String Telefone { get; set; }
        public String Telefone2 { get; set; }
        public String email { get; set; }
        public String grupo { get; set; }
    }
}
