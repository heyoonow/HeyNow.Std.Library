using System;
using System.Collections.Generic;
using System.Text;

namespace HeyNow.Std.Dac.IRepository
{
    public interface IBaseRepository<T>
    {
        int Insert(T model);
        List<T> GetAllList();
        T Get(int idx);
        int Update(T model);
        int Delete(T model);
    }
}
