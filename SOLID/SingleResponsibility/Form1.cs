namespace SingleResponsibility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreateReport_Click(object sender, EventArgs e)
        {


            OrderService orderService = new OrderService();
            var rows = orderService.GetOrdersBetweenDates(dateTimePickerStart.Value, dateTimePickerEnd.Value);
            //sorgu sunucunu reader nesnesi üzerinden listeye aldığımızı farz edelim

            ReportFactory factory = new ReportFactory();
            factory.CreatePdfReport(rows);

        }


    }
}