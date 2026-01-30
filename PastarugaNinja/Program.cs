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

                        if (args.Length == 3 && args[1] == "a")
                        {
                            ExcluirPasta.Excluir(args[2], true);
                            break;
                        }

                        if (args.Length == 3 && args[1] != "a")
                        {
                            CriarLog.Log($"Argumento: '{args[1]}' inválido para o comando de exclusão de arquivos");
                            ShowUsage();
                            Environment.Exit(2);
                        }

                        if (args.Length == 2)
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

                    case "mov":
                    case "m":
                    case "move":
                        if (args.Length < 3)
                        {
                            CriarLog.Log("Caminhos estão ausente para serem movidos");
                            ShowUsage();
                            Environment.Exit(2);
                        }
                        MoverPasta.Mover(args[1], args[2]);
                        break;
                    case "cop":
                    case "copy":
                        if (args.Length < 4)
                        {
                            CriarLog.Log("Caminhos estão ausente para serem copiados");
                            ShowUsage();
                            Environment.Exit(2);
                        }

                        if (args[1] == "x")
                        {
                            CopiarArquivo.Copiar(args[2], args[3], true);
                            break;
                        }

                        CopiarArquivo.Copiar(args[1], args[2]);
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
            Console.WriteLine("  create|cri|c <path> <directoryName>    Criar um diretório");
            Console.WriteLine("  move|mov|m <pathOrgin> <pathDestination>    Mover um diretório");
            Console.WriteLine("  copy|cop [x] <pathFileOrgin> <pathFileDestination>    Copiar arquivos para outro destino (use 'x' para recortar o arquivo)");
            Console.WriteLine("  delete|del|d [a] <path>                Deletar um diretório (use 'a' para excluir os arquivos juntos)");
            Console.WriteLine("  help                                   Mostrar esta ajusta");
        }
    }
}
