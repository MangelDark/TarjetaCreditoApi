using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TarjetaCreditoApi.Models
{
    public class TarjetaCredito
    {

        public int Id { get; set; }
        [Required]
        public string titular { get; set; }
        [Required]
        [MaxLength(16),MinLength(16)]
        public string numeroTarjeta { get; set; }
        [Required]
        [MaxLength(5), MinLength(5)]
        public string fechaExpiracion { get; set; }
        [Required]
        [MaxLength(3), MinLength(3)]
        public string cvv { get; set; }

    }
}
