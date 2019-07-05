using BatPrismTutorial.Services;
using SQLite;
using System;
using System.IO;

namespace BatPrismTutorial.iOS.Services
{
    public class SQLiteConnectionProvider : ISQLiteConnectionProvider
    {
        private SQLiteConnection Connection { get; set; }

        public SQLiteConnection GetConnection()
        {
            if (this.Connection != null) { return this.Connection; }

            var path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            path = Path.Combine(path, "..", "Library", "database.db3");
            return this.Connection = new SQLiteConnection(path);
        }
    }
}