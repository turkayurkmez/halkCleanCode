namespace CleanFunctions
{
    public static class FileProcess
    {

        /// <summary>
        /// Belirtilen klasör içerisindeki .dll dosyalarının listesini döndürür.
        /// </summary>
        /// <param name="directoryPath">Aranacak klasör</param>
        /// <returns>dll dosya listesi</returns>
        public static List<string> GetDllFilesFromDirectory(string directoryPath)
        {
            checkParameterIsNull(directoryPath);

            checkDirectorIsExists(directoryPath);

            var files = Directory.GetFiles(directoryPath, "*.dll");

            isIncludeDllFiles(directoryPath, files);

            return files.ToList();
        }

        private static void isIncludeDllFiles(string directoryPath, string[] files)
        {
            if (files == null)
            {
                throw new FileNotFoundException($"{directoryPath} klasörü içerisinde .dll uzantılı dosya bulunamadı");
            }
        }

        private static void checkDirectorIsExists(string directoryPath)
        {
            if (Directory.Exists(directoryPath))
            {
                throw new DirectoryNotFoundException($"{directoryPath} adresinde; bir klasör yok!!!!! ");

            }
        }

        private static void checkParameterIsNull(string directoryPath)
        {
            if (string.IsNullOrEmpty(directoryPath))
            {
                throw new ArgumentNullException(directoryPath, $"klasörün tam adresi belirtilmedi!");
            }
        }
    }
}
