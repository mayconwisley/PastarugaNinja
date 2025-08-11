using System;
using System.IO;

namespace PastarugaNinja
{
    public static class CriarPasta
    {
        public static void Criar(string path, string nameDirectory)
        {
            try
            {
                if (Directory.Exists(path))
                {
                    var newDirectory = Path.Combine(path, nameDirectory);
                    Directory.CreateDirectory(newDirectory);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
