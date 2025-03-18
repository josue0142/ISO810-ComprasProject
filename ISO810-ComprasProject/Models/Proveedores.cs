using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ISO810_ComprasProject.Models
{
    public class Proveedores
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProveedorId { get; set; }

        [Display(Name = "C�dula")]
        [StringLength(14)]
        public string Cedula { get; set; }


        [Display(Name = "RNC")]
        [StringLength(14)]
        public string RNC { get; set; }

        [Required(ErrorMessage = "El tipo de documento es obligatorio.")]
        public string TipoDocumento { get; set; } // "C�dula" o "RNC"

        [Required(ErrorMessage = "El n�mero de documento es obligatorio.")]
        [MaxLength(11, ErrorMessage = "El n�mero de documento no puede tener m�s de 11 caracteres.")]
        public string NumeroDocumento { get; set; }

        [Required]
        [Display(Name = "Nombre Comercial")]
        [StringLength(25)]
        public string NombreComercial { get; set; }

        public bool Activo { get; set; }


    }

}