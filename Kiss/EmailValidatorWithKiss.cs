using System.Text.RegularExpressions;

namespace Kiss;

public class EmailValidatorWithKiss
{
    private Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

    public bool Validate(string email)
    {
        if (string.IsNullOrEmpty(email))
        {
            throw new ArgumentException("Email cannot be null or empty");
        }

        Match match = regex.Match(email);
        return match.Success;
    }
}
