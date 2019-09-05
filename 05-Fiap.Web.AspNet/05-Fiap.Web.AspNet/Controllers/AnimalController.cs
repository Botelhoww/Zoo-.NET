using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _05_Fiap.Web.AspNet.Models;
using _05_Fiap.Web.AspNet.Persistences;
using Microsoft.AspNetCore.Mvc;

namespace _05_Fiap.Web.AspNet.Controllers
{
    public class AnimalController : Controller
    {
        private AllZooContext _context;

        public AnimalController(AllZooContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return View(_context.Zoos.ToList());
        }

        [HttpPost]
        public IActionResult Cadastrar(Animal animal)
        {
            _context.Animals.Add(animal);
            _context.SaveChanges();
            TempData["msg"] = "Cadastrado Animal";
            return View();
        }

    }
}