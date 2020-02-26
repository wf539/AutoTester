using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace AutoTester
{
    static class TestLib
    {
        public static string LogFile = "c:\\logfile.txt";

        public static void StartProgram(string strAppname)
        {
            if (!(File.Exists(LogFile)))
            {
                CreateLog("Starting Log File " + DateTime.Now);
            }
            Process.Start(strAppname);
            LogtoFile("Application " + strAppname + " Started at: " + DateTime.Now);
        }

        private static void CreateLog(string strHeader)
        {
            StreamWriter Writer;
            Writer = File.CreateText(LogFile);
            Writer.WriteLine(strHeader);
            Writer.Close();
        }

        private static void LogtoFile(string strLog)
        {
            StreamWriter Writer;
            Writer = File.AppendText(LogFile);
            Writer.WriteLine(strLog);
            Writer.Close();
        }
    }
}
