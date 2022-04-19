using HeyNow.Std.Biz.MemoryNote.Data;
using HeyNow.Std.Dac.SqlLiteRepositry.MemoryNote;
using HeyNow.Std.Model.MemoryNote;
using HeyNow.Std.Model.MemoryNote.App;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeyNow.Std.Biz.MemoryNote
{
    public class MemoBiz
    {
        MemoDac dac;
        public MemoBiz()
        {
            dac = new MemoDac();
        }

        public void Create(string contents)
        {
            var newItem = new MemoModel()
            {
                Contents = contents,
                ContentsLength = contents.Length,
                
                Count = 0,
            };
            
            dac.Insert(newItem);
        }
        public void Modify(MemoModel model, string contents)
        {
            model.Contents = contents;
            model.ModifyDT = DateTime.Now;
            dac.Update(model);
        }

        public int Insert(MemoModel model)
        {
            return dac.Insert(model);
        }
        public List<MemoModel> GetList(MemoSearchModel search)
        {
            var list = dac.GetList(search);
            return list;
        }

        public MemoModel Get(int idx)
        {
            var model =  dac.Get(idx);
            model.Count++;
            dac.Update(model);
            return model;
        }

        public int Update(MemoModel model)
        {
            return dac.Update(model);
        }
        public int Delete(MemoModel model)
        {
            return dac.Delete(model);
        }
        public List<MemoOrderModel> GetOrderData()
        {
            return StaticData.Instance.GetOrderData();
        }
    }
}
