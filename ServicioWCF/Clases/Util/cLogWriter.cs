using System;
using System.IO;
using System.Reflection;

namespace Clases.Util
{
    class cLogWriter
    {
        private string m_exePath = string.Empty;
        public cLogWriter(string logMessage)
        {
            LogWrite(logMessage);
        }
        public void LogWrite(string logMessage)
        {
            m_exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            try
            {
                using (StreamWriter w = File.AppendText(m_exePath + "\\" + "log.txt"))
                {
                    Log(logMessage, w);
                }
            }
            catch
            {
            }
        }

        public void Log(string logMessage, TextWriter txtWriter)
        {
            try
            {
                txtWriter.Write("\r\nLog Entry : ");
                txtWriter.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                    DateTime.Now.ToLongDateString());
                txtWriter.WriteLine("  :");
                txtWriter.WriteLine("  : {0}", logMessage);
                txtWriter.WriteLine("-------------------------------");
            }
            catch
            {
            }
        }
    }
}
