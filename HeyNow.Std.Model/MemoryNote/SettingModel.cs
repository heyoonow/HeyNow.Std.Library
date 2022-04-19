using SQLite;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace HeyNow.Std.Model.MemoryNote
{
    public class SettingModel
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Idx { get; set; }
        public string BackgroundColor { get; set; } = "#FFFFFF";
        public string MemoListColor { get; set; } = "#FFFFFF";
        public string MemoDetailColor { get; set; } = "#FFFFFF";
        public SettingModel()
        {
        }
    }
}
