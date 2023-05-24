namespace CleanFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Karmaşık bir işi, fonksiyonlara bölmek kodunuzu temiz tutar.
             * 
             * 1. Oyun başladığında
             * 2. 1-100 arası Rastgele Bir sayı tut.
             * 3. Kullanıcıdan tahmin iste
             * 4. Tahmini karşılaştır (Tahmin edilenin durumuna göre aşağı VEYA yukarı)                       * 
             * 5. Bilinene kadar 3. adıma git.
             * 6. Oyunu bitir
             */

            //One Job at a time 
            usingExtensionMethods();

            bool isGameActive = true;
            int target = getRandomNumber(100);
            while (isGameActive)
            {
                int suggest = getSuggestedValueFromPlayer();
                var result = compareSuggestAndTarget(suggest: suggest, target: target);
                Console.WriteLine(result);
                isGameActive = !(result == "Bildiniz!");
            }

            usingArgumentEncapsulation();

            //var files = FileProcess.GetDllFilesFromDirectory("");
            //usingExtensionMethods();

        }

        private static void usingExtensionMethods()
        {
            string name = "türkay ürkmez bu extension metodu yazdı";
            //name.TitleCase();
            string newName = name.ToTitleCase();
            Console.WriteLine(newName);
        }

        private static void usingArgumentEncapsulation()
        {
            People people = new People();
            var person = new Person()
            {
                Name = "Türkay",
                LastName = "Ürkmez",
                Age = 43,
                Address = "Eskişehir",
                Phone = "05442101010"
            };


            people.AddPerson(person);
        }

        static int getRandomNumber(int maxValue)
        {
            //en ideal fonksiyon; tek satırda işi bitiren ve mümkünse parametresi en az olan fonksiyondur!
            return new Random().Next(0, maxValue);
        }

        static int getSuggestedValueFromPlayer()
        {
            Console.Write("Lütfen tahmininizi girin:>");
            string suggestedValue = Console.ReadLine();
            int suggestedNumber = 0;

            while (!int.TryParse(suggestedValue, out suggestedNumber))
            {
                Console.WriteLine("Lütfen sadece sayısal değer girin");
                Console.Write("Lütfen tahmininizi girin:>");
                suggestedValue = Console.ReadLine();
            }
            return suggestedNumber;
        }

        static string compareSuggestAndTarget(int suggest, int target)
        {
            if (suggest > target)
            {
                return "Aşağı";
            }
            else if (suggest < target)
            {
                return "Yukarı";
            }
            else
            {
                return "Bildiniz!";
            }
        }

        public List<string> filteredCities(List<string> cities, string firstLetter)
        {
            List<string> filteredCities = new List<string>();
            foreach (var city in cities)
            {
                filteredCities = filterForFirsLetter(firstLetter, city);
            }

            return filteredCities;
        }

        private static List<string> filterForFirsLetter(string firstLetter, string city)
        {
            List<string> filteredCities = new List<string>();
            if (isCityStartFirstLetter(firstLetter, city))
            {
                filteredCities.Add(city);
            }

            return filteredCities;


        }

        private static bool isCityStartFirstLetter(string firstLetter, string city)
        {
            return city.StartsWith(firstLetter);
        }
    }
}