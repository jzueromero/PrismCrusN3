using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BatPrismTutorial.Model;
using SQLite;

namespace BatPrismTutorial.Services
{
    public class BatFamilyService : IBatFamilyService
    {
        // private ISQLiteConnectionProvider ConnectionProvider { get; }
        //private SQLiteConnection Connection { get; }

        private ISQLiteConnectionProvider ConnectionProvider { get; }
        private SQLiteAsyncConnection Connection { get; }

        public BatFamilyService(ISQLiteConnectionProvider connectionProvider)
        {
            this.ConnectionProvider = connectionProvider;
            this.Connection = this.ConnectionProvider.GetConnection();
            this.Connection.CreateTableAsync<BatFamily>();
        }

        /*public void Delete(int id)
        {
            this.Connection.Delete<BatFamily>(id);
        }*/
        public async Task DeleteAsync(BatFamily todoItem)
        {
            await this.Connection.CreateTableAsync<BatFamily>();
            await this.Connection.DeleteAsync(todoItem);
        }


        /*public IEnumerable<BatFamily> GetAll()
        {
            return this.Connection.Table<BatFamily>().ToList();
        }*/
        public async Task<IEnumerable<BatFamily>> GetAllAsync()
        {
            await this.Connection.CreateTableAsync<BatFamily>();
            return await this.Connection.Table<BatFamily>().ToListAsync();
        }

        /*public BatFamily GetById(int id)
        {
            return this.Connection.Table<BatFamily>().FirstOrDefault(x => x.Id == id);
        }*/
        public async Task<BatFamily> GetByIdAsync(int id)
        {
            await this.Connection.CreateTableAsync<BatFamily>();
            return await this.Connection.Table<BatFamily>().Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        /* public void Insert(BatFamily todoItem)
         {
             this.Connection.Insert(todoItem);
         }*/
        public async Task InsertAsync(BatFamily todoItem)
        {
            await this.Connection.CreateTableAsync<BatFamily>();
            await this.Connection.InsertAsync(todoItem);
        }

        /* public void Update(BatFamily todoItem)
         {
             this.Connection.Update(todoItem);
         }*/
        public async Task UpdateAsync(BatFamily todoItem)
        {
            await this.Connection.CreateTableAsync<BatFamily>();
            await this.Connection.UpdateAsync(todoItem);
        }
    }
}
