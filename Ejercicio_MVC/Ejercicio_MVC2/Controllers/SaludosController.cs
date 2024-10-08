﻿using Ejercicio_MVC2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Ejercicio_MVC2.Controllers
{
    public class SaludosController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Despedida()
        {
            return View();
        }

        public IActionResult Felicita(int ID, string name, int age)
        {
            ViewBag.Id = ID;
            ViewBag.Name = name;
            ViewBag.Age = age;
            return View();
        }

        public IActionResult Perfil(int ID, string Name, int Age)
        {
            Person person = new Person(ID, Name, Age, Name.ToLower()+"dominio.es");

            return View(person);
        }
    }
}
