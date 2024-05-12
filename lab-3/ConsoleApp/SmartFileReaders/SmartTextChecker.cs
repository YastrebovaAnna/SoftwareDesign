using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFileReaders
{
    public class SmartTextChecker : ITextReader
    {
        private readonly ITextReader _reader;

        public SmartTextChecker(ITextReader reader)
        {
            _reader = reader;
        }

        public char[][] ReadFile(string filePath)
        {
            Console.WriteLine($"Opening file: {filePath}");
            char[][] result;
            try
            {
                result = _reader.ReadFile(filePath);
                int totalLines = result.Length;
                int totalChars = result.Sum(line => line.Length);
                Console.WriteLine($"Successfully read the file: {filePath}");
                Console.WriteLine($"Total lines: {totalLines}, Total characters: {totalChars}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {filePath} - {ex.Message}");
                throw;
            }
            finally
            {
                Console.WriteLine($"Closing file: {filePath}");
            }
            return result;
        }
    }
}
