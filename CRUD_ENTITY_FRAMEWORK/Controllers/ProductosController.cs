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
                               Marca = d.Marca
                           }).ToList();
            }
            return View(lst);
        }

        public ActionResult Nuevo()
        {
            return View();
        }

        //recarga de métodos
        [HttpPost]
        public ActionResult Nuevo(ProductoViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (PracticaEntities db = new PracticaEntities())
                    {
                        var oProductos = new Productos();
                        oProductos.Nombre = model.Nombre;
                        oProductos.Descripcion= model.Descripcion;
                        oProductos.Marca = model.Marca;

                        db.Productos.Add(oProductos);
                        db.SaveChanges();
                    }

                    return Redirect("~/Productos/");
                }

                return View(model);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public ActionResult Editar(int Id)
        {
            ProductoViewModel model = new ProductoViewModel();

            using (PracticaEntities db = new PracticaEntities())
            {
                var oProducto = db.Productos.Find(Id);
                model.Nombre = oProducto.Nombre;
                model.Descripcion = oProducto.Descripcion;
                model.Marca = oProducto.Marca;
            }
                return View(model);
        }

        //recarga de métodos
        [HttpPost]
        public ActionResult Editar(ProductoViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (PracticaEntities db = new PracticaEntities())
                    {
                        var oProductos = db.Productos.Find(model.Id);
                        oProductos.Nombre = model.Nombre;
                        oProductos.Descripcion = model.Descripcion;
                        oProductos.Marca = model.Marca;

                        db.Entry(oProductos).State=System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }

                    return Redirect("~/Productos/");
                }

                return View(model);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public ActionResult Eliminar(int Id)
        {

            using (PracticaEntities db = new PracticaEntities())
            {
                var oProducto = db.Productos.Find(Id);
                db.Productos.Remove(oProducto);
                db.SaveChanges();
            }
            return Redirect("~/Productos/");

        }
    }
}