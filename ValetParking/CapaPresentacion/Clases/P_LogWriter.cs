using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Clases
{
    public class P_LogWriter
    {
        private string m_exePath = string.Empty;
        public P_LogWriter(string logMessage)
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
            {}
        }
        public void Log(string logMessage, TextWriter txtWriter)
        {
            try
            {                
                string separador = "";
                txtWriter.Write("Log Entry : ");
                txtWriter.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                    DateTime.Now.ToLongDateString());            
                txtWriter.WriteLine("  :{0}", logMessage.Replace(Environment.NewLine, ""));
                for (int i = 0; i <= logMessage.Length; i++)
                {
                    separador += "-";
                }
                txtWriter.WriteLine(separador);
            }
            catch (Exception ex)
            {
            }
        }
    }
}
