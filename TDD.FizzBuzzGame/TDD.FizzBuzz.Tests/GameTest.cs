namespace TDD.FizzBuzz.Tests
{
    public class GameTest
    {
        //[Fact]
        //public void IsExists()
        //{
        //    var gameBoard = new TDD.GameApp.GameBoard();
        //    int givenNumber = 3;
        //    string response = gameBoard.GetWordForNumber(givenNumber);

        //}

        [Fact]
        public void When_Send_Three_Return_Fizz()
        {
            /*
             * BDD user story
             *  -Ben bir oyuncu olarak
             *  -oyun fonksiyonuna 3 sayısını verdiğimde 
             *  -geriye Fizz dönmeli
             */
            var gameBoard = new TDD.GameApp.GameBoard();
            int givenNumber = 3;
            string actual = gameBoard.GetWordForNumber(givenNumber);
            Assert.Equal("Fizz", actual);
        }

        [Fact]
        public void When_Send_Five_Return_Buzz()
        {
            /*
             * BDD user story
             *  -Ben bir oyuncu olarak
             *  -oyun fonksiyonuna 5 sayısını verdiğimde 
             *  -geriye Fizz dönmeli
             */
            var gameBoard = new TDD.GameApp.GameBoard();
            int givenNumber = 5;
            string actual = gameBoard.GetWordForNumber(givenNumber);
            Assert.Equal("Buzz", actual);
        }
        [Fact]
        public void When_Send_Multiply_Three_Return_Fizz()
        {
            /*
             * BDD user story
             *  -Ben bir oyuncu olarak
             *  -oyun fonksiyonuna 3 sayısını verdiğimde 
             *  -geriye Fizz dönmeli
             */
            var gameBoard = new TDD.GameApp.GameBoard();
            int givenNumber = 12;
            string actual = gameBoard.GetWordForNumber(givenNumber);
            Assert.Equal("Fizz", actual);
        }

        [Fact]
        public void When_Send_Multiply_Five_Return_Buzz()
        {
            /*
             * BDD user story
             *  -Ben bir oyuncu olarak
             *  -oyun fonksiyonuna 3 sayısını verdiğimde 
             *  -geriye Fizz dönmeli
             */
            var gameBoard = new TDD.GameApp.GameBoard();
            int givenNumber = 10;
            string actual = gameBoard.GetWordForNumber(givenNumber);
            Assert.Equal("Buzz", actual);
        }

        [Fact]
        public void When_Send_Multiply_Five_And_Three_Return_FizzBuzz()
        {
            /*
             * BDD user story
             *  -Ben bir oyuncu olarak
             *  -oyun fonksiyonuna 3 sayısını verdiğimde 
             *  -geriye Fizz dönmeli
             */
            var gameBoard = new TDD.GameApp.GameBoard();
            int givenNumber = 15;
            string actual = gameBoard.GetWordForNumber(givenNumber);
            Assert.Equal("FizzBuzz", actual);
        }



    }
}