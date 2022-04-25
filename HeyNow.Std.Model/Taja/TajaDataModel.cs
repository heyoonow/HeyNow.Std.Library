using HeyNow.Std.Model.Taja.Type;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeyNow.Std.Model.Taja
{

    [Table("T_TajaData")]
    public class TajaDataModel: BaseModel
    {
        public string Text { get; set; }
        public TajaTextType Type { get; set; }
        public TajaLanguageType TypeLanguage { get; set; }

    }
}
