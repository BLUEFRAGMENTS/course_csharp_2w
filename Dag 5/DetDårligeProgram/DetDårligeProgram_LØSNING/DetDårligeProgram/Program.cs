using DetDårligeProgram.Funktionaliteter;

Console.WriteLine("Dætte R deT dÅlrige pROGRAM!");

SpilleMaskine spilleMaskine = new SpilleMaskine();

try
{
    spilleMaskine.StartMøntSpil();
}
catch(Exception ex)
{
    Console.WriteLine($"Der skete en fejl i MøntSpil: {ex}");
}

try
{
    spilleMaskine.StartLudoTerningSpil();
}
catch (Exception ex)
{
    Console.WriteLine($"Der skete en fejl i LudoSpil: {ex}");
}

try
{
    spilleMaskine.StartStabelKlodserSpil();
}
catch (Exception ex)
{
    Console.WriteLine($"Der skete en fejl i StabelKlodserSpil: {ex}");
}

Console.WriteLine("pRogrAMMET viRKeD!");
