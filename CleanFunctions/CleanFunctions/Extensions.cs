namespace CleanFunctions
{
    public static class Extensions
    {
        /// <summary>
        /// Girilen metindeki tüm kelimelerin ilk harflerini büyütür.
        /// </summary>
        /// <param name="text">kelimelerden oluşan metin</param>
        /// <returns>Başlık biçiminde döndür</returns>
        public static string ToTitleCase(this string text)
        {
            //string[] strings = text.Split(' ');
            //string titleCase = string.Empty;
            //foreach (var word in strings)
            //{
            //    var changedWord = word.Replace(word[0].ToString(), word[0].ToString().ToUpper());
            //    titleCase += changedWord + " ";
            //}

            //return titleCase.Trim();

            var result = text.Split(' ')
                             .Select(word =>
                                        word.Substring(0, 1).ToUpper() + word.Substring(1).ToUpper()
                              );



            return string.Join(" ", result);


        }
    }
}
