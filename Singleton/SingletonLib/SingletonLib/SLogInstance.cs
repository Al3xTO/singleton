using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SingletonLib
{
    public class SLogInstance
    {

        private static string logFilePath = "";
        private SLogInstance(string lFilePath)
        {
            logFilePath = lFilePath;

            if (!File.Exists(logFilePath))
            {
                File.Create(logFilePath).Close();
            }
        }

        private static SLogInstance _instance;

        private static readonly object _lock = new object();

        public static SLogInstance GetInstace(string fileName)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SLogInstance(fileName);
                    }
                }
            }
            return _instance;
        }

        public void LogAction(string username, string action) 
        {
            try 
            {
                string logMessage = $"{DateTime.Now} = Користувач: {username} - Дія: {action}{Environment.NewLine}";
                File.AppendAllText(logFilePath, logMessage);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка логування: {ex.Message}");
            }
        }
    }
}
