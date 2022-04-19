using System;
using System.Collections.Generic;
using System.Text;

namespace HeyNow.Std.Extend
{
    public static class StringExtend
    {
        public static bool IsEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }
    }
}
