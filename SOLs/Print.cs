using System;
using System.Collections.Generic;
using System.Text;

namespace SOLs
{
    public class Print : Utils
    {
        public void PrintHelloWorld() => Console.WriteLine("Hello World");

        public void PrintElements(int[] array)
        {
            Console.Write("[");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            Console.Write("]");
        }
        public void PrintElements(string[] array)
        {
            Console.Write("[");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            Console.Write("]");
        }
        public void PrintElements(string array)
        {
            Console.Write("[");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            Console.Write("]");
        }
        public void PrintElements(IList<bool> list)
        {
            Console.Write("[");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            Console.Write("]");
        }
    }
}
