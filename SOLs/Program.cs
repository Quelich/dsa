using System;
using SOLs;
using System.Collections.Generic;

namespace SOLs
{
    class Program : Utils
    {
        static void Main(string[] args)
        {
            var ip = new Utils();
            ip.DefangIPaddr("1.1.1.1");

        }
    }
}
