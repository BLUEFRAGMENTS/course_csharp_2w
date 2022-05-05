using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LoginMaskinenNamespace
{
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
}
