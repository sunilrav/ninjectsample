using Ninjectsample.Services;
using System.Web.Http;

namespace Ninjectsample.Controllers
{
    public class ValuesController : ApiController
    {
        ITaxService _taxService;
        public ValuesController(ITaxService taxService)
        {
            _taxService = taxService;
        }
        
        public string Get()
        {
            return _taxService.GetTaxRate().ToString();
        }
    }
}
