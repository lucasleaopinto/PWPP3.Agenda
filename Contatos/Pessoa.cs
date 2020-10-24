using System;
using SQLite;

namespace Contatos
{
    public class Pessoa
    {
        [PrimaryKey, AutoIncrement]
        public uint ID { get; set; }
        public String Nome { get; set; }
        public String Celular { get; set; }
        public String Telefone { get; set; }
        public String Email { get; set; }
        public String Grupo { get; set; }
    }
}
