using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BancoAppMetrica.Models
{
    public class BancoModel
    {
        public string idBanco { get; set; }
        public string nombreBanco { get; set; }
        public string direccionBanco { get; set; }
        public DateTime fecRegistro { get; set; }
    }
}