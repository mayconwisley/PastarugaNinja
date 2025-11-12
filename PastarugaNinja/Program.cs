using System;

namespace PastarugaNinja
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{
				if (args == null || args.Length == 0)
				{
					ShowUsage();
					Environment.Exit(2);
				}

				var cmd = args[0].Trim().ToLowerInvariant();

				if (cmd == "help" || cmd == "-h" || cmd == "--help")
				{
					ShowUsage();
					return;
				}

				switch (cmd)
				{
					case "del":
					case "d":
					case "delete":
						if (args.Length < 2)
						{
							CriarLog.Log("Argumento de caminho ausente para o comando de exclusão");
							ShowUsage();
							Environment.Exit(2);
						}
						ExcluirPasta.Excluir(args[1]);
						break;

					case "cri":
					case "c":
					case "create":
						if (args.Length < 3)
						{
							CriarLog.Log("Caminho ou nome de diretório ausente para o comando de criação");
							ShowUsage();
							Environment.Exit(2);
						}
						CriarPasta.Criar(args[1], args[2]);
						break;

					default:
						CriarLog.Log($"Comando desconhecido: {args[0]}");
						ShowUsage();
						Environment.Exit(2);
						break;
				}
			}
			catch (Exception ex)
			{
				CriarLog.Log("Exceção não tratada: " + ex.ToString());
				Environment.Exit(1);
			}
		}

		private static void ShowUsage()
		{
			Console.WriteLine("Pastaruga Ninja - Usage:");
			Console.WriteLine("  create|cri|c <path> <directoryName>    Create a directory");
			Console.WriteLine("  delete|del|d <path>                    Delete a directory");
			Console.WriteLine("  help                                    Show this help");
		}
	}
}
