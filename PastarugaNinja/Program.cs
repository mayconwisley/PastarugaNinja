using System;

namespace PastarugaNinja
{
    internal class Program
    {
        static void Main(string[] args)
        {


            if (args.Length == 0)
                CriarLog.Log("Nenhum argumento fornecido. Por favor, forneça o caminho do diretório e nome da pasta.");

            if (args.Length == 1)
                CriarLog.Log("Faltando um argumento");

            if (args.Length > 2)
                CriarLog.Log("Quantidade de argumentos inválidos");

            var path = args[0].ToString();
            var nameDirectory = args[1].ToString();

            try
            {
                CriarPasta.Criar(path, nameDirectory);
            }
            catch (Exception ex)
            {
                CriarLog.Log(ex.Message);
            }
        }
    }
}
