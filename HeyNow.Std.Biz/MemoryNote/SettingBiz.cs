using HeyNow.Std.Biz.MemoryNote.Data;
using HeyNow.Std.Dac.SqlLiteRepositry.MemoryNote;
using HeyNow.Std.Model.MemoryNote;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeyNow.Std.Biz.MemoryNote
{
    public class SettingBiz
    {
        SettingDac dac;
        public SettingBiz()
        {
            dac = new SettingDac();
        }

        public int Update(SettingModel model)
        {
            return dac.Update(model);
        }
        
    }
}
