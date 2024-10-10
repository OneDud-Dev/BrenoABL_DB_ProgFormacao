
namespace BrenoABL_ProgramaFormacao.Aplication._4_RegistroVendasActions;

sealed class ProductDataInput
{
    public static int InputQuantity()
    {
        Console.WriteLine("Escreva os dados do produto: ");
        Console.WriteLine("Quantidade: ");

        int? prodQuantity;

        try
        {
            prodQuantity = int.Parse( Console.ReadLine() );
        }
        catch (Exception)
        {
            while (true)
            {
                Console.WriteLine("O valor digitado não é valido");
                Console.WriteLine("Quantidade: ");
                prodQuantity = int.Parse(Console.ReadLine());

                if (prodQuantity != null)
                {
                    break;
                }
            }
        }

        if (prodQuantity < 1)
        {
            Console.WriteLine("Erro: A quantidade não pode ser menor que zero");
            InputQuantity();
        }

        return (int)prodQuantity;
    }


    public static string InputName()
    {
        Console.WriteLine("Escreva os dados do produto: ");
        Console.WriteLine("Nome: ");


        string? prodName = Console.ReadLine();

        if (prodName == null)
        {
            Console.WriteLine("Erro: O nome do produto não pode ser vazio");
            InputQuantity();
        }

        return prodName;
    }


    public static double InputPrice()
    {
        Console.WriteLine("Escreva os dados do produto: ");
        Console.WriteLine("Preço Individual: ");

        double? prodPrice;

        try
        {
            prodPrice = double.Parse(Console.ReadLine());
        }
        catch (Exception)
        {
            while (true)
            {
                Console.WriteLine("O valor digitado não é valido");
                Console.WriteLine("Quantidade: ");
                prodPrice = double.Parse(Console.ReadLine());

                if (prodPrice != null)
                {
                    break;
                }
            }
        }

        if (prodPrice < 1)
        {
            Console.WriteLine("Erro: o valor não pode ser menor que zero");
            InputPrice();
        }

        return (double)prodPrice;
    }
}
