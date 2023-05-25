namespace TDD.GameApp
{
    public class Result
    {
        public const string Fizz = "Fizz";
        public const string FizzBuzz = "FizzBuzz";
        public const string Buzz = "Buzz";


    }
    public class GameBoard
    {
        public string GetWordForNumber(int number)
        {
            if (number % 15 == 0)
            {
                return Result.FizzBuzz;
            }
            else if (number % 3 == 0)
            {
                return Result.Fizz;
            }
            else if (number % 5 == 0)
            {
                return Result.Buzz;
            }
            return string.Empty;

        }
    }
}
