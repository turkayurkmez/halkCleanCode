namespace OpenClosed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Bir sınıf, (yeni sınıfları) gelişime AÇIK (eski kodları) değişime KAPALI olmalı.
             * 
             */

            Customer customer = new Customer { Name = "Türkay", CardType = new Premium() };
            OrderManagement orderManagement = new OrderManagement() { Customer = customer };

            Console.WriteLine(orderManagement.GetTotalPrice(1000));

        }
    }
}