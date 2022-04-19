using HeyNow.Std.Model.MemoryNote.Type;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeyNow.Std.Model.MemoryNote.App
{
    public class MemoSearchModel : Paging
    {
        public string SearchText { get; set; }
        public MemoOrderType MemoOrderType { get; set; }
    }
}
