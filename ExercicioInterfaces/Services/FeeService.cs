
namespace ExercicioInterfaces.Services
{
    class FeeService : IFeeService
    {
        public double Fee(double amount, double number)
        {
            return amount * 0.01 * number;
        }
    }
}
