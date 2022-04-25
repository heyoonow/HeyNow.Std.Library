using HeyNow.Std.Dac.IRepository.MemoryNote;
using HeyNow.Std.Model.MemoryNote;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeyNow.Std.Dac.SqlLiteRepositry.MemoryNote
{
    public class SettingDac : BaseSqlite<SettingModel>, ISettingRepository
    {
        TableQuery<SettingModel> table;
        public SettingDac() : base("memo.db")
        {
            table = db.Table<SettingModel>();
        }

        public int CountTotal()
        {
            
            return table.Count();
        }

        public int Delete(SettingModel model)
        {
            throw new NotImplementedException();
        }

        public SettingModel Get(int idx)
        {
            return table.FirstOrDefault();
        }

        public List<SettingModel> GetAllList()
        {
            throw new NotImplementedException();
        }

        public int Insert(SettingModel model)
        {
            return db.Insert(model);
        }

        public int Update(SettingModel model)
        {
            return db.Update(model);
        }
    }
}
