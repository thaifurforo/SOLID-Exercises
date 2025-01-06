namespace SRP_Exercicio2;

public class Program
{
    public static void Main(string[] args)
    {
        var calculator = new SalaryCalculator();
        var presenter = new SalaryPresenter();

        try
        {
            double hourlyRate = calculator.CalculateHourlyRate(50000);
            presenter.DisplayHourlyRate(hourlyRate);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}