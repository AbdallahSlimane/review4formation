using AvisFormationCore.Web.Models;
using Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvisFormationCore.Web.Controllers
{
    public class Formation : Controller
    {

        IFormationRepository _repository;

        public Formation(IFormationRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            var viewModel = new ToutesLesFormationsViewModel();
            viewModel.Message = "Ceci est un message du controlleur";
            viewModel.Nombre = 3;

            return View(viewModel);
        }

        public IActionResult ToutesLesFormations()
        {
            var listFormations = _repository.GetAllFormations();


            var vm = new List<DetailFormationModel>();
            foreach (var f in listFormations)
            {
                var temp = new DetailFormationModel();
                temp.Formation = f;
                if (f.Avis != null && f.Avis.Count > 0)
                    temp.NoteMoyenne = Math.Round(f.Avis.Select(a => a.Notes).ToList().Average(), 1);
                vm.Add(temp);
            }
            return View(vm);
        }

        public IActionResult DetailsFormation(string nomSeo)
        {

            var formation = _repository.GetFormationByNomSeo(nomSeo);

            if(formation == null)
            {
                return RedirectToAction("ToutesLesFormations");
            }
            var vm = new DetailFormationModel();
            vm.Formation = formation;
            if (formation.Avis != null && formation.Avis.Count > 0)
                vm.NoteMoyenne = Math.Round(formation.Avis.Select(a => a.Notes).ToList().Average(), 1);

            return View(vm);
        }
    }

}
