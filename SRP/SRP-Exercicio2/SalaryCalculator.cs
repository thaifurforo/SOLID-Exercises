namespace SRP_Exercicio2;

public class SalaryCalculator
{
    public double CalculateHourlyRate(double annualSalary)
    {
        if (annualSalary <= 0)
        {
            throw new Exception("Annual salary must be greater than zero.");
        }

        double hourlyRate = annualSalary / 2080;
        Console.WriteLine($"The hourly rate is: {hourlyRate}");
        return hourlyRate;
    }
}