using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdbConnect
{
    class AdbBrage
    {
        public static bool connect(string ip)
        {
            string result = Cmd.startcmd("adb",string.Format("connect {0}", ip));
            if (result.StartsWith("connected"))
            {
                return true;
            }
            return false;
        }
    }
}
