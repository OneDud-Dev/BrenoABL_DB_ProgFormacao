
namespace BrenoABL_ProgramaFormacao.Aplication._4_RegistroVendasActions
{
    sealed class ProductDiscount
    {
        public static double TestForDiscount(int quantity, double value)
        {
            switch (quantity)
            {
                case int number when number > 0 && number < 11 :
                    return (double)value;

                case int number when number > 10 && number < 21:
                    return (double) (value + (value * (10 / 100)) );

                case int number when number > 20 && number < 51:
                    return (double) (value + (value * (20 / 100)) );

                case int number when number > 50:
                    return (double) (value + (value * (25 / 100)) );

                default :
                    return (double) 0;
            }
        }
    }
}
