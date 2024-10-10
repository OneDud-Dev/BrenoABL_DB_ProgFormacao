namespace BrenoABL_ProgramaFormacao.Aplication._1_TabuadaActions;

sealed class TabuadaResult
{
    public static List<string> Build(int input)
    {

        List<string> listaResultado = new List<string>();

        for (int linha = 1; linha < 11; linha++)
        {
            for (int col = 1; col < 11; col++)
            {
                listaResultado.Add($" {input} x {col} = {input * col} ");
            }
        }

        return listaResultado;
    }




}
