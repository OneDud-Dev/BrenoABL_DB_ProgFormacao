namespace BrenoABL_ProgramaFormacao.Aplication._1_TabuadaActions;

sealed class InputValues
{

    public static int Read()
    {
        Console.WriteLine("Digite um numero entre 1 e 10 para construir sua taboada de multiplicação");
        Console.WriteLine("Sua escolha : ");

        int result = int.Parse(Console.ReadLine() );
        try
        {
            Validation(result);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
            Read();
        }

        return result;
    }

    public static int Validation(int input)  
        =>  (input is <= 10 and >= 1) ? input :
            throw new ArgumentException("Erro: O valor da taboada deve ser entre 1 e 10");
}