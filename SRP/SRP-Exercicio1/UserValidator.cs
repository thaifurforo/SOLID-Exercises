namespace SRP_Exercicio1;

public class UserValidator
{
    public void Validate(User user)
    {
        if (string.IsNullOrEmpty(user.Name) || string.IsNullOrEmpty(user.Email))
        {
            throw new Exception("Name and Email are required.");
        }
    }
}