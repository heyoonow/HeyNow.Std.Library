using HeyNow.Std.Biz.Taja.Data;
using HeyNow.Std.Model.Taja;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeyNow.Std.Biz.Taja
{
    public partial class TajaBiz
    {
        private List<TajaDataModel> tajaData;
        private Random random;
        private string currentTaja;

        public string GetTajaData()
        {
            if (tajaData.Count == 0)
                tajaData = TajaData.Instance.GetData();

            int index = random.Next(0, tajaData.Count);
            var data = tajaData[index].Text.Trim();
            currentTaja = data;
            tajaData.RemoveAt(index);

            return data;
        }
    }
}
