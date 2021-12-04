using System;

namespace SOLs.QArray
{
    public class Bank
    {
        private int Length;
        private long[] Balance;

        public Bank(long[] balance)
        {
            Balance = balance;
            Length = balance.Length;
        }

        public bool Transfer(int account1, int account2, long money)
        {
            if ((account1 > Length || account1 < 0) || (account2 > Length || account2 < 0))
            {
                return false;
            }

            if (Balance[account1 - 1] < money)
            {
                return false;
            }

            Balance[account1 - 1] -= money;
            Balance[account2 - 1] += money;
            return true;
        }

        public bool Deposit(int account, long money)
        {
            if ((account > Length || account < 0))
            {
                return false;
            }
            Balance[account - 1] += money;
            return true;
        }

        public bool Withdraw(int account, long money)
        {
            if ((account > Length || account < 0))
            {
                return false;
            }
            if (Balance[account - 1] < money)
            {
                return false;
            }

            Balance[account - 1] -= money;
            return true;
        }
    }
}