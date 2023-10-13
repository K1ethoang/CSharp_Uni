using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cau_1_2
{
    internal class Cau_2
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = Encoding.UTF8;

            string s;

            Console.Write("Nhập chuỗi s: ");
            s = Console.ReadLine();

            Console.WriteLine("\t---Kết quả---\n");

            Dictionary<char, int> resDic = new Dictionary<char, int>();

            s = s.ToLower();

            foreach (char c in s)
            {
                if (c == ' ')
                    continue;
                if (resDic.ContainsKey(c))
                    resDic[c]++;
                else
                    resDic.Add(c, 1);
            }

            int maxValue = 0;
            foreach (var v in resDic)
            {
                if (v.Value > maxValue)
                    maxValue = v.Value;
            }

            foreach (var v in resDic)
            {
                if (v.Value == maxValue)
                    Console.WriteLine(v.Key + " - " + v.Value);
            }

            Console.ReadKey();
        }
    }
}
