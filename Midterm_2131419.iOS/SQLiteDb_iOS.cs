using System;
using System.IO;
using SQLite;
using Midterm_2131419.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteDb_iOS))]
namespace Midterm_2131419.iOS
{
    public class SQLiteDb_iOS : ISQLiteDb
    {
        public SQLiteConnection GetConnection()
        {
            var dbName = "Tasks.db3";
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, dbName);
            return new SQLiteConnection(path);
        }
    }
}