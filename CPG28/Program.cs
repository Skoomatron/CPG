class Validator
{
    private string _password;
    private bool _lengthCheck;
    private bool _containsNumber;
    private bool _forbidden;
    private bool _upper;
    private bool _lower;

    Validator(string password)
    {
        _password = password;
    }
    public void LengthCheck(string password)
    {
        if (password.Length >= 6 && password.Length <= 13)
        {
            _lengthCheck = true;
        }
        else
        {
            Console.WriteLine("Password has an invalid length!");
        }
    }

    public void ContainsForbidden(char character)
    {
        if (character == "T" || character == "&")
        {
            Console.WriteLine("Password contains the forbidden characters T or &!");
        }
    }

    public void ContainsNumber(char number)
    {
        if (Convert.ToInt32(number))
        {
            _containsNumber = true;
        }
    }

    public void CaseChecker(char character)
    {
        if (char.IsUpper(character))
        {
            _upper = true;
        } else if (char.IsLower(character))
        {
            _lower = true;
        }
    }
}