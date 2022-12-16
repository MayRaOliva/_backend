using Castle.MicroKernel.SubSystems.Conversion;
using System;
using System.Collections.Concurrent;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Domain.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        [Required]
        [Column](TypeName ="varchar(20)")]

        [Required]
        [Column] (TypeName = "varchar(50)")]
        public string Password { get; set; }

    }

}

