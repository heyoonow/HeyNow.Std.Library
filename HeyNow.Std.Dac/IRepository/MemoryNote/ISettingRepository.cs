using HeyNow.Std.Model.MemoryNote;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeyNow.Std.Dac.IRepository.MemoryNote
{
    public interface ISettingRepository : IBaseRepository<SettingModel>
    {
        int CountTotal();
    }
}
