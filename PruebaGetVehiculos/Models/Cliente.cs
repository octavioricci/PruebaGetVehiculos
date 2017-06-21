using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PruebaGetVehiculos.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }

        public ICollection<Vehiculo> Vehiculos { get; set; }

        [Display(Name = "Auto")]
        public int VehiculoPrincipalId { get; set; }

        public Vehiculo getVehiculoPrincipal()
        {
            foreach(var v in Vehiculos)
            {
                if (v.VehiculoId == VehiculoPrincipalId) return v;
            }
            return null;
        }
    }
}