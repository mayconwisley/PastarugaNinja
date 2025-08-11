using System;
using System.IO;

namespace PastarugaNinja
{
    public static class CriarLog
    {
        public static void Log(string mensage)
        {
            var rootPath = AppDomain.CurrentDomain.BaseDirectory;
            try
            {
                string nameFileLog = $"{DateTime.Now:yyyy-MM-dd HH}h - Log Pastaruga Ninja.log";
                string pathLogName = Path.Combine(rootPath, nameFileLog);
                if (!File.Exists(pathLogName))
                {
                    FileStream fileStream = File.Create(pathLogName);
                    fileStream.Close();
                }
                using (StreamWriter streamWriter = File.AppendText(pathLogName))
                {
                    AppendLog(mensage, streamWriter);
                }
                throw new ArgumentException("Verifique o arquivo de log");
            }
            catch (IOException ex)
            {
                throw new IOException(ex.Message);
            }
        }

        private static void AppendLog(string mensage, TextWriter textWriter)
        {
            try
            {
                textWriter.Write($"{DateTime.Now:yyyy-MM-dd HH:mm:ss}: ");
                textWriter.WriteLine(mensage);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
