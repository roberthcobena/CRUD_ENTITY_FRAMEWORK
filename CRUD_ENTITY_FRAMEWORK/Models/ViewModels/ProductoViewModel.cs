using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD_ENTITY_FRAMEWORK.Models.ViewModels
{
    public class ProductoViewModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name ="Nombre")]
        public string Nombre { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        [StringLength(100)]
        [Required]
        [Display(Name = "Marca")]
        public string Marca { get; set; }
    }
}