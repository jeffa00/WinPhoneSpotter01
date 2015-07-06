using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using WebApplication3.Models;
using Microsoft.AspNet.Authorization;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication3.Controllers
{
    public class PhoneSpottingController : Controller
    {
        private PhoneSpottingContext _spottingContext;
        public PhoneSpottingController(PhoneSpottingContext context)
        {
            _spottingContext = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(new PhoneSpottingsViewModel { Spottings = _spottingContext.Spottings.ToList() });
        }

        // GET: /<controller>/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public IActionResult Create(PhoneSpotting newSpotting)
        {
            if (ModelState.IsValid)
            {
                _spottingContext.Spottings.Add(newSpotting);
                _spottingContext.SaveChanges();
                return RedirectToAction("Index");
            }

            var errors = ModelState
                .Where(x => x.Value.Errors.Count > 0)
                .Select(x => new { x.Key, x.Value.Errors })
                .ToArray();

            return View(newSpotting);
        }

    }
}
