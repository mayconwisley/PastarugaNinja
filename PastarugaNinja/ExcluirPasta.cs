using System;
using System.IO;

namespace PastarugaNinja
{
	public static class ExcluirPasta
	{
		public static void Excluir(string path)
		{
			try
			{
				var paths = Directory.GetDirectories(path);
				foreach (var item in paths)
				{
					Directory.Delete(item, true);
				}
			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}
