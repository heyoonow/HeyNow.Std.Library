using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeyNow.Std.Model.MemoryNote
{
    [Table("Items")]
    public class Stock
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        [MaxLength(8)]
        public string Symbol { get; set; }
    }
}
