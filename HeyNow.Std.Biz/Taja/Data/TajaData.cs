using HeyNow.Std.Dac.SqlLiteRepositry.Taja;
using HeyNow.Std.Model.Taja;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeyNow.Std.Biz.Taja.Data
{
    public class TajaData
    {
        private static TajaData instance;
        public static TajaData Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TajaData();

                }
                return instance;
            }
        }

        private TestDac testDac;
        public TajaData()
        {
            testDac = new TestDac();
        }

        public List<TajaDataModel> GetData()
        {
            return testDac.GetAllList();
        }



    }
}
