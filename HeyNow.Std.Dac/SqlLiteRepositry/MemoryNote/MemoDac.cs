using HeyNow.Std.Dac.IRepository.MemoryNote;
using HeyNow.Std.Extend;
using HeyNow.Std.Model.MemoryNote;
using HeyNow.Std.Model.MemoryNote.App;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeyNow.Std.Dac.SqlLiteRepositry.MemoryNote
{
    public class MemoDac : BaseSqlite<MemoModel>, IMemoRepository
    {

        TableQuery<MemoModel> table;
        public MemoDac(): base("memo.db")
        {
            table = db.Table<MemoModel>();
        }
        public int Delete(MemoModel model)
        {
            return db.Delete(model);
        }

        public MemoModel Get(int idx)
        {
            return table.Where(x=>x.Idx == idx).FirstOrDefault();
        }

        public List<MemoModel> GetAllList()
        {
            return table.OrderByDescending(x=>x.Idx).ToList();
        }
        public List<MemoModel> GetList(MemoSearchModel search)
        {
            var query = table.Where(x => 1==1);

            if (search.SearchText.IsEmpty() == false)
            {
                query = query.Where(x => x.Contents.Contains(search.SearchText));
            }

            switch (search.MemoOrderType)
            {
                case Model.MemoryNote.Type.MemoOrderType.BASIC:
                    query = query.OrderByDescending(x => x.Favorit).ThenByDescending(x => x.RegDT);
                    break;
                case Model.MemoryNote.Type.MemoOrderType.DATE:
                    query = query.OrderByDescending(x => x.RegDT);
                    break;
                case Model.MemoryNote.Type.MemoOrderType.CONTENT_LANGTH:
                    query = query.OrderByDescending(x => x.ContentsLength).ThenByDescending(x => x.RegDT);
                    break;
                case Model.MemoryNote.Type.MemoOrderType.COUNT:
                    query = query.OrderByDescending(x => x.Count).ThenByDescending(x => x.RegDT);
                    break;
                case Model.MemoryNote.Type.MemoOrderType.MODIFY:
                    query = query.OrderByDescending(x => x.ModifyDT).ThenByDescending(x => x.RegDT);
                    break;
                default:
                    break;
            }

            return query.ToList();
        }
        public int Insert(MemoModel model)
        {
            return db.Insert(model);
        }

        public int Update(MemoModel model)
        {
            return db.Update(model);
        }
    }
}
