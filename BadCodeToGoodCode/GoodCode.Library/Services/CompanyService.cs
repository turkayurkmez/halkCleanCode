using GoodCode.Library.Models;

namespace GoodCode.Library.Services
{
    public class CompanyService
    {
        TimeSheetBillCalculator billCalculator = new TimeSheetBillCalculator();
        public void SendMailToCompanies(List<TimeSheetEntry> timeSheetEntries)
        {
            var companies = new FakeCompanyRepository().GetCompanies();
            MailSenderComponent mailSenderComponent = new MailSenderComponent();
            mailSenderComponent.SendMailToCompanies(companies, timeSheetEntries, billCalculator);


        }

        public double CalculateBillForExtraTime(List<TimeSheetEntry> timeSheetEntries, int maxHoursForWeek)
        {
            return billCalculator.CalculateBillForExtra(timeSheetEntries, maxHoursForWeek);
        }
    }
}
