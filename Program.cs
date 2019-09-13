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
            //DataPharser dp = new DataPharser();
            string str = "aavfghdsh fsagijpo oito aagjgj ooffaadasd";
            var table = new Dictionary<string, int>();
            for (int i = 0; i < str.Length-1; i++)
            {
                var tmp = str[i].ToString() + str[i + 1].ToString();
                if (!table.ContainsKey(tmp))
                {
                    table.Add(tmp, 0);
                }
            }
            for (int i = 0; i < str.Length-1; i++)
            {
                var tmp = str[i].ToString() + str[i + 1].ToString();
                if(table.ContainsKey(tmp))
                {
                    table[tmp]++;
                }
            }
            foreach (var item in table)
            {
                Console.WriteLine(item);
            }
        }
    }
}
