using AvisFormationCore.Web.Models;
using Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvisFormationCore.Web.Controllers
{
    public class ContactController : Controller
    {
        IContactRepository _context;

        public ContactController(IContactRepository context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            var vm = new EnvoieEmailModel();
            return View(vm);
        }

        public IActionResult SaveMessage(EnvoieEmailModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", viewModel);
            }
            _context.SaveMessage(viewModel.Nom, viewModel.Email, viewModel.Message);

            return View();
        }
    }
}
