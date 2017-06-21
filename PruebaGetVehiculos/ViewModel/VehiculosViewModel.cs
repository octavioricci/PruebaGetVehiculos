using PruebaGetVehiculos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaGetVehiculos.ViewModel
{
    public class VehiculosViewModel
    {
        public IEnumerable<Vehiculo> Vehiculos { get; set; }
        public Cliente Cliente { get; set; }
    }
}