namespace SRP_Exercicio3;

public class ReportGenerator
{
    public void GenerateReport(string data)
    {
        Console.WriteLine("Starting report generation...");

        string processedData = ProcessData(data);
        string report = CreateReport(processedData);
        SendReport(report);

        Console.WriteLine("Report generation completed.");
    }

    private static string ProcessData(string data)
    {
        Console.WriteLine("Processing data...");
        return data.ToUpper();
    }

    private static string CreateReport(string processedData)
    {
        Console.WriteLine("Creating report...");
        return $"Report: {processedData}";
    }

    private static void SendReport(string report)
    {
        Console.WriteLine("Sending report...");
        Console.WriteLine($"Report: {report}");
    }
}