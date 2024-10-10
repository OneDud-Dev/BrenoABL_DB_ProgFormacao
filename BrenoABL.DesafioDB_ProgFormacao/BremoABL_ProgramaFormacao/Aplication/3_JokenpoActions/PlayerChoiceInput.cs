
namespace BrenoABL_ProgramaFormacao.Aplication._3_JokenpoActions;

internal class PlayerChoiceInput
{
    public static int ReadPlayer()
    {
        Console.WriteLine($"Digite 1 para user Pedra");
        Console.WriteLine($"Digite 2 para usar Papel");
        Console.WriteLine($"Digite 3 para usar Tesoura");
        Console.WriteLine("Sua escolha : ");

        var input = Console.Read();

        switch (input)
        {
            case 1: case 2: case 3:
                break;

            default:
                Console.WriteLine("Digito invalido, envie novamente o codigo relacionado a sua ação: ");
                
                ReadPlayer();
                
                break;
        }

        return input;
    }
}