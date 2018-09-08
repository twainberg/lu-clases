using System;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class AlumnoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Alumno alumno)
        {
            Data.Lista.Add(alumno);
            return View();
        }

        public IActionResult VoyACrear()
        {
            return View();
        }

        public IActionResult Borrar()
        {
            Data.Lista.Clear();
            return View();
        }

        public IActionResult BorrarUno(string nombre)
        {
            var index = Data.Lista.FindIndex(a => a.Nombre == nombre);
            Data.Lista.RemoveAt(index);
            return View("Borrar");
        }
    }
}