namespace DependencyInversion
{
    public class Report
    {
        ISender mailSender;

        public Report(ISender mailSender)
        {
            this.mailSender = mailSender;
        }

        public void SendReport(string to)
        {

            mailSender.Send(to);
        }
    }

    public interface ISender
    {
        void Send(string to);
    }
    public class MailSender : ISender
    {
        public void Send(string to)
        {
            Console.WriteLine("Mail gönderildi");
        }
    }

    public class TelegramSender : ISender
    {
        public void Send(string to)
        {
            Console.WriteLine("Telegram ile gönderildi");
        }
    }
}
