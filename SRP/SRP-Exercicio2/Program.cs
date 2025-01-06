namespace SRP_Exercicio2;

public class Program
{
    public static void Main(string[] args)
    {
        var calculator = new SalaryCalculator();

        try
        {
            double hourlyRate = calculator.CalculateHourlyRate(50000);
            Console.WriteLine($"Calculation completed. Hourly rate: {hourlyRate}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}