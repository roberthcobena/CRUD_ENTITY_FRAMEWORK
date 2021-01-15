 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUD_ENTITY_FRAMEWORK.Models;
using CRUD_ENTITY_FRAMEWORK.Controllers;
using CRUD_ENTITY_FRAMEWORK.Models.ViewModels;

namespace CRUD_ENTITY_FRAMEWORK.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            List<ListProductosViewModel> lst;
            using (PracticaEntities db = new PracticaEntities())
            {
                lst = (from d in db.Productos
                           select new ListProductosViewModel
                           {
                               Id = d.Id,
                               Nombre = d.Nombre,
                               Descripcion = d.Descripcion,
                               Marca = d.Marca,
                               Precio = (double)d.Precio,
                               Stock = (int)d.Stock
                           }).ToList();
            }
            return View(lst);
        }
    }
}