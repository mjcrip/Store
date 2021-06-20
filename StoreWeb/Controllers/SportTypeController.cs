using Autofac;
using Store.Core.Services;
using StoreWeb.Models.SportType;
using System.Web.Mvc;

namespace StoreWeb.Controllers
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

        // GET: SportType
        public ActionResult Index()
        {
            return View();
        }

        // GET: SportType/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SportType/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SportType/Create
        [HttpPost]
        public ActionResult Create(SportTypeModel collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SportType/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SportType/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, SportTypeModel collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SportType/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SportType/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, SportTypeModel collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
