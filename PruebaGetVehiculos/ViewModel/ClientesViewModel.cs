using PruebaGetVehiculos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaGetVehiculos.ViewModel
{
    public class ClientesViewModel
    {
        public ICollection<Cliente> Clientes { get; set; }
        public ICollection<Vehiculo> Vehiculos { get; set; }

        public Cliente Cliente { get; set; }

        public Vehiculo Vehiculo { get; set; }
    }
}