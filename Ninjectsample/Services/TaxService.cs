
namespace Ninjectsample.Services
{
    public class TaxService : ITaxService
    {
        public double GetTaxRate()
        {
            return 0.7;
        }
    }
}