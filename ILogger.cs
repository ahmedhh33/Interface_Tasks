using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTasks
{
    internal interface ILogger
    {
        void LogInfo(string message);
        void LogError(string Errormessage);
    }
    internal class FileLogger : ILogger
    {
        private string fileName;

        public FileLogger(string fileName)
        {
            this.fileName = fileName;
        }

        public void LogInfo(string message)
        {
            // Write the message to a file.
            Console.WriteLine($"{fileName} {message} ");
        }

        public void LogError(string errorMessage)
        {
            // Write the error message to a file.
            Console.WriteLine($" {fileName} {errorMessage} ");
        }
    }

    internal class DatabaseLogger : ILogger
    {
        private string TelecomDatabase;

        public DatabaseLogger(string telecomdatabase)
        {
            this.TelecomDatabase = telecomdatabase;
        }

        public void LogInfo(string message)
        {
            Console.WriteLine($"{TelecomDatabase} {message} ");
        }

        public void LogError(string errorMessage)
        {
            Console.WriteLine($" {TelecomDatabase } {errorMessage} ");
        }
    }
}
