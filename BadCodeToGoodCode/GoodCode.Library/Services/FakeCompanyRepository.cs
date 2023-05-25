namespace GoodCode.Library.Services
{
    public class FakeCompanyRepository
    {
        public List<Company> GetCompanies()
        {
            return new List<Company>()
            {
                 new Company{ CompanyName="acme", HourlyPayment=150},
                 new Company{ CompanyName="abc", HourlyPayment=125},
            };
        }
    }
}
