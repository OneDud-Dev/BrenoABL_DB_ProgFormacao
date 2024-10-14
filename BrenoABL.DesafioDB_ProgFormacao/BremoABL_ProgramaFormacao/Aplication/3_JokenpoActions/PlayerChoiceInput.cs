
namespace BrenoABL_ProgramaFormacao.Aplication._3_JokenpoActions;

internal class PlayerChoiceInput
{
    public static string? ReadPlayer()
    {
        Console.WriteLine($"Digite 1 para user Pedra");
        Console.WriteLine($"Digite 2 para usar Papel");
        Console.WriteLine($"Digite 3 para usar Tesoura");
        Console.WriteLine("Sua escolha : ");

        return Console.ReadLine();
    }
}