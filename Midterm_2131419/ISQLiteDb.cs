using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm_2131419
{
    public interface ISQLiteDb
    {
        SQLiteConnection GetConnection();
    }
}