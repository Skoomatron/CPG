class Validator
{
    private string _password;
    private bool _lengthCheck;
    private bool _containsNumber;
    private bool _forbidden;

    Validator(string password)
    {
        _password = password;
    }
    
    public void Password()
    {
        do
        {
            Console.WriteLine("Please enter a password.");
            string input = Console.ReadLine();
            foreach (char character in input)
            {
        
            }
        } while (true);
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
            Password();
        }
    }

    public void ContainsNumber(int number)
    {
        if (typeof(number) == Int32)
        {
            
        }
    }
}