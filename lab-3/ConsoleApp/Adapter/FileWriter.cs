using System.IO;

namespace Adapter
{
    public class FileWriter
    {
        private string filePath;

        public FileWriter(string path)
        {
            filePath = path;
        }

        private void WriteToFile(string message, bool addNewLine)
        {
            using (var writer = new StreamWriter(filePath, true))
            {
                if (addNewLine)
                    writer.WriteLine(message);
                else
                    writer.Write(message);
            }
        }

        public void Write(string message)
        {
            WriteToFile(message, false);
        }

        public void WriteLine(string message)
        {
            WriteToFile(message, true);
        }
    }
}
