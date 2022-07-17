using AvisFormationCore.Web.Models;
using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AvisFormationCore.Web.Controllers
{
    public class HomeController : Controller
    {
        IFormationRepository _repository;

        public HomeController(IFormationRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {

            var listFormations = _repository.GetFormations(6);
            var vm = new List<DetailFormationModel>();
            foreach(var f in listFormations)
            {
                vm.Add(
                    new DetailFormationModel
                    {
                        Formation = f,
                        NoteMoyenne = f.Avis.Select(a=>a.Notes)
                        .DefaultIfEmpty(0).Average()
                    });
            }
            return View(vm);
        }

        public IActionResult TestRedirectionOk()
        {
            return View();
        }
    }
}
