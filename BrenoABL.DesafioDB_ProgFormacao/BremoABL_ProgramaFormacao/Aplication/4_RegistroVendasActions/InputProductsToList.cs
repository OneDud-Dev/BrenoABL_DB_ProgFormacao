
using BrenoABL_ProgramaFormacao.Aplication._1_TabuadaActions;
using System.Numerics;

namespace BrenoABL_ProgramaFormacao.Aplication._4_RegistroVendasActions;

sealed class InputProductsToList
{
    public static void GetProductData()
    {
        //TODO: List of Rich Entities

        bool    isReading   = true;
        List<string> name   = new List<string>();
        List<int>    qty    = new List<int>();
        List<double> price  = new List<double>();
        

        Console.WriteLine("Registro de vendas.");


        while (isReading)
        {
            Console.WriteLine("Digite 1 para Adicionar um Produto ou 2 para terminar");

            var choice = Console.ReadLine();
            if (choice == "2")
            {
                isReading = false;
            }

            else if (choice == "1")
            {
                name. Add( ProductDataInput.InputName()     );
                qty  .Add( ProductDataInput.InputQuantity() );
                price.Add( ProductDataInput.InputPrice()    );
            }
        }


        if (name.Count > 0)
        {
            BuildProductList(name, qty, price);
            Console.WriteLine();
            Console.WriteLine("aperte enter para voltar");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("aperte enter para voltar");
            Console.WriteLine();
        }

    }

    private static void BuildProductList(List<string> names, List<int> qty, List<Double> prices)
    {
        Console.WriteLine("Leitura de produtos concluida");
        Console.WriteLine("Os descontos estão sendo aplicados");
        Console.WriteLine("Vamos mostrar a lista de produtos:");
        double total = 0;

        for (int i = 0; i < names.Count; i++)
        {
            Console.WriteLine
                ($"Nome: {names[i]} \t\t Quantidade: {qty[i]} \t\t Preço: {(ProductDiscount.TestForDiscount(qty[i], prices[i]))} .");
            
            total += ProductDiscount.TestForDiscount(qty[i], prices[i]);
        }

        Console.WriteLine();
        Console.WriteLine($"Custo total: R$: {Math.Round(total, 2)}");
        Console.WriteLine();
        Console.WriteLine("aperte enter para voltar");
        Console.WriteLine();
    }
}