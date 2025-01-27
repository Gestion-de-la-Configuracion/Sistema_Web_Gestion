﻿using SGCS_Bumer_Solutions.Models.Extras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SGCS_Bumer_Solutions.Filtros
{
    public class AdminFilters
    {
        public class AutenticadoAttribute : ActionFilterAttribute//AdminFilters
        {
            public override void OnActionExecuting(ActionExecutingContext filterContext)
            {
                base.OnActionExecuting(filterContext);

                if (!SessionHelper.ExistUserInSession())
                {
                    filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new
                    {
                        controller = "Login",
                        action = "Index"
                    }));
                }
            }
        }



        // Si estamos logeado ya no podemos acceder a la página de Login
        public class NoLoginAttribute : ActionFilterAttribute
        {
            public override void OnActionExecuting(ActionExecutingContext filterContext)
            {
                base.OnActionExecuting(filterContext);

                if (SessionHelper.ExistUserInSession())
                {
                    filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new
                    {
                        controller = "Default",
                        action = "Index"
                    }));
                }
            }
        }
    }
}