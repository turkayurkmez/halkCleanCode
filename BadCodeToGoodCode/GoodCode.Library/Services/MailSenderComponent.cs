using GoodCode.Library.Models;

namespace GoodCode.Library.Services
{
    public class MailSenderComponent
    {
        public void SendMailToCompanies(List<Company> companies, List<TimeSheetEntry> timeSheetEntries, TimeSheetBillCalculator billCalculator)
        {
            foreach (var company in companies)
            {
                var bill = billCalculator.CalculateBillForCompany(timeSheetEntries, company);
                Console.WriteLine($"{company.CompanyName} firmasına {bill}$ fatura maili gönderildi....");

            }
        }
    }
}
