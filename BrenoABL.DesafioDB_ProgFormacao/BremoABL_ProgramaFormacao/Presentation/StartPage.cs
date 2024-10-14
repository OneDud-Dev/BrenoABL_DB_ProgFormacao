using BrenoABL_ProgramaFormacao.Aplication._1_TabuadaActions;
using BrenoABL_ProgramaFormacao.Aplication._2_MaiorMenorActions;
using BrenoABL_ProgramaFormacao.Aplication._3_JokenpoActions;
using BrenoABL_ProgramaFormacao.Aplication._4_RegistroVendasActions;

namespace BrenoABL_ProgramaFormacao.Presentation;

internal class StartPage
{


    public static void BuildHeader()
    {
        string? userChoice;
        Console.WriteLine("Esse programa foi desenvolvido como resposta ao desafio para o Programa Formação");
        Console.WriteLine("Criado por OneDudDev - Breno A. B. L.");

        Console.WriteLine("Os desafios aplicados foram 2, 3, 4 e 5.");
        Console.WriteLine("Digite 1 e confirme para ir ao desafio Taboada");
        Console.WriteLine("Digite 2 e confirme para ir ao desafio Numero Maior e Menor");
        Console.WriteLine("Digite 3 e confirme para ir ao desafio Jokenpo");
        Console.WriteLine("Digite 4 e confirme para ir ao desafio RegistroDeVendas");

        string? input = Console.ReadLine();
        try
        {
            int.Parse(input);
        }
        catch (Exception)
        {
            Console.WriteLine("Erro: Tecla invalida, tente novamente");
            BuildHeader();
        }

        switch (input)
        {
            case "1":
                //taboada
                Console.WriteLine("Desafio Taboada");
                Console.WriteLine("Digite 1 para continuar e 2 para voltar a pagina principal");
                userChoice = Console.ReadLine();
                
                switch (userChoice)
                {
                    case "1":
                        TabuadaResult.Build(int.Parse(InputValues.Read()));
                        Console.WriteLine("Aperte enter para voltar");
                        Console.ReadLine();
                        BuildHeader();
                        break;

                    case "2":
                        BuildHeader();
                        break;

                    default:
                        Console.WriteLine("Erro: Tecla invalida, tente novamente");
                        BuildHeader(); //TODO: proper loop.
                        break;
                }
                break;


            case "2":
                //MaiorMenor
                Console.WriteLine("Desafio Maior Menor");
                Console.WriteLine("Digite 1 para continuar e 2 para voltar a pagina principal");
                
                userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    case "1":
                        var generator = new NumberGenerator();
                        generator.GetOutput();
                        Console.WriteLine("Aperte enter para voltar");
                        Console.ReadLine();
                        BuildHeader();
                        break;

                    case "2":
                        BuildHeader();
                        break;

                    default:
                        Console.WriteLine("Erro: Tecla invalida, tente novamente");
                        BuildHeader();
                        break;
                }
                break;

                
            case "3":
                //Jokenpo
                Console.WriteLine("Desafio Jokenpo");
                Console.WriteLine("Digite 1 para continuar e 2 para voltar a pagina principal");

                userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    case "1":
                        JankenRound.RunJanken();
                        Console.WriteLine("Aperte enter para voltar");
                        Console.ReadLine();
                        BuildHeader();
                        break;

                    case "2":
                        BuildHeader();
                        break;

                    default:
                        Console.WriteLine("Erro: Tecla invalida, tente novamente");
                        BuildHeader();
                        break;
                }
                break;
            
            case "4":
                Console.WriteLine("Desafio Registro de vendas");
                Console.WriteLine("Digite 1 para continuar e 2 para voltar a pagina principal");
                userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        InputProductsToList.GetProductData();
                        Console.WriteLine("Aperte enter para voltar");
                        Console.ReadLine();
                        BuildHeader();
                        break;
                    
                    case "2":
                        BuildHeader();
                        break;

                    default:
                        Console.WriteLine("Erro: Tecla invalida, tente novamente");
                        BuildHeader();
                        break;
                }
                break;

            case "5":
                Environment.Exit(1);
                break;

            default:
                break;
        }
    }
}
