using Autofac;
using Store.Core.Entities.Sports;
using Store.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Store.Controllers
{
    public class SportTypeController : ApiController
    {
        private readonly ILifetimeScope _scope;
        private readonly SportsService _sportsService;

        public SportTypeController(ILifetimeScope scope)
        {
            _scope = scope;
            _sportsService = scope.Resolve<SportsService>();
        }
        [HttpPost]
        public SportType Create(SportType type)
        {
            type = _sportsService.CreateSportType(type);
            return type;
        }
    }
}