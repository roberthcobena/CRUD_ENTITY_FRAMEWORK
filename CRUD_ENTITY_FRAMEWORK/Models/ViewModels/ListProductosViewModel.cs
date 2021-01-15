using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_ENTITY_FRAMEWORK.Models.ViewModels
{
    public class ListProductosViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
    }
}