using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TarjetaCreditoApi.DTO
{
    public class TarjetaCreditoDTO
    {
        public string titular { get; set; }
        public string numeroTarjeta { get; set; }
        public string fechaExpiracion { get; set; }
        public string cvv { get; set; }
    }
}
