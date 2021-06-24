using System;
using System.Text;

namespace SOLs
{
    public class add_binary
    {
        private static void Main(string[] args)
        {
            
        }
        public string AddBinary(string a, string b)
        {
            return null;
        }

        private string StringToBinary(string data)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var VARIABLE in data.ToCharArray())
            {
                sb.Append(Convert.ToString(VARIABLE, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }
    }   
}