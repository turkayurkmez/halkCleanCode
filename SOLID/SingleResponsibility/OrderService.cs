using System.Data.SqlClient;

namespace SingleResponsibility
{
    public class OrderService
    {
        public List<string> GetOrdersBetweenDates(DateTime startDate, DateTime endDate)
        {
            SqlConnection sqlConnection = new SqlConnection();
            SqlCommand sqlCommand = new SqlCommand("");
            sqlCommand.Parameters.AddWithValue("@start", startDate);
            sqlCommand.Parameters.AddWithValue("@end", endDate);

            sqlConnection.Open();
            var reader = sqlCommand.ExecuteReader();
            //sorgu sunucunu reader nesnesi üzerinden listeye aldığımızı farz edelim
            List<string> rows = new List<string>();
            return rows;
        }
    }
}
