using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pc1OperacionesZamudio.Models
{
    public class Operacion
    {
        public string? Nombre { get; set; }

        public string? Correo { get; set; }

        public string? FechaOperacion { get; set; }

        public bool SP500 { get; set; }

        public bool DowJones { get; set; }

        public bool BonusUS { get; set; }

        public decimal MontoAbonar { get; set; }

        public decimal IGV { get; set; }

        public decimal Comision { get; set; }

        public decimal TotalPagar { get; set; }
    }
}