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
                    Directory.Delete(item);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
