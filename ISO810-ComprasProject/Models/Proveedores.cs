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

        [Required]
        [Display(Name = "Nombre Comercial")]
        [StringLength(25)]
        public string NombreComercial { get; set; }

        public bool Activo { get; set; }


    }

}