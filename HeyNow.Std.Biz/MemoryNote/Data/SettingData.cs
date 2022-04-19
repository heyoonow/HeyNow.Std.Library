using HeyNow.Std.Dac.SqlLiteRepositry.MemoryNote;
using HeyNow.Std.Model.MemoryNote;
using HeyNow.Std.Model.MemoryNote.App;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeyNow.Std.Biz.MemoryNote.Data
{
    public class SettingData
    {
        private static SettingData instance;
        public static SettingData Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SettingData();
                    
                }
                return instance;
            }
        }

        private SettingModel setting;
        public SettingModel Setting
        {
            get;set;
        }

        public void LoadSetting(bool force = false)
        {
            

            if (Setting == null || force == true)
            {
                var dac = new SettingDac();
                int count = dac.CountTotal();
                if (count == 0)
                {
                    dac.Insert(new SettingModel());
                }
                Setting = dac.Get(0);
            }
        }


    }
}
