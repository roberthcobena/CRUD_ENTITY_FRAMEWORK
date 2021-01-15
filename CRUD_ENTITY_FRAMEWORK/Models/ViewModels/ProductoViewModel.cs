using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD_ENTITY_FRAMEWORK.Models.ViewModels
{
    public class ProductoViewModel
    {
        public class ListProductosViewModel
        {
            public int Id { get; set; }
            [Required]
            [StringLength(10)]
            [Display(Name ="Nombre")]
            public string Nombre { get; set; }
            [Required]
            [StringLength(50)]
            [Display(Name = "Descripción")]
            public string Descripcion { get; set; }
            [StringLength(50)]
            [Required]
            [Display(Name = "Marca")]
            public string Marca { get; set; }
            [StringLength(50)]
            [Required]
            [Display(Name = "Precio")]
            public double Precio { get; set; }
            [StringLength(50)]
            [Required]
            [Display(Name = "Stock")]            
        }
    }
}