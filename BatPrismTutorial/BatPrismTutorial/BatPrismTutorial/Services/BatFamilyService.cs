using System;
using System.Collections.Generic;
using System.Text;
using BatPrismTutorial.Model;
using SQLite;

namespace BatPrismTutorial.Services
{
    public class BatFamilyService : IBatFamilyService
    {
        private ISQLiteConnectionProvider ConnectionProvider { get; }
        private SQLiteConnection Connection { get; }

        public BatFamilyService(ISQLiteConnectionProvider connectionProvider)
        {
            this.ConnectionProvider = connectionProvider;
            this.Connection = this.ConnectionProvider.GetConnection();
            this.Connection.CreateTable<BatFamily>();
        }

        public void Delete(int id)
        {
            this.Connection.Delete<BatFamily>(id);
        }

        public IEnumerable<BatFamily> GetAll()
        {
            return this.Connection.Table<BatFamily>().ToList();
        }

        public BatFamily GetById(int id)
        {
            return this.Connection.Table<BatFamily>().FirstOrDefault(x => x.Id == id);
        }

        public void Insert(BatFamily todoItem)
        {
            this.Connection.Insert(todoItem);
        }

        public void Update(BatFamily todoItem)
        {
            this.Connection.Update(todoItem);
        }
    }
}
