using HeyNow.Std.Dac.Config;
using HeyNow.Std.Extend;
using HeyNow.Std.Logger;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeyNow.Std.Dac.SqlLiteRepositry
{
    public class BaseSqlLite<T>:IDisposable
    {
        private string dbPath;
        protected SQLiteConnection db;
        
        public BaseSqlLite(string dbName = "memo.db")
        {
            string path = string.Empty;
            if (AppConfig.LocalPath.IsEmpty())
                dbPath = System.IO.Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments),  dbName);
            else
                dbPath = System.IO.Path.Combine(AppConfig.LocalPath, dbName);

            if (!System.IO.File.Exists(dbPath))
            {
                ("Database Create:" + dbPath).DebugInfo();

            }
            else
            {
                ("Already Database Created:" + dbPath).DebugInfo();
            }

            db = new SQLiteConnection(dbPath, SQLiteOpenFlags.Create |
     SQLiteOpenFlags.FullMutex |
     SQLiteOpenFlags.ReadWrite);
            db.CreateTable<T>();
            
        }

        public void Dispose()
        {
            if (db != null)
                db.Dispose();
        }
    }
}
