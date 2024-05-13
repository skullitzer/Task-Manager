using System;
using System.IO;
using SQLite;
using Midterm_2131419.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteDb_Android))]
namespace Midterm_2131419.Droid
{
    public class SQLiteDb_Android : ISQLiteDb
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