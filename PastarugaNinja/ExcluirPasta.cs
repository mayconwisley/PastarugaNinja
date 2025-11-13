using System;
using System.IO;

namespace PastarugaNinja
{
	public static class ExcluirPasta
	{
		public static void Excluir(string path, bool delArquivo = false)
		{
			try
			{
				var paths = Directory.GetDirectories(path);
				foreach (var item in paths)
				{
					Directory.Delete(item, true);
				}

				if (delArquivo)
					ExcluirArquivos(path);
			}
			catch (Exception)
			{
				throw;
			}
		}
		private static void ExcluirArquivos(string path)
		{
			try
			{
				var files = Directory.GetFiles(path);

				foreach (var file in files)
				{
					var arquivoEmUso = ArquivoEmUso(file);
					if (arquivoEmUso)
						continue;

					if (File.Exists(file))
						File.Delete(file);
				}
			}
			catch (Exception)
			{
				throw;
			}
		}

		private static bool ArquivoEmUso(string file)
		{
			try
			{
				using (var sr = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.None))
				{
				}
				return false;
			}
			catch (IOException)
			{
				return true;
			}
		}
	}
}
