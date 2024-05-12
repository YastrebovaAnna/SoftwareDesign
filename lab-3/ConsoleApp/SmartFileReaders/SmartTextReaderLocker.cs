using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SmartFileReaders
{
    public class SmartTextReaderLocker : ITextReader
    {
        private readonly ITextReader _reader;
        private readonly Regex _restrictedPattern;

        public SmartTextReaderLocker(ITextReader reader, string pattern)
        {
            _reader = reader;
            _restrictedPattern = new Regex(pattern, RegexOptions.IgnoreCase);
        }

        public char[][] ReadFile(string filePath)
        {
            if (_restrictedPattern.IsMatch(Path.GetFileName(filePath)))
            {
                Console.WriteLine("Access denied!");
                return new char[0][];
            }
            return _reader.ReadFile(filePath);
        }
    }
}
