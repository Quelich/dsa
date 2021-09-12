using System;
using System.Collections.Generic;
namespace SOLs
{
    public class StringAddition
    {
        public string AddStrings(string num1, string num2)
        {
            List<int> num1_to = parseString(num1);
            List<int> num2_to = parseString(num2);
            Console.WriteLine("First list: " + printALL(num1_to));
            Console.WriteLine("Second list: " + printALL(num2_to));
            Console.WriteLine("First list converted into int: " + toNumber(num1_to));
            Console.WriteLine("Second list converted into int: " + toNumber(num2_to));
            long result = toNumber(num1_to) + toNumber(num2_to);
            return IntToString(result);
        }

        public string printALL(List<int> input)
        {
            string output = "";
            output += "[";
            foreach (var VARIABLE in input)
            {
                output += " " + VARIABLE.ToString();
            }
            output += "]";
            return output;
        }
        public string IntToString(long a)
        {    
            var chars = new[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            var str = string.Empty;
            if (a == 0)
            {
                str = chars[0];
            }
            else if (a == int.MinValue)
            {
                str = "-9223372036854775808";
            }
            else
            {
                bool isNegative = (a < 0);
                if (isNegative)
                {
                    a = -a;
                }

                while (a > 0)
                {
                    str = chars[a % 10] + str;
                    a /= 10;
                }

                if (isNegative)
                {
                    str = "-" + str;
                }
            }

            return str;
        }
        private List<int> parseString(string input)
        {
            List<int> nums = new List<int>();
           
            foreach(var VARIABLE in input)
            {
                int num = 0;
                switch (VARIABLE)
                {
                    case '1':
                        num = 1;
                    break;
                    case '2':
                        num = 2;
                        break;
                    case '3':
                        num = 3;
                        break;
                    case '4':
                        num = 4;
                        break;
                    case '5':
                        num = 5;
                        break;
                    case '6':
                        num = 6;
                        break;
                    case '7':
                        num = 7;
                        break;
                    case '8':
                        num = 8;
                        break;
                    case '9':
                        num = 9;
                        break;
                    case '0':
                        num = 0;
                        break;
                }
            
                nums.Add(num);
                num = 0;
            }
            return nums;
        }

        private long toNumber(List<int> input)
        {
            int length = input.Count;
            long total = 0;
            for (int i = 0; i < length; i++)
            {
                total += (input[i] * pow(10, length - (i + 1)));
            }

            return total;
        }
        private long pow(int a, int b)
        {
            if (b == 0)
                return 1;
            long answer = a;
            long increment = a;
            int i, j;
            for (i = 1; i < b; i++) {
                for (j = 1; j < a; j++) {
                    answer += increment;
                }
                increment = answer;
            }
            return answer;
        }
    }
}
