using HeyNow.Std.Extend;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeyNow.Std.Model.MemoryNote
{
    [Table("T_Memo")]
    public class MemoModel
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Idx { get; set; }
        public string Contents { get; set; }
        public int Count { get; set; } = 0;
        public bool Favorit { get; set; } = false;
        public DateTime RegDT { get; set; }
        public DateTime? ModifyDT { get; set; } = null;
        [Ignore]
        public bool IsModify { get; set; } = false;
        //[Ignore]
        public int ContentsLength { get; set; } = 0;

        public MemoModel()
        {
            RegDT = DateTime.Now;
        }
    }
}
