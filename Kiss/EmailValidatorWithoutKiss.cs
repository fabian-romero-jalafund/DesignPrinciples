using System.Text.RegularExpressions;

namespace Kiss;

public class EmailValidatorWithoutKiss
{
    private Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

    public bool Validate(string email)
    {
        if (string.IsNullOrEmpty(email))
        {
            throw new ArgumentException("Email cannot be null or empty");
        }

        if (!HasAtSymbol(email))
        {
            return false;
        }

        if (!HasDotSymbol(email))
        {
            return false;
        }

        Match match = regex.Match(email);
        return match.Success;
    }

    private bool HasAtSymbol(string email)
    {
        return email.Contains('@');
    }

    private bool HasDotSymbol(string email)
    {
        return email.Contains('.');
    }
}
