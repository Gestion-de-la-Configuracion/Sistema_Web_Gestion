﻿using SGCS_Bumer_Solutions.Models.Base_de_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGCS_Bumer_Solutions.Controllers
{
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
    }
}