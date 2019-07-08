using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace BatPrismTutorial.Services
{
    public interface ISQLiteConnectionProvider
    {
        //SQLiteConnection GetConnection();
        //Ahora usaremos conexion asincrona
        SQLiteAsyncConnection GetConnection();
    }
}
