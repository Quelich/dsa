using System;

namespace SOLs
{
    //Leetcode Problems: 1678
    public class GoalParser
    {
        // public static void Main(string[] args)
        // {
        //     var command = "G()()()()(al)";
        //     Console.WriteLine(Interpret(command));
        // }
        public static string Interpret(string command)
        {
            var result = string.Empty;
            for (var i = 0; i < command.Length;i++)
            {
                if (command[i].Equals('G'))result += "G";
                if (command[i].Equals('(') && command[i+1].Equals(')'))result += "o";
                if (command[i].Equals('(') && command[i + 1].Equals('a')) result += "al";
            }
            return result;
        }
    }
}