namespace SRP_Exercicio3;

public class ReportGenerator
{
    public void GenerateReport(string data)
    {
        Console.WriteLine("Starting report generation...");

        string processedData = data.ToUpper();
        Console.WriteLine("Data processed.");

        string report = $"Report: {processedData}";
        Console.WriteLine("Report created.");

        Console.WriteLine($"Sending report: {report}");
        Console.WriteLine("Report sent.");
    }
}