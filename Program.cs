using System;
using System.Collections.Generic;

namespace Encryption_Task3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DataPharser dp = new DataPharser();
            string str = dp.getMessage("Message.txt");
            var table = new Dictionary<string, int>();
            var count = 0;
            for (int i = 0; i < str.Length - 1; i++)
            {
                var tmp = str[i].ToString() + str[i + 1].ToString();
                if (table.ContainsKey(tmp))
                {
                    table[tmp]++;
                }
                else
                {
                    table.Add(tmp, 1);
                    count++;
                }
            }
            Console.WriteLine("Исходное сообщение: " + str);
            foreach (var item in table)
            {
                Console.WriteLine("item - {0}, frequency {1:0.###}", item, (double)item.Value / count);
            }
        }
    }
}