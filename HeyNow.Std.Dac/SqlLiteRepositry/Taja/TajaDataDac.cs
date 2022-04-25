using HeyNow.Std.Dac.IRepository.Taja;
using HeyNow.Std.Model.Taja;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeyNow.Std.Dac.SqlLiteRepositry.Taja
{
    public class TajaDataDac : BaseSqlite<TajaDataModel>, ITajaDataRepository
    {
        private TableQuery<TajaDataModel> table;

        public TajaDataDac() : base("tajadata.db")
        {
            table = db.Table<TajaDataModel>();
        }
        public int Delete(TajaDataModel model)
        {
            return db.Delete(model);
        }

        public TajaDataModel Get(int idx)
        {
            throw new NotImplementedException();
        }

        public List<TajaDataModel> GetAllList()
        {
            return table.ToList();
        }

        public int Insert(TajaDataModel model)
        {
            return db.Insert(model);
        }

        public int Update(TajaDataModel model)
        {
            throw new NotImplementedException();
        }
    }
}
