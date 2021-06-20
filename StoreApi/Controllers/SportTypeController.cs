using Autofac;
using Store.Core.Entities.Sports;
using Store.Core.Services;
using System.Web.Mvc;

namespace StoreApi.Controllers
{
    public class SportTypeController : Controller
    {
        private readonly ILifetimeScope _scope;
        private readonly SportsService _sportsService;

        public SportTypeController(ILifetimeScope scope)
        {
            _scope = scope;
            _sportsService = scope.Resolve<SportsService>();
        }
        [HttpPost]
        public ActionResult Create(SportType type)
        {
            type = _sportsService.CreateSportType(type);
            return View(type);
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}