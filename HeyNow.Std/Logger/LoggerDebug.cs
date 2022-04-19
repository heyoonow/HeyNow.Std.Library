using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace HeyNow.Std.Logger
{
    public static class LoggerDebug
    {

        public static void DebugInfo(this string log)
        {
            //Debug.WriteLine($"[INFO][{DateTime.Now.ToString("HH:mm:ss")}] {log}");
            Console.WriteLine($"[INFO][{DateTime.Now.ToString("HH:mm:ss")}] {log}");
        }
    }
}
