using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace jompay.web.seframework
{
    public class Extensions
    {
        public static void WaitFiveSeconds()
        {
            Thread.Sleep(5000);
        }

        public static void WaitTenSeconds()
        {
            Thread.Sleep(10000);
        }
    }
}
