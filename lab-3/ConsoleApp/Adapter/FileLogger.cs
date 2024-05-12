
namespace Adapter
{
    public class FileLogger : Logger
    {
        private FileWriter fileWriter;

        public FileLogger(string path)
        {
            fileWriter = new FileWriter(path);
        }

        public override void Log(string message)
        {
            fileWriter.WriteLine("Log: " + message);
        }

        public override void Error(string message)
        {
            fileWriter.WriteLine("Error: " + message);
        }

        public override void Warn(string message)
        {
            fileWriter.WriteLine("Warn: " + message);
        }
    }

}
