using System;
using System.Collections.Generic;
using System.Text;

namespace SOLs
{
    public class Print 
    {
        
        public void PrintElements<T>(IEnumerable<T> array)
        {
            Console.Write("[");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            Console.Write("]");
        }
      
    }
}
