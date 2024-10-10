
namespace BrenoABL_ProgramaFormacao.Aplication._2_MaiorMenorActions;

public class NumberGenerator
{

    private List<int> numberList = new List<int>();
    public int indexFromMin { get; private set; } = 1;
    public int indexFromMax { get; private set; } = 1;



    public NumberGenerator()
    {
        indexFromMin = 1;
        indexFromMax = 1;

        Generate();
    }

    private void Generate()
    {

        for (int i = 0; i < 10; i++)
        {
            numberList.Add( new Random().Next(1,101) );

            if (numberList[i] < indexFromMin)
            {
                indexFromMin = i;
            }
            else if (numberList[i] > indexFromMax)
            {
                indexFromMax = i;
            }
        }
    }

    public void GetOutput()
    {
        for (int i = 0; i < numberList.Count; i++)
        {
            if (i == indexFromMin)
            {
                Console.Write(" ");
                Console.Write(numberList[i]);
                Console.Write(" ");
            }            
        }
        Console.WriteLine();
        Console.WriteLine($"O menor número é {numberList[indexFromMin]} at index {indexFromMin}.");
        Console.WriteLine($"O maior número é {numberList[indexFromMax]} at index {indexFromMax}.");

    }
}
