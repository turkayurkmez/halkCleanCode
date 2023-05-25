using GoodCode.Library.Models;
using GoodCode.Library.Services;

namespace GoodCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var timeSheetEntries = loadEntries();
            CompanyService companyService = new CompanyService();
            companyService.SendMailToCompanies(timeSheetEntries);
            var extraBill = companyService.CalculateBillForExtraTime(timeSheetEntries, maxHoursForWeek: 40);
            Console.WriteLine($"You will get paid ${extraBill} for your work");
            Console.Write("Press any key to exit application...");
            Console.ReadKey();

        }

        static List<TimeSheetEntry> loadEntries()
        {

            string answer = string.Empty;
            List<TimeSheetEntry> timeSheetEntries = new List<TimeSheetEntry>();
            do
            {
                answer = getWorkAndTimeFromUser(timeSheetEntries);

            } while (answer.ToLower() == "yes");
            return timeSheetEntries;

        }

        private static string getWorkAndTimeFromUser(List<TimeSheetEntry> timeSheetEntries)
        {
            string answer = string.Empty;
            Console.Write("Enter what you did: ");
            string workDoneWithCompanyName = Console.ReadLine();
            double timeForJob = getTimeForJob();
            TimeSheetEntry timeSheetEntry = new TimeSheetEntry
            {
                HoursWorked = timeForJob,
                WorkDone = workDoneWithCompanyName
            };
            timeSheetEntries.Add(timeSheetEntry);
            Console.Write("Do you want to enter more time (yes/no): ");
            answer = Console.ReadLine();
            return answer;
        }

        private static double getTimeForJob()
        {

            Console.Write("How long did you do it for: ");
            string rawTimeWorked = Console.ReadLine();
            double timeForJob;
            while (double.TryParse(rawTimeWorked, out timeForJob) == false)
            {
                Console.WriteLine();
                Console.WriteLine("Invalid number given");
                Console.Write("How long did you do it for: ");
                rawTimeWorked = Console.ReadLine();
            }

            return timeForJob;
        }




    }

}