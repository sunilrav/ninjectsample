using Ninjectsample.Services;
using System.Web.Mvc;

namespace Ninjectsample.Controllers
{
    public class HomeController : Controller
    {
        ITaxService _taxService;
        public HomeController(ITaxService taxService)
        {
            _taxService = taxService;
        }

        public ActionResult Index()
        {
            var rate = _taxService.GetTaxRate();

            return View(rate);
        }
    }
}
