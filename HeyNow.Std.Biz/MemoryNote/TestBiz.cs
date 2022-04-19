using HeyNow.Std.Dac.SqlLiteRepositry.MemoryNote;
using HeyNow.Std.Model.MemoryNote;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeyNow.Std.Biz.MemoryNote
{
    public class TestBiz
    {
        public List<Stock> Get()
        {
            var stock = new StockTest();
            return stock.Get();
        }
    }
}
