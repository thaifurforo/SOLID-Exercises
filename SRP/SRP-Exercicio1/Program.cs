namespace SRP_Exercicio1;

public class Program
{
    public static void Main(string[] args)
    {
        var user = new User { Name = "John", Email = "john@example.com" };

        try
        {
            user.Register();
            Console.WriteLine("User successfully registered.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}