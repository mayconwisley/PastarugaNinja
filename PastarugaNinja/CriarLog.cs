using System;
using System.IO;

namespace PastarugaNinja
{
	public static class CriarLog
	{
		private static readonly object _lock = new object();

		public static void Log(string message)
		{
			var rootPath = AppDomain.CurrentDomain.BaseDirectory;
			try
			{
				string nameFileLog = $"{DateTime.Now:yyyy-MM-dd HH}h - Log Pastaruga Ninja.log";
				string pathLogName = Path.Combine(rootPath, nameFileLog);

				lock (_lock)
				{
					// Adicione texto com segurança e feche o arquivo imediatamente.
					using (var streamWriter = new StreamWriter(pathLogName, true))
					{
						streamWriter.Write($"{DateTime.Now:yyyy-MM-dd HH:mm:ss}: ");
						streamWriter.WriteLine(message);
					}
				}
			}
			catch (IOException ioEx)
			{
				try
				{
					Console.Error.WriteLine("Falha no registro: " + ioEx.Message);
					Console.Error.WriteLine("Mensagem original: " + message);
				}
				catch
				{
				}
			}
			catch (Exception)
			{
			}
		}
	}
}
