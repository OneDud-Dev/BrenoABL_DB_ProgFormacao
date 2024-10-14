namespace BrenoABL_ProgramaFormacao.Aplication._1_TabuadaActions;

sealed class TabuadaResult
{
    public static void Build(int input)
    {

        //List<string> listaResultado = new List<string>();

        for (int col = 1; col < 11; col++)
        {

            Console.Write($" {input} x {col} = {input * col} ");
            Console.WriteLine();
        }
        

        //return listaResultado;
    }




}
