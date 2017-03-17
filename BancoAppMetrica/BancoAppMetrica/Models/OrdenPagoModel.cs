using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BancoAppMetrica.Models
{
    public class OrdenPagoModel
    {
        public string idOrdenPago { get; set; }
        public string idSucursal { get; set; }
        public decimal monto { get; set; }
        public string moneda { get; set; }
        public int estado { get; set; }
        public DateTime fecPago { get; set; }
    }
}