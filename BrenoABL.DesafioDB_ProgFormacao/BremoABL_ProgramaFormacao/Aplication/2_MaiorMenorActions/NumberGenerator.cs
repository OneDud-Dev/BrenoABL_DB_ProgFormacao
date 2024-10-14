
namespace BrenoABL_ProgramaFormacao.Aplication._2_MaiorMenorActions;

public class NumberGenerator
{

    private List<int> numberList = new List<int>();
    public int Min { get; private set; }
    public int max { get; private set; }



    public NumberGenerator()
    {
        Min = 100;
        max = 0;

        Generate();
    }

    private void Generate()
    {

        for (int i = 0; i < 10; i++)
        {
            numberList.Add( new Random().Next(1,101) );

            if (numberList[i] <= Min)
            {
                Min =  numberList[i];
            }
            if (numberList[i] >= max)
            {
                max = numberList[i];
            }
        }
    }

    public void GetOutput()
    {
        Console.WriteLine("Lista de Números: ");
        for (int i = 0; i < numberList.Count; i++)
        {
            Console.Write($" {numberList[i]} ");
        }
        
        Console.WriteLine();
        Console.WriteLine($"O menor número é {Min};");
        Console.WriteLine($"O maior número é {max}.");

    }
}
