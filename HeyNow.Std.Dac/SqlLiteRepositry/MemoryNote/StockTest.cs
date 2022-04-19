using HeyNow.Std.Logger;
using HeyNow.Std.Model.MemoryNote;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeyNow.Std.Dac.SqlLiteRepositry.MemoryNote
{
    public class StockTest : IDisposable
    {
        private string DBPath;
        private SQLiteConnection db;
        
        public StockTest()
        {
            DBPath = System.IO.Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "SMSConvey.db");
            if (!System.IO.File.Exists(DBPath))
            {
                ("Database Create:" + DBPath).DebugInfo();

            }
            else
            {
                ("Already Database Created:" + DBPath).DebugInfo();
            }

            db = new SQLiteConnection(DBPath);
            db.CreateTable<Stock>();
            if (db.Table<Stock>().Count() == 0)
            {
                
                // only insert the data if it doesn't already exist
                var newStock = new Stock();
                newStock.Symbol = "Data1";
                db.Insert(newStock);
                newStock = new Stock();
                newStock.Symbol = "Data2";
                db.Insert(newStock);
                newStock = new Stock();
                newStock.Symbol = "Data3";
                db.Insert(newStock);
            }
        }

        public List<Stock> Get()
        {
            var list = db.Table<Stock>().ToList();
            return list;
        }

        public void Dispose()
        {
            db.Dispose();
        }

        

    }
}
