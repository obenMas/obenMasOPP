using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BPS.Bussiness
{
    public class clsLog
    {
        public static void validateFile()
        {
            if (!Directory.Exists("C:/LogOben"))
            {
                Directory.CreateDirectory("C:/LogOben");
            }

            if (!File.Exists("C:/LogOben/logOben.txt"))
            {
                File.Create("C:/LogOben/logOben.txt");
            }
        }

        public static void addLog(Exception ex, int type, string place)
        {
            validateFile();
            string LogType = "";

            switch (type)
            {
                case 1:
                    LogType = "INF";
                    break;
                case 2:
                    LogType = "WAR";
                    break;
                case 3:
                    LogType = "ERR";
                    break;
            }

            string logEntry = "";

            logEntry += DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "\t";
            logEntry += clsGlobal.LoggedUser.userName + "\t";
            logEntry += LogType + "\t";
            logEntry += place + "\t";
            logEntry += "** " + ex.Message;

            StreamWriter sw = File.AppendText("C:/LogOben/logOben.txt");

            sw.WriteLine(logEntry);
            sw.Close();
        }

        public static void addLog(string message, int type, string place)
        {
            validateFile();
            string LogType = "";

            switch (type)
            {
                case 1:
                    LogType = "INF";
                    break;
                case 2:
                    LogType = "WAR";
                    break;
                case 3:
                    LogType = "ERR";
                    break;
            }

            string logEntry = "";

            logEntry += DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "\t";
            logEntry += clsGlobal.LoggedUser.userName + "\t";
            logEntry += LogType + "\t";
            logEntry += place + "\t";
            logEntry += "** " + message;

            StreamWriter sw = File.AppendText("C:/LogOben/logOben.txt");

            sw.WriteLine(logEntry);
            sw.Close();

        }

        public static string getLog(int type)
        {
            validateFile();
            return "";
        }

        public static void addLogMail(string message, int type, string place)
        {
            var pathConfig = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase), "mailLog.txt").Replace("file:\\", "");

            validateFileMail(pathConfig);
            string LogType = "";

            switch (type)
            {
                case 1:
                    LogType = "INF";
                    break;
                case 2:
                    LogType = "WAR";
                    break;
                case 3:
                    LogType = "ERR";
                    break;
            }

            string logEntry = "";

            logEntry += DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "\t";
            logEntry += clsGlobal.LoggedUser.userName + "\t";
            logEntry += LogType + "\t";
            logEntry += place + "\t";
            logEntry += "** " + message;

            StreamWriter sw = File.AppendText(pathConfig);

            sw.WriteLine(logEntry);
            sw.Dispose();
            sw.Close();

        }

        private static void validateFileMail(string pathConfig)
        {
            if (!File.Exists(pathConfig))
            {
                File.Create(pathConfig);
            }
        }
    }
}
