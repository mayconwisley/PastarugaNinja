using System;
using System.IO;

namespace PastarugaNinja
{
    public static class CopiarArquivo
    {
        public static bool Copiar(string pathFileOrigin, string pathFileDestination, bool isCut = false)
        {
            if (string.IsNullOrEmpty(pathFileOrigin))
            {
                CriarLog.Log("O caminho de origem inválido.");
                return false;
            }
            if (string.IsNullOrEmpty(pathFileDestination))
            {
                CriarLog.Log("O caminho de destino inválido.");
                return false;
            }

            try
            {
                if (!Directory.Exists(pathFileOrigin) || !Directory.Exists(pathFileDestination))
                {
                    CriarLog.Log($"O caminho de origem ou destino não existe: {pathFileOrigin}{pathFileDestination}");
                    return false;
                }

                foreach (var file in Directory.GetFiles(pathFileOrigin))
                {
                    var destinationFile = Path.Combine(pathFileDestination, Path.GetFileName(file));

                    if (isCut)
                    {
                        File.Move(file, destinationFile);
                    }
                    else
                    {
                        File.Copy(file, destinationFile, true);
                    }
                }
                CriarLog.Log($"Arquivos Copiados com sucesso");
                return true;
            }
            catch (UnauthorizedAccessException auEx)
            {
                CriarLog.Log($"Acesso negado ao mover diretório: {auEx.Message}");
                throw;
            }
            catch (Exception ex)
            {
                CriarLog.Log("Erro inesperado ao mover o diretório: " + ex.Message);
                throw;
            }
        }
    }
}
