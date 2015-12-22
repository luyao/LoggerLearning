using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warptele.Logger
{
    using VS.Logger;
    public static class GlobalLoger
    {
        public static Logger mLogger;
        public static Logger instance(string path)
        {
            if(null == mLogger)
            {
                mLogger = Logger.singleton(path);
            }
            return mLogger;
        }
        public static void ShutDown(string path)
        {
            GlobalLoger.instance(path).shutdown();
        }

        public static void Fatal(string path, string message)
        {
            GlobalLoger.instance(path).log(0, "", message);
        }
        public static void Error(string path, string message)
        {
            GlobalLoger.instance(path).log(1, "", message);
        }
        public static void Warning(string path, string message)
        {
            GlobalLoger.instance(path).log(2, "", message);
        }
        public static void Trace(string path, string message)
        {
            GlobalLoger.instance(path).log(3, "", message);
        }
        public static void Debug(string path, string message)
        {
            GlobalLoger.instance(path).log(4, "", message);
        }
    }

}
