using HeyNow.Std.Model.MemoryNote.App;
using HeyNow.Std.Model.MemoryNote.Type;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeyNow.Std.Biz.MemoryNote.Data
{
    public class StaticData
    {
        private static StaticData instance;
        public static StaticData Instance
        {
            get
            {
                if (instance == null)
                    instance = new StaticData();
                return instance;
            }
        }
        public List<MemoOrderModel> GetOrderData()
        {
            var list = new List<MemoOrderModel>();

            list.Add(new MemoOrderModel { Name="기본 (즐겨찾기+등록일)", Code= MemoOrderType.BASIC });
            list.Add(new MemoOrderModel { Name="등록일", Code= MemoOrderType.DATE });
            list.Add(new MemoOrderModel { Name="수정일", Code= MemoOrderType.MODIFY });
            list.Add(new MemoOrderModel { Name="조회수", Code= MemoOrderType.COUNT});
            
            list.Add(new MemoOrderModel { Name="내용길이", Code= MemoOrderType.CONTENT_LANGTH });

            return list;
        }


        
    }
}
