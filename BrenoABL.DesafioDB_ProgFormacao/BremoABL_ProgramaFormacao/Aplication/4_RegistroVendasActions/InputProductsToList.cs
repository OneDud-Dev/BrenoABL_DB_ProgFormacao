
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

            if (name.Count > 0)
            {
                BuildProductList(name, qty, price);
            }
        }
    }

    private static void BuildProductList(List<string> names, List<int> qty, List<Double> prices)
    {
        Console.WriteLine("Leitura de produtos concluida");
        Console.WriteLine("Os descontos estão sendo aplicados");
        Console.WriteLine("Vamos mostrar a lista de produtos:");

        while (true)
        {
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine
                    ($"Nome: {names[i]} \t\t Quantidade: {qty[i]} \t\t Preço: {(ProductDiscount.TestForDiscount(qty[i], prices[i]))} .");

            }


        }
    }
}