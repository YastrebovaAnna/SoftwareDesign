using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SmartFileReaders
{
    public class SmartTextReader : ITextReader
    {
        public char[][] ReadFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            return lines.Select(line => line.ToCharArray()).ToArray();
        }
    }
}
