using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webstring.Models;

namespace webstring.Controllers
{
    public class cadenaController : Controller
    {
        // GET: cadena
        public ActionResult practica()
        {
            return View();
        }

        public ActionResult contar(string valor1)
        {
            logica obj = new logica();
            string resultado1 = obj.contar(valor1);
            TempData["contar"] = resultado1;
            return View("practica");
        }

        public ActionResult mayuscula(string valor2)
        {
            logica obj = new logica();
            string resultado2 = obj.mayuscula(valor2);
            TempData["mayuscula"] = resultado2;
            return View("practica");
        }

        public ActionResult minuscula(string valor3)
        {
            logica obj = new logica();
            string resultado3 = obj.minuscula(valor3);
            TempData["minuscula"] = resultado3;
            return View("practica");
        }

        public ActionResult cajas(string valor4, string valor5, string valor6)
        {
            logica obj = new logica();
            string resultado4 = $"{valor4} {valor5} {valor6}";
            TempData["cajas"] = resultado4;
            return View("practica");
        }

        public ActionResult validar(string valor7, string valor8)
        {
            logica obj = new logica();
            string resultado5 = obj.validar(valor7, valor8);
            TempData["validar"] = resultado5;
            return View("practica");
        }

        public ActionResult cadena(string valor9)
        {
            logica obj = new logica();
            string resultado6 = obj.cadena(valor9);
            TempData["cadena"] = resultado6;
            return View("practica");
        }

        public ActionResult coma(string valor10)
        {
            logica obj = new logica();
            string resultado7 = obj.coma(valor10);
            TempData["coma"] = resultado7;
            return View("practica");
        }

        public ActionResult espacio(string valor11)
        {
            logica obj = new logica();
            string resultado8 = obj.espacio(valor11);
            TempData["espacio"] = resultado8;
            return View("practica");
        }

        public ActionResult ti(string valor12)
        {
            logica obj = new logica();
            string resultado9 = obj.ti(valor12);
            TempData["ti"] = resultado9;
            return View("practica");
        }

        public ActionResult ejercicio10(string valor13)
        {
            logica obj = new logica();
            string resultado10 = obj.ejercicio10(valor13);
            TempData["ejercicio10"] = resultado10;
            return View("practica");
        }   
    }
}