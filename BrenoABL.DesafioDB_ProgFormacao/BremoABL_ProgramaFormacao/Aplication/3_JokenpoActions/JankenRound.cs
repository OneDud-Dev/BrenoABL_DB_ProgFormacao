
namespace BrenoABL_ProgramaFormacao.Aplication._3_JokenpoActions;

internal class JankenRound
{
    public static void RunJanken()
    {
        int aiPlay = AiChoice.ChoseRandomAction();
        string? pcPlay = PlayerChoiceInput.ReadPlayer();

        
        switch (pcPlay)
        {
            case "1":
                Console.WriteLine("A escolha do jogador é Pedra ");
                switch (aiPlay)
                {
                    case 1:
                        Console.WriteLine("A escolha do Computador é Pedra ");
                        Console.WriteLine("O resultado é EMPATE");
                        break;
                    case 2:
                        Console.WriteLine("A escolha do Computador é Papel ");
                        Console.WriteLine("O resultado é Derrota do Jogador");
                        break;
                    case 3:
                        Console.WriteLine("A escolha do Computador é Tesoura ");
                        Console.WriteLine("O resultado é Vitoria do Jogador");
                        break;
                    default:
                        break;
                }
                break;



            case "2":
                Console.WriteLine("A escolha do jogador é Papel ");
                switch (aiPlay)
                {
                    case 1:
                        Console.WriteLine("A escolha do Computador é Pedra ");
                        Console.WriteLine("O resultado é Vitória do Jogador");
                        break;
                    case 2:
                        Console.WriteLine("A escolha do Computador é Papel ");
                        Console.WriteLine("O resultado é EMPATE");
                        break;
                    case 3:
                        Console.WriteLine("A escolha do Computador é Tesoura ");
                        Console.WriteLine("O resultado é Derrota do Jogador");
                        break;
                    default:
                        break;
                }
                break;



            case "3":
                Console.WriteLine("A escolha do jogador é Tesoura ");
                switch (aiPlay)
                {
                    case 1:
                        Console.WriteLine("A escolha do Computador é Pedra ");
                        Console.WriteLine("O resultado é Derrota do Jogador");
                        break;
                    case 2:
                        Console.WriteLine("A escolha do Computador é Papel ");
                        Console.WriteLine("O resultado é Vitória do Jogador");
                        break;
                    case 3:
                        Console.WriteLine("A escolha do Computador é Tesoura ");
                        Console.WriteLine("O resultado é EMPATE");
                        break;
                    default:
                        break;
                }
                break;

                

            default:
                Console.WriteLine("Digito invalido, envie novamente o codigo relacionado a sua ação: ");
                RunJanken();
                break;
        }
    }


}
