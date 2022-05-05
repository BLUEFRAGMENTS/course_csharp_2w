using LoginMaskinenNamespace;

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

