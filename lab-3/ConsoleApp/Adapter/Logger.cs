using System;

namespace Adapter
{
    public class Logger
    {
        private void LogMessage(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public virtual void Log(string message)
        {
            LogMessage(message, ConsoleColor.Green);
        }

        public virtual void Error(string message)
        {
            LogMessage(message, ConsoleColor.Red);
        }

        public virtual void Warn(string message)
        {
            LogMessage(message, ConsoleColor.DarkYellow);
        }
    }
}
