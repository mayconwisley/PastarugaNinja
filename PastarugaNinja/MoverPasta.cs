using System;
using System.IO;

namespace PastarugaNinja
{
    public static class MoverPasta
    {
        public static bool Mover(string pathOrigin, string pathDestination)
        {
            if (string.IsNullOrEmpty(pathOrigin))
            {
                CriarLog.Log("O caminho de origem inválido.");
                return false;
            }
            if (string.IsNullOrEmpty(pathDestination))
            {
                CriarLog.Log("O caminho de destino inválido.");
                return false;
            }

            try
            {
                if (!Directory.Exists(pathOrigin) || !Directory.Exists(pathDestination))
                {
                    CriarLog.Log($"O caminho de origem ou destino não existe: {pathOrigin}{pathDestination}");
                    return false;
                }

                var pathFinalDestination = Path.Combine(pathDestination, Path.GetFileName(pathOrigin));
                if (Directory.Exists(pathFinalDestination))
                {
                    CriarLog.Log($"A pasta já existe no destino: {pathFinalDestination}");
                    return false;
                }

                Directory.Move(pathOrigin, pathFinalDestination);
                CriarLog.Log($"Diretório movido com sucesso");
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
