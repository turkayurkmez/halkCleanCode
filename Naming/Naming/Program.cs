namespace Naming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int d = 0; //kullanıcının kayıt olmasından bu yana geçen gün sayısı.
            int daysSinceUserCreation = 0;
            int elapsedTimeInDays = 15;

            int hpLaptopInCompany = 1250;
            int healthPoint = 100;
            int horsePower = 250;
            int hitPoint = 45;

            int vurusGucu = 15;

            bool isOld = false;

            var totalPrice = 0.0M;
            int intTotalAmount = 150;


            //Bunu okuyan ve anlayan yazılımcı kör oldu.
            //var o = 0;
            //var l = 1;
            //var o1 = 01;

            //int a = 1;
            //if (o==l)
            //{
            //    a = o1;
            //}
            //else
            //{
            //    l = 01;
            //}

            List<string> accounts = new List<string>();
            List<string> accountList = new List<string>();




        }

        bool isPasswordAvailableForRules(string password)
        {
            return false;
        }

        List<string> getColoredShirtsOnDb()
        {
            return null;
        }

        public void CreateNewProduct(Product newProduct)
        {

        }

        private static List<int[]> cellsOnGameBoard = new List<int[]>();
        static List<int[]> getFlaggedCellsOnGameBoard()
        {
            List<int[]> flaggedCells = new List<int[]>();
            foreach (var cell in cellsOnGameBoard)
            {
                if (cell[0] == FlagState.Flagged)
                {
                    flaggedCells.Add(cell);
                }
            }
            return flaggedCells;

        }

        public class FlagState
        {
            public const int Flagged = 4;
            public const int NonFlagged = 0;
        }
    }
}