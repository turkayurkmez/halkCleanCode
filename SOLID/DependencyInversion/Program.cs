namespace DependencyInversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            MailSender mailSender = new MailSender();
            TelegramSender telegramSender = new TelegramSender();
            Report report = new Report(telegramSender);



        }
    }
}