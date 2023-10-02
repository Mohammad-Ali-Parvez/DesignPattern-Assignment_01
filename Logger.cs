using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_SINGLETON_PATTERN_FOR_LOGGER_Assignment_01
{
    internal class Logger
    {
        // Private static variable to store the single instance of Logger
        private static Logger _instance;

        // Private constructor to prevent direct instantiation
        private Logger()
        {
        }

        // Public static method to get the single instance of Logger
        public static Logger GetInstance()
        {
            // This method returns the single instance of Logger, creating it if it doesn't exist
            if (_instance == null)
            {
                _instance = new Logger();
            }
            return _instance;
        }

        // Public method to log a message
        public void LogMessage(string message)
        {
            // Print the message to the console
            Console.WriteLine(message);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Get the Logger instance using Logger.GetInstance()
            Logger logger1 = Logger.GetInstance();

            // Log messages using the logger instance
            logger1.LogMessage("This is a log message from logger1");

            // Attempting to create a new instance directly will return the existing instance
            Logger logger2 = Logger.GetInstance();

            // Both logger1 and logger2 will refer to the same instance
            logger2.LogMessage("This is a log message from logger2");
        }
    }
}
