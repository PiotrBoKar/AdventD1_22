using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventD1_22
{
    internal class ReadFile
    {
        public static List<int> getNumArray(string dName)
        {
            string path = @"c:\AdventOfCode\" + dName + ".txt";
            string[] text = File.ReadAllLines(path);
            List<int> values = new List<int>(text.Length);
            foreach (string line in text)
            {
                int value;
                if (int.TryParse(line, out value))
                {
                    values.Add(value);
                }
                else
                {
                    values.Add(0);
                }
            }
            return values;
        }
    }
}

