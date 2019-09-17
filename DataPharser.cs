using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Encryption_Task3
{
    internal class DataPharser
    {
        public string getMessage(string filePath)
        {
            using (StreamReader stream = new StreamReader(filePath, Encoding.Default))
            {
                var tmp = stream.ReadToEnd();
                char[] puctuations = { ',', '.', ' ', '!', '?', '-', '%', ' ' };
                char[] eng = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'V', 'X', 'Y', 'Z' };
                List<string> message = tmp.Split(puctuations).ToList();
                string result = "";
                foreach (var item in message)
                {
                    if (!string.IsNullOrEmpty(item))
                    {
                        if (!eng.Contains(char.ToUpper(item[0])) && !char.IsDigit(item[0]))
                        {
                            result += item.ToUpper();
                        }
                    }
                }
                return result;
            }
        }
    }
}