using System;
using SQLite;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;

namespace Contatos
{
    public class PessoaItemDatabase
    {

        readonly SQLiteAsyncConnection database;

        public PessoaItemDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Pessoa>().Wait();
        }

        public Task<List<Pessoa>> GetItemsAsync()
        {
            return database.Table<Pessoa>().ToListAsync();
        }

        public Task<Pessoa> GetItemAsync(uint id)
        {
            return database.Table<Pessoa>().Where(i => i.ID == id).FirstOrDefaultAsync();

        }

        public Task<int> SaveItemAsync(Pessoa item)
        {
            if (item.ID == 0)
            {
                return database.InsertAsync(item);
            }

            return database.UpdateAsync(item);
        }

        public Task<int> DeleteItemAsync(Pessoa item)
        {
            return database.DeleteAsync(item);
        }

    }
}
