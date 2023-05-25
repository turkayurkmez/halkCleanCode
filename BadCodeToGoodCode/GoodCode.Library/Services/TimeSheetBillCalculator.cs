using GoodCode.Library.Models;

namespace GoodCode.Library.Services
{
    public class TimeSheetBillCalculator
    {
        public double CalculateBillForCompany(List<TimeSheetEntry> timeSheetEntries, Company company)
        {
            double totalWorkedHours = 0;
            for (int i = 0; i < timeSheetEntries.Count; i++)
            {
                if (timeSheetEntries[i].WorkDone.ToLower().Contains(company.CompanyName))
                {
                    totalWorkedHours += timeSheetEntries[i].HoursWorked;
                }
            }

            return totalWorkedHours * company.HourlyPayment;
        }


        public double CalculateBillForExtra(List<TimeSheetEntry> timeSheetEntries, int maxHoursForWeek)
        {
            double totalHoursWorked = 0;
            int extraTimePayment = 15;
            int normalTimePayment = 10;
            for (int i = 0; i < timeSheetEntries.Count; i++)
            {
                totalHoursWorked += timeSheetEntries[i].HoursWorked;
            }
            if (totalHoursWorked > maxHoursForWeek)
            {
                var paymentForMoreThanHoursOfWeek = (totalHoursWorked - maxHoursForWeek) * extraTimePayment;
                var paymentForNormalTime = maxHoursForWeek * normalTimePayment;

                return paymentForMoreThanHoursOfWeek + paymentForNormalTime;

                //Console.WriteLine("You will get paid $" + (((totalHoursWorked - maxHoursForWeek) * extraTimePayment) + (maxHoursForWeek *normalTimePayment)) + " for your work.");
            }
            else
            {
                //Console.WriteLine("You will get paid $" + (totalHoursWorked * 10) + " for your time.");
                return totalHoursWorked * normalTimePayment;
            }

        }
    }
}
