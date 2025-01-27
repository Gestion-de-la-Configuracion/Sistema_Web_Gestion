﻿using SGCS_Bumer_Solutions.Models.Base_de_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static SGCS_Bumer_Solutions.Filtros.AdminFilters;

namespace SGCS_Bumer_Solutions.Controllers
{
    [Autenticado]
    public class MetodologiaController : Controller
    {
        METODOLOGIA metodologia = new METODOLOGIA();

        // GET: Metodologia
        public ActionResult Index()
        {
            return View(metodologia.ListarTodo());
        }

        public ActionResult Guardar(METODOLOGIA metodologia)
        {
            if (ModelState.IsValid)
            {
                metodologia.Guardar();
                return Redirect("~/Metodologia/Index");
            }
            else
            {
                return View("~/Metodologia/Index");
            }
        }

        public ActionResult EditMet(int id = 0)
        {
            return View(id == 0 ? new METODOLOGIA() : metodologia.ObtenerMetodologia(id));
        }

        public ActionResult Eliminar(int id)
        {
            metodologia.ID_METODOLOGIA = id;
            metodologia.Eliminar();
            return Redirect("~/Metodologia/Index");
        }

        public ActionResult Habilitar(int id)
        {
            metodologia.ID_METODOLOGIA = id;
            metodologia.Habilitar();
            return Redirect("~/Metodologia/Index");
        }
    }
}