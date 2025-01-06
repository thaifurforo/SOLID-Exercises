namespace SRP_Exercicio1;

public class User
{
    public string Name { get; set; }
    public string Email { get; set; }

    public void Register()
    {
        if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Email))
        {
            throw new Exception("Name and Email are required.");
        }

        Console.WriteLine("User registered in the database.");
    }
}