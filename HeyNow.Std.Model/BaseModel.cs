using SQLite;
using System;

namespace HeyNow.Std.Model
{
    public class BaseModel
    {
        [PrimaryKey, AutoIncrement, Column("Idx")]
        public int Idx { get; set; }
    }
}
