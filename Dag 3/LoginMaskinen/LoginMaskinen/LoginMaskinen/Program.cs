using System.Text.RegularExpressions;

// Step 1
Console.WriteLine("LOGINMASKINEN");

// Step 2
LoginMachine loginMachine = new LoginMachine();

// Step 3
while (loginMachine.IsUsernameValid == false)
{
    // Step 4
    Console.WriteLine();
    Console.WriteLine("Venligst indtast dit brugernavn (max 8 karakterer)");
    loginMachine.Username = Console.ReadLine();
}

// Step 5
while (loginMachine.IsPasswordValid == false)
{
    // Step 6
    Console.WriteLine();
    Console.WriteLine("Venligst indtast dit password (max 8 karakterer og skal indeholde et tal)");
    loginMachine.Password = Console.ReadLine();
}

// Step 7
Console.WriteLine();
loginMachine.TryToLogin();


public class LoginMachine
{
    private string? _username;
    private string? _password;

    public string? Username
    {
        get
        {
            return _username;
        }

        set
        {
            _username = value;
            if (IsUsernameValid == false)
            {
                _username = string.Empty;
                Console.WriteLine("Brugernavn duer ikke. Prøv igen.");
            }
        }
    }

    public string? Password
    {
        get
        {
            return _password;
        }

        set
        {
            _password = value;
            if (IsPasswordValid == false)
            {
                _password = string.Empty;
                Console.WriteLine("Password duer ikke. Prøv igen.");
            }
        }
    }

    public bool IsUsernameValid
    {
        get { return Username?.Length > 0 && Username?.Length < 8; }
    }

    public bool IsPasswordValid
    {
        get
        {
            if (_password != null)
            {
                Regex regex = new Regex(@"^(?=.*[0-9])(?=.*[a-zA-Z])([a-zA-Z0-9]+)$");
                bool hasNumberAndLetter = regex.IsMatch(_password);
                return
                    _password?.Length > 0
                    && _password?.Length < 8
                    && hasNumberAndLetter;
            }

            return false;
        }
    }

    public void TryToLogin()
    {
        if (IsUsernameValid && IsPasswordValid)
        {
            Console.WriteLine("Du er nu logget ind");
        }
        else
        {
            Console.WriteLine("Du kunne ikke logge ind");
        }
    }
}

