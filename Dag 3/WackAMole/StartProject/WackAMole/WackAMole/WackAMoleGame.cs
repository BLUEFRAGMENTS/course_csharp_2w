public class WackAMoleGame
{
    private int tidIMsEnMulvarpeErFremme = 1000;

    private int amountOfMoles = 5;
    private int molesHit = 0;
    private int molesMissed = 0;
    private bool isAMoleShown = false;
    private bool isPlaying = false;

    public WackAMoleGame()
    {
        // Standard spil
    }

    public WackAMoleGame(
        int amountOfMoles,
        int tidIMsEnMulvarpeErFremme)
    {
        this.amountOfMoles = amountOfMoles;
        this.tidIMsEnMulvarpeErFremme = tidIMsEnMulvarpeErFremme;
    }

    public void StartGame()
    {
        isPlaying = true;
        Console.WriteLine("Velkommen til Mulvarpe spillet!");
        Console.WriteLine("Tryk på en tast for at starte");
        Console.ReadLine();

        StartTimer();

        while (isPlaying)
        {
            char input = Console.ReadKey().KeyChar;
            if (isPlaying)
            {
                var ramte = HitAMole();
                TriedToHitMole?.Invoke(this, ramte);
            }
        }

        ConsoleKeyInfo consoleKeyInfo;
        Console.WriteLine("Try [Escape] for at afslutte");

        do
        {
            consoleKeyInfo = Console.ReadKey();
        } while (consoleKeyInfo.Key != ConsoleKey.Escape);
    }

    private async void StartTimer()
    {
        await RunTimerAsync();
        StopGame();
    }

    public event EventHandler? MoleDidShow;

    public event EventHandler? MoleDidHide;

    public event EventHandler<bool>? TriedToHitMole;

    private bool HitAMole()
    {
        if (isPlaying)
        {
            if (isAMoleShown)
            {
                molesHit++;
                isAMoleShown = false;
                return true;
            }
            else
            {
                molesMissed++;
                return false;
            }
        }

        return false;
    }

    private async Task RunTimerAsync()
    {
        for (int index = 0; index < amountOfMoles; index++)
        {
            var randomTimeInMiliseconds = new Random().Next(500, 3000);
            await Task.Delay(randomTimeInMiliseconds);

            MoleDidShow?.Invoke(this, null);
            isAMoleShown = true;

            await Task.Delay(tidIMsEnMulvarpeErFremme);
            MoleDidHide?.Invoke(this, null);
            isAMoleShown = false;
            Console.WriteLine();
        }

        isPlaying = false;
    }

    private void StopGame()
    {
        Console.WriteLine("####");
        Console.WriteLine("Spillet er slut.");
        Console.WriteLine();
        Console.WriteLine("SCORE ");
        Console.WriteLine("Ramt: " + molesHit);
        Console.WriteLine("Misser: " + molesMissed);
        Console.WriteLine("####");
    }
}
