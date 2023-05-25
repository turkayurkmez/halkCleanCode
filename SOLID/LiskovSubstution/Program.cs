namespace LiskovSubstution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var provider = ProviderFactory.Create("Sql");
            provider.Execute();

        }
    }
}