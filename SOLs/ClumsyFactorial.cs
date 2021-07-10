using System;
using System.Data;

namespace SOLs
{
    //PARTIALLY COMPLETE
    public class ClumsyFactorial
    {
        // public static void Main(string[] args)
        // {
        //     var n = 5;
        //     //Console.WriteLine(value );
        //     Clumsy(n);
        //     //Console.WriteLine(Clumsy(n));
        // }
        public static int Clumsy(int n)
        {
            var fact = n;
            var clumsyOperator = 4;// n = 10; clumsyOperator = 9
            var operations = string.Empty;
            for (var i = n; i > 0 ; i--) // Number of operations
            {
                if (clumsyOperator == 0)
                {
                    clumsyOperator = 4;
                }

                if (i == 1)
                {
                    operations += "1";
                    continue;
                }
                if (clumsyOperator == 4)
                {
                    fact *= i-1;
                    //Console.Write(i+"*");
                    operations += (i + " * ");
                }
                if (clumsyOperator == 3)
                {
                    fact /= i-1;
                    //Console.Write(i+"/");
                    operations += (i + " / ");
                }
                if (clumsyOperator == 2)
                {
                    fact += i-1;
                    //Console.Write(i+"+");
                    operations += (i + " + ");
                }
                if (clumsyOperator == 1)
                {
                    fact -= i-1;
                    //Console.Write(i+"-");
                    operations += (i + " - ");
                }
                clumsyOperator--;
              
            }

            ClumsyEvaluate(operations);
            var result = Convert.ToInt32(new DataTable().Compute(operations, " "));
            Console.WriteLine("Operations:" + operations);
            Console.WriteLine("Result: " + Convert.ToInt32(result));
            return result;
        }

        private static void ClumsyEvaluate<T>(T value)
        {
            Console.WriteLine("ClumsyEvaluate " + value);
        }
    }
}