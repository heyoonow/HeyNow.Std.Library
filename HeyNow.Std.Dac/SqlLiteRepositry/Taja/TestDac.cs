using HeyNow.Std.Dac.IRepository.Taja;
using HeyNow.Std.Model.Taja;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeyNow.Std.Dac.SqlLiteRepositry.Taja
{
    public class TestDac : BaseSqlite<TajaDataModel>, ITestRepository
    {
        private TableQuery<TajaDataModel> table;

        public TestDac():base("tajadata.db")
        {
            table = db.Table<TajaDataModel>();
        }

        public int Delete(TajaDataModel model)
        {
            //return table.Delete(model);
            return 0;
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
            throw new NotImplementedException();
        }

        public int Update(TajaDataModel model)
        {
            throw new NotImplementedException();
        }
    }
}
