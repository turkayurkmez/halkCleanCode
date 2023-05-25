namespace InterfaceSegregation
{
    /*
     * Bir nesne; bir interface'i implemente etmiş ise; o interface'den gelen bütün fonksiyonları kullanmalıdır.
     * Bir nesne içerisinde anlamsız olduğunu düşündüğünüz bir fonksiyon; interface'e bağlanmaya zorlanmamalıdır!
     */
    public interface IRepository<T>
    {
        T Get(int id);
        IList<T> GetAll();

        void Create(T entity);
        void Update(T entity);
        void Delete(int id);

        //  IList<T> GetByName(string name);
    }


    public class Product { }
    public class Price
    {

    }

    public interface IProductRepository : IRepository<Product>
    {
        IList<Product> GetProductsByName(string name);
        IList<Product> GetProductsByCategoryId(int categoryId);


    }

    public class PriceRepository : IRepository<Price>
    {
        public void Create(Price entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Price Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Price> GetAll()
        {
            throw new NotImplementedException();
        }



        public void Update(Price entity)
        {
            throw new NotImplementedException();
        }
    }
}
