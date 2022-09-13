using System;

namespace SOLs.QArray
{
    public class PlusOnee
    {
        public int[] PlusOne(int[] digits)
        {
            digits[digits.Length - 1]++;
            var isExceed = false;
            var array = new int[digits.Length + 1];
            for (var i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] == 10)
                {
                    digits[i] = 0;
                    if (i == 0)
                    {
                        isExceed = true;
                        for (var j = 1; j < digits.Length; j++)
                        {
                            array[j] = digits[j];
                        }
                        array[0]++;
                        break;
                    }
                    digits[i - 1]++;
                }
            }
            if (isExceed)
                return array;
            return digits;
        }
    }
}