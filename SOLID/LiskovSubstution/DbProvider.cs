namespace LiskovSubstution
{
    /*
     * Liskov diyor ki miras veren sınıf ile alan sınıfın nesneleri birbirleri ile yer değiştirebilmeli. Bunun olabilmesi için özelliklerine (property) müdahale edilmeden kullanılmalı.
     * 
     * Müdahale ediliyorsa miras ilişkisi yok demektir
     */

    public interface IExecutable
    {
        void Execute();
    }
    public class DbProvider : IExecutable
    {
        public string ConnectionString { get; set; }
        public virtual int RepeatCount { get; set; }

        public void Execute()
        {
            Console.WriteLine("Base Sorgu çalıştı!!");
        }

    }

    public class SQLDbProvider : IExecutable //: DbProvider
    {
        //SqlDbProvider instance'i RepeatCount özelliğini farklı kullanıyor:
        //public override int RepeatCount { get => base.RepeatCount + 1; set => Console.WriteLine("Sql bu özelliği kullanamaz"); }
        public void Execute()
        {
            Console.WriteLine("SQL Sorgusu çalıştı!!");
        }
    }

    public static class ProviderFactory
    {
        public static IExecutable Create(string providerName)
        {
            return providerName == "Sql" ? new SQLDbProvider() :
                                           new DbProvider();
            //bir biçimde....

        }
    }
}
