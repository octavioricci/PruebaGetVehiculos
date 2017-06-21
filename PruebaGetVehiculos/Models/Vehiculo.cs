using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaGetVehiculos.Models
{
    public class Vehiculo
    {
        public int VehiculoId { get; set; }

        public String Patente { get; set; }

        public string Modelo { get; set; }

        public Cliente Cliente { get; set; }
    }
}