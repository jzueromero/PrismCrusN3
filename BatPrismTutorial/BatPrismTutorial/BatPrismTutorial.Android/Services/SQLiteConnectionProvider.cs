using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using SQLite;
using System.IO;
using BatPrismTutorial.Services;

namespace BatPrismTutorial.Droid.Services
{
    class SQLiteConnectionProvider: ISQLiteConnectionProvider
    {
        //private SQLiteConnection Connection { get; set; }
        private SQLiteAsyncConnection Connection { get; set; }

        public SQLiteAsyncConnection GetConnection()
        {
            if (this.Connection != null) { return this.Connection; }

            var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            path = Path.Combine(path, "database.db3");
            return this.Connection = new SQLiteAsyncConnection(path);
        }

        /* public SQLiteConnection GetConnection()
         {
             if (this.Connection != null) { return this.Connection; }

             var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
             path = Path.Combine(path, "database.db3");
             return this.Connection = new SQLiteConnection(path);
         }*/


        public SQLiteAsyncConnection GetConnection()
        {
            if (this.Connection != null) { return this.Connection; }

            var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            path = Path.Combine(path, "database.db3");
            return this.Connection = new SQLiteAsyncConnection(path);
        }
    }
}