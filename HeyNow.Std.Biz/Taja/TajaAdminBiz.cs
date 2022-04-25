using HeyNow.Std.Dac.SqlLiteRepositry.Taja;
using HeyNow.Std.Model.Taja;
using HeyNow.Std.Model.Taja.Type;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeyNow.Std.Biz.Taja
{
    public class TajaAdminBiz
    {
        private TajaDataDac dac;
        public TajaAdminBiz()
        {
            dac = new TajaDataDac();
        }
        public List<TajaDataModel> GetAllData()
        {
            var data = dac.GetAllList();
            return data;
        }
        public int DeleteItem(TajaDataModel model)
        {
            return dac.Delete(model);
        }

        public void InsertWord(List<string> listWord)
        {
            foreach (var word in listWord)
            {
                var model = new TajaDataModel
                {
                    Text = word,
                    Type = TajaTextType.WORD,
                    TypeLanguage = TajaLanguageType.KOREAN,
                };
                dac.Insert(model);
            }
            
            
        }
    }
}
