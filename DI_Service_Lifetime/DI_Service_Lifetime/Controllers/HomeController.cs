using DI_Service_Lifetime.Models;
using DI_Service_Lifetime.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DI_Service_Lifetime.Controllers
{
    public class HomeController : Controller
    {
        private readonly IScopedGuidService _scoped1;
        private readonly IScopedGuidService _scoped2;

        private readonly ISingletonGuidService _singleton1;
        private readonly ISingletonGuidService _singleton2;

        private readonly ITransientGuidService _transient1;
        private readonly ITransientGuidService _transient2;

        public HomeController(IScopedGuidService scopedGuid1,
            IScopedGuidService scopedGuid2,
            ISingletonGuidService singleton1,
            ISingletonGuidService singleton2,
            ITransientGuidService transient1,
            ITransientGuidService transient2
            )
        {
            _singleton1 = singleton1;
            _singleton2 = singleton2;
            _scoped1 = scopedGuid1;
            _scoped2 = scopedGuid2;
            _transient1 = transient1;
            _transient2 = transient2;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}