using System;
using SOLs;
using SOLs.QArray;
using SOLs.HashTable;
using SOLs.DP;

namespace SOLs
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            Bank obj = new Bank(new long[] { 10, 100, 20, 50, 30 });
            bool param_1 = obj.Withdraw(3, 10);
            System.Console.WriteLine(param_1);
            bool param_2 = obj.Transfer(5, 1, 20);
            System.Console.WriteLine(param_2);
            bool param_3 = obj.Deposit(5, 20);
            System.Console.WriteLine(param_3);
            bool param_4 = obj.Transfer(3, 4, 15);
            System.Console.WriteLine(param_4);
            bool param_5 = obj.Withdraw(10, 50);
            System.Console.WriteLine(param_5);
        }
    }
}
