using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataPharser dp = new DataPharser();
            string str = dp.getMessage("Message.txt");
            var table = new Dictionary<string, int>();
            for (int i = 0; i < str.Length-1; i++)
            {
                var tmp = str[i].ToString() + str[i + 1].ToString();
                if (table.ContainsKey(tmp))
                {
                    table[tmp]++;
                }
                else
                {
                    table.Add(tmp, 1);
                }
                
            }
           
            foreach (var item in table)
            {
                Console.WriteLine(item);
            }
        }
    }
}
