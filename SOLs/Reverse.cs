using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace SOLs
{
    public class Reverse
    {
        public int reverse(int x)
        {
            if (x < Int32.MaxValue - 1 || x > Int32.MinValue)
            {
                int reversed = 0;

                if (x < 0) //negative
                {
                    int Length = x.ToString().Length - 1;
                    while (x < 0)
                    {
                        int rim = x % 10;
                        reversed += -1 * rim * (int)Math.Pow(10, Length - 1);
                        Length--;
                        x /= 10;
                    }
                    return reversed * -1;
                }

                if (x > 0) //positive
                {
                    int Length = x.ToString().Length;

                    while (x > 0)
                    {
                        int rim = x % 10; // 3
                        reversed += rim * (int)Math.Pow(10, Length - 1);
                        Length--;
                        x /= 10;
                    }

                    Console.WriteLine(reversed);
                    return reversed;
                }
            }
            
            
            return 0;
        }
    }
}
