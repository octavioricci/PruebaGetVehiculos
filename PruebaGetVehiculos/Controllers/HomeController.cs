using PruebaGetVehiculos.Models;
using PruebaGetVehiculos.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace PruebaGetVehiculos.Controllers
{
    public class HomeController : Controller
    {

        private ContextDB db = new ContextDB();
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ElijoAuto()
        {
            var autos = db.Vehiculos.ToList();
            var viewModel = new VehiculosViewModel
            {
                Vehiculos = autos
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Traer(VehiculosViewModel model)
        {
            Cliente clienteElegido=null;


            var clientes = db.Clientes.Include(c => c.Vehiculos).SingleOrDefault(c => c.VehiculoPrincipalId == model.Cliente.VehiculoPrincipalId);
           
            return View("MostrarAutoElegido",clientes);
        }
    }
}