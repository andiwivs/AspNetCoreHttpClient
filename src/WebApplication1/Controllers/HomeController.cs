using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplication1.Infrastructure;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProvideValues _valuesProvider;

        public HomeController(IProvideValues valuesProvider)
        {
            _valuesProvider = valuesProvider;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _valuesProvider.GetValues();

            return View(model);
        }
    }
}
