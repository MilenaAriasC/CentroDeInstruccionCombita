using CentroDeInstruccionCombita.BussinesLayer;
using CentroDeInstruccionCombita.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CentroDeInstruccionCombita.Controllers
{
    public class AspiranteController : Controller
    {
        private AspiranteBL aspiranteBL = new AspiranteBL();
        private CiudadBL ciudadbl = new CiudadBL();
       
        Aspirante asp = new Aspirante();
       
        // GET: Aspirante
        public ActionResult Index()
        {
            return View(aspiranteBL.listar());
        }

        // GET: Aspirante/Details/5
        public ActionResult Details(int IdAspirante)
            
            
        {
            return View();
        }

        // GET: Aspirante/Create   //crear nuevo aspirante 
        public ActionResult Create()
        {
            //Agreo Viewbag
            ViewBag.IdCiudad = new SelectList(ciudadbl.listar(), "IdCiudad", "Nombre");
            //ViewBag.IdDepartamento= new SelectList(departamentobl)
            return View();
        }

        // POST: Aspirante/Create 
        [HttpPost]
        public ActionResult Create(Aspirante aspirante)
        {
            try
            {
                // TODO: Add insert logic here
                aspiranteBL.guardar(aspirante);
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: Aspirante/Edit/5
        public ActionResult Edit(int IdAspirante)
        {
            asp = aspiranteBL.buscar(IdAspirante);
            ViewBag.IdCiudad = new SelectList(ciudadbl.listar(), "IdCiudad", "Nombre");

            return View(asp);
        }

        // POST: Aspirante/Edit/5
        [HttpPost]
        public ActionResult Edit(Aspirante aspirante)
        {
            try
            {
                // TODO: Add update logic here
                aspiranteBL.actualizar(aspirante);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: Aspirante/Delete/5
        public ActionResult Delete(int IdAspirante)
        {
            aspiranteBL.eliminar(IdAspirante);
            return View("Index", aspiranteBL.listar());
        }

        // POST: Aspirante/Delete/5
        [HttpPost]
        public ActionResult Delete(int IdAspirante, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
