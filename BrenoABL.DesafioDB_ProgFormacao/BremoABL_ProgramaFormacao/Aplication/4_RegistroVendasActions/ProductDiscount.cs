
namespace BrenoABL_ProgramaFormacao.Aplication._4_RegistroVendasActions
{
    sealed class ProductDiscount
    {
        public static double TestForDiscount(int quantity, double value)
        {
            switch (quantity) //quantidade * (valor + desconto)
            {
                case int number when number > 0 && number < 11 :
                    return (double) (quantity * value);

                case int number when number > 10 && number < 21:
                    return (double) (quantity * (value - (value * (10.0 / 100.0))));

                case int number when number > 20 && number < 51:
                    return (double) (quantity * (value - (value * (20.0 / 100.0))) ); 

                case int number when number > 50:
                    return (double) (quantity * (value - (value * (25.0 / 100.0))) );

                default :
                    return (double) 0;
            }
        }
    }
}
