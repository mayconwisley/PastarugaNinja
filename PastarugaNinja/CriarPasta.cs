using System;
using System.IO;

namespace PastarugaNinja;

public static class CriarPasta
{
    public static bool Criar(string path, string nameDirectory)
    {
        if (string.IsNullOrEmpty(path))
        {
            CriarLog.Log("O caminho não pode ser nulo nem vazio.");
            return false;
        }
        if (string.IsNullOrEmpty(nameDirectory))
        {
            CriarLog.Log("O nome do diretório não pode ser nulo nem vazio.");
            return false;
        }

        // Validar nome de diretório em busca de caracteres inválidos
        foreach (var c in Path.GetInvalidFileNameChars())
        {
            if (nameDirectory.Contains(c.ToString()))
            {
                CriarLog.Log("O nome do diretório contém caracteres inválidos.");
                return false;
            }
        }

        try
        {
            if (!Directory.Exists(path))
            {
                CriarLog.Log($"O caminho base não existe: {path}");
                return false;
            }

            var newDirectory = Path.Combine(path, nameDirectory);
            if (Directory.Exists(newDirectory))
            {
                CriarLog.Log($"O diretório já existe: {newDirectory}");
                return true;
            }

            Directory.CreateDirectory(newDirectory);
            CriarLog.Log($"Diretório criado: {newDirectory}");
            return true;
        }
        catch (UnauthorizedAccessException uaEx)
        {
            CriarLog.Log($"Acesso negado ao criar o diretório: {uaEx.Message}");
            throw;
        }
        catch (Exception ex)
        {
            CriarLog.Log($"Erro inesperado ao criar o diretório: {ex.Message}");
            throw;
        }
    }
}
