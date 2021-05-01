using Autofac;
using Store.Core.Entities.Sports;
using Store.Core.Services;
using System.Web.Http;

namespace Store.Controllers
{
    public class SportsController : ApiController
    {
        private readonly ILifetimeScope _scope;
        private readonly SportsService _sportsService;

        public SportsController(ILifetimeScope scope)
        {
            _scope = scope;
            _sportsService = scope.Resolve<SportsService>();
        }
        [HttpPost]
        public Sport Create(Sport sport)
        {
            sport = _sportsService.CreateSport(sport);
            return sport;
        }
    }
}
