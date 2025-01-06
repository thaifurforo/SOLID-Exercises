namespace SRP_Exercicio2;

public class SalaryCalculator
{
    public double CalculateHourlyRate(double annualSalary)
    {
        if (annualSalary <= 0)
        {
            throw new Exception("Annual salary must be greater than zero.");
        }

        return annualSalary / 2080;
    }
}